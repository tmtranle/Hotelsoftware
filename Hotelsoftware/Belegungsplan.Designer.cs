
namespace Hotelsoftware
{
    partial class Belegungsplan
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
            this.dataGridViewReservierungen = new System.Windows.Forms.DataGridView();
            this.r_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerBelegunsplan = new System.Windows.Forms.DateTimePicker();
            this.RbAlle = new System.Windows.Forms.RadioButton();
            this.RbGarantiert = new System.Windows.Forms.RadioButton();
            this.RbOption = new System.Windows.Forms.RadioButton();
            this.RbNoShow = new System.Windows.Forms.RadioButton();
            this.RbStorniert = new System.Windows.Forms.RadioButton();
            this.GbReservierungenStatus = new System.Windows.Forms.GroupBox();
            this.GbReservierungAktionen = new System.Windows.Forms.GroupBox();
            this.CmdResCheckInDialog = new System.Windows.Forms.Button();
            this.CmdResStornieren = new System.Windows.Forms.Button();
            this.CmdResBearbeiten = new System.Windows.Forms.Button();
            this.CmdResNeuHinzufuegen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservierungen)).BeginInit();
            this.GbReservierungenStatus.SuspendLayout();
            this.GbReservierungAktionen.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewReservierungen
            // 
            this.dataGridViewReservierungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservierungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.r_id,
            this.z_id,
            this.g_nachname,
            this.g_vorname,
            this.checkIn,
            this.checkOut,
            this.r_status});
            this.dataGridViewReservierungen.Location = new System.Drawing.Point(229, 12);
            this.dataGridViewReservierungen.Name = "dataGridViewReservierungen";
            this.dataGridViewReservierungen.RowTemplate.Height = 25;
            this.dataGridViewReservierungen.Size = new System.Drawing.Size(740, 776);
            this.dataGridViewReservierungen.TabIndex = 0;
            // 
            // r_id
            // 
            this.r_id.HeaderText = "Reservierungsnr.";
            this.r_id.Name = "r_id";
            // 
            // z_id
            // 
            this.z_id.HeaderText = "#";
            this.z_id.Name = "z_id";
            // 
            // g_nachname
            // 
            this.g_nachname.HeaderText = "Nachname";
            this.g_nachname.Name = "g_nachname";
            // 
            // g_vorname
            // 
            this.g_vorname.HeaderText = "Vorname";
            this.g_vorname.Name = "g_vorname";
            // 
            // checkIn
            // 
            this.checkIn.HeaderText = "Check-In";
            this.checkIn.Name = "checkIn";
            // 
            // checkOut
            // 
            this.checkOut.HeaderText = "Check-Out";
            this.checkOut.Name = "checkOut";
            // 
            // r_status
            // 
            this.r_status.HeaderText = "Status";
            this.r_status.Name = "r_status";
            // 
            // dateTimePickerBelegunsplan
            // 
            this.dateTimePickerBelegunsplan.Location = new System.Drawing.Point(12, 37);
            this.dateTimePickerBelegunsplan.Name = "dateTimePickerBelegunsplan";
            this.dateTimePickerBelegunsplan.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerBelegunsplan.TabIndex = 1;
            // 
            // RbAlle
            // 
            this.RbAlle.AutoSize = true;
            this.RbAlle.Checked = true;
            this.RbAlle.Location = new System.Drawing.Point(6, 22);
            this.RbAlle.Name = "RbAlle";
            this.RbAlle.Size = new System.Drawing.Size(43, 19);
            this.RbAlle.TabIndex = 3;
            this.RbAlle.TabStop = true;
            this.RbAlle.Text = "alle";
            this.RbAlle.UseVisualStyleBackColor = true;
            this.RbAlle.CheckedChanged += new System.EventHandler(this.RbAlle_CheckedChanged);
            // 
            // RbGarantiert
            // 
            this.RbGarantiert.AutoSize = true;
            this.RbGarantiert.Location = new System.Drawing.Point(6, 47);
            this.RbGarantiert.Name = "RbGarantiert";
            this.RbGarantiert.Size = new System.Drawing.Size(76, 19);
            this.RbGarantiert.TabIndex = 4;
            this.RbGarantiert.Text = "garantiert";
            this.RbGarantiert.UseVisualStyleBackColor = true;
            this.RbGarantiert.CheckedChanged += new System.EventHandler(this.RbGarantiert_CheckedChanged);
            // 
            // RbOption
            // 
            this.RbOption.AutoSize = true;
            this.RbOption.Location = new System.Drawing.Point(6, 97);
            this.RbOption.Name = "RbOption";
            this.RbOption.Size = new System.Drawing.Size(62, 19);
            this.RbOption.TabIndex = 5;
            this.RbOption.Text = "Option";
            this.RbOption.UseVisualStyleBackColor = true;
            this.RbOption.CheckedChanged += new System.EventHandler(this.RbOption_CheckedChanged);
            // 
            // RbNoShow
            // 
            this.RbNoShow.AutoSize = true;
            this.RbNoShow.Location = new System.Drawing.Point(6, 72);
            this.RbNoShow.Name = "RbNoShow";
            this.RbNoShow.Size = new System.Drawing.Size(70, 19);
            this.RbNoShow.TabIndex = 6;
            this.RbNoShow.Text = "NoShow";
            this.RbNoShow.UseVisualStyleBackColor = true;
            this.RbNoShow.CheckedChanged += new System.EventHandler(this.RbNoShow_CheckedChanged);
            // 
            // RbStorniert
            // 
            this.RbStorniert.AutoSize = true;
            this.RbStorniert.Location = new System.Drawing.Point(6, 122);
            this.RbStorniert.Name = "RbStorniert";
            this.RbStorniert.Size = new System.Drawing.Size(69, 19);
            this.RbStorniert.TabIndex = 7;
            this.RbStorniert.Text = "storniert";
            this.RbStorniert.UseVisualStyleBackColor = true;
            this.RbStorniert.CheckedChanged += new System.EventHandler(this.RbStorniert_CheckedChanged);
            // 
            // GbReservierungenStatus
            // 
            this.GbReservierungenStatus.Controls.Add(this.RbAlle);
            this.GbReservierungenStatus.Controls.Add(this.RbStorniert);
            this.GbReservierungenStatus.Controls.Add(this.RbGarantiert);
            this.GbReservierungenStatus.Controls.Add(this.RbNoShow);
            this.GbReservierungenStatus.Controls.Add(this.RbOption);
            this.GbReservierungenStatus.Location = new System.Drawing.Point(12, 66);
            this.GbReservierungenStatus.Name = "GbReservierungenStatus";
            this.GbReservierungenStatus.Size = new System.Drawing.Size(200, 153);
            this.GbReservierungenStatus.TabIndex = 8;
            this.GbReservierungenStatus.TabStop = false;
            this.GbReservierungenStatus.Text = "Reservierungen nach Status";
            // 
            // GbReservierungAktionen
            // 
            this.GbReservierungAktionen.Controls.Add(this.CmdResCheckInDialog);
            this.GbReservierungAktionen.Controls.Add(this.CmdResStornieren);
            this.GbReservierungAktionen.Controls.Add(this.CmdResBearbeiten);
            this.GbReservierungAktionen.Controls.Add(this.CmdResNeuHinzufuegen);
            this.GbReservierungAktionen.Location = new System.Drawing.Point(12, 225);
            this.GbReservierungAktionen.Name = "GbReservierungAktionen";
            this.GbReservierungAktionen.Size = new System.Drawing.Size(200, 148);
            this.GbReservierungAktionen.TabIndex = 9;
            this.GbReservierungAktionen.TabStop = false;
            this.GbReservierungAktionen.Text = "Reservierung";
            // 
            // CmdResCheckInDialog
            // 
            this.CmdResCheckInDialog.Location = new System.Drawing.Point(7, 110);
            this.CmdResCheckInDialog.Name = "CmdResCheckInDialog";
            this.CmdResCheckInDialog.Size = new System.Drawing.Size(187, 23);
            this.CmdResCheckInDialog.TabIndex = 10;
            this.CmdResCheckInDialog.Text = "Check-In Dialog öffnen";
            this.CmdResCheckInDialog.UseVisualStyleBackColor = true;
            this.CmdResCheckInDialog.Click += new System.EventHandler(this.CmdResCheckInDialog_Click);
            // 
            // CmdResStornieren
            // 
            this.CmdResStornieren.Location = new System.Drawing.Point(7, 81);
            this.CmdResStornieren.Name = "CmdResStornieren";
            this.CmdResStornieren.Size = new System.Drawing.Size(187, 23);
            this.CmdResStornieren.TabIndex = 2;
            this.CmdResStornieren.Text = "Stornieren";
            this.CmdResStornieren.UseVisualStyleBackColor = true;
            // 
            // CmdResBearbeiten
            // 
            this.CmdResBearbeiten.Location = new System.Drawing.Point(7, 52);
            this.CmdResBearbeiten.Name = "CmdResBearbeiten";
            this.CmdResBearbeiten.Size = new System.Drawing.Size(187, 23);
            this.CmdResBearbeiten.TabIndex = 1;
            this.CmdResBearbeiten.Text = "Bearbeiten";
            this.CmdResBearbeiten.UseVisualStyleBackColor = true;
            // 
            // CmdResNeuHinzufuegen
            // 
            this.CmdResNeuHinzufuegen.Location = new System.Drawing.Point(7, 23);
            this.CmdResNeuHinzufuegen.Name = "CmdResNeuHinzufuegen";
            this.CmdResNeuHinzufuegen.Size = new System.Drawing.Size(187, 23);
            this.CmdResNeuHinzufuegen.TabIndex = 0;
            this.CmdResNeuHinzufuegen.Text = "Neu hinzufügen";
            this.CmdResNeuHinzufuegen.UseVisualStyleBackColor = true;
            this.CmdResNeuHinzufuegen.Click += new System.EventHandler(this.CmdResNeuHinzufuegen_Click);
            // 
            // Belegungsplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 800);
            this.Controls.Add(this.GbReservierungAktionen);
            this.Controls.Add(this.GbReservierungenStatus);
            this.Controls.Add(this.dateTimePickerBelegunsplan);
            this.Controls.Add(this.dataGridViewReservierungen);
            this.Name = "Belegungsplan";
            this.Text = "Belegungsplan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservierungen)).EndInit();
            this.GbReservierungenStatus.ResumeLayout(false);
            this.GbReservierungenStatus.PerformLayout();
            this.GbReservierungAktionen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReservierungen;
        private System.Windows.Forms.DateTimePicker dateTimePickerBelegunsplan;
        private System.Windows.Forms.RadioButton RbAlle;
        private System.Windows.Forms.RadioButton RbGarantiert;
        private System.Windows.Forms.RadioButton RbOption;
        private System.Windows.Forms.RadioButton RbNoShow;
        private System.Windows.Forms.RadioButton RbStorniert;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn z_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_status;
        private System.Windows.Forms.GroupBox GbReservierungenStatus;
        private System.Windows.Forms.GroupBox GbReservierungAktionen;
        private System.Windows.Forms.Button CmdResNeuHinzufuegen;
        private System.Windows.Forms.Button CmdResBearbeiten;
        private System.Windows.Forms.Button CmdResStornieren;
        private System.Windows.Forms.Button CmdResCheckInDialog;
    }
}