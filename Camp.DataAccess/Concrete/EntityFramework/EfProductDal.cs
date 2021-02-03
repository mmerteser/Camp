using Camp.DataAccess.Abstract;
using Camp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Camp.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EFGenericRepositoryDal<Product>,IProductDal
    {
       
    }
}
