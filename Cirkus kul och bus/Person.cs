using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus_kul_och_bus
{
    public class Person
    {
        public int PersonNr { get; set; }           //person_nr
        public string Fornamn { get; set; }         //förnamn
        public string Efternamn { get; set; }       //efternamn
        public string PostNr { get; set; }          //post_nr
        public string Adress { get; set; }          //adress
        public string Email { get; set; }           //email
        public string TelefonNr { get; set; }       //telenr
        public string Kon { get; set; }             //kön
        public bool Foto { get; set; }              //foto_ok

      
        public string FullständigtNamn 
        {
            get 
            {
                return Fornamn + "\t" + Efternamn + "\t" + PersonNr.ToString() + "\t" + PostNr + "\t" + Adress + "\t" + Email + "\t" + TelefonNr + "\t" + Kon;
            }
        }

    }
}
