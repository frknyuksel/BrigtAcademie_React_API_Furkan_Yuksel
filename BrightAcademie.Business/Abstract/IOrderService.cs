﻿using BrightAcademie.Entity.Concrete;
using BrightAcademie.Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademie.Business.Abstract
{
    public interface IOrderService
    {
        Task CreateAsync(Order order);
        Task<List<Order>> GetAllOrdersAsync(string userId = null, bool dateSort = false,OrderStatus? orderStatus = null);
        Task<string> GetTotalAsync(int action);

    }
}
