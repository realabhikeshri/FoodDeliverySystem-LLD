namespace FoodDeliverySystem.Domain.Entities
{
    public class MenuItem
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; }
        public decimal Price { get; }


        public MenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}