using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinks_App.Data.interfaces;
using Drinks_App.Data.mocks;
using Drinks_App.ViewModel;
using Drinks_App.Data.Models;

namespace Drinks_App.Controllers
{
    public class DrinkController:Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;

        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }

        public ViewResult List(string category)
        {
            /* DrinkListViewModel vm = new DrinkListViewModel();
             vm.Drinks = _drinkRepository.Drinks;
             vm.CurrentCategory = "Drink Category";
             return View(vm);*/
            string _category = category;
            IEnumerable<Drink> drinks;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                drinks = _drinkRepository.Drinks.OrderBy(n => n.DrinkId);
                currentCategory = "All drinks";
            }
            else
            {
                if (string.Equals("Alcoholic", _category, StringComparison.OrdinalIgnoreCase))
                {
                    drinks = _drinkRepository.Drinks
                            .Where(p => p.Category.CategoryName.Equals("Alcoholic"))
                            .OrderBy(p => p.Name);
                }
                else
                {
                    drinks = _drinkRepository.Drinks
                           .Where(p => p.Category.CategoryName.Equals("Non-alcoholic"))
                           .OrderBy(p => p.Name);
                }
                currentCategory = _category;
            }
            var drinkListViewModel = new DrinkListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory
            };
            return View(drinkListViewModel);
        }
    }
}
