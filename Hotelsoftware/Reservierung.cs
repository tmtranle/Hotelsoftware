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
        public DateTime checkIn { get; }
        public DateTime checkOut { get; }
        public long g_id { get; }
        public long z_id { get; }

        // Konstruktor
        Reservierung(long r_id, DateTime checkIn, DateTime checkOut, long g_id, long z_id)
        {
            this.r_id = r_id;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.g_id = g_id;
            this.z_id = z_id;
        }

        // Anzeigemethode
        public override string ToString()
        {
            return "# " + z_id + " "+ g_id  + " " + checkIn + " " + checkOut;
        }
    }
}
