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
    public partial class ReservierungEditor : Form
    {
        public ReservierungEditor()
        {
            InitializeComponent();
        }

        private void CmdGaestekartei_Click(object sender, EventArgs e)
        {
            Gaestekartei fenster = new Gaestekartei();
            fenster.ShowDialog();
            //TODO mit Doppelklick soll der Gast ausgewählt werden,
            //gemerkt und an den ReservierungsEditor weitergegeben werden
        }

        private void CmdAbbruch_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public MySqlConnection conn = new MySqlConnection("Server=localhost;UID=root;PWD=;DATABASE=HotelsoftwareDB");

        private void CmdResNeuHinzufuegen_Click(object sender, EventArgs e)
        {
            // Nutzereingaben erhalten
            // Reservierungsnummer darf bei Res. neu hinzufügen nicht ausgefüllt sein
            if (TbReserNummer.Text != null)
            {
                MessageBox.Show("Reservierungsnummer nur bei Suche eingeben");
                return;
            }
            //string z_id = CbZimmerNummer.SelectedText;
            //long g_id = long.Parse(TbVersteckt_g_id.Text);
            //string r_status = CbReserStatus.SelectedText;
            //DateTime checkIn = dateTimePickerAnreise.Value;
            //DateTime checkOut = dateTimePickerAbreise.Value;
            //string z_kategorie = CbZimmerKategorie.SelectedText;
            //string z_status = CbZimmerStatus.SelectedText;
            //string g_nachname = TbNachname.Text;
            //string g_vorname = TbVorname.Text;
            //DateTime g_geburtstag = dateTimePickerGeburtstag.Value;

            //conn.Open();
            //MySqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = "INSERT INTO reservierung (z_id, z_kategorie, g.g_id, g_nachname, g_vorname, checkIn, checkOut, r_status)" +
            //    "VALUES (@z_id, @g.g_id, @g_nachname, @g_vorname, @checkIn, @checkOut, @r_status)";
            //cmd.Parameters.AddWithValue("z_id", z_id);
            //cmd.Parameters.AddWithValue("z_kategorie", z_kategorie);
            //cmd.Parameters.AddWithValue("g_id", g_id);
            //cmd.Parameters.AddWithValue("g_nachname", g_vorname);
            //cmd.Parameters.AddWithValue("g_vorname", g_vorname);
            //cmd.Parameters.AddWithValue("checkIn", checkIn);
            //cmd.Parameters.AddWithValue("checkOut", checkOut);
            //cmd.Parameters.AddWithValue("r_status", r_status);

            //cmd.Prepare();
            //cmd.ExecuteNonQuery();
            //long Id = cmd.LastInsertedId;
            //conn.Close();

            //Reservierung hinzuzufuegen = new Reservierung();

        }

        private void CmdResAendern_Click(object sender, EventArgs e)
        {
            // TODO Funktion Reservierung ändern programmieren
            MessageBox.Show("TODO");
        }

        private void CmdReserSuchen_Click(object sender, EventArgs e)
        {
            // TODO Funktion Reservierung suchen programmieren
            MessageBox.Show("TODO");
        }

        private void CmdResFixleistungen_Click(object sender, EventArgs e)
        {
            // TODO Fenster Leistungen programmieren
            MessageBox.Show("TODO");
        }
    }
}
