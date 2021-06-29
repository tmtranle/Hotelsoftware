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
    public partial class ZimmerstatusEditor : Form
    {
        // Wenn mit Parameterübergabe vom Fenster Zimmerplan

        //public List<Zimmer> listeZimmerStatusAendern = new List<Zimmer>();

        //public Zimmerplan fenster;
        //public Zimmer statusZuAendern;

        public ZimmerstatusEditor(/*Zimmerplan fenster, Zimmer statusZuAendern*/)
        {
            //this.fenster = fenster;
            //this.statusZuAendern = statusZuAendern;
            InitializeComponent();
        }

        private void CmdStatusAendern_Click(object sender, EventArgs e)
        {
            StatusAendern();
        }

        public MySqlConnection conn = new MySqlConnection("Server=localhost;UID=root;PWD=;DATABASE=HotelsoftwareDB");

        private void StatusAendern()
        {
            string neuerStatus = CbStatus.Text;

            // den Inhalt den der Nutzer in Tb eingegeben hat speichern
            string eingabe = TbZimmer.Text;
            // string zerschneiden
            String[] teile = eingabe.Split(',');
            // string in long umwandeln

            conn.Open();
            // mit der id, solange den status des zimmers ändern, bis jeder Zimmerstatus geändert wurde
            foreach (string teil in teile)
            {
                // Daten in DB aktualisiert
                long id = Int64.Parse(teil);
                
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = " UPDATE zimmer SET z_status = @neuerStatus  WHERE z_id = @z_id ";
                cmd.Parameters.AddWithValue("neuerStatus", neuerStatus);
                cmd.Parameters.AddWithValue("z_id", id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

            }
            conn.Close();

            DialogResult = DialogResult.OK;
            this.Close();

            

            

        }
    }
}
