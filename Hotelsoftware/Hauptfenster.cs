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


        private void CmdGaestedatei_Click(object sender, EventArgs e)
        {
            Gaestedatei fenster = new Gaestedatei();
            fenster.ShowDialog();
        }

        private void CmdAnreiseliste_Click(object sender, EventArgs e)
        {
            Anreiseliste fenster = new Anreiseliste();
            fenster.ShowDialog();
        }

        private void CmdFirmendatei_Click(object sender, EventArgs e)
        {
            Firmendatei fenster = new Firmendatei();
            fenster.ShowDialog();
        }
    }
}
