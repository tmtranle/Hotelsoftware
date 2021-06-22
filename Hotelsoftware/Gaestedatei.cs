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
    public partial class Gaestedatei : Form
    {
        public List<Gast> alleGaeste = new List<Gast>();

        public void GastHinzufuegen(Gast gast)
        {
            alleGaeste.Add(gast);
            LbGaeste.Items.Add(gast.ToString());
        }

        public Gaestedatei()
        {
            InitializeComponent();
            GaesteLaden();
        }

        public MySqlConnection conn = new MySqlConnection("Server=localhost;UID=root;PWD=;DATABASE=HotelsoftwareDB");
        public void GaesteLaden()
        {
            // Server kontaktieren
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT g_id, g_vorname, g_nachname, g_geburtsdatum, g_strasse, g_hausnummer,g_postleitzahl, g_stadt, g_land, f_id FROM gast ORDER BY g_nachname";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long g_id = reader.GetInt64(0);
                string g_vorname = reader.GetString(1);
                string g_nachname = reader.GetString(2);
                DateTime g_geburtsdatum = reader.GetDateTime(3);
                string g_strasse = reader.GetString(4);
                string g_hausnummer = reader.GetString(5);
                string g_postleitzahl = reader.GetString(6);
                string g_stadt = reader.GetString(7);
                string g_land = reader.GetString(8);
                long? f_id = reader.IsDBNull(9) ? null : reader.GetInt64(9);
                GastHinzufuegen(new Gast(g_id, g_vorname, g_nachname, g_geburtsdatum, g_strasse, g_hausnummer, g_postleitzahl, g_stadt, g_land, f_id));
            }
            reader.Close();
            conn.Close();
        }

        private void CmdGastSuchen_Click(object sender, EventArgs e)
        {
            // Nutzereingaben erhalten
            string g_vorname = TbVorname.Text;
            string g_nachname = TbNachname.Text;
            if (g_nachname.Length == 0)
            {
                MessageBox.Show("Nachname angeben");
                return;
            }
            DateTime g_geburtsdatum = dateTimePickerGeburtsdatum.Value;
            string g_strasse = TbStrasse.Text;
            string g_hausnummer = TbHausnummer.Text;
            string g_postleitzahl = TbPostleitzahl.Text;
            string g_stadt = TbStadt.Text;
            string g_land = TbLand.Text;

            // Server kontaktieren
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT g_vorname = @g_vorname " +
                " , g_nachname = @g_nachname " +
                " , g_geburtsdatum = @g_geburtsdatum " +
                " , g_strasse = @g_strasse " +
                " , g_hausnummer = @g_hausnummer " +
                " , g_postleitzahl = @g_postleitzahl " +
                " , g_stadt = @g_stadt " +
                " , g_land = @g_land " +
                " FROM gast";
            
            cmd.Parameters.AddWithValue("g_vorname", g_vorname);
            cmd.Parameters.AddWithValue("g_nachname", g_nachname);
            cmd.Parameters.AddWithValue("g_geburtsdatum", g_geburtsdatum);
            cmd.Parameters.AddWithValue("g_strasse", g_strasse);
            cmd.Parameters.AddWithValue("g_hausnummer", g_hausnummer);
            cmd.Parameters.AddWithValue("g_postleitzahl", g_postleitzahl);
            cmd.Parameters.AddWithValue("g_stadt", g_stadt);
            cmd.Parameters.AddWithValue("g_land", g_land);

            // TODO 
            // wenn Person gefunden wurde, in der LbGaeste markieren
            // boolean gastGefunden;
            // if gastGefunden = true;
            // else
            // CmdGastHinzufuegen.Enabled = true;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            
            conn.Close();
        }

        private void CmdGastHinzufuegen_Click(object sender, EventArgs e)
        {

        }
    }
}
