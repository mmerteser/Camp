using Camp.Core.DataAccess.EntityFramework;
using Camp.DataAccess.Abstract;
using Camp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal: EFEntityRepositoryBase<Order,NorthwindContext>,IOrderDal
    {
    }
}
