using EventSourcing.Events.Core;

namespace EventSourcing.Events
{
    public class ProductCreateEvent : Event
    {
        public ProductCreateEvent(Guid id, string name, decimal price, string decription)
        {
            Id = id;
            Name = name;
            Price = price;
            Decription = decription;
        }

        public Guid Id {get; set;}
        public string Name {get; private set;}
        public decimal Price {get; private set;}
        public string Decription { get; private set; }
    }
}