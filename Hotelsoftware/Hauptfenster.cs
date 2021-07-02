using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelsoftware
{
    public partial class Hauptfenster : Form
    {
        public Hauptfenster()
        {
            InitializeComponent();
        }

        private void CmdGaestekartei_Click(object sender, EventArgs e)
        {
            // Fenster zur Gästekartei öffnen
            Gaestekartei fenster = new Gaestekartei();
            fenster.ShowDialog();
        }

        private void CmdFirmenkartei_Click(object sender, EventArgs e)
        {
            // Fenster zur Firmenkartei öffnen
            Firmenkartei fenster = new Firmenkartei();
            fenster.ShowDialog();
        }

        private void CmdZimmerplan_Click(object sender, EventArgs e)
        {
            // Fenster zum Zimmerplan öffnen
            Zimmerplan fenster = new Zimmerplan();
            fenster.ShowDialog();
        }

        private void CmdBelegungsplan_Click(object sender, EventArgs e)
        {
            // Fenster zum Belegungsplan öffnen
            Belegungsplan fenster = new Belegungsplan();
            fenster.ShowDialog();
        }
    }
}
