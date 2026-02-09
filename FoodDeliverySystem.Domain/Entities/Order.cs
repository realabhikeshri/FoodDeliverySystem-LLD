using FoodDeliverySystem.Domain.Enums;


namespace FoodDeliverySystem.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Customer Customer { get; }
        public Restaurant Restaurant { get; }
        public List<MenuItem> Items { get; }
        public OrderStatus Status { get; private set; }
        public DateTime CreatedAt { get; } = DateTime.UtcNow;


        public Order(Customer customer, Restaurant restaurant, List<MenuItem> items)
        {
            Customer = customer;
            Restaurant = restaurant;
            Items = items;
            Status = OrderStatus.Placed;
        }


        public void UpdateStatus(OrderStatus status)
        {
            Status = status;
        }


        public decimal TotalAmount()
        {
            return Items.Sum(i => i.Price);
        }
    }
}