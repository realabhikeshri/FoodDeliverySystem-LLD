namespace FoodDeliverySystem.Domain.Entities
{
    public abstract class User
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; protected set; }
        public string Phone { get; protected set; }


        protected User(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}