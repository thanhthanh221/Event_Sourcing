namespace EventSourcing.Models
{
    public class Product : EntityAudit
    {
        public Product()
        {
        }

        public Product(string name, decimal price, string decription, Guid Id)
        {
            this.Id = Id;   
            Name = name;
            Price = price;
            Decription = decription;
        }

        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Decription { get; private set; }
    }
}