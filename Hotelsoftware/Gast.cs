using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelsoftware
{
    public class Gast
    {   // Attribute nach der Definition der Datenbank
        public long g_id { get; }
        public string g_vorname { get; }
        public string g_nachname { get; }
        public DateTime g_geburtsdatum { get; }
        public string g_strasse { get; }
        public string g_hausnummer { get; } 
        public string g_postleitzahl { get; }
        public string g_stadt { get; }
        public string g_land { get; }
        public long? f_id { get; set; }
        public string f_bezeichnung { get; set; }

        // Konstruktor
        public Gast (long g_id, string g_vorname, string g_nachname, DateTime g_geburtsdatum, string g_strasse, string g_hausnummer, string g_postleitzahl, string g_stadt, string g_land, long? f_id, string f_bezeichnung)
        {
            this.g_id = g_id;
            this.g_vorname = g_vorname;
            this.g_nachname = g_nachname;
            this.g_geburtsdatum = g_geburtsdatum;
            this.g_strasse = g_strasse;
            this.g_hausnummer = g_hausnummer;
            this.g_postleitzahl = g_postleitzahl;
            this.g_stadt = g_stadt;
            this.g_land = g_land;
            this.f_id = f_id;
            this.f_bezeichnung = f_bezeichnung;
        }

        // Anzeigemethode
        public override string ToString()
        {
            return g_nachname + ", " + g_vorname + " (" + g_stadt + ", "+ g_land + ") geb. " + g_geburtsdatum.ToShortDateString();
        }
    }
}
