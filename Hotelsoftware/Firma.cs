using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelsoftware
{
    public class Firma
    {
        // Attribute nach der Definition der Datenbank
        public long f_id { get; set; }
        public string f_bezeichnung { get; set; }
        public string f_strasse { get; set; }
        public string f_hausnummer { get; set; }
        public string f_postleitzahl { get; set; }
        public string f_stadt { get; set; }
        public string f_land { get; set; }

        // Konstruktor
        public Firma (long f_id, string f_bezeichnung, string f_strasse, string f_hausnummer, string f_postleitzahl, string f_stadt, string f_land)
        {
            this.f_id = f_id;
            this.f_bezeichnung = f_bezeichnung;
            this.f_strasse = f_strasse;
            this.f_hausnummer = f_hausnummer;
            this.f_postleitzahl = f_postleitzahl;
            this.f_stadt = f_stadt;
            this.f_land = f_land;
        }

        // Anzeigemethode
        public override string ToString()
        {
            return f_bezeichnung;
        }
    }
}
