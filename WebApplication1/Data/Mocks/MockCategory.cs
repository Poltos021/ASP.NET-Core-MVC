using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> Allcategories { get {
                return new List<Category> {
                    new Category{ categoryName = "электромобили", desc = "Современный вид"},
                    new Category{ categoryName = "классический", desc = "Двигатель"}

                };
            }
        }
    }

}
