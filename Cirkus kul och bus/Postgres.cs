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
        private DataTable _tabell;


        public Postgres() 
        {
            _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["cirkus"].ConnectionString);
            _conn.Open();
            _tabell = new DataTable();
        
        }
        private DataTable sqlFråga(string medlem) 
        {
        
          try
            {
                _cmd = new NpgsqlCommand(medlem, _conn);
                _dr = _cmd.ExecuteReader();
                _tabell.Load(_dr);
                return _tabell;
            }
          catch (NpgsqlException ex)
          {
          System.Windows.Forms.MessageBox.Show(ex.Message);



          return _tabell;
          }
          finally
          {
              _conn.Close();

          }
        
        }

        /// <summary>
        /// Hämtar från medlem
        /// </summary>
        /// <returns>Lista med medlemmar</returns>
        /// 

 

        public List<Person> HämtaPerson() 
        {


        List<Person> personer = new List<Person>(); 
            


               {
       
                       string medlem = "select person_nr as\"person.person_nr\",förnamn as\"person.förnamn\",efternamn as\"person.efternamn\" from person";
                      _tabell = sqlFråga(medlem);
                      Person nyperson = new Person();
                   personer.Add(nyperson);
               }

               return personer;
               
        }
    }
    
}
