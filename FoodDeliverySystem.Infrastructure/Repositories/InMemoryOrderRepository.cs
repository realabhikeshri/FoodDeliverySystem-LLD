using FoodDeliverySystem.Application.Interfaces;
using FoodDeliverySystem.Domain.Entities;
using System.Collections.Concurrent;


namespace FoodDeliverySystem.Infrastructure.Repositories
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private readonly ConcurrentDictionary<Guid, Order> _orders = new();


        public void Save(Order order)
        {
            _orders[order.Id] = order;
        }


        public Order GetById(Guid id)
        {
            return _orders[id];
        }
    }
}