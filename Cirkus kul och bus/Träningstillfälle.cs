using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus_kul_och_bus
{
    class Träningstillfälle
    {
        public int Id { get; set; }
        public int Datum { get; set; }
        public string Plats { get; set; }
        public int StartTid { get; set; }
        public int SlutTid { get; set; }
        public string Sammanfattning { get; set; }
    }
}
