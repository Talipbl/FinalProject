﻿using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order Get(int id);
        List<Order> GetByEmployeeId(int id);
        void Add(Order order);
        void Delete(Order order);
        void Update(Order order);
    }
}
