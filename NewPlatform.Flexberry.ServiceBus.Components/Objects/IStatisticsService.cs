﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ServiceBus.Components
{
    using System;
    using System.Xml;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// IStatisticsService.
    /// </summary>
    // *** Start programmer edit section *** (IStatisticsService CustomAttributes)

    // *** End programmer edit section *** (IStatisticsService CustomAttributes)
    public interface IStatisticsService : NewPlatform.Flexberry.ServiceBus.Components.IServiceBusComponent
    {
        
        // *** Start programmer edit section *** (IStatisticsService CustomMembers)

        // *** End programmer edit section *** (IStatisticsService CustomMembers)

        
        // *** Start programmer edit section *** (IStatisticsService.NotifyMessageReceived NewPlatform.Flexberry.ServiceBus.Subscription CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyMessageReceived NewPlatform.Flexberry.ServiceBus.Subscription CustomAttributes)
        void NotifyMessageReceived(NewPlatform.Flexberry.ServiceBus.Subscription subscription);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyMessageSent NewPlatform.Flexberry.ServiceBus.Subscription CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyMessageSent NewPlatform.Flexberry.ServiceBus.Subscription CustomAttributes)
        void NotifyMessageSent(NewPlatform.Flexberry.ServiceBus.Subscription subscription);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyErrorOccurred NewPlatform.Flexberry.ServiceBus.Subscription CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyErrorOccurred NewPlatform.Flexberry.ServiceBus.Subscription CustomAttributes)
        void NotifyErrorOccurred(NewPlatform.Flexberry.ServiceBus.Subscription subscription);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyAvgTimeSent NewPlatform.Flexberry.ServiceBus.Subscription System.Int32 CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyAvgTimeSent NewPlatform.Flexberry.ServiceBus.Subscription System.Int32 CustomAttributes)
        void NotifyAvgTimeSent(NewPlatform.Flexberry.ServiceBus.Subscription subscription, int time);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyAvgTimeSql NewPlatform.Flexberry.ServiceBus.Subscription System.Int32 System.String CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyAvgTimeSql NewPlatform.Flexberry.ServiceBus.Subscription System.Int32 System.String CustomAttributes)
        void NotifyAvgTimeSql(NewPlatform.Flexberry.ServiceBus.Subscription subscription, int time, string sql);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyIncConnectionCount NewPlatform.Flexberry.ServiceBus.Subscription NewPlatform.Flexberry.ServiceBus.Message CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyIncConnectionCount NewPlatform.Flexberry.ServiceBus.Subscription NewPlatform.Flexberry.ServiceBus.Message CustomAttributes)
        void NotifyIncConnectionCount(NewPlatform.Flexberry.ServiceBus.Subscription subscription, NewPlatform.Flexberry.ServiceBus.Message message);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyIncConnectionCount NewPlatform.Flexberry.ServiceBus.Subscription CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyIncConnectionCount NewPlatform.Flexberry.ServiceBus.Subscription CustomAttributes)
        void NotifyIncConnectionCount(NewPlatform.Flexberry.ServiceBus.Subscription subscription);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyDecConnectionCount NewPlatform.Flexberry.ServiceBus.Subscription NewPlatform.Flexberry.ServiceBus.Message CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyDecConnectionCount NewPlatform.Flexberry.ServiceBus.Subscription NewPlatform.Flexberry.ServiceBus.Message CustomAttributes)
        void NotifyDecConnectionCount(NewPlatform.Flexberry.ServiceBus.Subscription subscription, NewPlatform.Flexberry.ServiceBus.Message message);
        
        // *** Start programmer edit section *** (IStatisticsService.NotifyDecConnectionCount NewPlatform.Flexberry.ServiceBus.Subscription CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.NotifyDecConnectionCount NewPlatform.Flexberry.ServiceBus.Subscription CustomAttributes)
        void NotifyDecConnectionCount(NewPlatform.Flexberry.ServiceBus.Subscription subscription);
        
        // *** Start programmer edit section *** (IStatisticsService.GetCurrentState CustomAttributes)

        // *** End programmer edit section *** (IStatisticsService.GetCurrentState CustomAttributes)
        MessageInfo[] GetCurrentState();
    }
}
