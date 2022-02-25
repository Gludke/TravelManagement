using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelManagement.Models;
using TravelManagement.Models.Repositories;

namespace TravelManagement.Controllers
{
    public class TravelController : Controller
    {
        private readonly IDriverRepository driverRepository;
        private readonly ITravelRepository travelRepository;

        public TravelController(IDriverRepository driverRepository, TravelRepository travelRepository)
        {
            this.driverRepository = driverRepository;
            this.travelRepository = travelRepository;
        }

        //Direciona para a view de criação de viagem
        public IActionResult Create(int idDriver)
        {
            var driver = driverRepository.SearchDriverWithId(idDriver);
            var travel = new TravelViewModel(new Travel(driver));
            return View(travel);
        }

        //Cria a nova viagem e adiciona ao Motorista
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TravelViewModel travelViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.success = "fail";
                var driver = driverRepository.SearchDriverWithId(travelViewModel.Travel.Driver.Id);
                travelViewModel.Travel.Driver = driver;
                return View("Create", travelViewModel);
            }
            ViewBag.success = "success";
            var driver_ = driverRepository.SearchDriverWithId(travelViewModel.Travel.Driver.Id);
            travelViewModel.Travel.Driver = driver_;
            travelRepository.AddTravel(travelViewModel);
            return View("Create", travelViewModel);
        }
    }
}
