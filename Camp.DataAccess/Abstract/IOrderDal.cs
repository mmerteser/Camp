﻿using Camp.Core.DataAccess;
using Camp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.DataAccess.Abstract
{
    public interface IOrderDal:IEntityRepository<Order>
    {
    }
}
