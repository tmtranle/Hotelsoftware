
namespace Hotelsoftware
{
    partial class ZimmerstatusEditor
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
            this.LblZimmer = new System.Windows.Forms.Label();
            this.TbZimmer = new System.Windows.Forms.TextBox();
            this.CmdStatusAendern = new System.Windows.Forms.Button();
            this.CmdAbbruch = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.CbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblZimmer
            // 
            this.LblZimmer.AutoSize = true;
            this.LblZimmer.Location = new System.Drawing.Point(13, 13);
            this.LblZimmer.Name = "LblZimmer";
            this.LblZimmer.Size = new System.Drawing.Size(49, 15);
            this.LblZimmer.TabIndex = 0;
            this.LblZimmer.Text = "Zimmer";
            // 
            // TbZimmer
            // 
            this.TbZimmer.Location = new System.Drawing.Point(68, 10);
            this.TbZimmer.Name = "TbZimmer";
            this.TbZimmer.Size = new System.Drawing.Size(198, 23);
            this.TbZimmer.TabIndex = 1;
            // 
            // CmdStatusAendern
            // 
            this.CmdStatusAendern.Location = new System.Drawing.Point(97, 78);
            this.CmdStatusAendern.Name = "CmdStatusAendern";
            this.CmdStatusAendern.Size = new System.Drawing.Size(89, 23);
            this.CmdStatusAendern.TabIndex = 2;
            this.CmdStatusAendern.Text = "Status ändern";
            this.CmdStatusAendern.UseVisualStyleBackColor = true;
            this.CmdStatusAendern.Click += new System.EventHandler(this.CmdStatusAendern_Click);
            // 
            // CmdAbbruch
            // 
            this.CmdAbbruch.Location = new System.Drawing.Point(97, 107);
            this.CmdAbbruch.Name = "CmdAbbruch";
            this.CmdAbbruch.Size = new System.Drawing.Size(89, 23);
            this.CmdAbbruch.TabIndex = 3;
            this.CmdAbbruch.Text = "Abbruch";
            this.CmdAbbruch.UseVisualStyleBackColor = true;
            this.CmdAbbruch.Click += new System.EventHandler(this.CmdAbbruch_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(13, 39);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(39, 15);
            this.LblStatus.TabIndex = 4;
            this.LblStatus.Text = "Status";
            // 
            // CbStatus
            // 
            this.CbStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "sauber",
            "zu checken",
            "dreckig",
            "ausser Betrieb"});
            this.CbStatus.FormattingEnabled = true;
            this.CbStatus.Items.AddRange(new object[] {
            "sauber",
            "zu checken",
            "dreckig",
            "ausser Betrieb"});
            this.CbStatus.Location = new System.Drawing.Point(68, 40);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(198, 23);
            this.CbStatus.TabIndex = 5;
            // 
            // ZimmerstatusEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 146);
            this.Controls.Add(this.CbStatus);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.CmdAbbruch);
            this.Controls.Add(this.CmdStatusAendern);
            this.Controls.Add(this.TbZimmer);
            this.Controls.Add(this.LblZimmer);
            this.Name = "ZimmerstatusEditor";
            this.Text = "Zimmerstatus bearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblZimmer;
        private System.Windows.Forms.TextBox TbZimmer;
        private System.Windows.Forms.Button CmdStatusAendern;
        private System.Windows.Forms.Button CmdAbbruch;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.ComboBox CbStatus;
    }
}