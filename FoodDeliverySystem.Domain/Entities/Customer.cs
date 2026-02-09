namespace FoodDeliverySystem.Domain.Entities
{
    public class Customer : User
    {
        public Customer(string name, string phone) : base(name, phone) { }
    }
}