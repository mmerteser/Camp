﻿using Camp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.Bussines.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetAllByUnitPrice(decimal min,decimal max);
    }
}