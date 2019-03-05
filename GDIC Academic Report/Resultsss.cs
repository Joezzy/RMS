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
    public partial class Resultsss : Form
    {
        Connect connect = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=sis;Uid=root;Pwd=;");

        public Resultsss()
        {
            InitializeComponent();
            viewAll("SELECT * FROM sss");
        }

        void viewAll(string qry)
        {

            con.Open();
            try
            {
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = qry;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;


            }
            catch (Exception)
            {
                //throw;
            }
            finally
            {
                con.Close();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSurname.Text.Length > 0 && txtClass.Text.Length < 1)
            {
                viewAll("SELECT * FROM sss WHERE Surname='" + txtSurname.Text + "'  ");
            }

            else if (txtSurname.Text.Length < 1 && txtClass.Text.Length > 0)
            {
                viewAll("SELECT * FROM sss WHERE Class='" + txtClass.Text + "'  ");
            }

            else if (txtSurname.Text.Length > 0 && txtClass.Text.Length > 0)
            {
                viewAll("SELECT * FROM sss WHERE Class='" + txtClass.Text + "' and Surname='" + txtSurname.Text + "'  ");
            }
            else
            {
                MessageBox.Show("Enter parameter to search");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAll("SELECT * FROM sss");
        }

        private void Resultjss_Load(object sender, EventArgs e)
        {

        }

        private void subjectPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SubPosition2 prt = new SubPosition2();
            //prt.MdiParent = this;
            //prt.Show();
        }

    }
}
