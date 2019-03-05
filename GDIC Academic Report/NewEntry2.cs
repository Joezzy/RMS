using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDIC_Academic_Report
{
    public partial class NewEntry2 : Form
    {
        Connect connect = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=sis;Uid=root;Pwd=;");

        public NewEntry2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string klass = txtClass.Text;
            string sess = txtSess.Text;
            Regsss rj = new Regsss(klass,sess);
            rj.Show();
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


        private void NewEntry2_Load(object sender, EventArgs e)
        {

            listLoad2("select SCHEMA_NAME from information_schema.SCHEMATA");
        }

        private void txtSess_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClass.Items.Clear();
            string clazz = "sss";
            listLoad("SELECT TABLE_NAME FROM information_schema.TABLES where TABLE_SCHEMA='" + txtSess.Text + "' AND TABLE_NAME like'%" + clazz + "%' order by TABLE_NAME ASC");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }
