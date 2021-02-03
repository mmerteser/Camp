using Camp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
