using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinks_App.Data.interfaces;
using Drinks_App.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Drinks_App.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _appDbContext;

        public DrinkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Drink> Drinks => _appDbContext.Drinks.Include(c => c.Category);
        public IEnumerable<Drink> PreferredDrinks => _appDbContext.Drinks
                                    .Where(p => p.IsPreferredDrink)
                                    .Include(c => c.Category);
        public Drink GetDrinkById(int drinkID) => _appDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkID);
    }
}
