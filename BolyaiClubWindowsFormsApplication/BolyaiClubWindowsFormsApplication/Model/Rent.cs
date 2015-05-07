using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace BolyaiClubWindowsFormsApplication.Model
{
    [Table("Rent")]
    public class Rent
    {
        public int RentId { get; set; }

        public int RoomId { get; set; }

        public int RenterId { get; set; }

        public int UserId { get; set; }

        public int PriceId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public bool IsFinished { get; set; }

        public float Cost { get; set; }

        [Required]
        public bool IsPaid { get; set; }

        public virtual Price Price { get; set; }

        public virtual Room Room { get; set; }

        public virtual Renter Renter { get; set; }

        public virtual User User { get; set; }
    }
}
