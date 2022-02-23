using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelManagement.Models.Repositories;

namespace TravelManagement.Controllers
{
    public class DriverController : Controller
    {
        private readonly IDriverRepository driverRepository;

        public DriverController(IDriverRepository driverRepository)
        {
            this.driverRepository = driverRepository;
        }

        public IActionResult List()
        {
            var drivers = driverRepository.List();
            return View(drivers);
        }
    }
}
