
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
            this.Kategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdZimmerplan = new System.Windows.Forms.Button();
            this.LblAktuellerStatus = new System.Windows.Forms.Label();
            this.RBsauber = new System.Windows.Forms.RadioButton();
            this.RBzuChecken = new System.Windows.Forms.RadioButton();
            this.RBdreckig = new System.Windows.Forms.RadioButton();
            this.RBalle = new System.Windows.Forms.RadioButton();
            this.CmdStatusAendern = new System.Windows.Forms.Button();
            this.CmdAnreise = new System.Windows.Forms.Button();
            this.CmdAbreise = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZimmer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZimmer
            // 
            this.dataGridViewZimmer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewZimmer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZimmer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.z_id,
            this.Kategorie,
            this.Status});
            this.dataGridViewZimmer.Location = new System.Drawing.Point(120, 42);
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
            // Kategorie
            // 
            this.Kategorie.HeaderText = "z_kategorie";
            this.Kategorie.Name = "Kategorie";
            // 
            // Status
            // 
            this.Status.HeaderText = "z_status";
            this.Status.Name = "Status";
            // 
            // CmdZimmerplan
            // 
            this.CmdZimmerplan.Location = new System.Drawing.Point(13, 13);
            this.CmdZimmerplan.Name = "CmdZimmerplan";
            this.CmdZimmerplan.Size = new System.Drawing.Size(101, 23);
            this.CmdZimmerplan.TabIndex = 1;
            this.CmdZimmerplan.Text = "Zimmerplan";
            this.CmdZimmerplan.UseVisualStyleBackColor = true;
            // 
            // LblAktuellerStatus
            // 
            this.LblAktuellerStatus.AutoSize = true;
            this.LblAktuellerStatus.Location = new System.Drawing.Point(12, 72);
            this.LblAktuellerStatus.Name = "LblAktuellerStatus";
            this.LblAktuellerStatus.Size = new System.Drawing.Size(89, 15);
            this.LblAktuellerStatus.TabIndex = 2;
            this.LblAktuellerStatus.Text = "Aktueller Status";
            // 
            // RBsauber
            // 
            this.RBsauber.AutoSize = true;
            this.RBsauber.Location = new System.Drawing.Point(12, 115);
            this.RBsauber.Name = "RBsauber";
            this.RBsauber.Size = new System.Drawing.Size(60, 19);
            this.RBsauber.TabIndex = 3;
            this.RBsauber.TabStop = true;
            this.RBsauber.Text = "sauber";
            this.RBsauber.UseVisualStyleBackColor = true;
            this.RBsauber.CheckedChanged += new System.EventHandler(this.RBsauber_CheckedChanged);
            // 
            // RBzuChecken
            // 
            this.RBzuChecken.AutoSize = true;
            this.RBzuChecken.Location = new System.Drawing.Point(12, 140);
            this.RBzuChecken.Name = "RBzuChecken";
            this.RBzuChecken.Size = new System.Drawing.Size(84, 19);
            this.RBzuChecken.TabIndex = 4;
            this.RBzuChecken.TabStop = true;
            this.RBzuChecken.Text = "zu checken";
            this.RBzuChecken.UseVisualStyleBackColor = true;
            // 
            // RBdreckig
            // 
            this.RBdreckig.AutoSize = true;
            this.RBdreckig.Location = new System.Drawing.Point(12, 165);
            this.RBdreckig.Name = "RBdreckig";
            this.RBdreckig.Size = new System.Drawing.Size(64, 19);
            this.RBdreckig.TabIndex = 5;
            this.RBdreckig.TabStop = true;
            this.RBdreckig.Text = "dreckig";
            this.RBdreckig.UseVisualStyleBackColor = true;
            // 
            // RBalle
            // 
            this.RBalle.AutoSize = true;
            this.RBalle.Location = new System.Drawing.Point(12, 90);
            this.RBalle.Name = "RBalle";
            this.RBalle.Size = new System.Drawing.Size(43, 19);
            this.RBalle.TabIndex = 6;
            this.RBalle.TabStop = true;
            this.RBalle.Text = "alle";
            this.RBalle.UseVisualStyleBackColor = true;
            this.RBalle.CheckedChanged += new System.EventHandler(this.RBalle_CheckedChanged);
            // 
            // CmdStatusAendern
            // 
            this.CmdStatusAendern.Location = new System.Drawing.Point(12, 42);
            this.CmdStatusAendern.Name = "CmdStatusAendern";
            this.CmdStatusAendern.Size = new System.Drawing.Size(101, 23);
            this.CmdStatusAendern.TabIndex = 7;
            this.CmdStatusAendern.Text = "Status ändern";
            this.CmdStatusAendern.UseVisualStyleBackColor = true;
            // 
            // CmdAnreise
            // 
            this.CmdAnreise.Location = new System.Drawing.Point(120, 13);
            this.CmdAnreise.Name = "CmdAnreise";
            this.CmdAnreise.Size = new System.Drawing.Size(101, 23);
            this.CmdAnreise.TabIndex = 8;
            this.CmdAnreise.Text = "Auf Anreise";
            this.CmdAnreise.UseVisualStyleBackColor = true;
            // 
            // CmdAbreise
            // 
            this.CmdAbreise.Location = new System.Drawing.Point(227, 13);
            this.CmdAbreise.Name = "CmdAbreise";
            this.CmdAbreise.Size = new System.Drawing.Size(101, 23);
            this.CmdAbreise.TabIndex = 9;
            this.CmdAbreise.Text = "Auf Abreise";
            this.CmdAbreise.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Auf Abreise";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Zimmerplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 810);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmdAbreise);
            this.Controls.Add(this.CmdAnreise);
            this.Controls.Add(this.CmdStatusAendern);
            this.Controls.Add(this.RBalle);
            this.Controls.Add(this.RBdreckig);
            this.Controls.Add(this.RBzuChecken);
            this.Controls.Add(this.RBsauber);
            this.Controls.Add(this.LblAktuellerStatus);
            this.Controls.Add(this.CmdZimmerplan);
            this.Controls.Add(this.dataGridViewZimmer);
            this.Name = "Zimmerplan";
            this.Text = "Zimmerplan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZimmer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZimmer;
        private System.Windows.Forms.Button CmdZimmerplan;
        private System.Windows.Forms.Label LblAktuellerStatus;
        private System.Windows.Forms.RadioButton RBsauber;
        private System.Windows.Forms.RadioButton RBzuChecken;
        private System.Windows.Forms.RadioButton RBdreckig;
        private System.Windows.Forms.RadioButton RBalle;
        private System.Windows.Forms.Button CmdStatusAendern;
        private System.Windows.Forms.DataGridViewTextBoxColumn z_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button CmdAnreise;
        private System.Windows.Forms.Button CmdAbreise;
        private System.Windows.Forms.Button button1;
    }
}