using Drinks_App.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_App.Data.interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
