using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;}
        IEnumerable<Car> getFavCars { get; set; }

        Car getCar(int carId);
    }
}
