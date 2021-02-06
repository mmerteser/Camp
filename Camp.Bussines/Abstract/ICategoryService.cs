using Camp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.Bussines.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);

    }
}
