using Camp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
