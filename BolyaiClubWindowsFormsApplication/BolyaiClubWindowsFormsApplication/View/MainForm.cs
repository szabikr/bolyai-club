using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BolyaiClubWindowsFormsApplication.Model;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            using (var context = new BolyaiClubDbContext())
            {
                Person person = new Person
                {
                    Name = "Pistike",
                    Email = "pistike@pistike.com",
                    Mobile = "0748111222"
                };

                context.People.Add(person);
                context.SaveChanges();

            }
            
            
        }
    }
}
