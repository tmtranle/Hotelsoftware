﻿using System;
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
            alleZimmer.Add(zimmer);
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
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT z_id, z_kategorie, z_status FROM zimmer";
            
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
            
        }

        private void RBalle_CheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
            ZimmerLaden();
        }

        private void RBsauber_CheckedChanged(object sender, EventArgs e)
        {
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT z_id, z_kategorie, z_status FROM zimmer WHERE z_status = " + RBsauber.Checked;

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long z_id = reader.GetInt64(0);
                string z_kategorie = reader.GetString(1);
                string z_status = reader.GetString(2);
                RefreshView();
                ZimmerHinzufuegen(new Zimmer(z_id, z_kategorie, z_status));
            }
            reader.Close();

            conn.Close();

        }
    }
}
