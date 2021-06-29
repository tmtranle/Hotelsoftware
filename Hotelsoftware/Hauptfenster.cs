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
            Gaestekartei fenster = new Gaestekartei();
            fenster.ShowDialog();
        }

        private void CmdAnreiseliste_Click(object sender, EventArgs e)
        {
            Anreiseliste fenster = new Anreiseliste();
            fenster.ShowDialog();
        }

        private void CmdFirmenkartei_Click(object sender, EventArgs e)
        {
            Firmenkartei fenster = new Firmenkartei();
            fenster.ShowDialog();
        }

        private void CmdZimmerplan_Click(object sender, EventArgs e)
        {
            Zimmerplan fenster = new Zimmerplan();
            fenster.ShowDialog();
        }

        private void CmdBelegungsplan_Click(object sender, EventArgs e)
        {
            Belegungsplan fenster = new Belegungsplan();
            fenster.ShowDialog();
        }
    }
}
