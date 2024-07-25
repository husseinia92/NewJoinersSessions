using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewJoinersSessions.Models;

namespace NewJoinersSessions.Controllers
{
    public class HomeController : Controller
    {
        /*
         
         * c# concepts: 

         Reasons why i used static readonly :

         Singleton-like Behavior : shared across all instances of the controller.
         Immutability : once initialized, their references cannot be changed.
         Performance :  reduces the overhead of creating new instances every time.

         */

        private static readonly Car car = new Car("Toyota", "Camry", 2020, 15000, 4);
        private static readonly Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Street 750", 2019, 5000);

        public IActionResult Index()
        {
            return View();
        }

        /*
         *  ShowCarInfo Action instantiate the ViewModel and pass it to the view.
         */
        public IActionResult ShowCarInfo()
        {
            var viewModel = new VehicleInfoViewModel
            {
                Info = car.DisplayInfo()
            };
            return View("DisplayInfo", viewModel);
        }

        /*
         * ShowMotorcycleInfo Action instantiate the ViewModel and pass it to the view.
         */
        public IActionResult ShowMotorcycleInfo()
        {
            var viewModel = new VehicleInfoViewModel
            {
                Info = motorcycle.DisplayInfo()
            };
            return View("DisplayInfo", viewModel);
        }
    }
}
