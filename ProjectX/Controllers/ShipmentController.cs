using Microsoft.AspNetCore.Mvc;
using ProjectX.Repositories;
using System;

namespace ProjectX.Controllers
{
    public class ShipmentController : Controller
    {
        private readonly IShipmentRepository _shipmentRepository;

        public ShipmentController(IShipmentRepository shipmentRepository)
        {
            _shipmentRepository = shipmentRepository;
        }

        [HttpGet]
        public IActionResult TrackShipment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TrackShipment(Guid id, string passcode)
        {
            var shipment = _shipmentRepository.GetShipmentByIdAndPasscode(id, passcode);
            if (shipment == null)
            {
                ViewBag.Message = "Invalid ID or Passcode!";
                return View();
            }
            return View("ShipmentDetails", shipment);
        }
    }
}
