using EventSourcing.Events.Core;

namespace EventSourcing.Events
{
    public class ProductUpdateEvent : Event
    {
        public ProductUpdateEvent(Guid id, string name, decimal price, string decription)
        {
            Id = id;
            Name = name;
            Price = price;
            Decription = decription;
        }

        public Guid Id { get; set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Decription { get; private set; }

    }
}