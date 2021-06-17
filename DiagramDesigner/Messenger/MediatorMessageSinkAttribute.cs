using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramDesigner.Messenger
{
    class MediatorMessageSinkAttribute
    {
        /// <summary>
        /// Message key
        /// </summary>
        public object MessageKey { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MediatorMessageSinkAttribute()
        {
            MessageKey = null;
        }

        /// <summary>
        /// Constructor that takes a message key
        /// </summary>
        /// <param name="messageKey">Message Key</param>
        public MediatorMessageSinkAttribute(string messageKey)
        {
            MessageKey = messageKey;
        }
    }
}
