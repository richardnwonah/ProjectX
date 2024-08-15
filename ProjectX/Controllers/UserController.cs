using Microsoft.AspNetCore.Mvc;
using ProjectX.Repositories;

namespace ProjectX.Controllers
{
    public class UserController : Controller
    {
        private readonly IShipmentRepository _shipmentRepository;

        public UserController(IShipmentRepository shipmentRepository)
        {
            _shipmentRepository = shipmentRepository;
        }

        // Implement actions for viewing shipment details
    }
}
