
namespace Hotelsoftware
{
    partial class Firmenkartei
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
            this.LbFirmen = new System.Windows.Forms.ListBox();
            this.LblFirmenbezeichnung = new System.Windows.Forms.Label();
            this.TbFirmenbezeichnung = new System.Windows.Forms.TextBox();
            this.LblStrasse = new System.Windows.Forms.Label();
            this.TbStrasse = new System.Windows.Forms.TextBox();
            this.LblPostleitzahl = new System.Windows.Forms.Label();
            this.TbPostleitzahl = new System.Windows.Forms.TextBox();
            this.LblStadt = new System.Windows.Forms.Label();
            this.TbStadt = new System.Windows.Forms.TextBox();
            this.LblLand = new System.Windows.Forms.Label();
            this.TbLand = new System.Windows.Forms.TextBox();
            this.CmdFirmaSuchen = new System.Windows.Forms.Button();
            this.CmdFirmaEntfernen = new System.Windows.Forms.Button();
            this.CmdFirmaSpeichern = new System.Windows.Forms.Button();
            this.CmdFirmaHinzufuegen = new System.Windows.Forms.Button();
            this.LblHausnummer = new System.Windows.Forms.Label();
            this.TbHausnummer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbFirmen
            // 
            this.LbFirmen.FormattingEnabled = true;
            this.LbFirmen.ItemHeight = 15;
            this.LbFirmen.Location = new System.Drawing.Point(14, 12);
            this.LbFirmen.Name = "LbFirmen";
            this.LbFirmen.Size = new System.Drawing.Size(287, 274);
            this.LbFirmen.TabIndex = 0;
            this.LbFirmen.SelectedIndexChanged += new System.EventHandler(this.LbFirmen_SelectedIndexChanged);
            this.LbFirmen.DoubleClick += new System.EventHandler(this.LbFirmen_DoubleClick);
            // 
            // LblFirmenbezeichnung
            // 
            this.LblFirmenbezeichnung.AutoSize = true;
            this.LblFirmenbezeichnung.Location = new System.Drawing.Point(318, 12);
            this.LblFirmenbezeichnung.Name = "LblFirmenbezeichnung";
            this.LblFirmenbezeichnung.Size = new System.Drawing.Size(112, 15);
            this.LblFirmenbezeichnung.TabIndex = 1;
            this.LblFirmenbezeichnung.Text = "Firmenbezeichnung";
            // 
            // TbFirmenbezeichnung
            // 
            this.TbFirmenbezeichnung.Location = new System.Drawing.Point(318, 31);
            this.TbFirmenbezeichnung.Name = "TbFirmenbezeichnung";
            this.TbFirmenbezeichnung.Size = new System.Drawing.Size(322, 23);
            this.TbFirmenbezeichnung.TabIndex = 1;
            this.TbFirmenbezeichnung.TextChanged += new System.EventHandler(this.TbFirmenbezeichnung_TextChanged);
            // 
            // LblStrasse
            // 
            this.LblStrasse.AutoSize = true;
            this.LblStrasse.Location = new System.Drawing.Point(318, 61);
            this.LblStrasse.Name = "LblStrasse";
            this.LblStrasse.Size = new System.Drawing.Size(43, 15);
            this.LblStrasse.TabIndex = 3;
            this.LblStrasse.Text = "Strasse";
            // 
            // TbStrasse
            // 
            this.TbStrasse.Location = new System.Drawing.Point(318, 80);
            this.TbStrasse.Name = "TbStrasse";
            this.TbStrasse.Size = new System.Drawing.Size(223, 23);
            this.TbStrasse.TabIndex = 2;
            // 
            // LblPostleitzahl
            // 
            this.LblPostleitzahl.AutoSize = true;
            this.LblPostleitzahl.Location = new System.Drawing.Point(318, 110);
            this.LblPostleitzahl.Name = "LblPostleitzahl";
            this.LblPostleitzahl.Size = new System.Drawing.Size(67, 15);
            this.LblPostleitzahl.TabIndex = 5;
            this.LblPostleitzahl.Text = "Postleitzahl";
            // 
            // TbPostleitzahl
            // 
            this.TbPostleitzahl.Location = new System.Drawing.Point(318, 129);
            this.TbPostleitzahl.Name = "TbPostleitzahl";
            this.TbPostleitzahl.Size = new System.Drawing.Size(100, 23);
            this.TbPostleitzahl.TabIndex = 4;
            // 
            // LblStadt
            // 
            this.LblStadt.AutoSize = true;
            this.LblStadt.Location = new System.Drawing.Point(425, 110);
            this.LblStadt.Name = "LblStadt";
            this.LblStadt.Size = new System.Drawing.Size(34, 15);
            this.LblStadt.TabIndex = 7;
            this.LblStadt.Text = "Stadt";
            // 
            // TbStadt
            // 
            this.TbStadt.Location = new System.Drawing.Point(425, 129);
            this.TbStadt.Name = "TbStadt";
            this.TbStadt.Size = new System.Drawing.Size(215, 23);
            this.TbStadt.TabIndex = 5;
            // 
            // LblLand
            // 
            this.LblLand.AutoSize = true;
            this.LblLand.Location = new System.Drawing.Point(318, 160);
            this.LblLand.Name = "LblLand";
            this.LblLand.Size = new System.Drawing.Size(33, 15);
            this.LblLand.TabIndex = 9;
            this.LblLand.Text = "Land";
            // 
            // TbLand
            // 
            this.TbLand.Location = new System.Drawing.Point(318, 178);
            this.TbLand.Name = "TbLand";
            this.TbLand.Size = new System.Drawing.Size(322, 23);
            this.TbLand.TabIndex = 10;
            // 
            // CmdFirmaSuchen
            // 
            this.CmdFirmaSuchen.Location = new System.Drawing.Point(318, 234);
            this.CmdFirmaSuchen.Name = "CmdFirmaSuchen";
            this.CmdFirmaSuchen.Size = new System.Drawing.Size(158, 23);
            this.CmdFirmaSuchen.TabIndex = 6;
            this.CmdFirmaSuchen.Text = "Suchen";
            this.CmdFirmaSuchen.UseVisualStyleBackColor = true;
            this.CmdFirmaSuchen.Click += new System.EventHandler(this.CmdFirmaSuchen_Click);
            // 
            // CmdFirmaEntfernen
            // 
            this.CmdFirmaEntfernen.Enabled = false;
            this.CmdFirmaEntfernen.Location = new System.Drawing.Point(482, 263);
            this.CmdFirmaEntfernen.Name = "CmdFirmaEntfernen";
            this.CmdFirmaEntfernen.Size = new System.Drawing.Size(158, 23);
            this.CmdFirmaEntfernen.TabIndex = 8;
            this.CmdFirmaEntfernen.Text = "Entfernen";
            this.CmdFirmaEntfernen.UseVisualStyleBackColor = true;
            this.CmdFirmaEntfernen.Click += new System.EventHandler(this.CmdFirmaEntfernen_Click);
            // 
            // CmdFirmaSpeichern
            // 
            this.CmdFirmaSpeichern.Enabled = false;
            this.CmdFirmaSpeichern.Location = new System.Drawing.Point(316, 263);
            this.CmdFirmaSpeichern.Name = "CmdFirmaSpeichern";
            this.CmdFirmaSpeichern.Size = new System.Drawing.Size(158, 23);
            this.CmdFirmaSpeichern.TabIndex = 7;
            this.CmdFirmaSpeichern.Text = "Änderungen speichern";
            this.CmdFirmaSpeichern.UseVisualStyleBackColor = true;
            this.CmdFirmaSpeichern.Click += new System.EventHandler(this.CmdFirmaSpeichern_Click);
            // 
            // CmdFirmaHinzufuegen
            // 
            this.CmdFirmaHinzufuegen.Enabled = false;
            this.CmdFirmaHinzufuegen.Location = new System.Drawing.Point(482, 234);
            this.CmdFirmaHinzufuegen.Name = "CmdFirmaHinzufuegen";
            this.CmdFirmaHinzufuegen.Size = new System.Drawing.Size(158, 23);
            this.CmdFirmaHinzufuegen.TabIndex = 9;
            this.CmdFirmaHinzufuegen.Text = "Neu hinzufügen";
            this.CmdFirmaHinzufuegen.UseVisualStyleBackColor = true;
            this.CmdFirmaHinzufuegen.Click += new System.EventHandler(this.CmdNeuFirmaHinzufuegen_Click);
            // 
            // LblHausnummer
            // 
            this.LblHausnummer.AutoSize = true;
            this.LblHausnummer.Location = new System.Drawing.Point(547, 61);
            this.LblHausnummer.Name = "LblHausnummer";
            this.LblHausnummer.Size = new System.Drawing.Size(80, 15);
            this.LblHausnummer.TabIndex = 26;
            this.LblHausnummer.Text = "Hausnummer";
            // 
            // TbHausnummer
            // 
            this.TbHausnummer.Location = new System.Drawing.Point(547, 80);
            this.TbHausnummer.Name = "TbHausnummer";
            this.TbHausnummer.Size = new System.Drawing.Size(93, 23);
            this.TbHausnummer.TabIndex = 3;
            // 
            // Firmenkartei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 340);
            this.Controls.Add(this.TbHausnummer);
            this.Controls.Add(this.LblHausnummer);
            this.Controls.Add(this.CmdFirmaSuchen);
            this.Controls.Add(this.CmdFirmaEntfernen);
            this.Controls.Add(this.CmdFirmaSpeichern);
            this.Controls.Add(this.CmdFirmaHinzufuegen);
            this.Controls.Add(this.TbLand);
            this.Controls.Add(this.LblLand);
            this.Controls.Add(this.TbStadt);
            this.Controls.Add(this.LblStadt);
            this.Controls.Add(this.TbPostleitzahl);
            this.Controls.Add(this.LblPostleitzahl);
            this.Controls.Add(this.TbStrasse);
            this.Controls.Add(this.LblStrasse);
            this.Controls.Add(this.TbFirmenbezeichnung);
            this.Controls.Add(this.LblFirmenbezeichnung);
            this.Controls.Add(this.LbFirmen);
            this.Name = "Firmenkartei";
            this.Text = "Firmenkartei";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbFirmen;
        private System.Windows.Forms.Label LblFirmenbezeichnung;
        private System.Windows.Forms.TextBox TbFirmenbezeichnung;
        private System.Windows.Forms.Label LblStrasse;
        private System.Windows.Forms.TextBox TbStrasse;
        private System.Windows.Forms.Label LblPostleitzahl;
        private System.Windows.Forms.TextBox TbPostleitzahl;
        private System.Windows.Forms.Label LblStadt;
        private System.Windows.Forms.TextBox TbStadt;
        private System.Windows.Forms.Label LblLand;
        private System.Windows.Forms.TextBox TbLand;
        private System.Windows.Forms.Button CmdFirmaSuchen;
        private System.Windows.Forms.Button CmdFirmaEntfernen;
        private System.Windows.Forms.Button CmdFirmaSpeichern;
        private System.Windows.Forms.Button CmdFirmaHinzufuegen;
        private System.Windows.Forms.Label LblHausnummer;
        private System.Windows.Forms.TextBox TbHausnummer;
    }
}