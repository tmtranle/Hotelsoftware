
namespace Hotelsoftware
{
    partial class Hauptfenster
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdAnreiseliste = new System.Windows.Forms.Button();
            this.CmdGaestekartei = new System.Windows.Forms.Button();
            this.CmdFirmenkartei = new System.Windows.Forms.Button();
            this.CmdAbreiseliste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdAnreiseliste
            // 
            this.CmdAnreiseliste.Location = new System.Drawing.Point(208, 12);
            this.CmdAnreiseliste.Name = "CmdAnreiseliste";
            this.CmdAnreiseliste.Size = new System.Drawing.Size(92, 23);
            this.CmdAnreiseliste.TabIndex = 0;
            this.CmdAnreiseliste.Text = "Anreiseliste";
            this.CmdAnreiseliste.UseVisualStyleBackColor = true;
            this.CmdAnreiseliste.Click += new System.EventHandler(this.CmdAnreiseliste_Click);
            // 
            // CmdGaestekartei
            // 
            this.CmdGaestekartei.Location = new System.Drawing.Point(12, 12);
            this.CmdGaestekartei.Name = "CmdGaestekartei";
            this.CmdGaestekartei.Size = new System.Drawing.Size(92, 23);
            this.CmdGaestekartei.TabIndex = 1;
            this.CmdGaestekartei.Text = "Gästekartei";
            this.CmdGaestekartei.UseVisualStyleBackColor = true;
            this.CmdGaestekartei.Click += new System.EventHandler(this.CmdGaestekartei_Click);
            // 
            // CmdFirmenkartei
            // 
            this.CmdFirmenkartei.Location = new System.Drawing.Point(110, 12);
            this.CmdFirmenkartei.Name = "CmdFirmenkartei";
            this.CmdFirmenkartei.Size = new System.Drawing.Size(92, 23);
            this.CmdFirmenkartei.TabIndex = 2;
            this.CmdFirmenkartei.Text = "Firmenkartei";
            this.CmdFirmenkartei.UseVisualStyleBackColor = true;
            this.CmdFirmenkartei.Click += new System.EventHandler(this.CmdFirmenkartei_Click);
            // 
            // CmdAbreiseliste
            // 
            this.CmdAbreiseliste.Location = new System.Drawing.Point(306, 12);
            this.CmdAbreiseliste.Name = "CmdAbreiseliste";
            this.CmdAbreiseliste.Size = new System.Drawing.Size(92, 23);
            this.CmdAbreiseliste.TabIndex = 3;
            this.CmdAbreiseliste.Text = "Abreiseliste";
            this.CmdAbreiseliste.UseVisualStyleBackColor = true;
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdAbreiseliste);
            this.Controls.Add(this.CmdFirmenkartei);
            this.Controls.Add(this.CmdGaestekartei);
            this.Controls.Add(this.CmdAnreiseliste);
            this.Name = "Hauptfenster";
            this.Text = "Property Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdAnreiseliste;
        private System.Windows.Forms.Button CmdGaestekartei;
        private System.Windows.Forms.Button CmdFirmenkartei;
        private System.Windows.Forms.Button CmdAbreiseliste;
    }
}

