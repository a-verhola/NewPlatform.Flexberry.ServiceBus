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
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// MessageInfo.
    /// </summary>
    // *** Start programmer edit section *** (MessageInfo CustomAttributes)

    // *** End programmer edit section *** (MessageInfo CustomAttributes)
    public class MessageInfo
    {
        
        private System.DateTime fStartSendingTime;
        
        private string fRecipientName;
        
        private string fRecipientAddress;
        
        private int fSize;
        
        // *** Start programmer edit section *** (MessageInfo CustomMembers)

        // *** End programmer edit section *** (MessageInfo CustomMembers)

        
        /// <summary>
        /// StartSendingTime.
        /// </summary>
        // *** Start programmer edit section *** (MessageInfo.StartSendingTime CustomAttributes)

        // *** End programmer edit section *** (MessageInfo.StartSendingTime CustomAttributes)
        public virtual System.DateTime StartSendingTime
        {
            get
            {
                // *** Start programmer edit section *** (MessageInfo.StartSendingTime Get start)

                // *** End programmer edit section *** (MessageInfo.StartSendingTime Get start)
                System.DateTime result = this.fStartSendingTime;
                // *** Start programmer edit section *** (MessageInfo.StartSendingTime Get end)

                // *** End programmer edit section *** (MessageInfo.StartSendingTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageInfo.StartSendingTime Set start)

                // *** End programmer edit section *** (MessageInfo.StartSendingTime Set start)
                this.fStartSendingTime = value;
                // *** Start programmer edit section *** (MessageInfo.StartSendingTime Set end)

                // *** End programmer edit section *** (MessageInfo.StartSendingTime Set end)
            }
        }
        
        /// <summary>
        /// RecipientName.
        /// </summary>
        // *** Start programmer edit section *** (MessageInfo.RecipientName CustomAttributes)

        // *** End programmer edit section *** (MessageInfo.RecipientName CustomAttributes)
        public virtual string RecipientName
        {
            get
            {
                // *** Start programmer edit section *** (MessageInfo.RecipientName Get start)

                // *** End programmer edit section *** (MessageInfo.RecipientName Get start)
                string result = this.fRecipientName;
                // *** Start programmer edit section *** (MessageInfo.RecipientName Get end)

                // *** End programmer edit section *** (MessageInfo.RecipientName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageInfo.RecipientName Set start)

                // *** End programmer edit section *** (MessageInfo.RecipientName Set start)
                this.fRecipientName = value;
                // *** Start programmer edit section *** (MessageInfo.RecipientName Set end)

                // *** End programmer edit section *** (MessageInfo.RecipientName Set end)
            }
        }
        
        /// <summary>
        /// RecipientAddress.
        /// </summary>
        // *** Start programmer edit section *** (MessageInfo.RecipientAddress CustomAttributes)

        // *** End programmer edit section *** (MessageInfo.RecipientAddress CustomAttributes)
        public virtual string RecipientAddress
        {
            get
            {
                // *** Start programmer edit section *** (MessageInfo.RecipientAddress Get start)

                // *** End programmer edit section *** (MessageInfo.RecipientAddress Get start)
                string result = this.fRecipientAddress;
                // *** Start programmer edit section *** (MessageInfo.RecipientAddress Get end)

                // *** End programmer edit section *** (MessageInfo.RecipientAddress Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageInfo.RecipientAddress Set start)

                // *** End programmer edit section *** (MessageInfo.RecipientAddress Set start)
                this.fRecipientAddress = value;
                // *** Start programmer edit section *** (MessageInfo.RecipientAddress Set end)

                // *** End programmer edit section *** (MessageInfo.RecipientAddress Set end)
            }
        }
        
        /// <summary>
        /// Size.
        /// </summary>
        // *** Start programmer edit section *** (MessageInfo.Size CustomAttributes)

        // *** End programmer edit section *** (MessageInfo.Size CustomAttributes)
        public virtual int Size
        {
            get
            {
                // *** Start programmer edit section *** (MessageInfo.Size Get start)

                // *** End programmer edit section *** (MessageInfo.Size Get start)
                int result = this.fSize;
                // *** Start programmer edit section *** (MessageInfo.Size Get end)

                // *** End programmer edit section *** (MessageInfo.Size Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (MessageInfo.Size Set start)

                // *** End programmer edit section *** (MessageInfo.Size Set start)
                this.fSize = value;
                // *** Start programmer edit section *** (MessageInfo.Size Set end)

                // *** End programmer edit section *** (MessageInfo.Size Set end)
            }
        }
    }
}
