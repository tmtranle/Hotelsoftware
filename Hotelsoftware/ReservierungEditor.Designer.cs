
namespace Hotelsoftware
{
    partial class ReservierungEditor
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
            this.GbZimmer = new System.Windows.Forms.GroupBox();
            this.CbZimmerStatus = new System.Windows.Forms.ComboBox();
            this.CbZimmerNummer = new System.Windows.Forms.ComboBox();
            this.CbZimmerKategorie = new System.Windows.Forms.ComboBox();
            this.LblZimmerStatus = new System.Windows.Forms.Label();
            this.LblZimmerKategorie = new System.Windows.Forms.Label();
            this.LblZimmerNummer = new System.Windows.Forms.Label();
            this.GbReservierungsdaten = new System.Windows.Forms.GroupBox();
            this.CbReserStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerAbreise = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAnreise = new System.Windows.Forms.DateTimePicker();
            this.LblReserStatus = new System.Windows.Forms.Label();
            this.LblAbreise = new System.Windows.Forms.Label();
            this.TbReserNummer = new System.Windows.Forms.TextBox();
            this.LblAnreise = new System.Windows.Forms.Label();
            this.LblReserNummer = new System.Windows.Forms.Label();
            this.CmdResNeuHinzufuegen = new System.Windows.Forms.Button();
            this.CmdResAendern = new System.Windows.Forms.Button();
            this.CmdAbbruch = new System.Windows.Forms.Button();
            this.CmdResLeistungen = new System.Windows.Forms.Button();
            this.GbFixleistungen = new System.Windows.Forms.GroupBox();
            this.dataGridViewFixleistungen = new System.Windows.Forms.DataGridView();
            this.GbGastdaten = new System.Windows.Forms.GroupBox();
            this.TbVersteckt_g_id = new System.Windows.Forms.TextBox();
            this.Lbl_g_id = new System.Windows.Forms.Label();
            this.dateTimePickerGeburtstag = new System.Windows.Forms.DateTimePicker();
            this.LblGebDatum = new System.Windows.Forms.Label();
            this.TbVorname = new System.Windows.Forms.TextBox();
            this.LblVorname = new System.Windows.Forms.Label();
            this.TbNachname = new System.Windows.Forms.TextBox();
            this.LblNachname = new System.Windows.Forms.Label();
            this.CmdReserSuchen = new System.Windows.Forms.Button();
            this.CmdGaestekartei = new System.Windows.Forms.Button();
            this.GbZimmer.SuspendLayout();
            this.GbReservierungsdaten.SuspendLayout();
            this.GbFixleistungen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFixleistungen)).BeginInit();
            this.GbGastdaten.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbZimmer
            // 
            this.GbZimmer.Controls.Add(this.CbZimmerStatus);
            this.GbZimmer.Controls.Add(this.CbZimmerNummer);
            this.GbZimmer.Controls.Add(this.CbZimmerKategorie);
            this.GbZimmer.Controls.Add(this.LblZimmerStatus);
            this.GbZimmer.Controls.Add(this.LblZimmerKategorie);
            this.GbZimmer.Controls.Add(this.LblZimmerNummer);
            this.GbZimmer.Location = new System.Drawing.Point(297, 12);
            this.GbZimmer.Name = "GbZimmer";
            this.GbZimmer.Size = new System.Drawing.Size(190, 170);
            this.GbZimmer.TabIndex = 1;
            this.GbZimmer.TabStop = false;
            this.GbZimmer.Text = "Zimmer";
            // 
            // CbZimmerStatus
            // 
            this.CbZimmerStatus.FormattingEnabled = true;
            this.CbZimmerStatus.Items.AddRange(new object[] {
            "ausser Betrieb",
            "zu checken",
            "dreckig",
            "sauber"});
            this.CbZimmerStatus.Location = new System.Drawing.Point(70, 89);
            this.CbZimmerStatus.Name = "CbZimmerStatus";
            this.CbZimmerStatus.Size = new System.Drawing.Size(107, 23);
            this.CbZimmerStatus.TabIndex = 16;
            // 
            // CbZimmerNummer
            // 
            this.CbZimmerNummer.FormattingEnabled = true;
            this.CbZimmerNummer.Items.AddRange(new object[] {
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "114",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "214"});
            this.CbZimmerNummer.Location = new System.Drawing.Point(70, 60);
            this.CbZimmerNummer.Name = "CbZimmerNummer";
            this.CbZimmerNummer.Size = new System.Drawing.Size(107, 23);
            this.CbZimmerNummer.TabIndex = 15;
            // 
            // CbZimmerKategorie
            // 
            this.CbZimmerKategorie.FormattingEnabled = true;
            this.CbZimmerKategorie.Items.AddRange(new object[] {
            "EZ",
            "DZ",
            "TRI"});
            this.CbZimmerKategorie.Location = new System.Drawing.Point(70, 31);
            this.CbZimmerKategorie.Name = "CbZimmerKategorie";
            this.CbZimmerKategorie.Size = new System.Drawing.Size(107, 23);
            this.CbZimmerKategorie.TabIndex = 14;
            // 
            // LblZimmerStatus
            // 
            this.LblZimmerStatus.AutoSize = true;
            this.LblZimmerStatus.Location = new System.Drawing.Point(6, 92);
            this.LblZimmerStatus.Name = "LblZimmerStatus";
            this.LblZimmerStatus.Size = new System.Drawing.Size(39, 15);
            this.LblZimmerStatus.TabIndex = 13;
            this.LblZimmerStatus.Text = "Status";
            // 
            // LblZimmerKategorie
            // 
            this.LblZimmerKategorie.AutoSize = true;
            this.LblZimmerKategorie.Location = new System.Drawing.Point(6, 34);
            this.LblZimmerKategorie.Name = "LblZimmerKategorie";
            this.LblZimmerKategorie.Size = new System.Drawing.Size(57, 15);
            this.LblZimmerKategorie.TabIndex = 10;
            this.LblZimmerKategorie.Text = "Kategorie";
            // 
            // LblZimmerNummer
            // 
            this.LblZimmerNummer.AutoSize = true;
            this.LblZimmerNummer.Location = new System.Drawing.Point(6, 63);
            this.LblZimmerNummer.Name = "LblZimmerNummer";
            this.LblZimmerNummer.Size = new System.Drawing.Size(55, 15);
            this.LblZimmerNummer.TabIndex = 0;
            this.LblZimmerNummer.Text = "Nummer";
            // 
            // GbReservierungsdaten
            // 
            this.GbReservierungsdaten.Controls.Add(this.CbReserStatus);
            this.GbReservierungsdaten.Controls.Add(this.dateTimePickerAbreise);
            this.GbReservierungsdaten.Controls.Add(this.dateTimePickerAnreise);
            this.GbReservierungsdaten.Controls.Add(this.LblReserStatus);
            this.GbReservierungsdaten.Controls.Add(this.LblAbreise);
            this.GbReservierungsdaten.Controls.Add(this.TbReserNummer);
            this.GbReservierungsdaten.Controls.Add(this.LblAnreise);
            this.GbReservierungsdaten.Controls.Add(this.LblReserNummer);
            this.GbReservierungsdaten.Location = new System.Drawing.Point(12, 12);
            this.GbReservierungsdaten.Name = "GbReservierungsdaten";
            this.GbReservierungsdaten.Size = new System.Drawing.Size(279, 170);
            this.GbReservierungsdaten.TabIndex = 2;
            this.GbReservierungsdaten.TabStop = false;
            this.GbReservierungsdaten.Text = "Reservierungsdaten";
            // 
            // CbReserStatus
            // 
            this.CbReserStatus.FormattingEnabled = true;
            this.CbReserStatus.Items.AddRange(new object[] {
            "garantiert",
            "NoShow",
            "Option",
            "storniert"});
            this.CbReserStatus.Location = new System.Drawing.Point(68, 57);
            this.CbReserStatus.Name = "CbReserStatus";
            this.CbReserStatus.Size = new System.Drawing.Size(121, 23);
            this.CbReserStatus.TabIndex = 7;
            // 
            // dateTimePickerAbreise
            // 
            this.dateTimePickerAbreise.Location = new System.Drawing.Point(68, 122);
            this.dateTimePickerAbreise.Name = "dateTimePickerAbreise";
            this.dateTimePickerAbreise.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerAbreise.TabIndex = 0;
            // 
            // dateTimePickerAnreise
            // 
            this.dateTimePickerAnreise.Location = new System.Drawing.Point(68, 93);
            this.dateTimePickerAnreise.Name = "dateTimePickerAnreise";
            this.dateTimePickerAnreise.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerAnreise.TabIndex = 0;
            // 
            // LblReserStatus
            // 
            this.LblReserStatus.AutoSize = true;
            this.LblReserStatus.Location = new System.Drawing.Point(8, 60);
            this.LblReserStatus.Name = "LblReserStatus";
            this.LblReserStatus.Size = new System.Drawing.Size(39, 15);
            this.LblReserStatus.TabIndex = 6;
            this.LblReserStatus.Text = "Status";
            // 
            // LblAbreise
            // 
            this.LblAbreise.AutoSize = true;
            this.LblAbreise.Location = new System.Drawing.Point(8, 123);
            this.LblAbreise.Name = "LblAbreise";
            this.LblAbreise.Size = new System.Drawing.Size(46, 15);
            this.LblAbreise.TabIndex = 4;
            this.LblAbreise.Text = "Abreise";
            // 
            // TbReserNummer
            // 
            this.TbReserNummer.Location = new System.Drawing.Point(68, 22);
            this.TbReserNummer.Name = "TbReserNummer";
            this.TbReserNummer.Size = new System.Drawing.Size(121, 23);
            this.TbReserNummer.TabIndex = 0;
            // 
            // LblAnreise
            // 
            this.LblAnreise.AutoSize = true;
            this.LblAnreise.Location = new System.Drawing.Point(8, 100);
            this.LblAnreise.Name = "LblAnreise";
            this.LblAnreise.Size = new System.Drawing.Size(46, 15);
            this.LblAnreise.TabIndex = 1;
            this.LblAnreise.Text = "Anreise";
            // 
            // LblReserNummer
            // 
            this.LblReserNummer.AutoSize = true;
            this.LblReserNummer.Location = new System.Drawing.Point(7, 26);
            this.LblReserNummer.Name = "LblReserNummer";
            this.LblReserNummer.Size = new System.Drawing.Size(55, 15);
            this.LblReserNummer.TabIndex = 0;
            this.LblReserNummer.Text = "Nummer";
            // 
            // CmdResNeuHinzufuegen
            // 
            this.CmdResNeuHinzufuegen.Location = new System.Drawing.Point(504, 19);
            this.CmdResNeuHinzufuegen.Name = "CmdResNeuHinzufuegen";
            this.CmdResNeuHinzufuegen.Size = new System.Drawing.Size(110, 23);
            this.CmdResNeuHinzufuegen.TabIndex = 3;
            this.CmdResNeuHinzufuegen.Text = "Res. hinzufügen";
            this.CmdResNeuHinzufuegen.UseVisualStyleBackColor = true;
            this.CmdResNeuHinzufuegen.Click += new System.EventHandler(this.CmdResNeuHinzufuegen_Click);
            // 
            // CmdResAendern
            // 
            this.CmdResAendern.Location = new System.Drawing.Point(504, 48);
            this.CmdResAendern.Name = "CmdResAendern";
            this.CmdResAendern.Size = new System.Drawing.Size(110, 23);
            this.CmdResAendern.TabIndex = 4;
            this.CmdResAendern.Text = "Res. ändern";
            this.CmdResAendern.UseVisualStyleBackColor = true;
            this.CmdResAendern.Click += new System.EventHandler(this.CmdResAendern_Click);
            // 
            // CmdAbbruch
            // 
            this.CmdAbbruch.Location = new System.Drawing.Point(504, 164);
            this.CmdAbbruch.Name = "CmdAbbruch";
            this.CmdAbbruch.Size = new System.Drawing.Size(110, 23);
            this.CmdAbbruch.TabIndex = 5;
            this.CmdAbbruch.Text = "Abbruch";
            this.CmdAbbruch.UseVisualStyleBackColor = true;
            this.CmdAbbruch.Click += new System.EventHandler(this.CmdAbbruch_Click);
            // 
            // CmdResLeistungen
            // 
            this.CmdResLeistungen.Location = new System.Drawing.Point(504, 135);
            this.CmdResLeistungen.Name = "CmdResLeistungen";
            this.CmdResLeistungen.Size = new System.Drawing.Size(110, 23);
            this.CmdResLeistungen.TabIndex = 6;
            this.CmdResLeistungen.Text = "Leistungen";
            this.CmdResLeistungen.UseVisualStyleBackColor = true;
            this.CmdResLeistungen.Click += new System.EventHandler(this.CmdResFixleistungen_Click);
            // 
            // GbFixleistungen
            // 
            this.GbFixleistungen.Controls.Add(this.dataGridViewFixleistungen);
            this.GbFixleistungen.Location = new System.Drawing.Point(13, 276);
            this.GbFixleistungen.Name = "GbFixleistungen";
            this.GbFixleistungen.Size = new System.Drawing.Size(474, 205);
            this.GbFixleistungen.TabIndex = 7;
            this.GbFixleistungen.TabStop = false;
            this.GbFixleistungen.Text = "Fixleistungen";
            // 
            // dataGridViewFixleistungen
            // 
            this.dataGridViewFixleistungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFixleistungen.Location = new System.Drawing.Point(7, 15);
            this.dataGridViewFixleistungen.Name = "dataGridViewFixleistungen";
            this.dataGridViewFixleistungen.RowTemplate.Height = 25;
            this.dataGridViewFixleistungen.Size = new System.Drawing.Size(461, 184);
            this.dataGridViewFixleistungen.TabIndex = 0;
            // 
            // GbGastdaten
            // 
            this.GbGastdaten.Controls.Add(this.TbVersteckt_g_id);
            this.GbGastdaten.Controls.Add(this.Lbl_g_id);
            this.GbGastdaten.Controls.Add(this.dateTimePickerGeburtstag);
            this.GbGastdaten.Controls.Add(this.LblGebDatum);
            this.GbGastdaten.Controls.Add(this.TbVorname);
            this.GbGastdaten.Controls.Add(this.LblVorname);
            this.GbGastdaten.Controls.Add(this.TbNachname);
            this.GbGastdaten.Controls.Add(this.LblNachname);
            this.GbGastdaten.Location = new System.Drawing.Point(13, 188);
            this.GbGastdaten.Name = "GbGastdaten";
            this.GbGastdaten.Size = new System.Drawing.Size(474, 82);
            this.GbGastdaten.TabIndex = 8;
            this.GbGastdaten.TabStop = false;
            this.GbGastdaten.Text = "Gast";
            // 
            // TbVersteckt_g_id
            // 
            this.TbVersteckt_g_id.Location = new System.Drawing.Point(382, 20);
            this.TbVersteckt_g_id.Name = "TbVersteckt_g_id";
            this.TbVersteckt_g_id.Size = new System.Drawing.Size(58, 23);
            this.TbVersteckt_g_id.TabIndex = 10;
            this.TbVersteckt_g_id.Visible = false;
            // 
            // Lbl_g_id
            // 
            this.Lbl_g_id.AutoSize = true;
            this.Lbl_g_id.Location = new System.Drawing.Point(347, 28);
            this.Lbl_g_id.Name = "Lbl_g_id";
            this.Lbl_g_id.Size = new System.Drawing.Size(29, 15);
            this.Lbl_g_id.TabIndex = 9;
            this.Lbl_g_id.Text = "g_id";
            this.Lbl_g_id.Visible = false;
            // 
            // dateTimePickerGeburtstag
            // 
            this.dateTimePickerGeburtstag.Location = new System.Drawing.Point(240, 49);
            this.dateTimePickerGeburtstag.Name = "dateTimePickerGeburtstag";
            this.dateTimePickerGeburtstag.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerGeburtstag.TabIndex = 7;
            // 
            // LblGebDatum
            // 
            this.LblGebDatum.AutoSize = true;
            this.LblGebDatum.Location = new System.Drawing.Point(238, 31);
            this.LblGebDatum.Name = "LblGebDatum";
            this.LblGebDatum.Size = new System.Drawing.Size(83, 15);
            this.LblGebDatum.TabIndex = 6;
            this.LblGebDatum.Text = "Geburtsdatum";
            // 
            // TbVorname
            // 
            this.TbVorname.Location = new System.Drawing.Point(78, 49);
            this.TbVorname.Name = "TbVorname";
            this.TbVorname.Size = new System.Drawing.Size(148, 23);
            this.TbVorname.TabIndex = 5;
            // 
            // LblVorname
            // 
            this.LblVorname.AutoSize = true;
            this.LblVorname.Location = new System.Drawing.Point(7, 52);
            this.LblVorname.Name = "LblVorname";
            this.LblVorname.Size = new System.Drawing.Size(54, 15);
            this.LblVorname.TabIndex = 4;
            this.LblVorname.Text = "Vorname";
            // 
            // TbNachname
            // 
            this.TbNachname.Location = new System.Drawing.Point(78, 20);
            this.TbNachname.Name = "TbNachname";
            this.TbNachname.Size = new System.Drawing.Size(148, 23);
            this.TbNachname.TabIndex = 3;
            // 
            // LblNachname
            // 
            this.LblNachname.AutoSize = true;
            this.LblNachname.Location = new System.Drawing.Point(7, 23);
            this.LblNachname.Name = "LblNachname";
            this.LblNachname.Size = new System.Drawing.Size(65, 15);
            this.LblNachname.TabIndex = 0;
            this.LblNachname.Text = "Nachname";
            // 
            // CmdReserSuchen
            // 
            this.CmdReserSuchen.Location = new System.Drawing.Point(504, 77);
            this.CmdReserSuchen.Name = "CmdReserSuchen";
            this.CmdReserSuchen.Size = new System.Drawing.Size(110, 23);
            this.CmdReserSuchen.TabIndex = 9;
            this.CmdReserSuchen.Text = "Res. suchen";
            this.CmdReserSuchen.UseVisualStyleBackColor = true;
            this.CmdReserSuchen.Click += new System.EventHandler(this.CmdReserSuchen_Click);
            // 
            // CmdGaestekartei
            // 
            this.CmdGaestekartei.Location = new System.Drawing.Point(504, 106);
            this.CmdGaestekartei.Name = "CmdGaestekartei";
            this.CmdGaestekartei.Size = new System.Drawing.Size(110, 23);
            this.CmdGaestekartei.TabIndex = 10;
            this.CmdGaestekartei.Text = "Gästekartei";
            this.CmdGaestekartei.UseVisualStyleBackColor = true;
            this.CmdGaestekartei.Click += new System.EventHandler(this.CmdGaestekartei_Click);
            // 
            // ReservierungEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 491);
            this.Controls.Add(this.CmdGaestekartei);
            this.Controls.Add(this.CmdReserSuchen);
            this.Controls.Add(this.GbGastdaten);
            this.Controls.Add(this.GbFixleistungen);
            this.Controls.Add(this.CmdResLeistungen);
            this.Controls.Add(this.CmdAbbruch);
            this.Controls.Add(this.CmdResAendern);
            this.Controls.Add(this.CmdResNeuHinzufuegen);
            this.Controls.Add(this.GbReservierungsdaten);
            this.Controls.Add(this.GbZimmer);
            this.Name = "ReservierungEditor";
            this.Text = "ReservierungEditor";
            this.GbZimmer.ResumeLayout(false);
            this.GbZimmer.PerformLayout();
            this.GbReservierungsdaten.ResumeLayout(false);
            this.GbReservierungsdaten.PerformLayout();
            this.GbFixleistungen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFixleistungen)).EndInit();
            this.GbGastdaten.ResumeLayout(false);
            this.GbGastdaten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbZimmer;
        private System.Windows.Forms.GroupBox GbReservierungsdaten;
        private System.Windows.Forms.Button CmdResNeuHinzufuegen;
        private System.Windows.Forms.Button CmdResAendern;
        private System.Windows.Forms.Button CmdAbbruch;
        private System.Windows.Forms.Button CmdResLeistungen;
        private System.Windows.Forms.Label LblZimmerNummer;
        private System.Windows.Forms.Label LblReserStatus;
        private System.Windows.Forms.Label LblAbreise;
        private System.Windows.Forms.TextBox TbReserNummer;
        private System.Windows.Forms.Label LblAnreise;
        private System.Windows.Forms.Label LblReserNummer;
        private System.Windows.Forms.Label LblZimmerKategorie;
        private System.Windows.Forms.GroupBox GbFixleistungen;
        private System.Windows.Forms.DataGridView dataGridViewFixleistungen;
        private System.Windows.Forms.Label LblZimmerStatus;
        private System.Windows.Forms.ComboBox CbZimmerStatus;
        private System.Windows.Forms.ComboBox CbZimmerNummer;
        private System.Windows.Forms.ComboBox CbZimmerKategorie;
        private System.Windows.Forms.GroupBox GbGastdaten;
        private System.Windows.Forms.DateTimePicker dateTimePickerAbreise;
        private System.Windows.Forms.DateTimePicker dateTimePickerAnreise;
        private System.Windows.Forms.TextBox TbNachname;
        private System.Windows.Forms.Label LblNachname;
        private System.Windows.Forms.TextBox TbVorname;
        private System.Windows.Forms.Label LblVorname;
        private System.Windows.Forms.DateTimePicker dateTimePickerGeburtstag;
        private System.Windows.Forms.Label LblGebDatum;
        private System.Windows.Forms.Button CmdReserSuchen;
        private System.Windows.Forms.Button CmdGaestekartei;
        private System.Windows.Forms.ComboBox CbReserStatus;
        private System.Windows.Forms.Label Lbl_g_id;
        private System.Windows.Forms.TextBox TbVersteckt_g_id;
    }
}