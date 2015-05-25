using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace BolyaiClubWindowsFormsApplication.Model
{
    [Table("Client")]
    public class Client
    {
        public Client()
        {
            Rents = new HashSet<Rent>();
        }

        public int ClientId { get; set; }

        public int PersonId { get; set; }

        public bool IsNonProfit { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int CreatedBy { get; set; }

        public virtual Person Person { get; set; }

        public virtual ICollection<Rent> Rents { get; set; }

        public virtual User User { get; set; }

        //public override string ToString()
        //{
        //    return //DatabaseManager.GetPersonEmail(PersonId);
        //}

    }
}
