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
    public partial class Resultjss : Form
    {
        Connect connect = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=;Uid=root;Pwd=;");

        public Resultjss()
        {
            InitializeComponent();
          
        }

        void viewAll(string qry)
        {
            string dbb = txtSess.Text;
            if (dbb == "")
            {
                MessageBox.Show("Please select a Session","RMS");
            }
            else if (txtClass.Text == "")
            {
                MessageBox.Show("Please select a Class","RMS");
            }
            else
            {

                MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if (txtSurname.Text.Length > 0 && txtClass.Text.Length < 1)
            //{
            //    viewAll("SELECT * FROM jss WHERE Surname='" + txtSurname.Text + "'  ");
            //}

            //else if (txtSurname.Text.Length < 1 && txtClass.Text.Length > 0)
            //{
            //    viewAll("SELECT * FROM jss WHERE Class='" + txtClass.Text + "'  ");
            //}

            //else if (txtSurname.Text.Length > 0 && txtClass.Text.Length > 0)
            //{
            //    viewAll("SELECT * FROM jss WHERE Class='" + txtClass.Text + "' and Surname='" + txtSurname.Text + "'  ");
            //}
            //else
            //{
            //    MessageBox.Show("Enter parameter to search");
            //}
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  viewAll("SELECT * FROM jss");
        }

        private void Resultjss_Load(object sender, EventArgs e)
        {
            listLoad2("select SCHEMA_NAME from information_schema.SCHEMATA");
        }





        void listLoad2(string str)
        {

            MySqlCommand cm = new MySqlCommand(str, connection);
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtSess.Items.Add(dr["SCHEMA_NAME"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        void listLoad(string str)
        {

            MySqlCommand cm = new MySqlCommand(str, connection);
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtClass.Items.Add(dr["TABLE_NAME"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSess_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClass.Items.Clear();
            string clazz = "ss";
            listLoad("SELECT TABLE_NAME FROM information_schema.TABLES where TABLE_SCHEMA='" + txtSess.Text + "' AND TABLE_NAME like'%" + clazz + "%' order by TABLE_NAME ASC");

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbb = txtSess.Text;
            if (dbb == "")
            {
                MessageBox.Show("Please select a Session", "RMS");
            }
            else if (txtClass.Text == "")
            {
                MessageBox.Show("Please select a Class", "RMS");
            }
            else
            {
                //  viewAll("SELECT * FROM '" + txtClass.Text + "'");

                // string dbb = txtSess.Text;
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");
                con.Open();
                try
                {
                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandText = "SELECT * FROM  " + txtClass.Text + "";
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd1);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    con.Close();

                }
            }
        }

        

        

    }
}
