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
        private string Fotostring { get; set; }

        public string Kontaktperson { get; set; }
        public string KontaktpersonTelenr { get; set; }
        public int Medlemstyp { get; set; }

        public string FullständigaPersonUpp
        {
            get 
            {
                if (Foto == true)
                {
                    Fotostring = "JA";
                    return "Förnamn: "+ Fornamn + "\t" + "Efternamn:  "+ Efternamn + "\t" + "PersonNr: " + PersonNr.ToString() + "\t" + "PostNr: " + PostNr + "\t" + "Adress: "+ Adress + "\n" +"Email "+ Email + "\t"+"TelefonNr: " + TelefonNr + "\t"+"Kön: " + Kon + "\t"+"Foto? " + Fotostring + "\t"+"Kontaktperson " + Kontaktperson + "\t"+"KontaktpersonteleNr " +KontaktpersonTelenr + "\t"+"Medlemstyp: " +Medlemstyp + "\n\n";
                }

                else
                {
                    Fotostring = "NEJ";
                    return "Förnamn: " + Fornamn + "\t" + "Efternamn:  " + Efternamn + "\t" + "PersonNr: " + PersonNr.ToString() + "\t" + "PostNr: " + PostNr + "\t" + "Adress: " + Adress + "\n" + "Email " + Email + "\t" + "TelefonNr: " + TelefonNr + "\t" + "Kön: " + Kon + "\t" + "Foto? " + Fotostring + "\t" + "Kontaktperson " + Kontaktperson + "\t" + "KontaktpersonteleNr " + KontaktpersonTelenr + "\t" + "Medlemstyp: " + Medlemstyp + "\n\n";

                }
            }
        }

    }
}
