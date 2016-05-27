using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace Cirkus_kul_och_bus
{
   public class Postgres
    {
        private NpgsqlConnection _conn;
        private NpgsqlCommand _cmd;
        private NpgsqlDataReader _dr;
        
        public Postgres() 
        {
            _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["cirkus"].ConnectionString);
            _conn.Open();
                 
        }

       private void sqlNonQuery(string fråga)
        {
           try
           {
               _cmd = new NpgsqlCommand(fråga, _conn);
               _cmd.ExecuteNonQuery();
           }

           catch(NpgsqlException ex)
           {
               System.Windows.Forms.MessageBox.Show(ex.Message);
           }
        }

       private NpgsqlDataReader sqlFråga(string fråga)
       {
           try
           {
               _cmd = new NpgsqlCommand(fråga, _conn);
               _dr = _cmd.ExecuteReader();

               return _dr;
           }

           catch (NpgsqlException ex)
           {
               System.Windows.Forms.MessageBox.Show(ex.Message);

               return null;
           }
       }

        public List<Person> HämtaPerson() 
        {
             
            Person nyperson;
            string fråga = "select förnamn as\"förnamn\", efternamn as \"efternamn\", person_nr as \"personnummer\", adress as \"adress\", post_nr as \"postnummer\", telenr as \"telefonnummer\", kön as \"kön\", foto_ok as \"foto_ok\", email as \"email\", kontaktperson_namn as \"Kontaktperson\", kontaktperson_tele as \"Telefonnummer kontaktperson\", medlemstyp as \"Typ av medlem\" from person";
            _dr = sqlFråga(fråga);
            List<Person> personlista = new List<Person>();
            
            while (_dr.Read())
            {
                nyperson = new Person()
             {
                 Fornamn = _dr["förnamn"].ToString(),
                 Efternamn = _dr["efternamn"].ToString(),
                 PersonNr = (int)_dr["personnummer"],
                 Adress = _dr["adress"].ToString(),
                 PostNr = _dr["postnummer"].ToString(),
                 TelefonNr =  _dr["telefonnummer"].ToString(),
                 Kon = _dr["kön"].ToString(),
                 Foto = Convert.ToBoolean(_dr["foto_ok"]),
                 Email = _dr["email"].ToString(),
                 Kontaktperson = _dr["Kontaktperson"].ToString(),
                 KontaktpersonTelenr = _dr["Telefonnummer kontaktperson"].ToString(),
                 Medlemstyp = (int)_dr["Typ av medlem"]
                 
                 
             };
             personlista.Add(nyperson);
            }
            return personlista;
        }

        public List<Träningstillfälle> HämtaTräningsTillfälle()
        {
           Träningstillfälle nyttTräningstillfälle;
           string fråga = "select träningstillfälles_id as\"Träningstillfälle\", datum as \"Datum\", plats as \"Plats\", starttid as \"Starttid\", sluttid as \"Sluttid\", sammanfattning as \"Sammanfattning\", träningsgrupps_id as \"Träningsgrupp\" from träningstillfälle";
            _dr = sqlFråga(fråga);
            List<Träningstillfälle> träningstillfällen = new List<Träningstillfälle>();

            while (_dr.Read())
            {
                nyttTräningstillfälle = new Träningstillfälle()
                {
                    Id = (int)_dr["Träningstillfälle"],
                    Datum = (int)_dr["Datum"],
                    Plats = _dr["Plats"].ToString(),
                    StartTid = (int)_dr["Starttid"],
                    SlutTid = (int)_dr["Sluttid"],
                    Sammanfattning = _dr["Sammanfattning"].ToString(),
                    Träningsgrupps_id = (int)_dr["Träningsgrupp"],
                };
                träningstillfällen.Add(nyttTräningstillfälle);
            }
            return träningstillfällen;
        
        }

        public List<Träningsgrupp> HämtaTräningsgrupp()
        {
            Träningsgrupp nyträningsgrupp;
            string fråga = "select träningsgrupps_id as\"Träningsgrupp\", namn as \"Namn\" from träningsgrupp";
            _dr = sqlFråga(fråga);
            List<Träningsgrupp> träningsgrupp = new List<Träningsgrupp>();

            while (_dr.Read())
            {
                nyträningsgrupp = new Träningsgrupp()
                {
                    Id = (int)_dr["Träningsgrupp"],
                    Namn= _dr["Namn"].ToString(),
                
                };
                träningsgrupp.Add(nyträningsgrupp);
            }
            return träningsgrupp;
        }


        public List<Träningstillfälle> HämtaNärvaro()
        {
            Träningstillfälle närvarande;
            string fråga = "select n.träningtillfälles_id as \"Träningstillfälle\", p.person_nr as \"Personnummer\", p.förnamn as \"Fornamn\", p.efternamn as \"Efternamn\", tt.datum as \"Datum\", tt.starttid as \"Starttid\", tt.sluttid as \"Sluttid\", tt.sammanfattning as \"Sammanfattning\" from närvaro n inner join träningstillfälle tt on tt.träningstillfälles_id = n.träningtillfälles_id inner join person p on p.person_nr = n.person_nr";
            _dr = sqlFråga(fråga);
            List<Träningstillfälle> närvarolista = new List<Träningstillfälle>();

            while (_dr.Read())
            {
                närvarande = new Träningstillfälle()
                {
                    Id = (int)_dr["Träningstillfälle"],
                    PersonNr = (int)_dr["Personnummer"],
                    Fornamn = _dr["Fornamn"].ToString(),
                    Efternamn = _dr["Efternamn"].ToString(),
                    Datum = (int)_dr["Datum"],
                    StartTid = (int)_dr["Starttid"],
                    SlutTid = (int)_dr["Sluttid"],
                    Sammanfattning = _dr["Sammanfattning"].ToString(),
                    
                    

                };
                närvarolista.Add(närvarande);
            }
            return närvarolista;
        }


        public void LäggTillPersonerTillTräningstillfällen(int T, int personnummer)
        {
            _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["cirkus"].ConnectionString);
            {
                _conn.Open();
                sqlNonQuery("begin");

                _cmd = new NpgsqlCommand("insert into närvaro (träningtillfälles_id, person_nr) values(@T,@personnummer)", _conn);

                _cmd.Parameters.AddWithValue("@T", T);
                _cmd.Parameters.AddWithValue("@personnummer", personnummer);
               
                _cmd.ExecuteNonQuery();
                sqlNonQuery("commit");

            }
        }



        public void LäggTillTräningstillfälle(int t, int datum, string plats, int starttid, int sluttid, string sammanfattning, int träningsgrupp)
        {

            _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["cirkus"].ConnectionString);
            {
                _conn.Open();
                sqlNonQuery("begin");
               
                _cmd = new NpgsqlCommand("insert into träningstillfälle (träningstillfälles_id, datum, plats, starttid, sluttid, sammanfattning, träningsgrupps_id) values(@Traningstillfalles,@Datum, @Plats, @Starttid, @Sluttid, @Sammanfattning,@Traningsgrupp)", _conn);

                _cmd.Parameters.AddWithValue("@Traningstillfalles", t);
                _cmd.Parameters.AddWithValue("@Datum", datum);
                _cmd.Parameters.AddWithValue("@Plats", plats);
                _cmd.Parameters.AddWithValue("@Starttid", starttid);
                _cmd.Parameters.AddWithValue("@Sluttid", sluttid);
                _cmd.Parameters.AddWithValue("@Sammanfattning", sammanfattning);
                _cmd.Parameters.AddWithValue("@Traningsgrupp", träningsgrupp);

                _cmd.ExecuteNonQuery();
                sqlNonQuery("commit");
             
            }
        }

       public void LäggTillPerson(int personnummer, string fornamn, string efternamn, string postnummer, string adress, string email, string telefonnummer, string kon, bool foto, string kontaktpersonNamn, string kontaktTele, int medlemstyp)
        {
            _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["cirkus"].ConnectionString);
            {
                _conn.Open();
                sqlNonQuery("begin");           
                
                _cmd = new NpgsqlCommand("insert into person (person_nr, förnamn, efternamn, post_nr, adress, email, telenr, kön, foto_ok, kontaktperson_namn, kontaktperson_tele, medlemstyp) values(@person_nr, @fornamn, @efternamn, @postnummer, @adress, @email, @telefonnummer, @kon, @foto, @kontaktperson_namn, @kontaktperson_tele, @medlemstyp)", _conn);

                _cmd.Parameters.AddWithValue("@person_nr", personnummer);
                _cmd.Parameters.AddWithValue("@fornamn", fornamn);
                _cmd.Parameters.AddWithValue("@efternamn", efternamn);
                _cmd.Parameters.AddWithValue("@postnummer", postnummer);
                _cmd.Parameters.AddWithValue("@adress", adress);
                _cmd.Parameters.AddWithValue("@email", email);
                _cmd.Parameters.AddWithValue("@telefonnummer", telefonnummer);
                _cmd.Parameters.AddWithValue("@kon", kon);
                _cmd.Parameters.AddWithValue("@foto", foto);
                _cmd.Parameters.AddWithValue("@kontaktperson_namn", kontaktpersonNamn);
                _cmd.Parameters.AddWithValue("@kontaktperson_tele", kontaktTele);
                _cmd.Parameters.AddWithValue("@medlemstyp", medlemstyp);
                
                _cmd.ExecuteNonQuery();
                sqlNonQuery("commit");
                //_conn.Close(); tar bort denna för att den ligger i metoden HämtaPerson()
            }
       } 

       public void TaBortPerson(int personnummer)
        {
            _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["cirkus"].ConnectionString);
            {
                _conn.Open();
                sqlNonQuery("begin"); 
           
                _cmd = new NpgsqlCommand("DELETE FROM person WHERE person_nr=@person_nr", _conn);
                _cmd.Parameters.AddWithValue("@person_nr", personnummer);
                
                _cmd.ExecuteNonQuery();
                sqlNonQuery("commit");
            }
        }

       public void UppdateraPerson (string fornamn, string efternamn, string postnummer, string adress, string email, string telefonnummer, bool foto, int personnummer, string kontaktpersonNamn, string kontaktTele, int medlemstyp)
       {
           _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["cirkus"].ConnectionString);
           {
               _conn.Open();
               sqlNonQuery("begin");

               _cmd = new NpgsqlCommand("update person set förnamn = @fornamn, efternamn = @efternamn, post_nr = @postnummer, adress = @adress, email = @email, telenr = @telefonnummer, foto_ok = @foto, kontaktperson_namn = @kontaktperson_namn, kontaktperson_tele = @kontaktperson_tele, medlemstyp= @medlemstyp WHERE person_nr = @personnummer", _conn);

               _cmd.Parameters.AddWithValue("@personnummer", personnummer);
               _cmd.Parameters.AddWithValue("@fornamn", fornamn);
               _cmd.Parameters.AddWithValue("@efternamn", efternamn);
               _cmd.Parameters.AddWithValue("@postnummer", postnummer);
               _cmd.Parameters.AddWithValue("@adress", adress);
               _cmd.Parameters.AddWithValue("@email", email);
               _cmd.Parameters.AddWithValue("@telefonnummer", telefonnummer);
               _cmd.Parameters.AddWithValue("@foto", foto);
               _cmd.Parameters.AddWithValue("@kontaktperson_namn", kontaktpersonNamn);
               _cmd.Parameters.AddWithValue("@kontaktperson_tele", kontaktTele);
               _cmd.Parameters.AddWithValue("@medlemstyp", medlemstyp);
                
               _cmd.ExecuteNonQuery();
               sqlNonQuery("commit");
           }
       }
   } 
  

}
    

