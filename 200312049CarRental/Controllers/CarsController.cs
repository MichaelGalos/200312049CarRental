using _200312049CarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _200312049CarRental.Controllers
{
    public class CarsController : Controller
    {
        List<Car> carList = new List<Car>()
        {
            new Car {Id = 1, Brand = "Toyota", Model = "Corrolla", Type = "Compact", Year = 2017},
            new Car {Id = 2, Brand = "Ford", Model = "F-150", Type = "Truck", Year = 2018},
            new Car {Id = 3, Brand = "Dodge", Model = "Caravan", Type = "Minivan", Year = 2019}
        };

        // GET: Cars
        public ActionResult Index()
        {
            return View(carList);
        }

        // GET: Cars/Details - Single Car
        public ActionResult Details(int? id)
        {
            if(id == null || id > carList.Count)
            {
                return Content("Invalid Car Id");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];

            return View(car);
        }
    }
}