using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus_kul_och_bus
{
   public class Träningsgrupp
    {
        public int Id { get; set; }
        public string Namn { get; set; }

        public string TräningsgruppsInfo
        {
            get
            {
                return "Träningsgrupp: "+ Id + "\t"+"Namn: " + Namn;
            }
        }
    }
  
}
