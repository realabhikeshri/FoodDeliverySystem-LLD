using FoodDeliverySystem.Domain.Entities;


namespace FoodDeliverySystem.Application.Interfaces
{
    public interface IOrderRepository
    {
        void Save(Order order);
        Order GetById(Guid id);
    }
}