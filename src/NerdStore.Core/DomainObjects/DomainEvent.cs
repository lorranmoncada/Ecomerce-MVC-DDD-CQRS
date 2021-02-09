﻿using NerdStore.Core.Message;
using System;

namespace NerdStore.Core.DomainObjects
{
    // Classe base para eventos
    public class DomainEvent : Event
    {
        public DomainEvent(Guid agreggateId)
        {
            AggregateId = agreggateId;
        }
    }
}
