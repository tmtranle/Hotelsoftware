using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelsoftware
{
    class Leistungen
    {
        // Attribute nach der Definition der Datenbank
        public long l_id { get; }
        public string l_bezeichnung { get; }
        public double l_preis { get; }

        // Konstruktor
        public Leistungen(long l_id, string l_bezeichnung, double l_preis)
        {
            this.l_id = l_id;
            this.l_bezeichnung = l_bezeichnung;
            this.l_preis = l_preis;
        }

        // Anzeigemethode
        public override string ToString()
        {
            return l_bezeichnung + " " + l_preis;
        }
    }
}
