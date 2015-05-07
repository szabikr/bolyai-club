using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace BolyaiClubWindowsFormsApplication.Model
{
    [Table("Room")]
    public class Room
    {
        public Room()
        {
            Prices = new HashSet<Price>();
            Rents = new HashSet<Rent>();
        }

        public int RoomId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Capacity { get; set; }

        public virtual ICollection<Price> Prices { get; set; }

        public virtual ICollection<Rent> Rents { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
