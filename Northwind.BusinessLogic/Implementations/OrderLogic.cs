using Models;
using Northwind.BusinessLogic.Interfaces;
using System.Collections.Generic;
using UnitOfWork;

namespace Northwind.BusinessLogic.Implementations
{
    public class OrderLogic : IOrderLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderLogic(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
        public bool Delete(Order entity) => _unitOfWork.Order.Delete(entity);

        public Order GetById(int orderId)
        {
            return _unitOfWork.Order.GetById(orderId);
        }
        public OrderList GetOrderById(int orderId) => _unitOfWork.Order.GetOrderById(orderId);
        public IEnumerable<OrderList> getPaginatedOrder(int page, int rows) => _unitOfWork.Order.getPaginatedOrder(page, rows);       
    }
}
