﻿namespace NewPlatform.Flexberry.ServiceBus.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using EasyNetQ.Management.Client;
    using EasyNetQ.Management.Client.Model;

    using ServiceBusMessage = Message;
    using RabbitMQMessage = EasyNetQ.Management.Client.Model.Message;

    /// <summary>
    /// Interface implementation for manage messages stored in RabbitMQ.
    /// </summary>
    internal class RmqMessageManager : IMessageManager
    {
        /// <summary>
        /// The client for manage RabbitMQ.
        /// </summary>
        private IManagementClient _managementClient;

        /// <summary>
        /// Messages converter from RabbitMQ format to Flexberry Service Bus format.
        /// </summary>
        private IMessageConverter _messageConverter;

        /// <summary>
        /// The name manager in RabbitMQ.
        /// </summary>
        private AmqpNamingManager _namingManager;

        /// <summary>
        /// Initializes a new instance of <see cref="RmqMessageManager"/>.
        /// </summary>
        /// <param name="managementClient">The client for manage RabbitMQ.</param>
        /// <param name="messageConverter">Messages converter from RabbitMQ format to Flexberry Service Bus format.</param>
        /// <param name="namingManager">The name manager in RabbitMQ.</param>
        public RmqMessageManager(IManagementClient managementClient, IMessageConverter messageConverter, AmqpNamingManager namingManager)
        {
            _managementClient = managementClient ?? throw new ArgumentNullException(nameof(managementClient));
            _messageConverter = messageConverter ?? throw new ArgumentNullException(nameof(messageConverter));
            _namingManager = namingManager ?? throw new ArgumentNullException(nameof(namingManager));
        }

        /// <summary>
        /// Returns count messages from RabbitMQ.
        /// </summary>
        /// <param name="clientId">Filter queues by client ID, empty string - do not filter.</param>
        /// <param name="messageTypeId">Filter queues by message type ID, empty string - do not filter.</param>
        /// <returns>Count messages from RabbitMQ.</returns>
        public int CountMessages(string clientId, string messageTypeId)
        {
            return FilterQueues(_managementClient.GetQueuesAsync().Result, clientId, messageTypeId).Sum(q => q.Messages);
        }

        /// <summary>
        /// Returns messages from RabbitMQ.
        /// </summary>
        /// <param name="offset">Offset from start.</param>
        /// <param name="count">Count of messages.</param>
        /// <param name="clientId">Filter queues by client ID, empty string - do not filter.</param>
        /// <param name="messageTypeId">Filter queues by message type ID, empty string - do not filter.</param>
        /// <returns>Messages from RabbitMQ.</returns>
        public ServiceBusMessage[] GetMessages(int offset, int count, string clientId, string messageTypeId)
        {
            int skipped = 0;
            var sbMessages = new List<ServiceBusMessage>();

            IEnumerable<Queue> queues = FilterQueues(_managementClient.GetQueuesAsync().Result, clientId, messageTypeId);
            foreach (var queue in queues)
            {
                skipped += queue.Messages;
                if (skipped > offset)
                {
                    string _clientId;
                    string _messageTypeId;
                    _namingManager.ParseQueueName(queue.Name, out _clientId, out _messageTypeId);
                    var client = new Client() { ID = _clientId };
                    var messageType = new MessageType() { ID = _messageTypeId };

                    int skipInQueue = offset > 0 ? queue.Messages - (skipped - offset) : offset;
                    int getFromQueue = Math.Min(queue.Messages, count + skipInQueue - sbMessages.Count);
                    var getMessagesCriteria = new GetMessagesCriteria(getFromQueue, Ackmodes.ack_requeue_true);

                    IEnumerable<RabbitMQMessage> rmqMessages = _managementClient.GetMessagesFromQueueAsync(queue, getMessagesCriteria).Result.Skip(skipInQueue);
                    foreach (var rmqMessage in rmqMessages)
                    {
                        ServiceBusMessage sbMessage = _messageConverter.ConvertFromMqFormat(System.Text.Encoding.UTF8.GetBytes(rmqMessage.Payload), null);
                        sbMessage.Recipient = client;
                        sbMessage.MessageType = messageType;
                        sbMessages.Add(sbMessage);
                    }

                    if (sbMessages.Count == count)
                    {
                        break;
                    }
                }
            }

            return sbMessages.ToArray();
        }

        /// <summary>
        /// Filter queues by client ID and message type ID.
        /// </summary>
        /// <param name="queues">Queues for filter.</param>
        /// <param name="clientId">Client ID.</param>
        /// <param name="messageTypeId">Message type ID.</param>
        /// <returns>Filtered queues.</returns>
        private IEnumerable<Queue> FilterQueues(IEnumerable<Queue> queues, string clientId, string messageTypeId)
        {
            return queues.Where((q) =>
            {
                string _clientId;
                string _messageTypeId;
                _namingManager.ParseQueueName(q.Name, out _clientId, out _messageTypeId);
                return _clientId.Contains(clientId) && _messageTypeId.Contains(messageTypeId);
            });
        }
    }
}