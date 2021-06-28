
namespace Hotelsoftware
{
    partial class Gaestekartei
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdGastNeuHinzufuegen = new System.Windows.Forms.Button();
            this.CmdGastSpeichern = new System.Windows.Forms.Button();
            this.CmdGastEntfernen = new System.Windows.Forms.Button();
            this.LbGaeste = new System.Windows.Forms.ListBox();
            this.LblVorname = new System.Windows.Forms.Label();
            this.TbVorname = new System.Windows.Forms.TextBox();
            this.LblNachname = new System.Windows.Forms.Label();
            this.TbNachname = new System.Windows.Forms.TextBox();
            this.LblGeburtsdatum = new System.Windows.Forms.Label();
            this.dateTimePickerGeburtsdatum = new System.Windows.Forms.DateTimePicker();
            this.LblStrasse = new System.Windows.Forms.Label();
            this.TbStrasse = new System.Windows.Forms.TextBox();
            this.LblPostleitzahl = new System.Windows.Forms.Label();
            this.TbPostleitzahl = new System.Windows.Forms.TextBox();
            this.LblStadt = new System.Windows.Forms.Label();
            this.TbStadt = new System.Windows.Forms.TextBox();
            this.LblLand = new System.Windows.Forms.Label();
            this.TbLand = new System.Windows.Forms.TextBox();
            this.LblFirma = new System.Windows.Forms.Label();
            this.LblFirmaAnzeigen = new System.Windows.Forms.Label();
            this.CmdFirmaAuswaehlen = new System.Windows.Forms.Button();
            this.CmdGastSuchen = new System.Windows.Forms.Button();
            this.LblHausnummer = new System.Windows.Forms.Label();
            this.TbHausnummer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdGastNeuHinzufuegen
            // 
            this.CmdGastNeuHinzufuegen.Enabled = false;
            this.CmdGastNeuHinzufuegen.Location = new System.Drawing.Point(504, 310);
            this.CmdGastNeuHinzufuegen.Name = "CmdGastNeuHinzufuegen";
            this.CmdGastNeuHinzufuegen.Size = new System.Drawing.Size(158, 23);
            this.CmdGastNeuHinzufuegen.TabIndex = 13;
            this.CmdGastNeuHinzufuegen.Text = "Neu hinzufügen";
            this.CmdGastNeuHinzufuegen.UseVisualStyleBackColor = true;
            this.CmdGastNeuHinzufuegen.Click += new System.EventHandler(this.CmdGastNeuHinzufuegen_Click);
            // 
            // CmdGastSpeichern
            // 
            this.CmdGastSpeichern.Enabled = false;
            this.CmdGastSpeichern.Location = new System.Drawing.Point(331, 339);
            this.CmdGastSpeichern.Name = "CmdGastSpeichern";
            this.CmdGastSpeichern.Size = new System.Drawing.Size(158, 23);
            this.CmdGastSpeichern.TabIndex = 11;
            this.CmdGastSpeichern.Text = "Änderungen speichern";
            this.CmdGastSpeichern.UseVisualStyleBackColor = true;
            this.CmdGastSpeichern.Click += new System.EventHandler(this.CmdGastSpeichern_Click);
            // 
            // CmdGastEntfernen
            // 
            this.CmdGastEntfernen.Enabled = false;
            this.CmdGastEntfernen.Location = new System.Drawing.Point(504, 339);
            this.CmdGastEntfernen.Name = "CmdGastEntfernen";
            this.CmdGastEntfernen.Size = new System.Drawing.Size(158, 23);
            this.CmdGastEntfernen.TabIndex = 12;
            this.CmdGastEntfernen.Text = "Entfernen";
            this.CmdGastEntfernen.UseVisualStyleBackColor = true;
            this.CmdGastEntfernen.Click += new System.EventHandler(this.CmdGastEntfernen_Click);
            // 
            // LbGaeste
            // 
            this.LbGaeste.FormattingEnabled = true;
            this.LbGaeste.ItemHeight = 15;
            this.LbGaeste.Location = new System.Drawing.Point(14, 12);
            this.LbGaeste.Name = "LbGaeste";
            this.LbGaeste.Size = new System.Drawing.Size(303, 349);
            this.LbGaeste.TabIndex = 3;
            this.LbGaeste.SelectedIndexChanged += new System.EventHandler(this.LbGaeste_SelectedIndexChanged);
            // 
            // LblVorname
            // 
            this.LblVorname.AutoSize = true;
            this.LblVorname.Location = new System.Drawing.Point(331, 56);
            this.LblVorname.Name = "LblVorname";
            this.LblVorname.Size = new System.Drawing.Size(54, 15);
            this.LblVorname.TabIndex = 4;
            this.LblVorname.Text = "Vorname";
            // 
            // TbVorname
            // 
            this.TbVorname.Location = new System.Drawing.Point(331, 77);
            this.TbVorname.Name = "TbVorname";
            this.TbVorname.Size = new System.Drawing.Size(331, 23);
            this.TbVorname.TabIndex = 2;
            // 
            // LblNachname
            // 
            this.LblNachname.AutoSize = true;
            this.LblNachname.Location = new System.Drawing.Point(331, 12);
            this.LblNachname.Name = "LblNachname";
            this.LblNachname.Size = new System.Drawing.Size(65, 15);
            this.LblNachname.TabIndex = 6;
            this.LblNachname.Text = "Nachname";
            // 
            // TbNachname
            // 
            this.TbNachname.Location = new System.Drawing.Point(331, 30);
            this.TbNachname.Name = "TbNachname";
            this.TbNachname.Size = new System.Drawing.Size(330, 23);
            this.TbNachname.TabIndex = 1;
            this.TbNachname.TextChanged += new System.EventHandler(this.TbNachname_TextChanged);
            // 
            // LblGeburtsdatum
            // 
            this.LblGeburtsdatum.AutoSize = true;
            this.LblGeburtsdatum.Location = new System.Drawing.Point(331, 237);
            this.LblGeburtsdatum.Name = "LblGeburtsdatum";
            this.LblGeburtsdatum.Size = new System.Drawing.Size(83, 15);
            this.LblGeburtsdatum.TabIndex = 8;
            this.LblGeburtsdatum.Text = "Geburtsdatum";
            // 
            // dateTimePickerGeburtsdatum
            // 
            this.dateTimePickerGeburtsdatum.Location = new System.Drawing.Point(331, 255);
            this.dateTimePickerGeburtsdatum.Name = "dateTimePickerGeburtsdatum";
            this.dateTimePickerGeburtsdatum.Size = new System.Drawing.Size(201, 23);
            this.dateTimePickerGeburtsdatum.TabIndex = 8;
            // 
            // LblStrasse
            // 
            this.LblStrasse.AutoSize = true;
            this.LblStrasse.Location = new System.Drawing.Point(331, 103);
            this.LblStrasse.Name = "LblStrasse";
            this.LblStrasse.Size = new System.Drawing.Size(43, 15);
            this.LblStrasse.TabIndex = 10;
            this.LblStrasse.Text = "Strasse";
            // 
            // TbStrasse
            // 
            this.TbStrasse.Location = new System.Drawing.Point(331, 121);
            this.TbStrasse.Name = "TbStrasse";
            this.TbStrasse.Size = new System.Drawing.Size(244, 23);
            this.TbStrasse.TabIndex = 3;
            // 
            // LblPostleitzahl
            // 
            this.LblPostleitzahl.AutoSize = true;
            this.LblPostleitzahl.Location = new System.Drawing.Point(332, 147);
            this.LblPostleitzahl.Name = "LblPostleitzahl";
            this.LblPostleitzahl.Size = new System.Drawing.Size(67, 15);
            this.LblPostleitzahl.TabIndex = 12;
            this.LblPostleitzahl.Text = "Postleitzahl";
            // 
            // TbPostleitzahl
            // 
            this.TbPostleitzahl.Location = new System.Drawing.Point(332, 166);
            this.TbPostleitzahl.Name = "TbPostleitzahl";
            this.TbPostleitzahl.Size = new System.Drawing.Size(98, 23);
            this.TbPostleitzahl.TabIndex = 5;
            // 
            // LblStadt
            // 
            this.LblStadt.AutoSize = true;
            this.LblStadt.Location = new System.Drawing.Point(436, 147);
            this.LblStadt.Name = "LblStadt";
            this.LblStadt.Size = new System.Drawing.Size(34, 15);
            this.LblStadt.TabIndex = 14;
            this.LblStadt.Text = "Stadt";
            // 
            // TbStadt
            // 
            this.TbStadt.Location = new System.Drawing.Point(436, 166);
            this.TbStadt.Name = "TbStadt";
            this.TbStadt.Size = new System.Drawing.Size(226, 23);
            this.TbStadt.TabIndex = 6;
            // 
            // LblLand
            // 
            this.LblLand.AutoSize = true;
            this.LblLand.Location = new System.Drawing.Point(331, 192);
            this.LblLand.Name = "LblLand";
            this.LblLand.Size = new System.Drawing.Size(33, 15);
            this.LblLand.TabIndex = 16;
            this.LblLand.Text = "Land";
            // 
            // TbLand
            // 
            this.TbLand.Location = new System.Drawing.Point(331, 211);
            this.TbLand.Name = "TbLand";
            this.TbLand.Size = new System.Drawing.Size(331, 23);
            this.TbLand.TabIndex = 7;
            // 
            // LblFirma
            // 
            this.LblFirma.AutoSize = true;
            this.LblFirma.Location = new System.Drawing.Point(538, 237);
            this.LblFirma.Name = "LblFirma";
            this.LblFirma.Size = new System.Drawing.Size(37, 15);
            this.LblFirma.TabIndex = 18;
            this.LblFirma.Text = "Firma";
            // 
            // LblFirmaAnzeigen
            // 
            this.LblFirmaAnzeigen.AutoSize = true;
            this.LblFirmaAnzeigen.Location = new System.Drawing.Point(538, 262);
            this.LblFirmaAnzeigen.Name = "LblFirmaAnzeigen";
            this.LblFirmaAnzeigen.Size = new System.Drawing.Size(87, 15);
            this.LblFirmaAnzeigen.TabIndex = 19;
            this.LblFirmaAnzeigen.Text = "(keine Angabe)";
            // 
            // CmdFirmaAuswaehlen
            // 
            this.CmdFirmaAuswaehlen.Location = new System.Drawing.Point(632, 256);
            this.CmdFirmaAuswaehlen.Name = "CmdFirmaAuswaehlen";
            this.CmdFirmaAuswaehlen.Size = new System.Drawing.Size(30, 23);
            this.CmdFirmaAuswaehlen.TabIndex = 9;
            this.CmdFirmaAuswaehlen.Text = "...";
            this.CmdFirmaAuswaehlen.UseVisualStyleBackColor = true;
            this.CmdFirmaAuswaehlen.Click += new System.EventHandler(this.CmdFirmaAuswaehlen_Click);
            // 
            // CmdGastSuchen
            // 
            this.CmdGastSuchen.Location = new System.Drawing.Point(332, 310);
            this.CmdGastSuchen.Name = "CmdGastSuchen";
            this.CmdGastSuchen.Size = new System.Drawing.Size(158, 23);
            this.CmdGastSuchen.TabIndex = 10;
            this.CmdGastSuchen.Text = "Suchen";
            this.CmdGastSuchen.UseVisualStyleBackColor = true;
            this.CmdGastSuchen.Click += new System.EventHandler(this.CmdGastSuchen_Click);
            // 
            // LblHausnummer
            // 
            this.LblHausnummer.AutoSize = true;
            this.LblHausnummer.Location = new System.Drawing.Point(582, 103);
            this.LblHausnummer.Name = "LblHausnummer";
            this.LblHausnummer.Size = new System.Drawing.Size(80, 15);
            this.LblHausnummer.TabIndex = 22;
            this.LblHausnummer.Text = "Hausnummer";
            // 
            // TbHausnummer
            // 
            this.TbHausnummer.Location = new System.Drawing.Point(582, 121);
            this.TbHausnummer.Name = "TbHausnummer";
            this.TbHausnummer.Size = new System.Drawing.Size(80, 23);
            this.TbHausnummer.TabIndex = 4;
            // 
            // Gaestekartei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 377);
            this.Controls.Add(this.TbHausnummer);
            this.Controls.Add(this.LblHausnummer);
            this.Controls.Add(this.CmdGastSuchen);
            this.Controls.Add(this.CmdFirmaAuswaehlen);
            this.Controls.Add(this.LblFirmaAnzeigen);
            this.Controls.Add(this.LblFirma);
            this.Controls.Add(this.TbLand);
            this.Controls.Add(this.LblLand);
            this.Controls.Add(this.TbStadt);
            this.Controls.Add(this.LblStadt);
            this.Controls.Add(this.TbPostleitzahl);
            this.Controls.Add(this.LblPostleitzahl);
            this.Controls.Add(this.TbStrasse);
            this.Controls.Add(this.LblStrasse);
            this.Controls.Add(this.dateTimePickerGeburtsdatum);
            this.Controls.Add(this.LblGeburtsdatum);
            this.Controls.Add(this.TbNachname);
            this.Controls.Add(this.LblNachname);
            this.Controls.Add(this.TbVorname);
            this.Controls.Add(this.LblVorname);
            this.Controls.Add(this.LbGaeste);
            this.Controls.Add(this.CmdGastEntfernen);
            this.Controls.Add(this.CmdGastSpeichern);
            this.Controls.Add(this.CmdGastNeuHinzufuegen);
            this.Name = "Gaestekartei";
            this.Text = "Gästekartei";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdGastNeuHinzufuegen;
        private System.Windows.Forms.Button CmdGastSpeichern;
        private System.Windows.Forms.Button CmdGastEntfernen;
        private System.Windows.Forms.ListBox LbGaeste;
        private System.Windows.Forms.Label LblVorname;
        private System.Windows.Forms.TextBox TbVorname;
        private System.Windows.Forms.Label LblNachname;
        private System.Windows.Forms.TextBox TbNachname;
        private System.Windows.Forms.Label LblGeburtsdatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerGeburtsdatum;
        private System.Windows.Forms.Label LblStrasse;
        private System.Windows.Forms.TextBox TbStrasse;
        private System.Windows.Forms.Label LblPostleitzahl;
        private System.Windows.Forms.TextBox TbPostleitzahl;
        private System.Windows.Forms.Label LblStadt;
        private System.Windows.Forms.TextBox TbStadt;
        private System.Windows.Forms.Label LblLand;
        private System.Windows.Forms.TextBox TbLand;
        private System.Windows.Forms.Label LblFirma;
        private System.Windows.Forms.Label LblFirmaAnzeigen;
        private System.Windows.Forms.Button CmdFirmaAuswaehlen;
        private System.Windows.Forms.Button CmdGastSuchen;
        private System.Windows.Forms.Label LblHausnummer;
        private System.Windows.Forms.TextBox TbHausnummer;
    }
}