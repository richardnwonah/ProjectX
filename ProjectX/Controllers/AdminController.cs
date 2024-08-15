using Microsoft.AspNetCore.Mvc;
using ProjectX.Models;
using ProjectX.Repositories;
using System;

namespace ProjectX.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IShipmentRepository _shipmentRepository;

        public AdminController(IUserRepository userRepository, IShipmentRepository shipmentRepository)
        {
            _userRepository = userRepository;
            _shipmentRepository = shipmentRepository;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _userRepository.GetUserByUsernameAndPassword(username, password);
            if (user != null && user.IsAdmin)
            {
                // You can implement session or cookie-based authentication here
                return RedirectToAction("Index");
            }

            ViewBag.Message = "Invalid credentials!";
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_shipmentRepository.GetAllShipments());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Shipment shipment)
        {
            if (ModelState.IsValid)
            {
                shipment.Id = Guid.NewGuid();
                _shipmentRepository.AddShipment(shipment);
                return RedirectToAction("Index");
            }
            return View(shipment);
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var shipment = _shipmentRepository.GetShipmentById(id);
            if (shipment == null)
            {
                return NotFound();
            }
            return View(shipment);
        }

        [HttpPost]
        public IActionResult Edit(Shipment shipment)
        {
            if (ModelState.IsValid)
            {
                _shipmentRepository.UpdateShipment(shipment);
                return RedirectToAction("Index");
            }
            return View(shipment);
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var shipment = _shipmentRepository.GetShipmentById(id);
            if (shipment == null)
            {
                return NotFound();
            }
            return View(shipment);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _shipmentRepository.DeleteShipment(id);
            return RedirectToAction("Index");
        }
    }
}
