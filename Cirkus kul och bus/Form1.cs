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
        List<Närvaro> närvarolista = new List<Närvaro>();
        List<Träningstillfälle> utskrift = new List<Träningstillfälle>(); 


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
               träningstillfällen= pg.HämtaTräningsTillfälle();

                listboxPersoner.DataSource = träningstillfällen;
                listboxPersoner.DisplayMember = "TräningstillfällesInfo";
            }
            else if (rbtn_träningsgrupp.Checked) 
            {
               träningsgrupper = pg.HämtaTräningsgrupp();

                listboxPersoner.DataSource = träningsgrupper;
                listboxPersoner.DisplayMember = "TräningsgruppsInfo";
            
            
            }
            

        }
        public int MedlemsTyp()
            {
            
                int medlemstyp =0;
                Person nymedlemstyp = new Person();
                medlemstyp = nymedlemstyp.Medlemstyp;

                if (rbt_medlem.Checked)
                {
                    medlemstyp = 1;
                }
                else if (rbt_provapa.Checked)
                {
                    medlemstyp = 2;
                }
                else if (rbt_cirkusvan.Checked)
                {
                    medlemstyp = 3;
                }
                else if (rbt_ledare.Checked)
                {
                    medlemstyp = 4;
                }
                else if (rbt_uppdrag.Checked)
                {
                    medlemstyp = 5;
                }
                else if (rbt_ledareansvarig.Checked)
                {
                    medlemstyp = 6;
                }
                else if (rbt_styrelse.Checked)
                {
                    medlemstyp = 7;
                }
                else
                {
                    MessageBox.Show("Välj en medlemstyp!");
                }
            return medlemstyp;
            }



        private void btn_läggTillPers_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                personlista = new List<Person>();
                listboxPersoner.DataSource = null;

                string fnamn, enamn, postAdress, email, kon, postNr, teleNr, kontaktperson, kontaktpersonNr;
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
                kontaktperson = tbx_kontaktperson.Text;
                kontaktpersonNr = tbx_kontakpersonnr.Text;

                pg.LäggTillPerson(personNr, fnamn, enamn, postNr, postAdress, email, teleNr, kon, fotoOk, kontaktperson, kontaktpersonNr, MedlemsTyp());

                personlista = pg.HämtaPerson();

                listboxPersoner.DataSource = personlista;
                listboxPersoner.DisplayMember = "FullständigaPersonUpp";
            }
            catch
            {
                MessageBox.Show("Tomma fält?");
               
            }
            

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
            string fnamn, enamn, postAdress, email, kon, postNr, teleNr,kontaktNamn,kontaktTele;
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
            kontaktNamn = tbx_kontaktperson.Text;
            kontaktTele = tbx_kontakpersonnr.Text;
           
            personNr = int.Parse(tbx_personNr.Text);
            fotoOk = cBoxJa.Checked;

            pg.UppdateraPerson(fnamn, enamn, postNr, postAdress, email, teleNr, fotoOk, personNr,kontaktNamn,kontaktTele,MedlemsTyp());

            personlista = pg.HämtaPerson();

            listboxPersoner.DataSource = personlista;
            listboxPersoner.DisplayMember = "FullständigaPersonUpp";

        }

        private void btn_träningstillfälle_Click(object sender, EventArgs e)
        {
           
            listboxPersoner.DataSource = null;
            träningstillfällen = new List<Träningstillfälle>();

            string plats, sammanfattning;
            int datum, starttid, sluttid, träningstillfälleid,träningsgrupp;
          
            plats = tbx_plats.Text;
            sammanfattning = tbx_sammanfattning.Text;
            datum = int.Parse(tbx_datum.Text);
            starttid = int.Parse(tbx_starttid.Text);
            sluttid = int.Parse(tbx_sluttid.Text);
            träningsgrupp = int.Parse(tbx_träningsgruppsid.Text);
            träningstillfälleid = int.Parse(tbx_träningstillfälle.Text);
           

            pg.LäggTillTräningstillfälle(träningstillfälleid,datum,plats,starttid,sluttid,sammanfattning,träningsgrupp);
            
            träningstillfällen = pg.HämtaTräningsTillfälle();

            listboxPersoner.DataSource = träningstillfällen;
            listboxPersoner.DisplayMember = "TräningstillfällesInfo";

        }

        private void btn_närvaro_Click(object sender, EventArgs e)
        {
            
            listboxPersoner.DataSource = null;
            närvarolista = new List<Närvaro>();

            int personnummer, träningstillfällesId;
            personnummer = int.Parse(tbx_närvaroPers.Text);
            träningstillfällesId = int.Parse(tbx_närvaroId.Text);

            pg.LäggTillPersonerTillTräningstillfällen(träningstillfällesId, personnummer);

            listboxPersoner.DataSource = närvarolista;
            listboxPersoner.DisplayMember = "NärvaroInfo";

        }

        private void btn_hämtaNärvaro_Click(object sender, EventArgs e)
        {
            utskrift = new List<Träningstillfälle>();

            utskrift = pg.HämtaNärvaro();
            listboxPersoner.DataSource = utskrift;

            listboxPersoner.DisplayMember = "UtskriftsInfo";
            
        }
    }
}

