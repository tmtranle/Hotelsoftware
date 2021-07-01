using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotelsoftware
{
    public partial class Belegungsplan : Form
    {
        List<Reservierung> alleReservierungen = new List<Reservierung>();

        public void ReservierungenHinzufuegen(Reservierung reservierung)
        {
            // Liste befüllen
            alleReservierungen.Add(reservierung);
            // Model füllen
            int index = dataGridViewReservierungen.Rows.Add();
            dataGridViewReservierungen.Rows[index].Cells[0].Value = reservierung.r_id;
            dataGridViewReservierungen.Rows[index].Cells[1].Value = reservierung.z_id;
            dataGridViewReservierungen.Rows[index].Cells[2].Value = reservierung.g_nachname;
            dataGridViewReservierungen.Rows[index].Cells[3].Value = reservierung.g_vorname;
            dataGridViewReservierungen.Rows[index].Cells[4].Value = reservierung.checkIn.ToShortDateString();
            dataGridViewReservierungen.Rows[index].Cells[5].Value = reservierung.checkOut.ToShortDateString();
            dataGridViewReservierungen.Rows[index].Cells[6].Value = reservierung.r_status;
        }


        public Belegungsplan()
        {
            InitializeComponent();
            ReservierungenLaden();
        }

        public MySqlConnection conn = new MySqlConnection("Server=localhost;UID=root;PWD=;DATABASE=HotelsoftwareDB");
       
        private void ReservierungenLaden()
        {
            // HIER?
            DateTime eingestelltesDatum = dateTimePickerBelegunsplan.Value;

            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT r.r_id, r.checkIn, r.checkOut, g.g_id, z.z_id, r.r_status, g.g_nachname, g.g_vorname " +
                                    " FROM reservierung r INNER JOIN gast g ON r.g_id = g.g_id INNER JOIN zimmer z " +
                                    " ON r.z_id = z.z_id " +  /* eingestelltesDatum +
                                    " WHERE checkIn = " + */
                                    " ORDER BY z_id ";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long r_id = reader.GetInt64(0);
                DateTime checkIn = reader.GetDateTime(1);
                DateTime checkOut = reader.GetDateTime(2);
                long g_id = reader.GetInt64(3);
                long z_id = reader.GetInt64(4);
                string r_status = reader.GetString(5);
                string g_nachname = reader.GetString(6);
                string g_vorname = reader.GetString(7);
                ReservierungenHinzufuegen(new Reservierung(r_id, checkIn, checkOut, g_id, z_id, r_status, g_nachname, g_vorname));
            }
            reader.Close();
            conn.Close();
        }

        private void RefreshView()
        {
            // Liste leeren
            alleReservierungen.Clear();
            // Model leeren
            dataGridViewReservierungen.Rows.Clear();
        }

        private void RbAlle_CheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
            ReservierungenLaden();
        }
        private void RbGarantiert_CheckedChanged(object sender, EventArgs e)
        {
            FilterAnwenden();
        }
        private void RbNoShow_CheckedChanged(object sender, EventArgs e)
        {
            FilterAnwenden();
        }
        private void RbOption_CheckedChanged(object sender, EventArgs e)
        {
            FilterAnwenden();
        }
        private void RbStorniert_CheckedChanged(object sender, EventArgs e)
        {
            FilterAnwenden();
        }

        private void FilterAnwenden()
        { 
            // TODO welches Dateum ist ausgewählt
            // welcher RadioButton = true
            // aus diesen info WHERE ...datum AND ...checkbox
            RefreshView();

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT r.r_id, r.checkIn, r.checkOut, g.g_id, z.z_id, r.r_status, g.g_nachname, g.g_vorname " +
                                    " FROM reservierung r INNER JOIN gast g ON r.g_id = g.g_id INNER JOIN zimmer z " +
                                    " ON r.z_id = z.z_id WHERE r_status = 'storniert' ORDER BY z_id ";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long r_id = reader.GetInt64(0);
                DateTime checkIn = reader.GetDateTime(1);
                DateTime checkOut = reader.GetDateTime(2);
                long g_id = reader.GetInt64(3);
                long z_id = reader.GetInt64(4);
                string r_status = reader.GetString(5);
                string g_nachname = reader.GetString(6);
                string g_vorname = reader.GetString(7);
                ReservierungenHinzufuegen(new Reservierung(r_id, checkIn, checkOut, g_id, z_id, r_status, g_nachname, g_vorname));
            }
            reader.Close();

            conn.Close();
        }

        private void dateTimePickerBelegunsplan_ValueChanged(object sender, EventArgs e)
        {
            // TODO die Reservierungen sollen nach dem ausgewählten Tag gefiltert werden
            FilterAnwenden();
        }
    }
}
