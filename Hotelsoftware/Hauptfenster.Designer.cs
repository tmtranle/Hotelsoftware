
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
            this.CmdGaestedatei = new System.Windows.Forms.Button();
            this.CmdFirmendatei = new System.Windows.Forms.Button();
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
            // CmdGaestedatei
            // 
            this.CmdGaestedatei.Location = new System.Drawing.Point(12, 12);
            this.CmdGaestedatei.Name = "CmdGaestedatei";
            this.CmdGaestedatei.Size = new System.Drawing.Size(92, 23);
            this.CmdGaestedatei.TabIndex = 1;
            this.CmdGaestedatei.Text = "Gästedatei";
            this.CmdGaestedatei.UseVisualStyleBackColor = true;
            this.CmdGaestedatei.Click += new System.EventHandler(this.CmdGaestedatei_Click);
            // 
            // CmdFirmendatei
            // 
            this.CmdFirmendatei.Location = new System.Drawing.Point(110, 12);
            this.CmdFirmendatei.Name = "CmdFirmendatei";
            this.CmdFirmendatei.Size = new System.Drawing.Size(92, 23);
            this.CmdFirmendatei.TabIndex = 2;
            this.CmdFirmendatei.Text = "Firmendatei";
            this.CmdFirmendatei.UseVisualStyleBackColor = true;
            this.CmdFirmendatei.Click += new System.EventHandler(this.CmdFirmendatei_Click);
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
            this.Controls.Add(this.CmdFirmendatei);
            this.Controls.Add(this.CmdGaestedatei);
            this.Controls.Add(this.CmdAnreiseliste);
            this.Name = "Hauptfenster";
            this.Text = "Property Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdAnreiseliste;
        private System.Windows.Forms.Button CmdGaestedatei;
        private System.Windows.Forms.Button CmdFirmendatei;
        private System.Windows.Forms.Button CmdAbreiseliste;
    }
}

