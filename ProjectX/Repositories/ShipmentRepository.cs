using System;
using System.Collections.Generic;
using System.Linq;
using ProjectX.Data;
using ProjectX.Models;

namespace ProjectX.Repositories
{
    public class ShipmentRepository : IShipmentRepository
    {
        private readonly ApplicationDbContext _context;

        public ShipmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Shipment> GetAllShipments() => _context.Shipments.ToList();

        public Shipment GetShipmentById(Guid id) => _context.Shipments.Find(id);

        public void AddShipment(Shipment shipment)
        {
            _context.Shipments.Add(shipment);
            _context.SaveChanges();
        }

        public void UpdateShipment(Shipment shipment)
        {
            _context.Shipments.Update(shipment);
            _context.SaveChanges();
        }

        public void DeleteShipment(Guid id)
        {
            var shipment = _context.Shipments.Find(id);
            if (shipment != null)
            {
                _context.Shipments.Remove(shipment);
                _context.SaveChanges();
            }
        }

        public Shipment GetShipmentByIdAndPasscode(Guid Id, string passcode) =>
            _context.Shipments.FirstOrDefault(s => s.Id == Id && s.Passcode == passcode);
    }
}
