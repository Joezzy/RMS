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
    public partial class export : Form
    {
        Connect connect = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        MySqlConnection SQLConnection = new MySqlConnection("Server=localhost;Database=sis;Uid=root;Pwd=;");

        public export()
        {
            InitializeComponent();
        }

        private void export_Load(object sender, EventArgs e)
        {
         //   listLoad("SELECT TABLE_NAME FROM information_schema.TABLES where TABLE_SCHEMA='sis'");
            listLoad2("select SCHEMA_NAME from information_schema.SCHEMATA");
        }



        void listLoad2(string str)
        {

            MySqlCommand cm = new MySqlCommand(str, SQLConnection);
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


        private void button1_Click(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("yyyy-MM-dd_HHmmss");
         //   string LogFolder = @"C:\Users\Hokpannaccie\Desktop\Records\log\";
            try
            {

                //Declare Variables and provide values
                string FileNamePart = txtClass.Text;//Datetime will be added to it
                string DestinationFolder = @"C:\Users\Hokpannaccie\Desktop\Records\";
            string TableName = txtClass.Text;
                string FileDelimiter = ","; //You can provide comma or pipe or whatever you like
                string FileExtension = ".csv"; //Provide the extension you like such as .txt or .csv


                //Create Connection to SQL Server in which you like to load files
               // MySqlConnection SQLConnection = new MySqlConnection();
              //  SQLConnection.ConnectionString = "Data Source = (local); Initial Catalog =TechBrothersIT; "
                //   + "Integrated Security=true;";

                //Read data from table or view to data table
                string query = "Select * From " + TableName;
                MySqlCommand cmd = new MySqlCommand(query, SQLConnection);
                SQLConnection.Open();
                DataTable d_table = new DataTable();
                d_table.Load(cmd.ExecuteReader());
                SQLConnection.Close();

                //Prepare the file path 
                string FileFullPath = DestinationFolder + "\\" + FileNamePart + "_" + datetime + FileExtension;

                StreamWriter sw = null;
                sw = new StreamWriter(FileFullPath, false);

                // Write the Header Row to File
                int ColumnCount = d_table.Columns.Count;
                for (int ic = 0; ic < ColumnCount; ic++)
                {
                    sw.Write(d_table.Columns[ic]);
                    if (ic < ColumnCount - 1)
                    {
                        sw.Write(FileDelimiter);
                    }
                }
                sw.Write(sw.NewLine);

                // Write All Rows to the File
                foreach (DataRow dr in d_table.Rows)
                {
                    for (int ir = 0; ir < ColumnCount; ir++)
                    {
                        if (!Convert.IsDBNull(dr[ir]))
                        {
                            sw.Write(dr[ir].ToString());
                        }
                        if (ir < ColumnCount - 1)
                        {
                            sw.Write(FileDelimiter);
                        }
                    }
                    sw.Write(sw.NewLine);

                }
                MessageBox.Show("Export successful!");
                sw.Close();

            } 
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString() + " \n\n\n\" MAKE SURE YOU HAVE CREATED A fOLDER AND NAME IT 'Records' on the Desktop ");
                // Create Log File for Errors
            //    using (StreamWriter sw = File.CreateText(LogFolder + "\\" + "ErrorLog_" + datetime + ".log"))
             //   {
                  // sw.WriteLine(exception.ToString());

               // }

            }


        }



        void listLoad(string str)
        {

            MySqlCommand cm = new MySqlCommand(str, SQLConnection);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSess_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClass.Items.Clear();
            string clazz = "jss";
            listLoad("SELECT TABLE_NAME FROM information_schema.TABLES where TABLE_SCHEMA='" + txtSess.Text + "' AND TABLE_NAME like'%" + clazz + "%' order by TABLE_NAME ASC");

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
