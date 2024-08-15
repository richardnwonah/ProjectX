using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectX.Models
{
    public class Shipment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Passcode { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string OwnersName { get; set; }

        [Required]
        [EmailAddress]
        public string OwnersMail { get; set; }

        [Required]
        public double ShipmentWeight { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        public DateTime ShipmentStartDate { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        [Required]
        public string Passls { get; set; }
    }
}
