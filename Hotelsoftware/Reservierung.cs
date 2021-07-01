using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelsoftware
{
    public class Reservierung
    {
        // Attribute nach der Definition der Datenbank
        public long r_id { get; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
        public long g_id { get; set; }
        public long z_id { get; set; }
        public string r_status { get; set; }
        public string g_nachname { get; set; }
        public string g_vorname { get; set; }


        // Konstruktor
        public Reservierung(long r_id, DateTime checkIn, DateTime checkOut, long g_id, long z_id, string r_status, string g_nachname, string g_vorname)
        {
            this.r_id = r_id;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.g_id = g_id;
            this.z_id = z_id;
            this.r_status = r_status;
            this.g_nachname = g_nachname;
            this.g_vorname = g_vorname;
        }

        // Anzeigemethode
        public override string ToString()
        {
            return "# " + z_id + " "+ g_nachname + " " + checkIn + " " + checkOut;
        }
    }
}
