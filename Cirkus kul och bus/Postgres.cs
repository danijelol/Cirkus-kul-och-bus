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
          finally
          {
             // _conn.Close();

          }
        
        }

        /// <summary>
        /// Hämtar från person
        /// </summary>
        /// <returns>Lista med personer</returns>
        /// 
        public List<Person> HämtaPerson() 
        {
                     
         string fråga = "select förnamn as\"förnamn\", efternamn as \"efternamn\", person_nr as \"personnummer\"  from person";

         _dr = sqlFråga(fråga);

         Person nyperson;

         List<Person> personlista = new List<Person>();       

         while (_dr.Read())
         {
             nyperson = new Person()
             {
                 Fornamn = _dr["förnamn"].ToString(),
                 Efternamn = _dr["efternamn"].ToString(),
                 PersonNr = (int)_dr["personnummer"]
             };
             personlista.Add(nyperson);
         }

         return personlista;                                       
        }

       public void LäggTillPerson(int personnummer, string fornamn, string efternamn, string postnummer, string adress, string email, string telefonnummer, string kon, bool foto)
        {
            string fråga;
            sqlNonQuery("begin");
            fråga = "insert into person values(" + personnummer + "," + fornamn + "," + efternamn + ","  + postnummer + ","  + adress + ","  + email + ","  + telefonnummer + ","  + kon + ",)";
            sqlNonQuery(fråga);
            fråga = "select förnamn as\"förnamn\", efternamn as \"efternamn\", person_nr as \"personnummer\"  from person";
            _dr = sqlFråga(fråga);
            sqlNonQuery("commit");
            _conn.Close();
            
        }
    }
    
}
