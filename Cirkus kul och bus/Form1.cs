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

        List<Person> personlista = new List<Person>();

        Postgres pg = new Postgres();   
       

        private void button1_Click(object sender, EventArgs e)
        {
            personlista = new List<Person>();    
         
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

        private void listboxPersoner_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void btn_tabort_Click(object sender, EventArgs e)
        {

            listboxPersoner.DataSource = null;

            int personNr = int.Parse(tbx_personNr.Text);
            pg.TaBortPerson(personNr);

           
            personlista = pg.HämtaPerson();

            listboxPersoner.DataSource = personlista;
            listboxPersoner.DisplayMember = "FullständigtNamn";

        }

       


    }
}
