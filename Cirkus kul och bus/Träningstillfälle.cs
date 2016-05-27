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
                return "Träningstillfälle: "+ Id + "\t"+"Datum: " + Datum + "\t"+ "Plats: " + Plats + "\t"+"Starttid: " + StartTid + "\t"+"Sluttid: " + SlutTid + "\t" + "Sammanfattning: "+ Sammanfattning + "\t"+"Träningsgrupp: " + Träningsgrupps_id;
            }
        }

        public string UtskriftsInfo
         {
            get
             {
                 return "Träningstillfälle: " + Id + "\t" + "Datum: " + Datum + "\t" + "Starttid: " + StartTid + "\t" +"Sluttid: " +SlutTid + "\t" +"Sammanfattning: "+ Sammanfattning + "\t"+"PersonNr: " + PersonNr + "\t"+"Förnamn: " + Fornamn + "\t"+ "Efternamn: " + Efternamn;
             }
         }

        public string LedareInfo
        {
            get
            {
                return "Förnamn: "+Fornamn + "\t"+"Efternamn: " + Efternamn + "\t"+"Träningstillfälle " + Id;
            }
        }

  
    }
}
