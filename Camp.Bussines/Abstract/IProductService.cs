using Camp.Core;
using Camp.Core.Utilities.Results;
using Camp.Entities.Concrete;
using Camp.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.Bussines.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllByUnitPrice(decimal min,decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
    }
}
