using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotelsoftware
{
    public partial class Zimmerplan : Form
    {
        private List<Zimmer> alleZimmer = new List<Zimmer>();

        public void ZimmerHinzufuegen(Zimmer zimmer)
        {
            // Liste befüllen
            alleZimmer.Add(zimmer);
            // Model füllen
            int index = dataGridViewZimmer.Rows.Add();
            dataGridViewZimmer.Rows[index].Cells[0].Value = zimmer.z_id;
            dataGridViewZimmer.Rows[index].Cells[1].Value = zimmer.z_kategorie;
            dataGridViewZimmer.Rows[index].Cells[2].Value = zimmer.z_status;
        }

        public Zimmerplan()
        {
            InitializeComponent();
            ZimmerLaden();
        }

        public MySqlConnection conn = new MySqlConnection("Server=localhost;UID=root;PWD=;DATABASE=HotelsoftwareDB");

        private void ZimmerLaden()
        {
            string filter;
            if (RbAusserBetrieb.Checked == true)
            {
                filter = RbAusserBetrieb.Text;
            }
            else if (RbSauber.Checked == true)
            {
                filter = RbSauber.Text;
            }
            else if (RbZuChecken.Checked == true)
            {
                filter = RbZuChecken.Text;
            }
            else if (RbDreckig.Checked == true)
            {
                filter = RbDreckig.Text;
            }
            else
            {
                filter = RbSauber.Text;
            }

            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            if (RbAlle.Checked == true)
            {
                cmd.CommandText = "SELECT z_id, z_kategorie, z_status FROM zimmer ORDER BY z_id";
            }
            else
            {
                cmd.CommandText = "SELECT z_id, z_kategorie, z_status FROM zimmer WHERE z_status = @z_status ORDER BY z_id";
                cmd.Parameters.AddWithValue("z_status", filter);
                cmd.Prepare();
            }

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long z_id = reader.GetInt64(0);
                string z_kategorie = reader.GetString(1);
                string z_status = reader.GetString(2);
                ZimmerHinzufuegen(new Zimmer(z_id, z_kategorie, z_status));
            }
            reader.Close();

            conn.Close();
        }

        private void RefreshView()
        {
            // Liste leeren
            alleZimmer.Clear();
            // Model leeren
            dataGridViewZimmer.Rows.Clear();
        }

        private void CmdStatusAendern_Click(object sender, EventArgs e)
        {
            ZimmerstatusEditor fenster = new ZimmerstatusEditor();
            fenster.ShowDialog();
            if (fenster.DialogResult == DialogResult.OK)
            {
                RefreshView();
                ZimmerLaden();
                RbAlle.Checked = true;
            }
        }

        private void RbAlle_CheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
            ZimmerLaden();
        }

        private void RbSauber_CheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
            ZimmerLaden();
        }

        private void RbZuChecken_CheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
            ZimmerLaden();
        }

        private void RbDreckig_CheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
            ZimmerLaden();
        }

        private void RbAusserBetrieb_CheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
            ZimmerLaden();
        }
       
    }
}
