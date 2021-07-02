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
    public partial class Firmenkartei : Form
    {
        public List<Firma> alleFirmen = new List<Firma>();
        
        public Firma DoppeltgeklickteFirma { get; set; }

        public void FirmaHinzufuegen(Firma firma)
        {
            // zur Liste hinzufügen
            alleFirmen.Add(firma);
            // zum Model hinzufügen
            LbFirmen.Items.Add(firma.ToString());
        }

        public Firmenkartei()
        {
            InitializeComponent();
            FirmenLaden();
        }
        
        public MySqlConnection conn = new MySqlConnection("Server=localhost;UID=root;PWD=;DATABASE=HotelsoftwareDB");
        public void FirmenLaden()
        {
            // Server kontaktieren
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            // SQL Abfrage
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
            // Verbindung beenden
            conn.Close();
        }

        private void CmdFirmaSuchen_Click(object sender, EventArgs e)
        {
            FirmaSuchen();
            CmdFirmaHinzufuegen.Enabled = true;
        }

        private void FirmaSuchen()
        { 
            // Nutzereingaben erhalten
            string f_bezeichnung = TbFirmenbezeichnung.Text;
            if (f_bezeichnung.Length == 0)
            {
                TbLeeren();
                LbFirmen.Items.Clear();
                FirmenLaden();
                return;
            }
            
            // Server kontaktieren
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            // SQL Abfrage
            cmd.CommandText = "SELECT f_id, f_bezeichnung, f_strasse, f_hausnummer, f_postleitzahl, f_stadt, f_land " +
                " FROM firma WHERE f_bezeichnung like @f_bezeichnung ORDER BY f_bezeichnung";
            cmd.Parameters.AddWithValue("f_bezeichnung", "%"+f_bezeichnung+"%");
            cmd.Prepare();
            MySqlDataReader reader = cmd.ExecuteReader();
            // Lb und Liste erstmal leeren
            LbFirmen.Items.Clear();
            alleFirmen.Clear();
            // Ergebnis anzeigen
            while (reader.Read())
            {
                long f_id = reader.GetInt64(0);
                f_bezeichnung = reader.GetString(1);
                string f_strasse = reader.GetString(2);
                string f_hausnummer = reader.GetString(3);
                string f_postleitzahl = reader.GetString(4);
                string f_stadt = reader.GetString(5);
                string f_land = reader.GetString(6);
                FirmaHinzufuegen(new Firma(f_id, f_bezeichnung, f_strasse, f_hausnummer, f_postleitzahl, f_stadt, f_land));
                
            }
            reader.Close();
            // Verbindung beenden
            conn.Close();

        }

        private void CmdNeuFirmaHinzufuegen_Click(object sender, EventArgs e)
        {
            FirmaNeuHinzufuegen();
        }

        private void FirmaNeuHinzufuegen() 
        {
            // Nutzereingaben erhalten
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
            int anzahl; // für die Anzeige, wenn Eintrag hinzugefügt werden konnte
            anzahl = cmd.ExecuteNonQuery();
            if (anzahl > 0)
            {
                MessageBox.Show("Eintrag hinzugefügt");
            }    
            // ID einholen
            long f_id = cmd.LastInsertedId;
            conn.Close();

            // zur Liste hinzufügen 
            Firma hinzuzufuegen = new Firma(f_id, f_bezeichnung, f_strasse, f_hausnummer, f_postleitzahl, f_stadt, f_land);
            
            // Listbox aktualisieren
            FirmaHinzufuegen(hinzuzufuegen);

            // Textboxen leeren
            TbLeeren();

            // Verbindung beenden
            conn.Close();
        }

        private void TbLeeren()
        {
            TbFirmenbezeichnung.Text = "";
            TbStrasse.Text = "";
            TbHausnummer.Text = "";
            TbPostleitzahl.Text = "";
            TbStrasse.Text = "";
            TbStadt.Text = "";
            TbLand.Text = "";

        }

        private void CmdFirmaSpeichern_Click(object sender, EventArgs e)
        {
            FirmaSpeichern();
        }

        private void FirmaSpeichern()
        {
            // Index für ausgewählte Firma definieren zum bearbeiten
            int bearbeitenIndex = LbFirmen.SelectedIndex;
            if (bearbeitenIndex < 0 || bearbeitenIndex >= alleFirmen.Count)
            {
                return;
            }
            Firma zuBearbeiten = alleFirmen[bearbeitenIndex];

            string f_bezeichnung = TbFirmenbezeichnung.Text;
            string f_strasse = TbStrasse.Text;
            string f_hausnummer = TbHausnummer.Text;
            string f_postleitzahl = TbPostleitzahl.Text;
            string f_stadt = TbStadt.Text;
            string f_land = TbLand.Text;

            // Server kontaktieren
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE firma SET f_bezeichnung = @f_bezeichnung" +
                ", f_strasse = @f_strasse " +
                ", f_hausnummer = @f_hausnummer " +
                ", f_postleitzahl = @f_postleitzahl " +
                ", f_stadt = @f_stadt " +
                ", f_land = @f_land " +
                "WHERE f_id = " + zuBearbeiten.f_id;

            cmd.Parameters.AddWithValue("f_bezeichnung", f_bezeichnung);
            cmd.Parameters.AddWithValue("f_strasse", f_strasse);
            cmd.Parameters.AddWithValue("f_hausnummer", f_hausnummer);
            cmd.Parameters.AddWithValue("f_postleitzahl", f_postleitzahl);
            cmd.Parameters.AddWithValue("f_stadt", f_stadt);
            cmd.Parameters.AddWithValue("f_land", f_land);
            cmd.Prepare();
            // für die Anzeige, wenn Eintrag bearbeitet werden konnte
            int anzahl = cmd.ExecuteNonQuery(); 
            if (anzahl > 0)
            {
                MessageBox.Show("Änderungen gespeichert");
            }
            // Serververbindung beenden
            conn.Close();

            // Änderung in der Listbox anzeigen
            RefreshView();
            FirmenLaden();
        }

        private void RefreshView()
        {
            // Liste leeren
            alleFirmen.Clear();
            // Model leeren
            LbFirmen.Items.Clear();
        }


        private void CmdFirmaEntfernen_Click(object sender, EventArgs e)
        {
            FirmaEntfernen();
        }

        private void FirmaEntfernen()
        {
            int anzahl; 
            // Index für ausgewählte Firma definieren zum entfernen
            int entfernenIndex = LbFirmen.SelectedIndex;
            if (entfernenIndex < 0 || entfernenIndex >= alleFirmen.Count)
            {
                return;
            }
            Firma zuEntfernen = alleFirmen[entfernenIndex];

            // Server kontaktieren
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM firma WHERE f_id = " + zuEntfernen.f_id;
            anzahl = cmd.ExecuteNonQuery();
            if (anzahl > 0)
            {
                MessageBox.Show("Eintrag entfernt");
            }
            conn.Close();

            // aus der List<Firma> entfernen
            alleFirmen.RemoveAt(entfernenIndex);

            // aus der Listbox entfernen
            LbFirmen.Items.RemoveAt(entfernenIndex);
        }

        private void LbFirmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Index für ausgewählte Firma definieren zum bearbeiten
            int bearbeitenIndex = LbFirmen.SelectedIndex;
            if (bearbeitenIndex < 0 || bearbeitenIndex >= alleFirmen.Count)
            {
                return;
            }
            Firma zuBearbeiten = alleFirmen[bearbeitenIndex];

            // Variablen der Firma in die Eingabefelder kopieren
            TbFirmenbezeichnung.Text = zuBearbeiten.f_bezeichnung;
            TbStrasse.Text = zuBearbeiten.f_strasse;
            TbHausnummer.Text = zuBearbeiten.f_hausnummer;
            TbPostleitzahl.Text = zuBearbeiten.f_postleitzahl;
            TbStadt.Text = zuBearbeiten.f_stadt;
            TbLand.Text = zuBearbeiten.f_land;

            // Sobald ein Element der Listbox ausgewählt wird, werden die Buttons Bearbeiten und Entfernen nutzbar
            CmdFirmaSpeichern.Enabled = true;
            CmdFirmaEntfernen.Enabled = true;
        }

        private void TbFirmenbezeichnung_TextChanged(object sender, EventArgs e)
        {   // bei erneuter Suche, dem löschen der Firmenbez., werden die Inhalte der Textboxen geleert
            if (TbFirmenbezeichnung.TextLength == 0)
            {
                TbLeeren();
            }
        }

        private void LbFirmen_DoubleClick(object sender, EventArgs e)
        {
            // Doppelklick in die Lb der Firmen soll die ausgewählte Firma als Parameter an den Gast zurückliefern
            // aus der View den Index holen
            int auswaehlenIndex = LbFirmen.SelectedIndex;
            // diesen Index prüfen 
            if (auswaehlenIndex < 0 || auswaehlenIndex >= alleFirmen.Count)
            {
                return;
            }
            // die ausgewählte Firma merken
            DoppeltgeklickteFirma = alleFirmen[auswaehlenIndex];

            // Erfolg anzeigen
            DialogResult = DialogResult.OK;
            // Fenster schließen
            Close();
        }

        
    }
}
