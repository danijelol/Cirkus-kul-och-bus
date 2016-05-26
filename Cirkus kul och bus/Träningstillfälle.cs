using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus_kul_och_bus
{
    public class Träningstillfälle : Person
    {
        public int Id { get; set; }
        public int Datum { get; set; }
        public string Plats { get; set; }
        public int StartTid { get; set; }
        public int SlutTid { get; set; }
        public string Sammanfattning { get; set; }
        public int Träningsgrupps_id { get; set; }

         public string TräningstillfällesInfo
        {
            get
            {
                return Id + "\t" + Datum + "\t" + Plats + "\t" + StartTid + "\t" + SlutTid + "\t" + Sammanfattning + "\t" + Träningsgrupps_id;
            }
        }

  
    }
}
