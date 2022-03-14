using MediatR;
using System;

namespace NerdStore.Core.Messages
{
    public abstract class Event : Message, INotification
    {
        public DateTime Timestamp { get; set; }

        public Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
//install-package mediatr -v 7.0.0