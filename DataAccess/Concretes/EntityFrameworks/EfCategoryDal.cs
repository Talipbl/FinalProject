﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFrameworks
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,FinalContext>, ICategoryDal
    {
        
    }
}
