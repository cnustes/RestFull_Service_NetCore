﻿using Models;
using System.Collections.Generic;

namespace Repositories
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        IEnumerable<CustomerList> CustomerPageList(int page, int rows);
    }
}
