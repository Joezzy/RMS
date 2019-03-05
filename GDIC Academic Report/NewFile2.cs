using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GDIC_Academic_Report
{
    public partial class NewFile2 : Form
    {
        Connect connect = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=sis;Uid=root;Pwd=;");

        public NewFile2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = txtClass.Text;
            string m = txtCat.Text;
            string nalz = n + "_" + m;
            createFile(nalz);
        }


        public bool createFile(string TableName)
        {

            string dbb = txtSess.Text;
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");
            try
            {
                con.Open();

                string sqlStatement = "CREATE TABLE " + TableName + "" + "(id int(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT," +
  "Surname varchar(50) DEFAULT NULL," +
  "Other_Names varchar(50) DEFAULT NULL," +
  "Gender varchar(6) DEFAULT NULL," +
  "Class varchar(4) DEFAULT NULL," +
  "Term varchar(11) DEFAULT NULL," +
  "Session varchar(4) DEFAULT NULL," +
  "Mathematics_CA varchar(3) DEFAULT NULL," +
  "Mathematics_Exam varchar(3) DEFAULT NULL," +
  "Mathematics int(3) DEFAULT NULL," +
  "Mathematics_Rem varchar(2) DEFAULT NULL," +
  "Maths_Position varchar(10) DEFAULT NULL," +
  "English_Language_CA varchar(3) DEFAULT NULL," +
  "English_Language_Exam varchar(3) DEFAULT NULL," +
  "English_Language int(3) DEFAULT NULL," +
  "English_Language_Rem varchar(2) DEFAULT NULL," +
  "Eng_Position varchar(10) DEFAULT NULL," +
  "Biology_CA varchar(3) NOT NULL," +
  "Biology_Exam varchar(3) DEFAULT NULL," +
  "Biology int(3) DEFAULT NULL," +
  "Biology_Rem varchar(2) DEFAULT NULL," +
  "Bio_Position varchar(10) DEFAULT NULL," +
  "Economics_CA varchar(3) DEFAULT NULL," +
  "Economics_Exam varchar(3) DEFAULT NULL," +
  "Economics int(3) DEFAULT NULL," +
  "Economics_Rem varchar(2) NOT NULL," +
  "Econs_Position varchar(10) DEFAULT NULL," +
  "Geography_CA varchar(3) DEFAULT NULL," +
  "Geography_Exam varchar(3) DEFAULT NULL," +
  "Geography int(3) DEFAULT NULL," +
  "Geography_Rem varchar(2) DEFAULT NULL," +
  "Geo_Position varchar(10) DEFAULT NULL," +
  "Agric_Science_CA varchar(3) DEFAULT NULL," +
  "Agric_Science_Exam varchar(3) DEFAULT NULL," +
  "Agric_Science int(3) DEFAULT NULL," +
  "Agric_Science_Rem varchar(2) DEFAULT NULL," +
  "Agric_Position varchar(10) DEFAULT NULL," +
  "Commerce_CA varchar(3) DEFAULT NULL," +
  "Commerce_Exam varchar(3) DEFAULT NULL," +
  "Commerce int(3) DEFAULT NULL," +
  "Commerce_Rem varchar(2) DEFAULT NULL," +
  "Comm_Position varchar(10) DEFAULT NULL," +
  "Accounting_CA varchar(3) DEFAULT NULL," +
  "Accounting_Exam varchar(3) DEFAULT NULL," +
  "Accounting varchar(3) DEFAULT NULL," +
  "Accounting_Rem varchar(3) DEFAULT NULL," +
  "Account_Position varchar(10) DEFAULT NULL," +
  "Government_CA varchar(3) DEFAULT NULL," +
  "Government_Exam varchar(3) DEFAULT NULL," +
  "Government int(3) DEFAULT NULL," +
  "Government_Rem varchar(2) DEFAULT NULL," +
  "Gov_Position varchar(10) DEFAULT NULL," +
  "Lit_In_Eng_CA varchar(3) DEFAULT NULL," +
  "Lit_In_Eng_Exam varchar(3) DEFAULT NULL," +
  "Lit_In_Eng int(3) DEFAULT NULL," +
  "Lit_In_Eng_Rem varchar(2) DEFAULT NULL," +
  "Lit_Position varchar(10) DEFAULT NULL," +
  "Physics_CA varchar(3) DEFAULT NULL," +
  "Physics_Exam varchar(3) DEFAULT NULL," +
  "Physics int(3) DEFAULT NULL," +
  "Physics_Rem varchar(2) DEFAULT NULL," +
  "Phy_Position varchar(10) DEFAULT NULL," +
  "Chemistry_CA varchar(3) DEFAULT NULL," +
  "Chemistry_Exam varchar(3) DEFAULT NULL," +
  "Chemistry int(3) DEFAULT NULL," +
  "Chemistry_Rem varchar(2) DEFAULT NULL," +
  "Chem_Position varchar(10) DEFAULT NULL," +
  "Further_Maths_CA varchar(3) DEFAULT NULL," +
  "Further_Maths_Exam varchar(3) DEFAULT NULL," +
  "Further_Maths int(3) DEFAULT NULL," +
  "Further_Maths_Rem varchar(2) DEFAULT NULL," +
  "Fmaths_Position varchar(10) DEFAULT NULL," +
  "Civic_Ed_CA varchar(3) DEFAULT NULL," +
  "Civic_Ed_Exam varchar(3) DEFAULT NULL," +
  "Civic_Ed int(3) DEFAULT NULL," +
  "Civic_Ed_Rem varchar(2) DEFAULT NULL," +
  "Civic_Position varchar(10) DEFAULT NULL," +
  "Computer_CA varchar(3) DEFAULT NULL," +
  "Computer_Exam varchar(3) DEFAULT NULL," +
  "Computer int(3) DEFAULT NULL," +
  "Computer_Rem varchar(2) DEFAULT NULL," +
  "Computer_Position varchar(10) DEFAULT NULL," +
  "Office_Practice_CA varchar(3) DEFAULT NULL," +
  "Office_Practice_Exam varchar(3) DEFAULT NULL," +
  "Office_Practice int(3) DEFAULT NULL," +
  "Office_Practice_Rem varchar(2) DEFAULT NULL," +
  "OP_Position varchar(10) DEFAULT NULL," +
  "Yoruba_CA varchar(3) DEFAULT NULL," +
  "Yoruba_Exam varchar(3) DEFAULT NULL," +
  "Yoruba int(3) DEFAULT NULL," +
  "Yoruba_Rem varchar(2) DEFAULT NULL," +
  "Yoruba_Position varchar(10) DEFAULT NULL," +
  "CRS_CA int(1) DEFAULT NULL," +
  "CRS_Exam varchar(3) DEFAULT NULL," +
  "CRS int(3) DEFAULT NULL," +
  "CRS_Rem varchar(2) DEFAULT NULL," +
  "CRS_Position varchar(10) DEFAULT NULL," +
  "IRS_CA varchar(3) DEFAULT NULL," +
  "IRS_Exam varchar(3) DEFAULT NULL," +
  "IRS int(3) DEFAULT NULL," +
  "IRS_Rem varchar(2) DEFAULT NULL," +
  "IRS_Position varchar(10) DEFAULT NULL," +
  "TD_CA varchar(3) DEFAULT NULL," +
  "TD_Exam varchar(3) DEFAULT NULL," +
  "TD int(3) DEFAULT NULL," +
  "TD_Rem varchar(2) DEFAULT NULL," +
  "TD_Position varchar(10) DEFAULT NULL," +
  "Catering_CA varchar(3) DEFAULT NULL," +
  "Catering_Exam varchar(3) DEFAULT NULL," +
  "Catering int(3) DEFAULT NULL," +
  "Catering_Rem varchar(2) DEFAULT NULL," +
  "Catering_Position varchar(10) DEFAULT NULL," +
  "Animal_Hus_CA varchar(3) DEFAULT NULL," +
  "Animal_Hus_Exam varchar(3) DEFAULT NULL," +
  "Animal_Hus int(3) DEFAULT NULL," +
  "Animal_Hus_Rem varchar(2) DEFAULT NULL," +
  "Animal_Position varchar(10) DEFAULT NULL," +
  "Paint_Decor_CA varchar(3) DEFAULT NULL," +
  "Paint_Decor_Exam varchar(3) DEFAULT NULL," +
  "Paint_Decor int(3) DEFAULT NULL," +
  "Paint_Decor_Rem varchar(2) DEFAULT NULL," +
  "PD_Position varchar(10) DEFAULT NULL," +
  "Average varchar(6) DEFAULT NULL," +
  "Subj_Offered varchar(2) DEFAULT NULL," +
  "Teacher text," +
  "Principal text," +
  "Punctuality varchar(2) DEFAULT NULL," +
  "Attendance varchar(2) DEFAULT NULL," +
  "Reliability varchar(2) DEFAULT NULL," +
  "Politeness varchar(2) DEFAULT NULL," +
  "Honesty varchar(2) DEFAULT NULL," +
  "Self_Control varchar(2) DEFAULT NULL," +
  "Staff_Rship varchar(2) DEFAULT NULL," +
  "Student_Rship varchar(2) DEFAULT NULL," +
  "Initiative varchar(2) DEFAULT NULL," +
  "Org_Ability varchar(2) DEFAULT NULL)";


                MySqlCommand sqlCmd = new MySqlCommand(sqlStatement, con);
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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewFile2_Load(object sender, EventArgs e)
        {
            listLoad2("select SCHEMA_NAME from information_schema.SCHEMATA");
       
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
