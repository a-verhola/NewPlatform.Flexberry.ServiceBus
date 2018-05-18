﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ServiceBus
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business.Audit;
    using ICSSoft.STORMNET.Business.Audit.Objects;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// StatisticsCompressionSetting.
    /// </summary>
    // *** Start programmer edit section *** (StatisticsCompressionSetting CustomAttributes)

    // *** End programmer edit section *** (StatisticsCompressionSetting CustomAttributes)
    [ClassStorage("CompressionSetting")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.@this)]
    [View("AuditView", new string[] {
            "CompressTo as \'Сжимать до интервала\'",
            "StatisticsAgeCount",
            "StatisticsAgeUnits",
            "StatisticsAge as \'Сжимать старше, чем\'",
            "CompressFrequencyCount",
            "CompressFrequencyUnits",
            "CompressFrequency as \'Периодичность сжатия\'",
            "NextCompressTime as \'Время следующего сжатия\'",
            "LastCompressTime as \'Время последнего сжатия\'"}, Hidden=new string[] {
            "StatisticsAgeCount",
            "StatisticsAgeUnits",
            "CompressFrequencyCount",
            "CompressFrequencyUnits"})]
    [View("CompressView", new string[] {
            "CompressTo",
            "StatisticsAgeCount",
            "StatisticsAgeUnits",
            "CompressFrequencyCount",
            "CompressFrequencyUnits",
            "NextCompressTime",
            "LastCompressTime",
            "StatisticsSetting"})]
    [View("DetailView", new string[] {
            "CompressTo as \'Сжимать до интервала\'",
            "StatisticsAge as \'Сжимать старше, чем\'",
            "StatisticsAgeCount",
            "StatisticsAgeUnits",
            "CompressFrequency as \'Периодичность сжатия\'",
            "CompressFrequencyCount",
            "CompressFrequencyUnits",
            "NextCompressTime as \'Время следующего сжатия\'",
            "LastCompressTime as \'Время последнего сжатия\'",
            "StatisticsSetting"}, Hidden=new string[] {
            "StatisticsAgeCount",
            "StatisticsAgeUnits",
            "CompressFrequencyCount",
            "CompressFrequencyUnits",
            "StatisticsSetting"})]
    [View("EditView", new string[] {
            "StatisticsSetting as \'Настройка регистрации статистики\'",
            "StatisticsSetting.Subscription",
            "StatisticsSetting.Subscription.Description",
            "StatisticsSetting.Subscription.Client",
            "StatisticsSetting.Subscription.Client.ID",
            "StatisticsSetting.Subscription.Client.Name",
            "StatisticsSetting.Subscription.MessageType",
            "StatisticsSetting.Subscription.MessageType.ID",
            "StatisticsSetting.Subscription.MessageType.Name",
            "CompressTo as \'Сжимать до интервала\'",
            "StatisticsAgeCount as \'Сжимать старше, чем\'",
            "StatisticsAgeUnits as \'Единица времени возраста сжатия статистики\'",
            "CompressFrequencyCount as \'Периодичность сжатия\'",
            "CompressFrequencyUnits as \'Единица времени периодичности сжатия\'",
            "NextCompressTime as \'Время следующего сжатия\'",
            "LastCompressTime as \'Время последнего сжатия\'"}, Hidden=new string[] {
            "StatisticsSetting.Subscription",
            "StatisticsSetting.Subscription.Description",
            "StatisticsSetting.Subscription.Client",
            "StatisticsSetting.Subscription.Client.ID",
            "StatisticsSetting.Subscription.Client.Name",
            "StatisticsSetting.Subscription.MessageType",
            "StatisticsSetting.Subscription.MessageType.ID",
            "StatisticsSetting.Subscription.MessageType.Name"})]
    [MasterViewDefineAttribute("EditView", "StatisticsSetting", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Subscription.Description")]
    [View("ListView", new string[] {
            "StatisticsSetting",
            "StatisticsSetting.Subscription",
            "StatisticsSetting.Subscription.Description as \'Подписка\'",
            "StatisticsSetting.Subscription.Client",
            "StatisticsSetting.Subscription.Client.ID",
            "StatisticsSetting.Subscription.Client.Name",
            "StatisticsSetting.Subscription.MessageType",
            "StatisticsSetting.Subscription.MessageType.ID",
            "StatisticsSetting.Subscription.MessageType.Name",
            "CompressTo as \'Сжимать до интервала\'",
            "StatisticsAgeCount",
            "StatisticsAgeUnits",
            "StatisticsAge as \'Сжимать старше, чем\'",
            "CompressFrequencyCount",
            "CompressFrequencyUnits",
            "CompressFrequency as \'Периодичность сжатия\'",
            "NextCompressTime as \'Время следующего сжатия\'",
            "LastCompressTime as \'Время последнего сжатия\'"}, Hidden=new string[] {
            "StatisticsSetting",
            "StatisticsSetting.Subscription",
            "StatisticsSetting.Subscription.Client",
            "StatisticsSetting.Subscription.Client.ID",
            "StatisticsSetting.Subscription.Client.Name",
            "StatisticsSetting.Subscription.MessageType",
            "StatisticsSetting.Subscription.MessageType.ID",
            "StatisticsSetting.Subscription.MessageType.Name",
            "StatisticsAgeCount",
            "StatisticsAgeUnits",
            "CompressFrequencyCount",
            "CompressFrequencyUnits"})]
    public class StatisticsCompressionSetting : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private NewPlatform.Flexberry.ServiceBus.StatisticsInterval fCompressTo;
        
        private int fStatisticsAgeCount;
        
        private NewPlatform.Flexberry.ServiceBus.TimeUnit fStatisticsAgeUnits;
        
        private int fCompressFrequencyCount;
        
        private NewPlatform.Flexberry.ServiceBus.TimeUnit fCompressFrequencyUnits;
        
        private System.DateTime fNextCompressTime = System.DateTime.Now;
        
        private DateTime? fLastCompressTime;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private NewPlatform.Flexberry.ServiceBus.StatisticsSetting fStatisticsSetting;
        
        // *** Start programmer edit section *** (StatisticsCompressionSetting CustomMembers)

        // *** End programmer edit section *** (StatisticsCompressionSetting CustomMembers)

        
        /// <summary>
        /// CompressTo.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressTo CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.CompressTo CustomAttributes)
        [PropertyStorage("TargetCompression")]
        [NotNull()]
        public virtual NewPlatform.Flexberry.ServiceBus.StatisticsInterval CompressTo
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressTo Get start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressTo Get start)
                NewPlatform.Flexberry.ServiceBus.StatisticsInterval result = this.fCompressTo;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressTo Get end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressTo Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressTo Set start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressTo Set start)
                this.fCompressTo = value;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressTo Set end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressTo Set end)
            }
        }
        
        /// <summary>
        /// StatisticsAgeCount.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeCount CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeCount CustomAttributes)
        [PropertyStorage("LifetimeLimit")]
        [NotNull()]
        public virtual int StatisticsAgeCount
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeCount Get start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeCount Get start)
                int result = this.fStatisticsAgeCount;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeCount Get end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeCount Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeCount Set start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeCount Set start)
                this.fStatisticsAgeCount = value;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeCount Set end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeCount Set end)
            }
        }
        
        /// <summary>
        /// StatisticsAgeUnits.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeUnits CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeUnits CustomAttributes)
        [PropertyStorage("LifetimeUnits")]
        [NotNull()]
        public virtual NewPlatform.Flexberry.ServiceBus.TimeUnit StatisticsAgeUnits
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeUnits Get start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeUnits Get start)
                NewPlatform.Flexberry.ServiceBus.TimeUnit result = this.fStatisticsAgeUnits;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeUnits Get end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeUnits Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeUnits Set start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeUnits Set start)
                this.fStatisticsAgeUnits = value;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeUnits Set end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsAgeUnits Set end)
            }
        }
        
        /// <summary>
        /// StatisticsAge.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsAge CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsAge CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [StrLen(255)]
        [DataServiceExpression(typeof(ICSSoft.STORMNET.Business.MSSQLDataService), "CAST(@StatisticsAgeCount@ as varchar(max)) + \' (\' + @StatisticsAgeUnits@ + \')\'")]
        [DataServiceExpression(typeof(ICSSoft.STORMNET.Business.PostgresDataService), "@StatisticsAgeCount@::text || \'(\' || @StatisticsAgeUnits@ || \')\'")]
        public virtual string StatisticsAge
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsAge Get)
                return $"{StatisticsAgeCount} ({EnumCaption.GetCaptionFor(StatisticsAgeUnits)})";
                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsAge Get)
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsAge Set)

                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsAge Set)
            }
        }
        
        /// <summary>
        /// CompressFrequencyCount.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyCount CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyCount CustomAttributes)
        [PropertyStorage("Period")]
        [NotNull()]
        public virtual int CompressFrequencyCount
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyCount Get start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyCount Get start)
                int result = this.fCompressFrequencyCount;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyCount Get end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyCount Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyCount Set start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyCount Set start)
                this.fCompressFrequencyCount = value;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyCount Set end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyCount Set end)
            }
        }
        
        /// <summary>
        /// CompressFrequencyUnits.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyUnits CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyUnits CustomAttributes)
        [PropertyStorage("PeriodUnits")]
        [NotNull()]
        public virtual NewPlatform.Flexberry.ServiceBus.TimeUnit CompressFrequencyUnits
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyUnits Get start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyUnits Get start)
                NewPlatform.Flexberry.ServiceBus.TimeUnit result = this.fCompressFrequencyUnits;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyUnits Get end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyUnits Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyUnits Set start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyUnits Set start)
                this.fCompressFrequencyUnits = value;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyUnits Set end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressFrequencyUnits Set end)
            }
        }
        
        /// <summary>
        /// CompressFrequency.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressFrequency CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.CompressFrequency CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [StrLen(255)]
        [DataServiceExpression(typeof(ICSSoft.STORMNET.Business.MSSQLDataService), "CAST(@CompressFrequencyCount@ as varchar(max)) + \' (\' + @CompressFrequencyUnits@ " +
            "+ \')\'")]
        [DataServiceExpression(typeof(ICSSoft.STORMNET.Business.PostgresDataService), "@CompressFrequencyCount@::text || \' (\' || @CompressFrequencyUnits@ || \')\'")]
        public virtual string CompressFrequency
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressFrequency Get)
                return $"{CompressFrequencyCount} ({EnumCaption.GetCaptionFor(CompressFrequencyUnits)})";
                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressFrequency Get)
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CompressFrequency Set)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CompressFrequency Set)
            }
        }
        
        /// <summary>
        /// NextCompressTime.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.NextCompressTime CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.NextCompressTime CustomAttributes)
        [PropertyStorage("NextCompressionTime")]
        [NotNull()]
        public virtual System.DateTime NextCompressTime
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.NextCompressTime Get start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.NextCompressTime Get start)
                System.DateTime result = this.fNextCompressTime;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.NextCompressTime Get end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.NextCompressTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.NextCompressTime Set start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.NextCompressTime Set start)
                this.fNextCompressTime = value;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.NextCompressTime Set end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.NextCompressTime Set end)
            }
        }
        
        /// <summary>
        /// LastCompressTime.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.LastCompressTime CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.LastCompressTime CustomAttributes)
        [PropertyStorage("LastCompressionTime")]
        public virtual DateTime? LastCompressTime
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.LastCompressTime Get start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.LastCompressTime Get start)
                DateTime? result = this.fLastCompressTime;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.LastCompressTime Get end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.LastCompressTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.LastCompressTime Set start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.LastCompressTime Set start)
                this.fLastCompressTime = value;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.LastCompressTime Set end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.LastCompressTime Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.CreateTime CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CreateTime Get start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CreateTime Get end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CreateTime Set start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.CreateTime Set end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.Creator CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.Creator Get start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.Creator Get end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.Creator Set start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.Creator Set end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.EditTime CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.EditTime Get start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.EditTime Get end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.EditTime Set start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.EditTime Set end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.Editor CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.Editor Get start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.Editor Get end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.Editor Set start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.Editor Set end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.Editor Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.Flexberry.ServiceBus.StatisticsSetting.
        /// </summary>
        // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsSetting CustomAttributes)

        // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsSetting CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "StatSetting"})]
        public virtual NewPlatform.Flexberry.ServiceBus.StatisticsSetting StatisticsSetting
        {
            get
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsSetting Get start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsSetting Get start)
                NewPlatform.Flexberry.ServiceBus.StatisticsSetting result = this.fStatisticsSetting;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsSetting Get end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsSetting Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsSetting Set start)

                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsSetting Set start)
                this.fStatisticsSetting = value;
                // *** Start programmer edit section *** (StatisticsCompressionSetting.StatisticsSetting Set end)

                // *** End programmer edit section *** (StatisticsCompressionSetting.StatisticsSetting Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "AuditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AuditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(NewPlatform.Flexberry.ServiceBus.StatisticsCompressionSetting));
                }
            }
            
            /// <summary>
            /// "CompressView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View CompressView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("CompressView", typeof(NewPlatform.Flexberry.ServiceBus.StatisticsCompressionSetting));
                }
            }
            
            /// <summary>
            /// "DetailView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View DetailView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("DetailView", typeof(NewPlatform.Flexberry.ServiceBus.StatisticsCompressionSetting));
                }
            }
            
            /// <summary>
            /// "EditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View EditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("EditView", typeof(NewPlatform.Flexberry.ServiceBus.StatisticsCompressionSetting));
                }
            }
            
            /// <summary>
            /// "ListView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ListView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ListView", typeof(NewPlatform.Flexberry.ServiceBus.StatisticsCompressionSetting));
                }
            }
        }
        
        /// <summary>
        /// Audit class settings.
        /// </summary>
        public class AuditSettings
        {
            
            /// <summary>
            /// Включён ли аудит для класса.
            /// </summary>
            public static bool AuditEnabled = true;
            
            /// <summary>
            /// Использовать имя представления для аудита по умолчанию.
            /// </summary>
            public static bool UseDefaultView = false;
            
            /// <summary>
            /// Включён ли аудит операции чтения.
            /// </summary>
            public static bool SelectAudit = false;
            
            /// <summary>
            /// Имя представления для аудирования операции чтения.
            /// </summary>
            public static string SelectAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции создания.
            /// </summary>
            public static bool InsertAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции создания.
            /// </summary>
            public static string InsertAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции изменения.
            /// </summary>
            public static bool UpdateAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции изменения.
            /// </summary>
            public static string UpdateAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции удаления.
            /// </summary>
            public static bool DeleteAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции удаления.
            /// </summary>
            public static string DeleteAuditViewName = "AuditView";
            
            /// <summary>
            /// Путь к форме просмотра результатов аудита.
            /// </summary>
            public static string FormUrl = "";
            
            /// <summary>
            /// Режим записи данных аудита (синхронный или асинхронный).
            /// </summary>
            public static ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode WriteMode = ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode.Synchronous;
            
            /// <summary>
            /// Максимальная длина сохраняемого значения поля (если 0, то строка обрезаться не будет).
            /// </summary>
            public static int PrunningLength = 0;
            
            /// <summary>
            /// Показывать ли пользователям в изменениях первичные ключи.
            /// </summary>
            public static bool ShowPrimaryKey = false;
            
            /// <summary>
            /// Сохранять ли старое значение.
            /// </summary>
            public static bool KeepOldValue = true;
            
            /// <summary>
            /// Сжимать ли сохраняемые значения.
            /// </summary>
            public static bool Compress = false;
            
            /// <summary>
            /// Сохранять ли все значения атрибутов, а не только изменяемые.
            /// </summary>
            public static bool KeepAllValues = false;
        }
    }
    
    /// <summary>
    /// Detail array of StatisticsCompressionSetting.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfStatisticsCompressionSetting CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfStatisticsCompressionSetting CustomAttributes)
    public class DetailArrayOfStatisticsCompressionSetting : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.Flexberry.ServiceBus.DetailArrayOfStatisticsCompressionSetting members)

        // *** End programmer edit section *** (NewPlatform.Flexberry.ServiceBus.DetailArrayOfStatisticsCompressionSetting members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type StatisticsCompressionSetting by index.
        /// </summary>
        /// <summary>
        /// Adds object with type StatisticsCompressionSetting.
        /// </summary>
        public DetailArrayOfStatisticsCompressionSetting(NewPlatform.Flexberry.ServiceBus.StatisticsSetting fStatisticsSetting) : 
                base(typeof(StatisticsCompressionSetting), ((ICSSoft.STORMNET.DataObject)(fStatisticsSetting)))
        {
        }
        
        public NewPlatform.Flexberry.ServiceBus.StatisticsCompressionSetting this[int index]
        {
            get
            {
                return ((NewPlatform.Flexberry.ServiceBus.StatisticsCompressionSetting)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.Flexberry.ServiceBus.StatisticsCompressionSetting dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
