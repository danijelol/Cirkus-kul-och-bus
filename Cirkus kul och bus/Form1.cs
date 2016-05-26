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
        List<Träningstillfälle> träningstillfällen = new List<Träningstillfälle>();
        List<Träningsgrupp> träningsgrupper = new List<Träningsgrupp>();
        Postgres pg = new Postgres();   
       

        private void button1_Click(object sender, EventArgs e)
        {
            personlista = new List<Person>();  
            träningstillfällen  = new List<Träningstillfälle>();                   

            if (rbtn_Person.Checked) 
            {
                personlista = pg.HämtaPerson();

                listboxPersoner.DataSource = personlista;
                listboxPersoner.DisplayMember = "FullständigaPersonUpp";          
            }
            else if (rbtn_träning.Checked) 
            {
                pg.HämtaTräningsTillfälle();

                listboxPersoner.DataSource = träningstillfällen;
                listboxPersoner.DisplayMember = "FullständigaPersonUpp";
            }
            else if (rbtn_träningsgrupp.Checked) 
            {
                pg.HämtaTräningsgrupp();

                listboxPersoner.DataSource = träningsgrupper;
                listboxPersoner.DisplayMember = "FullständigaPersonUpp";
            
            
            }
            

        }

        private void btn_läggTillPers_Click(object sender, EventArgs e)
        {

            personlista = new List<Person>();
            listboxPersoner.DataSource = null;

            string fnamn, enamn, postAdress, email, kon, postNr, teleNr;
            int personNr;
            bool fotoOk;

            fnamn = tbx_fornamn.Text;
            enamn = tbx_efternamn.Text;
            postAdress = tbx_adress.Text;
            email = tbx_email.Text;
            postNr = tbx_postNr.Text;
            kon = tbx_kon.Text;
            teleNr = tbx_teleNr.Text;

            personNr = int.Parse(tbx_personNr.Text);
            fotoOk = cBoxJa.Checked;

            pg.LäggTillPerson(personNr, fnamn, enamn, postNr, postAdress, email, teleNr, kon, fotoOk);

            personlista = pg.HämtaPerson();

            listboxPersoner.DataSource = personlista;
            listboxPersoner.DisplayMember = "FullständigaPersonUpp";

        }

        private void listboxPersoner_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void btn_tabort_Click(object sender, EventArgs e)
        {
            personlista = new List<Person>();
            listboxPersoner.DataSource = null;

            int personNr = int.Parse(tbx_personNr.Text);
            pg.TaBortPerson(personNr);




            personlista = pg.HämtaPerson();

            listboxPersoner.DataSource = personlista;
            listboxPersoner.DisplayMember = "FullständigaPersonUpp";


        }

        private void btn_ändraPerson_Click(object sender, EventArgs e)
        {
            string fnamn, enamn, postAdress, email, kon, postNr, teleNr;
            int personNr;
            bool fotoOk;


            personlista = new List<Person>();
            listboxPersoner.DataSource = null;


            fnamn = tbx_fornamn.Text;
            enamn = tbx_efternamn.Text;
            postAdress = tbx_adress.Text;
            email = tbx_email.Text;
            postNr = tbx_postNr.Text;
            kon = tbx_kon.Text;
            teleNr = tbx_teleNr.Text;

            personNr = int.Parse(tbx_personNr.Text);
            fotoOk = cBoxJa.Checked;

            pg.UppdateraPerson(fnamn, enamn, postNr, postAdress, email, teleNr, fotoOk, personNr);

            personlista = pg.HämtaPerson();

            listboxPersoner.DataSource = personlista;
            listboxPersoner.DisplayMember = "FullständigaPersonUpp";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

       
       


    }
}
