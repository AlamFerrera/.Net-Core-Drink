using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Drinks_App.Models;
using Drinks_App.Data.interfaces;
using Drinks_App.ViewModel;

namespace Drinks_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;

        public HomeController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredDrinks = _drinkRepository.PreferredDrinks
            };
            return View(homeViewModel);
        }
    }
}
