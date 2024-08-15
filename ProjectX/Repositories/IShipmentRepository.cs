using System;
using System.Collections.Generic;
using ProjectX.Models;

namespace ProjectX.Repositories
{
    public interface IShipmentRepository
    {
        IEnumerable<Shipment> GetAllShipments();
        Shipment GetShipmentById(Guid id);
        void AddShipment(Shipment shipment);
        void UpdateShipment(Shipment shipment);
        void DeleteShipment(Guid id);
        Shipment GetShipmentByIdAndPasscode(Guid uniqueId, string passcode);
    }
}
