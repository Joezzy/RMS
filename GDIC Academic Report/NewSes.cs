using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace GDIC_Academic_Report
{
    public partial class NewSes : Form
    {
        public NewSes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UDQuery("CREATE DATABASE IF NOT EXISTS " + txtSess.Text + " CHARACTER SET latin1 COLLATE latin1_bin;");
                MessageBox.Show("Session Created", "Result Processing");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }



        public void UDQuery(string qry)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=;Uid=root;Pwd=;");
            MySqlCommand cmd;
            con.Open();


            cmd = con.CreateCommand();
            cmd.CommandText = qry;

            cmd.ExecuteNonQuery();


            con.Close();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
