using Camp.Core.DataAccess;
using Camp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Camp.Entities.DTOs;

namespace Camp.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails(); 
    }
}
