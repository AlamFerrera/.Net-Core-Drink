using Drinks_App.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_App.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Drink>PreferredDrinks { get; set; }
    }
}
