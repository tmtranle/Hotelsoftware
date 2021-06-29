﻿using System;
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
    public partial class Gaestekartei : Form
    {
        public List<Gast> alleGaeste = new List<Gast>();

        public void GastHinzufuegen(Gast gast)
        {
            alleGaeste.Add(gast);
            LbGaeste.Items.Add(gast.ToString());
        }

        public Gaestekartei()
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

            //TODO JOIN MIT FIRMEN
            cmd.CommandText = "SELECT g_id, g_vorname, g_nachname, g_geburtsdatum, g_strasse, g_hausnummer,g_postleitzahl, g_stadt, g_land, f.f_id, f_bezeichnung " +
                                    " FROM gast " + 
                                    " LEFT OUTER JOIN firma f on f.f_id = gast.f_id " +
                                    " ORDER BY g_nachname ";

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
                string f_bezeichnung = f_id == null ? null : reader.GetString(10);
                GastHinzufuegen(new Gast(g_id, g_vorname, g_nachname, g_geburtsdatum, g_strasse, g_hausnummer, g_postleitzahl, g_stadt, g_land, f_id, f_bezeichnung));
            }
            reader.Close();
            conn.Close();
        }

        private void CmdGastSuchen_Click(object sender, EventArgs e)
        {
            GastSuchen();
            CmdGastNeuHinzufuegen.Enabled = true;
        }

        private void GastSuchen()
        { 
            // Nutzereingaben erhalten
            
            string g_nachname = TbNachname.Text;
            if (g_nachname.Length == 0)
            {
                TbLeeren();
                LbGaeste.Items.Clear();
                GaesteLaden();
                return;
            }
            
            // Server kontaktieren
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT g_id, g_vorname, g_nachname, g_geburtsdatum, g_strasse, g_hausnummer,g_postleitzahl, g_stadt, g_land, f_id " +
                " FROM gast WHERE g_nachname like @g_nachname ORDER BY g_nachname";

            cmd.Parameters.AddWithValue("g_nachname", "%" + g_nachname + "%");

            cmd.Prepare();
            MySqlDataReader reader = cmd.ExecuteReader();
            LbGaeste.Items.Clear();
            alleGaeste.Clear();

            while (reader.Read())
            {
                long g_id = reader.GetInt64(0);
                string g_vorname = reader.GetString(1);
                g_nachname = reader.GetString(2);
                DateTime g_geburtsdatum = reader.GetDateTime(3);
                string g_strasse = reader.GetString(4);
                string g_hausnummer = reader.GetString(5);
                string g_postleitzahl = reader.GetString(6);
                string g_stadt = reader.GetString(7);
                string g_land = reader.GetString(8);
                long? f_id = reader.IsDBNull(9) ? null : reader.GetInt64(9);
                string f_bezeichnung = f_id == null ? null : reader.GetString(10);
                GastHinzufuegen(new Gast(g_id, g_vorname, g_nachname, g_geburtsdatum, g_strasse, g_hausnummer, g_postleitzahl, g_stadt, g_land, f_id, f_bezeichnung));
            }

            reader.Close();         
            
            conn.Close();
        }

        private void CmdGastNeuHinzufuegen_Click(object sender, EventArgs e)
        {
            GastNeuHinzufuegen();
            CmdGastNeuHinzufuegen.Enabled = true;
        }

        private void GastNeuHinzufuegen()
        {
            //TODO Funktion bearbeiten, vorab aber den Doppelklick ausprogrammieren -
            // dieser soll den long f_id liefern als Parameter
            //int anzahl; // für die Anzeige, wenn ein Eintrag hinzugefügt werden konnte

            //string g_vorname = TbVorname.Text;
            //string g_nachname = TbNachname.Text;
            //DateTime g_geburtsdatum = dateTimePickerGeburtsdatum.Value;
            //string g_strasse = TbStrasse.Text;
            //string g_hausnummer = TbHausnummer.Text;
            //string g_postleitzahl = TbPostleitzahl.Text;
            //string g_stadt = TbStadt.Text;
            //string g_land = TbLand.Text;
            //long? f_id = ; 

       }

        private void TbLeeren()
        {
            TbVorname.Text = "";
            TbNachname.Text = "";
            TbStrasse.Text = "";
            TbHausnummer.Text = "";
            TbPostleitzahl.Text = "";
            TbStadt.Text = "";
            TbLand.Text = "";

        }

        private void CmdGastSpeichern_Click(object sender, EventArgs e)
        {
            //GastSpeichern();
        }

        public void GastSpeichern()
        {
            int anzahl; // für die Anzeige, wenn Eintrag bearbeitet werden konnte

            // Index für ausgewählte Firma definieren zum bearbeiten
            int bearbeitenIndex = LbGaeste.SelectedIndex;
            if (bearbeitenIndex < 0 || bearbeitenIndex >= alleGaeste.Count)
            {
                return;
            }
            Gast zuBearbeiten = alleGaeste[bearbeitenIndex];

            string g_vorname = TbVorname.Text;
            string g_nachname = TbNachname.Text;
            DateTime g_geburtsdatum = dateTimePickerGeburtsdatum.Value;
            string g_strasse = TbStrasse.Text;
            string g_hausnummer = TbHausnummer.Text;
            string g_postleitzahl = TbPostleitzahl.Text;
            string g_stadt = TbStadt.Text;
            string g_land = TbLand.Text;
            
            // Server kontaktieren
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE gast SET g_vorname = @g_vorname " +
                " , g_nachname = @g_nachname " +
                " , g_geburtsdatum = @g_geburtsdatum " +
                " , g_hausnummer = @g_hausnummer " +
                " , g_postleitzahl = @g_postleitzahl " +
                " , g_stadt = @g_stadt " +
                " , g_land = @g_land " +
                " WHERE g_id = " + zuBearbeiten.g_id;

            cmd.Parameters.AddWithValue("g_vorname", g_vorname);
            cmd.Parameters.AddWithValue("g_nachname", g_nachname);
            cmd.Parameters.AddWithValue("g_geburtsdatum", g_geburtsdatum);
            cmd.Parameters.AddWithValue("g_hausnummer", g_hausnummer);
            cmd.Parameters.AddWithValue("g_postleitzahl", g_postleitzahl);
            cmd.Parameters.AddWithValue("g_stadt", g_stadt);
            cmd.Parameters.AddWithValue("g_land", g_land);
            cmd.Prepare();
            anzahl = cmd.ExecuteNonQuery();
            if (anzahl > 0)
            {
                MessageBox.Show("Änderungen gespeichert");
            }

            

            

            

            // Serververbindung beenden
            conn.Close();
        }

        private void CmdGastEntfernen_Click(object sender, EventArgs e)
        {
            int anzahl;
            // Index für ausgewählte Firma definieren zum entfernen
            int entfernenIndex = LbGaeste.SelectedIndex;
            if (entfernenIndex < 0 || entfernenIndex >= alleGaeste.Count)
            {
                return;
            }
            Gast zuEntfernen = alleGaeste[entfernenIndex];

            // Server kontaktieren
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM gast WHERE g_id = " + zuEntfernen.g_id;
            anzahl = cmd.ExecuteNonQuery();
            if (anzahl > 0)
            {
                MessageBox.Show("Eintrag entfernt");
            }
            conn.Close();

            // aus der List<Firma> entfernen
            alleGaeste.RemoveAt(entfernenIndex);

            // aus der Listbox entfernen
            LbGaeste.Items.RemoveAt(entfernenIndex);
        }

        private void LbGaeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Index für ausgewählten Gast definieren zum bearbeiten
            int bearbeitenIndex = LbGaeste.SelectedIndex;
            if (bearbeitenIndex < 0 || bearbeitenIndex >= alleGaeste.Count)
            {
                return;
            }
            Gast zuBearbeiten = alleGaeste[bearbeitenIndex];

            // Variablen des Gastes in die Eingabefelder kopieren
            TbVorname.Text = zuBearbeiten.g_vorname;
            TbNachname.Text = zuBearbeiten.g_nachname;
            TbStrasse.Text = zuBearbeiten.g_strasse;
            TbHausnummer.Text = zuBearbeiten.g_hausnummer;
            TbPostleitzahl.Text = zuBearbeiten.g_postleitzahl;
            TbStadt.Text = zuBearbeiten.g_stadt;
            TbLand.Text = zuBearbeiten.g_land;
            LblFirmaAnzeigen.Text = zuBearbeiten.f_bezeichnung;

            // Sobald ein Element der Listbox ausgewählt wird, werden die Buttons Bearbeiten und Entfernen nutzbar
            CmdGastSpeichern.Enabled = true;
            CmdGastEntfernen.Enabled = true;
            
        }

        private void TbNachname_TextChanged(object sender, EventArgs e)
        {
            // bei erneuter Suche, dem löschen des Nachnamens, werden die Inhalte der Textboxen geleert
            if (TbNachname.TextLength == 0)
            {
                TbLeeren();
            }
        }
        
        private Firma ausgewaehlteFirma = null;
        private void CmdFirmaAuswaehlen_Click(object sender, EventArgs e)
        {    // Parameterübergabe ausgewählte Firma an Gaststamm übergeben und anzeigen
            Firmenkartei fenster = new Firmenkartei();
            fenster.ShowDialog();
            ausgewaehlteFirma = fenster.DoppeltgeklickteFirma;
            if (fenster.DialogResult == DialogResult.OK)
            {
                
                    
                    conn.Open();
                    int index = LbGaeste.SelectedIndex;
                    if (index < 0 || index >= alleGaeste.Count)
                    {
                        return;
                    }
                    Gast g = alleGaeste[index];
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE gast SET f_id = @f_id WHERE g_id = @g_id";
                    cmd.Parameters.AddWithValue("f_id", ausgewaehlteFirma == null ? null : ausgewaehlteFirma.f_id);
                    cmd.Parameters.AddWithValue("g_id", g.g_id);
                    cmd.Prepare();
                    // für die Anzeige, wenn Eintrag bearbeitet werden konnte
                    int anzahl = cmd.ExecuteNonQuery();
                    
                    if (anzahl > 0)
                    {
                        // Daten im Speicher aktualisieren
                        g.f_id = ausgewaehlteFirma.f_id;
                        g.f_bezeichnung = ausgewaehlteFirma.f_bezeichnung;

                        // Anzeige aktualisieren
                        // wenn Firma vorhanden ist, im Label den Namen der Firma anzeigen
                        LblFirmaAnzeigen.Text = ausgewaehlteFirma.f_bezeichnung;
                        MessageBox.Show("Firma hinterlegt");
                    }
                    conn.Close();

                    
                
            }
        }
    }
}