using Models;
using Northwind.BusinessLogic.Interfaces;
using System.Collections.Generic;
using UnitOfWork;

namespace Northwind.BusinessLogic.Implementations
{
    public class CustomerLogic : ICustomerLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerLogic(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
        public IEnumerable<CustomerList> CustomerPagedList(int page, int rows) => _unitOfWork.Customer.CustomerPageList(page, rows);

        public bool Delete(Customer customer) => _unitOfWork.Customer.Delete(customer);

        public Customer GetById(int id) => _unitOfWork.Customer.GetById(id);

        public IEnumerable<Customer> GetList() => _unitOfWork.Customer.GetList();

        public int Insert(Customer customer) => _unitOfWork.Customer.Insert(customer);

        public bool Update(Customer customer) => _unitOfWork.Customer.Update(customer);
    }
}
