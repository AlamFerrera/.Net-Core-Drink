using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_App.Data.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int DrinkId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Drink drink { get; set; }
        public virtual Order order { get; set; }
    }
}
