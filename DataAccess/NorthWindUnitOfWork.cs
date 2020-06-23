using Repositories;
using System;
using UnitOfWork;

namespace DataAccess
{
    public class NorthWindUnitOfWork : IUnitOfWork
    {
        public NorthWindUnitOfWork(string connecctionString)
        {
            Customer = new CustomerRepository(connecctionString);
            User = new UserRepository(connecctionString);
            Supplier = new SupplierRepository(connecctionString);
            Order = new OrderRepository(connecctionString);
        } 
        public ICustomerRepository Customer  { get; private set; }

        public IUserRepository User { get; private set; }

        public ISupplierRepository Supplier { get; private set; }
        public IOrderRepository Order { get; private set; }
    }
}
