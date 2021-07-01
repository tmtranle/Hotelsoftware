
namespace Hotelsoftware
{
    partial class Zimmerplan
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
            this.dataGridViewZimmer = new System.Windows.Forms.DataGridView();
            this.z_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z_kategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdStatusAendern = new System.Windows.Forms.Button();
            this.GbAktuellerStatus = new System.Windows.Forms.GroupBox();
            this.RbAusserBetrieb = new System.Windows.Forms.RadioButton();
            this.RbDreckig = new System.Windows.Forms.RadioButton();
            this.RbZuChecken = new System.Windows.Forms.RadioButton();
            this.RbSauber = new System.Windows.Forms.RadioButton();
            this.RbAlle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZimmer)).BeginInit();
            this.GbAktuellerStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewZimmer
            // 
            this.dataGridViewZimmer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewZimmer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZimmer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.z_id,
            this.z_kategorie,
            this.z_status});
            this.dataGridViewZimmer.Location = new System.Drawing.Point(137, 12);
            this.dataGridViewZimmer.Name = "dataGridViewZimmer";
            this.dataGridViewZimmer.RowTemplate.Height = 25;
            this.dataGridViewZimmer.Size = new System.Drawing.Size(315, 756);
            this.dataGridViewZimmer.TabIndex = 0;
            // 
            // z_id
            // 
            this.z_id.HeaderText = "#";
            this.z_id.Name = "z_id";
            this.z_id.Width = 80;
            // 
            // z_kategorie
            // 
            this.z_kategorie.HeaderText = "Kategorie";
            this.z_kategorie.Name = "z_kategorie";
            // 
            // z_status
            // 
            this.z_status.HeaderText = "Status";
            this.z_status.Name = "z_status";
            // 
            // CmdStatusAendern
            // 
            this.CmdStatusAendern.Location = new System.Drawing.Point(12, 12);
            this.CmdStatusAendern.Name = "CmdStatusAendern";
            this.CmdStatusAendern.Size = new System.Drawing.Size(114, 23);
            this.CmdStatusAendern.TabIndex = 7;
            this.CmdStatusAendern.Text = "Status ändern";
            this.CmdStatusAendern.UseVisualStyleBackColor = true;
            this.CmdStatusAendern.Click += new System.EventHandler(this.CmdStatusAendern_Click);
            // 
            // GbAktuellerStatus
            // 
            this.GbAktuellerStatus.Controls.Add(this.RbAusserBetrieb);
            this.GbAktuellerStatus.Controls.Add(this.RbDreckig);
            this.GbAktuellerStatus.Controls.Add(this.RbZuChecken);
            this.GbAktuellerStatus.Controls.Add(this.RbSauber);
            this.GbAktuellerStatus.Controls.Add(this.RbAlle);
            this.GbAktuellerStatus.Location = new System.Drawing.Point(12, 41);
            this.GbAktuellerStatus.Name = "GbAktuellerStatus";
            this.GbAktuellerStatus.Size = new System.Drawing.Size(114, 163);
            this.GbAktuellerStatus.TabIndex = 12;
            this.GbAktuellerStatus.TabStop = false;
            this.GbAktuellerStatus.Text = "aktueller Status";
            // 
            // RbAusserBetrieb
            // 
            this.RbAusserBetrieb.AutoSize = true;
            this.RbAusserBetrieb.Location = new System.Drawing.Point(6, 48);
            this.RbAusserBetrieb.Name = "RbAusserBetrieb";
            this.RbAusserBetrieb.Size = new System.Drawing.Size(98, 19);
            this.RbAusserBetrieb.TabIndex = 4;
            this.RbAusserBetrieb.Text = "ausser Betrieb";
            this.RbAusserBetrieb.UseVisualStyleBackColor = true;
            this.RbAusserBetrieb.CheckedChanged += new System.EventHandler(this.RbAusserBetrieb_CheckedChanged);
            // 
            // RbDreckig
            // 
            this.RbDreckig.AutoSize = true;
            this.RbDreckig.Location = new System.Drawing.Point(6, 100);
            this.RbDreckig.Name = "RbDreckig";
            this.RbDreckig.Size = new System.Drawing.Size(64, 19);
            this.RbDreckig.TabIndex = 3;
            this.RbDreckig.Text = "dreckig";
            this.RbDreckig.UseVisualStyleBackColor = true;
            this.RbDreckig.CheckedChanged += new System.EventHandler(this.RbDreckig_CheckedChanged);
            // 
            // RbZuChecken
            // 
            this.RbZuChecken.AutoSize = true;
            this.RbZuChecken.Location = new System.Drawing.Point(6, 74);
            this.RbZuChecken.Name = "RbZuChecken";
            this.RbZuChecken.Size = new System.Drawing.Size(84, 19);
            this.RbZuChecken.TabIndex = 2;
            this.RbZuChecken.Text = "zu checken";
            this.RbZuChecken.UseVisualStyleBackColor = true;
            this.RbZuChecken.CheckedChanged += new System.EventHandler(this.RbZuChecken_CheckedChanged);
            // 
            // RbSauber
            // 
            this.RbSauber.AutoSize = true;
            this.RbSauber.Location = new System.Drawing.Point(6, 126);
            this.RbSauber.Name = "RbSauber";
            this.RbSauber.Size = new System.Drawing.Size(60, 19);
            this.RbSauber.TabIndex = 1;
            this.RbSauber.Text = "sauber";
            this.RbSauber.UseVisualStyleBackColor = true;
            this.RbSauber.CheckedChanged += new System.EventHandler(this.RbSauber_CheckedChanged);
            // 
            // RbAlle
            // 
            this.RbAlle.AutoSize = true;
            this.RbAlle.Checked = true;
            this.RbAlle.Location = new System.Drawing.Point(6, 22);
            this.RbAlle.Name = "RbAlle";
            this.RbAlle.Size = new System.Drawing.Size(43, 19);
            this.RbAlle.TabIndex = 0;
            this.RbAlle.TabStop = true;
            this.RbAlle.Text = "alle";
            this.RbAlle.UseVisualStyleBackColor = true;
            this.RbAlle.CheckedChanged += new System.EventHandler(this.RbAlle_CheckedChanged);
            // 
            // Zimmerplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 785);
            this.Controls.Add(this.GbAktuellerStatus);
            this.Controls.Add(this.CmdStatusAendern);
            this.Controls.Add(this.dataGridViewZimmer);
            this.Name = "Zimmerplan";
            this.Text = "Zimmerplan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZimmer)).EndInit();
            this.GbAktuellerStatus.ResumeLayout(false);
            this.GbAktuellerStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZimmer;
        private System.Windows.Forms.Button CmdStatusAendern;
        private System.Windows.Forms.GroupBox GbAktuellerStatus;
        private System.Windows.Forms.RadioButton RbAusserBetrieb;
        private System.Windows.Forms.RadioButton RbDreckig;
        private System.Windows.Forms.RadioButton RbZuChecken;
        private System.Windows.Forms.RadioButton RbSauber;
        private System.Windows.Forms.RadioButton RbAlle;
        private System.Windows.Forms.DataGridViewTextBoxColumn z_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn z_kategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn z_status;
    }
}