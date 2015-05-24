using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace BolyaiClubWindowsFormsApplication.Model
{
    [Table("Person")]
    public class Person
    {
        public Person()
        {
            Clients = new HashSet<Client>();
            Users = new HashSet<User>();
        }

        public int PersonId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(15)]
        public string Mobile { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}
