using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus_kul_och_bus
{
   public class Närvaro:Träningstillfälle
    {
        public int PersonNummer { get; set; }
        public int Träningstillfälle_id { get; set; }

        public string NärvaroInfo
        {
            get
            {
                return PersonNummer + "\t" + Träningstillfälle_id;
            }
        }
    }
}
