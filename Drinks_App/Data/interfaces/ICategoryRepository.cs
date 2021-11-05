using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinks_App.Data.Models;

namespace Drinks_App.Data.interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get;}
    }
}
