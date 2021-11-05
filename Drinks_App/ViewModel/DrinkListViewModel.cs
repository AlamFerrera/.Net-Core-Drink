using Drinks_App.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_App.ViewModel
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink>Drinks { get; set; }
        public string CurrentCategory { get; set; }
    }
}
