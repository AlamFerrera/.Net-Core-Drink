﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_App.Data.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public string ShortDescripcion { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPreferredDrink { get; set; }
        public bool InStock { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
