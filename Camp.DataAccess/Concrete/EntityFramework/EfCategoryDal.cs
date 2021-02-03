using Camp.DataAccess.Abstract;
using Camp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Camp.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal :EFGenericRepositoryDal<Category>,ICategoryDal
    {
       
    }
}
