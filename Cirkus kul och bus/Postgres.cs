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
        /// <summary>
        /// Hämtar från medlem
        /// </summary>
        /// <returns>Lista med medlemmar</returns>
        public List<Medlem> HämtaMedlem() 
        {
        
        
        }
    }
    
}
