﻿using Npgsql;
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
       
        public Postgres() //Skapar koppling mot databas
        {
            _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["cirkus"].ConnectionString);
            _conn.Open();             
        }

        private void sqlNonQuery(string fråga) // Ger möjlighet att ställa frågor mot databas
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

        private NpgsqlDataReader sqlFråga(string fråga) // Skickar in fråga och retunerar från databas
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

        public List<Person> HämtaPerson() // Hämtar personer från persontabellen
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

        public List<Träningstillfälle> HämtaTräningsTillfälle() // Hämtar träningstillfällen
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

        public List<Träningsgrupp> HämtaTräningsgrupp() // Hämtar träningsgrupper
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

        public List<Träningstillfälle> HämtaNärvaro() // Hämtar närvarolista
        {
            Träningstillfälle närvarande;
            string fråga = "select n.träningtillfälles_id as \"Träningstillfälle\", count(p.person_nr) as \"antal\" from närvaro n inner join träningstillfälle tt on tt.träningstillfälles_id = n.träningtillfälles_id inner join person p on p.person_nr = n.person_nr  group by n.träningtillfälles_id;";
            _dr = sqlFråga(fråga);
            List<Träningstillfälle> närvarolista = new List<Träningstillfälle>();

            while (_dr.Read())
            {
                närvarande = new Träningstillfälle()
                {
                    Id = (int)_dr["Träningstillfälle"],
                    Antal_närvarande = (Int64)_dr["antal"]
                                                    

                };
                närvarolista.Add(närvarande);
            }
            return närvarolista;
        }

        public List<Träningstillfälle> HämtaNärvaroDatum(int startdatum, int slutdatum) // Filtrerar närvaro efter datum 
        {
            Träningstillfälle närvarande;
            string fråga = "select count(tt.träningstillfälles_id) \"antal\", tt.träningsgrupps_id as \"id\" from träningstillfälle tt inner join närvaro n on n.träningtillfälles_id = tt.träningstillfälles_id where tt.datum between " + startdatum + " and " + slutdatum + "group by träningsgrupps_id";
            _dr = sqlFråga(fråga);
            List<Träningstillfälle> närvarolista = new List<Träningstillfälle>();

            while (_dr.Read())
            {
                närvarande = new Träningstillfälle()
                {
                    Antal_närvarande = (Int64)_dr["antal"],
                    Träningsgrupps_id = (int)_dr["id"]
                    
               

                };
                närvarolista.Add(närvarande);
            }
            return närvarolista;
        }

        public List<Träningstillfälle> HämtaNärvaroTräningsgrupp(string id) // Hämtar närvaro för en specifik träningsgrupp
        {
            Träningstillfälle närvarande;
            string fråga = "select count(tt.träningstillfälles_id) \"antal\", tt.träningsgrupps_id as \"id\" from träningstillfälle tt inner join närvaro n on n.träningtillfälles_id = tt.träningstillfälles_id where tt.träningsgrupps_id in (" + id + ") group by träningsgrupps_id";
             
            _dr = sqlFråga(fråga);
            List<Träningstillfälle> närvarolista = new List<Träningstillfälle>();

            while (_dr.Read())
            {
                närvarande = new Träningstillfälle()
                {
                    Antal_närvarande = (Int64)_dr["antal"],
                    Träningsgrupps_id = (int)_dr["id"],
                    

                };
                närvarolista.Add(närvarande);
            }
            return närvarolista;
        }

        public List<Träningstillfälle> HämtaTräningsgruppLedare(string id) // Hämtar närvaro för specifik ledare 
        {
            Träningstillfälle närvarande;
            string fråga = "select n.träningtillfälles_id as \"Träningstillfälle\", p.person_nr as \"Personnummer\", p.förnamn as \"Fornamn\", p.efternamn as \"Efternamn\", tt.datum as \"Datum\", tt.starttid as \"Starttid\", tt.sluttid as \"Sluttid\", tt.sammanfattning as \"Sammanfattning\" from närvaro n inner join träningstillfälle tt on tt.träningstillfälles_id = n.träningtillfälles_id inner join person p on p.person_nr = n.person_nr inner join leder l ON l.träningsgrupps_id = tt.träningsgrupps_id WHERE l.person_nr IN(" + id + ")";
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

        public List<Träningstillfälle> HämtaAktuellLedareFörTräningstillfälle() // Hämtar vilken/vilka ledare som lett specifikt träningstillfälle
        {
            Träningstillfälle lett;
            string fråga = "select p.förnamn as \"Förnamn\", p.efternamn as \"Efternamn\", tt.träningstillfälles_id as \"Träningstillfälle\" from träningstillfälle tt inner join leder l on l.träningsgrupps_id = tt.träningsgrupps_id inner join person p on p.person_nr = l.person_nr";
            _dr = sqlFråga(fråga);
            List<Träningstillfälle> ledare = new List<Träningstillfälle>();

            while (_dr.Read())
            {
                lett = new Träningstillfälle()
                {
                   Fornamn = _dr["Förnamn"].ToString(),
                    Efternamn = _dr["Efternamn"].ToString(),
                    Id= (int)_dr["Träningstillfälle"],                   
                };
                ledare.Add(lett);
            }
            return ledare;
        }

        public void LäggTillPersonerTillTräningstillfällen(int T, int personnummer) // Lägger till medlemmar till träningstillfälle
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

        public void LäggTillTräningstillfälle(int t, int datum, string plats, int starttid, int sluttid, string sammanfattning, int träningsgrupp) // Skapar träningstillfällen
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

        public void LäggTillPerson(int personnummer, string fornamn, string efternamn, string postnummer, string adress, string email, string telefonnummer, string kon, bool foto, string kontaktpersonNamn, string kontaktTele, int medlemstyp) // Skapar medlem
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
        } // Tar bort medlemmar

        public void UppdateraPerson (string fornamn, string efternamn, string postnummer, string adress, string email, string telefonnummer, bool foto, int personnummer, string kontaktpersonNamn, string kontaktTele, int medlemstyp) // Ändrar personuppgifter
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
    

