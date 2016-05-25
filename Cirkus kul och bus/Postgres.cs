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
        /// Hämtar från medlem
        /// </summary>
        /// <returns>Lista med medlemmar</returns>
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
    }
    
}
