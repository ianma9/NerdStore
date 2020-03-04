using System;
using System.Collections.Generic;
using System.Text;
using NerdStore.Core.Messages;

namespace NerdStore.Core.DomainObjects
{
    public class DomainEvent : Event 
    {
        public DomainEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}
