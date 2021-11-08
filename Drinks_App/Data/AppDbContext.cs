using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinks_App.Data.Models;

namespace Drinks_App.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
