using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace BolyaiClubWindowsFormsApplication.Model
{
    [Table("User")]
    public class User
    {
        public User()
        {
            Rents = new HashSet<Rent>();
            Renters = new HashSet<Renter>();
        }

        public int UserId { get; set; }

        public int PersonId { get; set; }

        public bool IsAdmin { get; set; }

        [Required]
        [StringLength(256)]
        public string Password { get; set; }

        public virtual Person Person { get; set; }

        public virtual ICollection<Rent> Rents { get; set; }

        public virtual ICollection<Renter> Renters { get; set; }

    }
}
