using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFrameworks
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, FinalContext>, IOrderDal
    {

    }
}
