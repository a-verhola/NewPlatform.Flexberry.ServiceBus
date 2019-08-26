﻿namespace NewPlatform.Flexberry.ServiceBus.Components
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using RabbitMQ.Client;
    using RabbitMQ.Client.Events;

    using NewPlatform.Flexberry.ServiceBus.MessageSenders;

    /// <summary>
    /// RabbitMQ consumer creating connection for self.
    /// </summary>
    internal class RmqConsumer : BaseRmqConsumer
    {
        private readonly IConnectionFactory _connectionFactory;
        private IConnection _connection;

        public RmqConsumer(ILogger logger, IMessageConverter converter, IConnectionFactory connectionFactory, Subscription subscription, ushort defaultPrefetchCount, bool useLegacySenders) : base(logger, converter, subscription, defaultPrefetchCount, useLegacySenders)
        {
            _connectionFactory = connectionFactory;
        }

        public override void Stop()
        {
            if (_connection != null)
            {
                _connection.Dispose();
            }

            base.Stop();
        }

        /// <summary>
        /// Get connection for RabbitMQ.
        /// </summary>
        protected override IConnection Connection
        {
            get
            {
                if (_connection == null || base.ShouldRecreate)
                {
                    _connection = _connectionFactory.CreateConnection();
                    _connection.ConnectionShutdown += OnConnectionShutdown;
                    _connection.RecoverySucceeded += OnRecoverySucceeded;
                    _connection.ConnectionRecoveryError += OnConnectionRecoveryError;
                }

                return _connection;
            }
        }
    }
}
