using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace BolyaiClubWindowsFormsApplication.Model
{
    [Table("Price")]
    public class Price
    {
        public Price()
        {
            Rents = new HashSet<Rent>();
        }

        public int PriceId { get; set; }

        public int RoomId { get; set; }

        public bool IsNonProfit { get; set; }

        public int Value { get; set; }

        public virtual Room Room { get; set; }

        public virtual ICollection<Rent> Rents { get; set; }
    }
}
