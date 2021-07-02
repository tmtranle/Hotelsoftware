using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelsoftware
{
    public class Zimmer
    {
        // Attribute nach der Definition der Datenbank
        public long z_id { get; }
        public string z_kategorie { get; }
        public string z_status { get; set; }

        // Konstruktor
        public Zimmer(long z_id, string z_kategorie, string z_status)
        {
            this.z_id = z_id;
            this.z_kategorie = z_kategorie;
            this.z_status = z_status;
        }

        // Anzeigemethode
        public override string ToString()
        {
            return z_id + "(" + z_kategorie + ") " + z_status ;
        }
    }
}
