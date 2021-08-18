using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars { get
            {
                return new List<Car>
                {
                    new Car { name = "Tesla 1", shopDesc = "Каеф тесла 1", longDesc = "не удачный", 
                        img = "https://images.ru.prom.st/64275777_w200_h200_elektromobil-tesla-model.jpg", price = 45000, isFavourite = true, available = false, Category = _categoryCars.Allcategories.First() },
                    new Car { name = "Tesla 2", shopDesc = "Каеф тесла 2", longDesc = "Тишина", 
                        img = "https://drive-boom.ru/gallery/tesla/photo/tesla-model-s-5-door-hatchback-39187sm.jpeg", price = 4000, isFavourite = false, available = false, Category = _categoryCars.Allcategories.First() },
                    new Car { name = "BWV", shopDesc = "БМВ а что", longDesc = "Бытсро ломается", 
                        img = "https://bmwguide.ru/wp-content/uploads/2016/05/Vorsteiner-BMW-i8-Aero-And-Wheels-12.jpg", price = 9000, isFavourite = false, available = true, Category = _categoryCars.Allcategories.Last() },
                    new Car { name = "Audi", shopDesc = "ЕЕЕЕЕ", longDesc = "Уют и шум", 
                        img = "https://i.pinimg.com/originals/b6/45/21/b645212d203e37d89e5af715d2301e9e.jpg", price = 16600, isFavourite = true, available = true, Category = _categoryCars.Allcategories.Last() }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
