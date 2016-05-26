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
            string fråga = "select förnamn as\"förnamn\", efternamn as \"efternamn\", person_nr as \"personnummer\", adress as \"adress\", post_nr as \"postnummer\", telenr as \"telefonnummer\", kön as \"kön\", email as \"email\" from person";
            _dr = sqlFråga(fråga);
            Person nyperson;
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
                 Email = _dr["email"].ToString(),
                 //Foto = _dr["foto"]

             };

             personlista.Add(nyperson);
         }
            return personlista;
        }
        


       public void LäggTillPerson(int personnummer, string fornamn, string efternamn, string postnummer, string adress, string email, string telefonnummer, string kon, bool foto)
        {
            _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["cirkus"].ConnectionString);
            {
                _conn.Open();
                sqlNonQuery("begin");           
                
                _cmd = new NpgsqlCommand("insert into person (person_nr, förnamn, efternamn, post_nr, adress, email, telenr, kön, foto_ok) values(@person_nr, @fornamn, @efternamn, @postnummer, @adress, @email, @telefonnummer, @kon, @foto)", _conn);

                _cmd.Parameters.AddWithValue("@person_nr", personnummer);
                _cmd.Parameters.AddWithValue("@fornamn", fornamn);
                _cmd.Parameters.AddWithValue("@efternamn", efternamn);
                _cmd.Parameters.AddWithValue("@postnummer", postnummer);
                _cmd.Parameters.AddWithValue("@adress", adress);
                _cmd.Parameters.AddWithValue("@email", email);
                _cmd.Parameters.AddWithValue("@telefonnummer", telefonnummer);
                _cmd.Parameters.AddWithValue("@kon", kon);
                _cmd.Parameters.AddWithValue("@foto", foto);
                
                _cmd.ExecuteNonQuery();
                sqlNonQuery("commit");
                _conn.Close();
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
                _conn.Close();
            }
        }

       public void UppdateraPerson (string fornamn, string efternamn, string postnummer, string adress, string email, string telefonnummer, bool foto, int personnummer)
       {
           _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["cirkus"].ConnectionString);
           {
               _conn.Open();
               sqlNonQuery("begin");

               _cmd = new NpgsqlCommand("update person set förnamn = @fornamn, efternamn = @efternamn, post_nr = @postnummer, adress = @adress, email = @email, telenr = @telefonnummer, foto_ok = @foto WHERE person_nr = @personnummer", _conn);

               _cmd.Parameters.AddWithValue("@personnummer", personnummer);
               _cmd.Parameters.AddWithValue("@fornamn", fornamn);
               _cmd.Parameters.AddWithValue("@efternamn", efternamn);
               _cmd.Parameters.AddWithValue("@postnummer", postnummer);
               _cmd.Parameters.AddWithValue("@adress", adress);
               _cmd.Parameters.AddWithValue("@email", email);
               _cmd.Parameters.AddWithValue("@telefonnummer", telefonnummer);
               _cmd.Parameters.AddWithValue("@foto", foto);

               _cmd.ExecuteNonQuery();
               sqlNonQuery("commit");
               _conn.Close();
           }
       }
   }
}
    

