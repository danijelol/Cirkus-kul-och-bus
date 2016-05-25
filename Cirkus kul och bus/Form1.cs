using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cirkus_kul_och_bus
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        //public BindingList<Person> personlista = new BindingList<Person>();

        private void button1_Click(object sender, EventArgs e)
        {          
            Postgres pg = new Postgres();           

            List<Person> personlista = new List<Person>();
            personlista = pg.HämtaPerson();
                                          
            listboxPersoner.DataSource = personlista;
            listboxPersoner.DisplayMember = "FullständigtNamn";

            
        }


    }
}
