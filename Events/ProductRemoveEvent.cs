using EventSourcing.Events.Core;

namespace EventSourcing.Events
{
    public class ProductRemoveEvent : Event
    {
        public ProductRemoveEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }

    }
}