using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelManagement.Models;
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

        //Direciona para a criação do motorista
        public IActionResult Create()
        {
            var newDriver = new Driver();
            return View(newDriver);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Driver driver)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.success = "fail";
                return View();
            }
            driverRepository.Add(driver);
            ViewBag.success = "success";
            return View();
        }

        //Leva para a view de remoção
        public IActionResult Remove(int idDriver)
        {
            if (idDriver == 0)
                return NotFound();

            try
            {
                var driver = driverRepository.SearchDriverWithId(idDriver);
                if (driver == null)
                    return NotFound();

                return View(driver);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Remove o motorista
        public IActionResult RemoveDriver(int idDriver)
        {
            if (idDriver == 0)
                return NotFound();

            try
            {
                driverRepository.Remove(idDriver);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Detalhes completos do Motorista
        public IActionResult Details(int idDriver)
        {
            if (idDriver == 0)
                return NotFound();

            try
            {
                var driver = driverRepository.SearchDriverWithId(idDriver);
                return View(driver);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
