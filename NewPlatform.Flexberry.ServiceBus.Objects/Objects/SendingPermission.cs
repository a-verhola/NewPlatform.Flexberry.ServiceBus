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
    /// SendingPermission.
    /// </summary>
    // *** Start programmer edit section *** (SendingPermission CustomAttributes)

    // *** End programmer edit section *** (SendingPermission CustomAttributes)
    [ClassStorage("OutboundMessageTypeRestriction")]
    [AutoAltered()]
    [Caption("Разрешение на отправку")]
    [AccessType(ICSSoft.STORMNET.AccessType.@this)]
    [View("AuditView", new string[] {
            "MessageType as \'Тип сообщения\'",
            "MessageType.ID as \'ID\'"}, Hidden=new string[] {
            "MessageType.ID"})]
    [MasterViewDefineAttribute("AuditView", "MessageType", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ID")]
    [View("DetailView", new string[] {
            "Client",
            "MessageType as \'Тип сообщения\'",
            "MessageType.Name"}, Hidden=new string[] {
            "Client",
            "MessageType.Name"})]
    [MasterViewDefineAttribute("DetailView", "MessageType", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [View("ServiceBusView", new string[] {
            "Client",
            "Client.ID",
            "MessageType",
            "MessageType.ID"})]
    public class SendingPermission : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private NewPlatform.Flexberry.ServiceBus.MessageType fMessageType;
        
        private NewPlatform.Flexberry.ServiceBus.Client fClient;
        
        // *** Start programmer edit section *** (SendingPermission CustomMembers)

        // *** End programmer edit section *** (SendingPermission CustomMembers)

        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (SendingPermission.CreateTime CustomAttributes)

        // *** End programmer edit section *** (SendingPermission.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (SendingPermission.CreateTime Get start)

                // *** End programmer edit section *** (SendingPermission.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (SendingPermission.CreateTime Get end)

                // *** End programmer edit section *** (SendingPermission.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SendingPermission.CreateTime Set start)

                // *** End programmer edit section *** (SendingPermission.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (SendingPermission.CreateTime Set end)

                // *** End programmer edit section *** (SendingPermission.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (SendingPermission.Creator CustomAttributes)

        // *** End programmer edit section *** (SendingPermission.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (SendingPermission.Creator Get start)

                // *** End programmer edit section *** (SendingPermission.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (SendingPermission.Creator Get end)

                // *** End programmer edit section *** (SendingPermission.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SendingPermission.Creator Set start)

                // *** End programmer edit section *** (SendingPermission.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (SendingPermission.Creator Set end)

                // *** End programmer edit section *** (SendingPermission.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (SendingPermission.EditTime CustomAttributes)

        // *** End programmer edit section *** (SendingPermission.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (SendingPermission.EditTime Get start)

                // *** End programmer edit section *** (SendingPermission.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (SendingPermission.EditTime Get end)

                // *** End programmer edit section *** (SendingPermission.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SendingPermission.EditTime Set start)

                // *** End programmer edit section *** (SendingPermission.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (SendingPermission.EditTime Set end)

                // *** End programmer edit section *** (SendingPermission.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (SendingPermission.Editor CustomAttributes)

        // *** End programmer edit section *** (SendingPermission.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (SendingPermission.Editor Get start)

                // *** End programmer edit section *** (SendingPermission.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (SendingPermission.Editor Get end)

                // *** End programmer edit section *** (SendingPermission.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SendingPermission.Editor Set start)

                // *** End programmer edit section *** (SendingPermission.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (SendingPermission.Editor Set end)

                // *** End programmer edit section *** (SendingPermission.Editor Set end)
            }
        }
        
        /// <summary>
        /// SendingPermission.
        /// </summary>
        // *** Start programmer edit section *** (SendingPermission.MessageType CustomAttributes)

        // *** End programmer edit section *** (SendingPermission.MessageType CustomAttributes)
        [PropertyStorage(new string[] {
                "ТипСообщения"})]
        [NotNull()]
        public virtual NewPlatform.Flexberry.ServiceBus.MessageType MessageType
        {
            get
            {
                // *** Start programmer edit section *** (SendingPermission.MessageType Get start)

                // *** End programmer edit section *** (SendingPermission.MessageType Get start)
                NewPlatform.Flexberry.ServiceBus.MessageType result = this.fMessageType;
                // *** Start programmer edit section *** (SendingPermission.MessageType Get end)

                // *** End programmer edit section *** (SendingPermission.MessageType Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SendingPermission.MessageType Set start)

                // *** End programmer edit section *** (SendingPermission.MessageType Set start)
                this.fMessageType = value;
                // *** Start programmer edit section *** (SendingPermission.MessageType Set end)

                // *** End programmer edit section *** (SendingPermission.MessageType Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.Flexberry.ServiceBus.Client.
        /// </summary>
        // *** Start programmer edit section *** (SendingPermission.Client CustomAttributes)

        // *** End programmer edit section *** (SendingPermission.Client CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Клиент"})]
        [TypeUsage(new string[] {
                "NewPlatform.Flexberry.ServiceBus.Client"})]
        public virtual NewPlatform.Flexberry.ServiceBus.Client Client
        {
            get
            {
                // *** Start programmer edit section *** (SendingPermission.Client Get start)

                // *** End programmer edit section *** (SendingPermission.Client Get start)
                NewPlatform.Flexberry.ServiceBus.Client result = this.fClient;
                // *** Start programmer edit section *** (SendingPermission.Client Get end)

                // *** End programmer edit section *** (SendingPermission.Client Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SendingPermission.Client Set start)

                // *** End programmer edit section *** (SendingPermission.Client Set start)
                this.fClient = value;
                // *** Start programmer edit section *** (SendingPermission.Client Set end)

                // *** End programmer edit section *** (SendingPermission.Client Set end)
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
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(NewPlatform.Flexberry.ServiceBus.SendingPermission));
                }
            }
            
            /// <summary>
            /// "DetailView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View DetailView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("DetailView", typeof(NewPlatform.Flexberry.ServiceBus.SendingPermission));
                }
            }
            
            /// <summary>
            /// "ServiceBusView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ServiceBusView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ServiceBusView", typeof(NewPlatform.Flexberry.ServiceBus.SendingPermission));
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
    /// Detail array of SendingPermission.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfSendingPermission CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfSendingPermission CustomAttributes)
    public class DetailArrayOfSendingPermission : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.Flexberry.ServiceBus.DetailArrayOfSendingPermission members)

        // *** End programmer edit section *** (NewPlatform.Flexberry.ServiceBus.DetailArrayOfSendingPermission members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type SendingPermission by index.
        /// </summary>
        /// <summary>
        /// Adds object with type SendingPermission.
        /// </summary>
        public DetailArrayOfSendingPermission(NewPlatform.Flexberry.ServiceBus.Client fClient) : 
                base(typeof(SendingPermission), ((ICSSoft.STORMNET.DataObject)(fClient)))
        {
        }
        
        public NewPlatform.Flexberry.ServiceBus.SendingPermission this[int index]
        {
            get
            {
                return ((NewPlatform.Flexberry.ServiceBus.SendingPermission)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.Flexberry.ServiceBus.SendingPermission dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
