using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus_kul_och_bus
{
    class Medlem : Person
    {
        public int MedlemsNr { get; set; }
        public string Kontaktperson { get; set; }
        public string KontaktpersonTelenr { get; set; }
        public int Medlemstyp { get; set; }

     
    }
}
