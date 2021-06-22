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
   
    public partial class Firmendatei : Form
    {
        public List<Firma> alleFirmen = new List<Firma>();
        public MySqlConnection conn = new MySqlConnection("Server=localhost;UID=root;PWD=;DATABASE=HotelsoftwareDB");

        public void FirmaHinzufuegen(Firma firma)
        {
            alleFirmen.Add(firma);
            LbFirmen.Items.Add(firma.ToString());
        }

        public Firmendatei()
        {
            InitializeComponent();
            FirmenLaden();
        }

        public void FirmenLaden()
        {
            // Server kontaktieren
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT f_id, f_bezeichnung, f_strasse, f_hausnummer, f_postleitzahl, f_stadt, f_land FROM firma ORDER BY f_bezeichnung";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long f_id = reader.GetInt64(0);
                string f_bezeichnung = reader.GetString(1);
                string f_strasse = reader.GetString(2);
                string f_hausnummer = reader.GetString(3);
                string f_postleitzahl = reader.GetString(4);
                string f_stadt = reader.GetString(5);
                string f_land = reader.GetString(6);
                FirmaHinzufuegen(new Firma(f_id, f_bezeichnung, f_strasse, f_hausnummer, f_postleitzahl, f_stadt, f_land));
            }
            reader.Close();
            conn.Close();
        }

        private void CmdFirmaSuchen_Click(object sender, EventArgs e)
        {
            CmdFirmaHinzufuegen.Enabled = true;
        }

        private void CmdFirmaHinzufuegen_Click(object sender, EventArgs e)
        {
            string f_bezeichnung = TbFirmenbezeichnung.Text;
            if (f_bezeichnung.Length == 0)
            {
                MessageBox.Show("Firmenbezeichnung angeben");
                return;
            }
            string f_strasse = TbStrasse.Text;
            string f_hausnummer = TbHausnummer.Text;
            string f_postleitzahl = TbPostleitzahl.Text;
            string f_stadt = TbStadt.Text;
            string f_land = TbLand.Text;

            // Server kontaktieren
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            // SQL Abfrage
            cmd.CommandText = "INSERT INTO firma (f_bezeichnung, f_strasse, f_hausnummer, f_postleitzahl, f_stadt, f_land)"
                + " VALUES(@f_bezeichnung, @f_strasse, @f_hausnummer, @f_postleitzahl, @f_stadt, @f_land)";
            // Vorbereitung Parameter
            cmd.Parameters.AddWithValue("f_bezeichnung", f_bezeichnung);
            cmd.Parameters.AddWithValue("f_strasse", f_strasse);
            cmd.Parameters.AddWithValue("f_hausnummer", f_hausnummer);
            cmd.Parameters.AddWithValue("f_postleitzahl", f_postleitzahl);
            cmd.Parameters.AddWithValue("f_stadt", f_stadt);
            cmd.Parameters.AddWithValue("f_land", f_land);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            // ID einholen
            long f_id = cmd.LastInsertedId;
            conn.Close();

            // zur Liste hinzufügen 
            Firma hinzuzufuegen = new Firma(f_id, f_bezeichnung, f_strasse, f_hausnummer, f_postleitzahl, f_stadt, f_land);
            
            // Listbox aktualisieren
            FirmaHinzufuegen(hinzuzufuegen);

            // Textboxen leeren
            TbFirmenbezeichnung.Text = "";
            TbStrasse.Text = "";
            TbHausnummer.Text = "";
            TbPostleitzahl.Text = "";
            TbStrasse.Text = "";
            TbStadt.Text = "";
            TbLand.Text = "";
            
            // Verbindung beenden
            conn.Close();
        }

        private void CmdFirmaBearbeiten_Click(object sender, EventArgs e)
        {

        }

        private void CmdFirmaEntfernen_Click(object sender, EventArgs e)
        {
            
        }
    }
}
