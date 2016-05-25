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
        Postgres pg = new Postgres();   
        //public BindingList<Person> personlista = new BindingList<Person>();

        private void button1_Click(object sender, EventArgs e)
        {          
                    

            List<Person> personlista = new List<Person>();
            personlista = pg.HämtaPerson();
                                          
            listboxPersoner.DataSource = personlista;
            listboxPersoner.DisplayMember = "FullständigtNamn";

            

        }

        private void btn_läggTillPers_Click(object sender, EventArgs e)
        {
            
            string fnamn, enamn, postAdress, email, kon, postNr, teleNr;
            int personNr;
            bool fotoOk;

            fnamn = tbx_fornamn.Text;
            enamn = tbx_efternamn.Text;
            postAdress = tbx_adress.Text;
            email = tbx_email.Text;
            postNr = tbx_fornamn.Text;
            kon = tbx_kon.Text;
            teleNr = tbx_teleNr.Text;

            personNr = int.Parse(tbx_personNr.Text);
            fotoOk = cBoxJa.Checked;

            pg.LäggTillPerson(personNr, fnamn, enamn, postNr, postAdress, email, teleNr, kon, fotoOk);
        }

       


    }
}
