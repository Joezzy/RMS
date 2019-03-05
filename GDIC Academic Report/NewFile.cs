﻿using System;
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
    public partial class NewFile : Form
    {
          Connect connect = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=;Uid=root;Pwd=;");


        public NewFile()
        {
            InitializeComponent();
        }

        public bool DeleteData(string TableName)
{

               string dbb = txtSess.Text;
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");
            try{
                con.Open();

string sqlStatement = "CREATE TABLE " + TableName + "" + "(id INTEGER PRIMARY KEY  AUTO_INCREMENT NOT NULL," +


 "Admission_No varchar(6) DEFAULT NULL," +
  "Surname varchar(8) DEFAULT NULL," +
  "Other_Names varchar(8) DEFAULT NULL," +
  "Gender varchar(6) DEFAULT NULL," +
  "Class varchar(4) DEFAULT NULL," +
  "Term varchar(11) DEFAULT NULL," +
  "Session varchar(25) DEFAULT NULL," +
  "Mathematics_CA int(2) DEFAULT NULL," +
  "Mathematics_Exam int(2) DEFAULT NULL," +
  "Mathematics int(3) DEFAULT NULL," +
  "Mathematics_Rem varchar(4) DEFAULT NULL," +
  "Maths_Position varchar(10) DEFAULT NULL," +
  "English_Language_CA int(2) DEFAULT NULL," +
  "English_Language_Exam int(2) DEFAULT NULL," +
  "English_Language int(3) DEFAULT NULL," +
  "English_Language_Rem varchar(4) DEFAULT NULL," +
  "Eng_Position varchar(10) DEFAULT NULL," +
  "Social_Studies_CA int(2) DEFAULT NULL," +
  "Social_Studies_Exam int(2) DEFAULT NULL," +
  "Social_Studies int(3) DEFAULT NULL," +
  "Social_Studies_Rem varchar(4) DEFAULT NULL," +
  "Social_Stu_Position varchar(10) DEFAULT NULL," +
  "Basic_Science_CA int(2) DEFAULT NULL," +
  "Basic_Science_Exam int(2) DEFAULT NULL," +
  "Basic_Science int(3) DEFAULT NULL," +
  "Basic_Science_Rem varchar(4) DEFAULT NULL," +
  "Basic_Sci_Position varchar(10) DEFAULT NULL," +
  "Basic_Tech_CA int(2) DEFAULT NULL," +
  "Basic_Tech_Exam int(2) DEFAULT NULL," +
  "Basic_Tech int(3) DEFAULT NULL," +
  "Basic_Tech_Rem varchar(4) DEFAULT NULL," +
  "Basic_Tech_Position varchar(10) DEFAULT NULL," +
  "Agric_Science_CA int(2) DEFAULT NULL," +
  "Agric_Science_Exam int(2) DEFAULT NULL," +
  "Agric_Science int(3) DEFAULT NULL," +
  "Agric_Science_Rem varchar(4) DEFAULT NULL," +
  "Agric_Position varchar(10) DEFAULT NULL," +
  "Home_Econs_CA int(2) DEFAULT NULL," +
  "Home_Econs_Exam int(2) DEFAULT NULL," +
  "Home_Econs int(3) DEFAULT NULL," +
  "Home_Econs_Rem varchar(4) DEFAULT NULL," +
  "Home_Econs_Position varchar(10) DEFAULT NULL," +
  "Civic_Ed_CA int(2) DEFAULT NULL," +
  "Civic_Ed_Exam int(2) DEFAULT NULL," +
  "Civic_Ed int(3) DEFAULT NULL," +
  "Civic_Ed_Rem varchar(6) DEFAULT NULL," +
  "Civic_Position varchar(10) DEFAULT NULL," +
  "Computer_CA int(2) DEFAULT NULL," +
  "Computer_Exam int(2) DEFAULT NULL," +
  "Computer int(3) DEFAULT NULL," +
  "Computer_Rem varchar(4) DEFAULT NULL," +
  "Computer_Position varchar(10) DEFAULT NULL," +
  "CCA_CA int(2) DEFAULT NULL," +
  "CCA_Exam int(2) DEFAULT NULL," +
  "CCA int(3) DEFAULT NULL," +
  "CCA_Rem varchar(9) DEFAULT NULL," +
  "CCA_Position varchar(10) DEFAULT NULL," +
  "Business_Studies_CA int(2) DEFAULT NULL," +
  "Business_Studies_Exam int(2) DEFAULT NULL," +
  "Business_Studies int(3) DEFAULT NULL," +
  "Business_Studies_Rem varchar(4) DEFAULT NULL," +
  "Business_Stu_Position varchar(10) DEFAULT NULL," +
  "PHE_CA int(2) DEFAULT NULL," +
  "PHE_Exam int(2) DEFAULT NULL," +
  "PHE int(3) DEFAULT NULL," +
  "PHE_Rem varchar(4) DEFAULT NULL," +
  "PHE_Position varchar(10) DEFAULT NULL," +
  "french_CA int(2) DEFAULT NULL," +
  "french_Exam int(2) DEFAULT NULL," +
  "french int(3) DEFAULT NULL," +
  "French_Rem varchar(4) DEFAULT NULL," +
  "French_Position varchar(10) DEFAULT NULL," +
  "Yoruba_CA int(2) DEFAULT NULL," +
  "Yoruba_Exam int(2) DEFAULT NULL," +
  "Yoruba int(3) DEFAULT NULL," +
  "Yoruba_Rem varchar(7) DEFAULT NULL," +
  "Yoruba_Position varchar(10) DEFAULT NULL," +
  "CRS_CA int(2) DEFAULT NULL," +
  "CRS_Exam int(2) DEFAULT NULL," +
  "CRS int(3) DEFAULT NULL," +
  "CRS_Rem varchar(7) DEFAULT NULL," +
  "CRS_Position varchar(10) DEFAULT NULL," +
  "IRS_CA int(2) DEFAULT NULL," +
  "IRS_Exam int(2) DEFAULT NULL," +
  "IRS int(2) DEFAULT NULL," +
  "IRS_Rem varchar(3) DEFAULT NULL," +
  "IRS_Position varchar(10) DEFAULT NULL," +
  "Security_Studies_CA int(2) DEFAULT NULL," +
  "Security_Studies_Exam int(2) DEFAULT NULL," +
  "Security_Studies int(3) DEFAULT NULL," +
  "Security_Studies_Rem varchar(4) DEFAULT NULL," +
  "Security_Stu_Position varchar(10) DEFAULT NULL," +
  "Total varchar(10) DEFAULT NULL," +
  "Average varchar(6) DEFAULT NULL," +
  "Teacher text," +
  "Principal text," +
  "Punctuality varchar(1) DEFAULT NULL," +
  "Attendance varchar(1) DEFAULT NULL," +
  "Reliability varchar(1) DEFAULT NULL," +
  "Politeness varchar(1) DEFAULT NULL," +
  "Honesty varchar(1) DEFAULT NULL," +
  "Self_Control varchar(1) DEFAULT NULL," +
  "Staff_Rship varchar(1) DEFAULT NULL," +
  "Student_Rship varchar(1) DEFAULT NULL," +
  "Initiative varchar(1) DEFAULT NULL," +
  "Org_Ability varchar(1) DEFAULT NULL)";
                

MySqlCommand sqlCmd=new MySqlCommand(sqlStatement, con);
sqlCmd.ExecuteNonQuery();
MessageBox.Show("Record Created Sucessfully");


        }
                        catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return true;
}

        private void button1_Click(object sender, EventArgs e)
        {
          string  n = txtClass.Text;
          string m = txtCat.Text;
          string nalz = n +"_"+ m;
            DeleteData(nalz);
           // MessageBox.Show("Record Created Sucessfully");
            //txtClass.Clear();

        }

        private void NewFile_Load(object sender, EventArgs e)
        {
            listLoad2("select SCHEMA_NAME from information_schema.SCHEMATA");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void listLoad2(string str)
        {

            MySqlConnection con2 = new MySqlConnection("Server=localhost;Database=;Uid=root;Pwd=;");
            MySqlCommand cm = new MySqlCommand(str, con2);
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


    }
}
