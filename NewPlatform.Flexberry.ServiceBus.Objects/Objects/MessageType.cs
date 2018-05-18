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
    /// MessageType.
    /// </summary>
    // *** Start programmer edit section *** (MessageType CustomAttributes)

    // *** End programmer edit section *** (MessageType CustomAttributes)
    [ClassStorage("ТипСообщения")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.@this)]
    [View("AuditView", new string[] {
            "ID as \'ID\'",
            "Name as \'Наименование\'",
            "Description as \'Комментарий\'"})]
    [View("EditView", new string[] {
            "ID as \'ID\'",
            "Name as \'Наименование\'",
            "Description as \'Комментарий\'"})]
    [View("ListView", new string[] {
            "ID as \'ID\'",
            "Name as \'Наименование\'"})]
    public class MessageType : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private string fID;
        
        private string fName;
        
        private string fDescription;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        // *** Start programmer edit section *** (MessageType CustomMembers)

        // *** End programmer edit section *** (MessageType CustomMembers)

        
        /// <summary>
        /// ID.
        /// </summary>
        // *** Start programmer edit section *** (MessageType.ID CustomAttributes)

        // *** End programmer edit section *** (MessageType.ID CustomAttributes)
        [PropertyStorage("Ид")]
        [StrLen(255)]
        public virtual string ID
        {
            get
            {
                // *** Start programmer edit section *** (MessageType.ID Get start)

                // *** End programmer edit section *** (MessageType.ID Get start)
                string result = this.fID;
                // *** Start programmer edit section *** (MessageType.ID Get end)
                if (string.IsNullOrEmpty(result))
                    result = __PrimaryKey.ToString();
                // *** End programmer edit section *** (MessageType.ID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageType.ID Set start)

                // *** End programmer edit section *** (MessageType.ID Set start)
                this.fID = value;
                // *** Start programmer edit section *** (MessageType.ID Set end)

                // *** End programmer edit section *** (MessageType.ID Set end)
            }
        }
        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (MessageType.Name CustomAttributes)

        // *** End programmer edit section *** (MessageType.Name CustomAttributes)
        [PropertyStorage("Наименование")]
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (MessageType.Name Get start)

                // *** End programmer edit section *** (MessageType.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (MessageType.Name Get end)

                // *** End programmer edit section *** (MessageType.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageType.Name Set start)

                // *** End programmer edit section *** (MessageType.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (MessageType.Name Set end)

                // *** End programmer edit section *** (MessageType.Name Set end)
            }
        }
        
        /// <summary>
        /// Description.
        /// </summary>
        // *** Start programmer edit section *** (MessageType.Description CustomAttributes)

        // *** End programmer edit section *** (MessageType.Description CustomAttributes)
        [PropertyStorage("Комментарий")]
        public virtual string Description
        {
            get
            {
                // *** Start programmer edit section *** (MessageType.Description Get start)

                // *** End programmer edit section *** (MessageType.Description Get start)
                string result = this.fDescription;
                // *** Start programmer edit section *** (MessageType.Description Get end)

                // *** End programmer edit section *** (MessageType.Description Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageType.Description Set start)

                // *** End programmer edit section *** (MessageType.Description Set start)
                this.fDescription = value;
                // *** Start programmer edit section *** (MessageType.Description Set end)

                // *** End programmer edit section *** (MessageType.Description Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (MessageType.CreateTime CustomAttributes)

        // *** End programmer edit section *** (MessageType.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (MessageType.CreateTime Get start)

                // *** End programmer edit section *** (MessageType.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (MessageType.CreateTime Get end)

                // *** End programmer edit section *** (MessageType.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageType.CreateTime Set start)

                // *** End programmer edit section *** (MessageType.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (MessageType.CreateTime Set end)

                // *** End programmer edit section *** (MessageType.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (MessageType.Creator CustomAttributes)

        // *** End programmer edit section *** (MessageType.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (MessageType.Creator Get start)

                // *** End programmer edit section *** (MessageType.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (MessageType.Creator Get end)

                // *** End programmer edit section *** (MessageType.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageType.Creator Set start)

                // *** End programmer edit section *** (MessageType.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (MessageType.Creator Set end)

                // *** End programmer edit section *** (MessageType.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (MessageType.EditTime CustomAttributes)

        // *** End programmer edit section *** (MessageType.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (MessageType.EditTime Get start)

                // *** End programmer edit section *** (MessageType.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (MessageType.EditTime Get end)

                // *** End programmer edit section *** (MessageType.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageType.EditTime Set start)

                // *** End programmer edit section *** (MessageType.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (MessageType.EditTime Set end)

                // *** End programmer edit section *** (MessageType.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (MessageType.Editor CustomAttributes)

        // *** End programmer edit section *** (MessageType.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (MessageType.Editor Get start)

                // *** End programmer edit section *** (MessageType.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (MessageType.Editor Get end)

                // *** End programmer edit section *** (MessageType.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageType.Editor Set start)

                // *** End programmer edit section *** (MessageType.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (MessageType.Editor Set end)

                // *** End programmer edit section *** (MessageType.Editor Set end)
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
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(NewPlatform.Flexberry.ServiceBus.MessageType));
                }
            }
            
            /// <summary>
            /// "EditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View EditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("EditView", typeof(NewPlatform.Flexberry.ServiceBus.MessageType));
                }
            }
            
            /// <summary>
            /// "ListView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ListView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ListView", typeof(NewPlatform.Flexberry.ServiceBus.MessageType));
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
}
