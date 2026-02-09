namespace FoodDeliverySystem.Domain.Entities
{
    public class Restaurant
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; }
        public List<MenuItem> Menu { get; } = new();


        public Restaurant(string name)
        {
            Name = name;
        }


        public void AddMenuItem(MenuItem item)
        {
            Menu.Add(item);
        }
    }
}