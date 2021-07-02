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
            // nach dem ausgewählten Datum filtern
            DateTime datum = dateTimePickerBelegunsplan.Value;
            // nach dem ausgewählten Status filtern 
            string filter;
            if (RbGarantiert.Checked == true)
            {
                filter = RbGarantiert.Text;
            }
            else if (RbNoShow.Checked == true)
            {
                filter = RbNoShow.Text;
            }
            else if (RbOption.Checked == true)
            {
                filter = RbOption.Text;
            }
            else
            {
                filter = RbStorniert.Text;
            }

            // Verbindung zum Datenbankserver aufbauen
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            if (RbAlle.Checked == true)
            {
                cmd.CommandText = "SELECT r_id, z_id, g.g_id, g_nachname, g_vorname, checkIn, checkOut, r_status " +
                                       " FROM reservierung " +
                                       " LEFT JOIN gast g on g.g_id = reservierung.g_id " +
                                       " WHERE checkIn = date(@checkIn) " +
                                       " ORDER BY z_id";
                cmd.Parameters.AddWithValue("checkIn", datum);
                
            }
            else
            {
                cmd.CommandText = "SELECT r_id, z_id, g.g_id, g_nachname, g_vorname, checkIn, checkOut, r_status " +
                                        " FROM reservierung " +
                                        " LEFT JOIN gast g on g.g_id = reservierung.g_id " +
                                        " WHERE r_status = @r_status " +
                                        " AND checkIn = date(@checkIn) " +
                                        " ORDER BY z_id";
                cmd.Parameters.AddWithValue("r_status", filter);
                cmd.Parameters.AddWithValue("checkIn", datum);
                
            }
            cmd.Prepare();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long r_id = reader.GetInt64(0);
                long z_id = reader.GetInt64(1);
                long g_id = reader.GetInt64(2);
                string g_nachname = reader.GetString(3);
                string g_vorname = reader.GetString(4);
                DateTime checkIn = reader.GetDateTime(5);
                DateTime checkOut = reader.GetDateTime(6);
                string r_status = reader.GetString(7);
                
                ReservierungenHinzufuegen(new Reservierung(r_id, z_id, g_id, g_nachname, g_vorname, checkIn, checkOut, r_status));
            }
            reader.Close();
            // Verbindung zum Datenbankserver trennen
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
            RefreshView();
            ReservierungenLaden();
        }

        private void RbNoShow_CheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
            ReservierungenLaden();
        }

        private void RbOption_CheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
            ReservierungenLaden();
        }

        private void RbStorniert_CheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
            ReservierungenLaden();
        }

        private void CmdResNeuHinzufuegen_Click(object sender, EventArgs e)
        {
            ReservierungEditor fenster = new ReservierungEditor();
            fenster.ShowDialog();
        }

        private void CmdResEinchecken_Click(object sender, EventArgs e)
        {
            CmdResStornieren.Enabled = true;
        }

        private void CmdResCheckInDialog_Click(object sender, EventArgs e)
        {
            ReservierungEditor fenster = new ReservierungEditor();
            fenster.ShowDialog();

        }
    }
}
