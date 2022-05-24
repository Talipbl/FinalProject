using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }

        public Order Get(int id)
        {
            return _orderDal.Get(p => p.OrderId == id);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public List<Order> GetByEmployeeId(int id)
        {
            return _orderDal.GetAll(p => p.EmployeeId == id);
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }
    }
}
