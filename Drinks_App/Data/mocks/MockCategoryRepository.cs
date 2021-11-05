using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinks_App.Data.interfaces;
using Drinks_App.Data.Models;

namespace Drinks_App.Data.mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Alcoholic", Description = "All alcoholic drinks"},
                    new Category { CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks"}
                };
            }
        }
    }
}
