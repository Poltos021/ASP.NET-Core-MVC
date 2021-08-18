 using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.interfaces;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iallCars, ICarsCategory icarsCategory) {
            _allCars = iallCars;
            _allCategories = icarsCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Автомобили";
            //ViewBag.VB = "Some new"; вызов -  @ViewBag.VB
            CarsListViewModel obj = new CarsListViewModel();
            obj.getAllCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
        }
    }
}
