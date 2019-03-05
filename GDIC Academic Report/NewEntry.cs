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
    public partial class NewEntry : Form
    {
        Connect connect = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=sis;Uid=root;Pwd=;");


        public NewEntry()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string klass = txtClass.Text;
            string sess = txtSess.Text;
            Regjss rj = new Regjss(klass,sess);
            rj.Show();
            this.Hide();
//            string tbl=txtClass.Text;
//            string createTableQuery = string.Format(@"CREATE TABLE `{0}` (
//   `ID` int(2) DEFAULT NULL,
//  `Surname` varchar(5) DEFAULT NULL,
//  `Other Names` varchar(7) DEFAULT NULL,
//  `Gender` varchar(6) DEFAULT NULL,
//  `Class` varchar(4) DEFAULT NULL,
//  `Term` varchar(11) DEFAULT NULL,
//  `Session` varchar(4) DEFAULT NULL,
//  `Mathematics CA` int(2) DEFAULT NULL,
//  `Mathematics Exam` int(2) DEFAULT NULL,
//  `Mathematics` int(2) DEFAULT NULL,
//  `Mathematics Rem` varchar(2) DEFAULT NULL,
//  `Maths_Position` varchar(10) DEFAULT NULL,
//  `English Language CA` int(2) DEFAULT NULL,
//  `English Language Exam` int(2) DEFAULT NULL,
//  `English Language` int(2) DEFAULT NULL,
//  `English Language Rem` varchar(2) DEFAULT NULL,
//  `Eng_Position` varchar(10) DEFAULT NULL,
//  `Biology CA` int(2) DEFAULT NULL,
//  `Biology exam` int(2) DEFAULT NULL,
//  `Biology` int(2) DEFAULT NULL,
//  `Biology Rem` varchar(2) DEFAULT NULL,
//  `Bio_Position` varchar(10) DEFAULT NULL,
//  `Economics CA` int(2) DEFAULT NULL,
//  `Economics exam` int(2) DEFAULT NULL,
//  `Economics` int(2) DEFAULT NULL,
//  `Economics Rem` varchar(2) DEFAULT NULL,
//  `Econs_Position` varchar(10) DEFAULT NULL,
//  `Geography CA` int(2) DEFAULT NULL,
//  `Geography Exam` int(2) DEFAULT NULL,
//  `Geography` int(2) DEFAULT NULL,
//  `Geography Rem` varchar(2) DEFAULT NULL,
//  `Geo_Position` varchar(10) DEFAULT NULL,
//  `Agric Science CA` int(2) DEFAULT NULL,
//  `Agric Science Exam` int(2) DEFAULT NULL,
//  `Agric Science` int(2) DEFAULT NULL,
//  `Agric Science Rem` varchar(2) DEFAULT NULL,
//  `Agric_Position` varchar(10) DEFAULT NULL,
//  `Commerce CA` int(2) DEFAULT NULL,
//  `Commerce Exam` int(2) DEFAULT NULL,
//  `Commerce` int(2) DEFAULT NULL,
//  `Commerce Rem` varchar(2) DEFAULT NULL,
//  `Comm_Position` varchar(10) DEFAULT NULL,
//  `Accounting CA` int(1) DEFAULT NULL,
//  `Accounting Exam` int(1) DEFAULT NULL,
//  `Accounting` int(2) DEFAULT NULL,
//  `Accounting Rem` varchar(1) DEFAULT NULL,
//  `Account_Position` varchar(10) DEFAULT NULL,
//  `Government CA` int(2) DEFAULT NULL,
//  `Government Exam` int(2) DEFAULT NULL,
//  `Government` int(2) DEFAULT NULL,
//  `Government Rem` varchar(2) DEFAULT NULL,
//  `Gov_Position` varchar(10) DEFAULT NULL,
//  `Lit-In-Eng CA` int(2) DEFAULT NULL,
//  `Lit-In-Eng Exam` int(2) DEFAULT NULL,
//  `Lit-In-Eng` int(2) DEFAULT NULL,
//  `Lit-In-Eng Rem` varchar(2) DEFAULT NULL,
//  `Lit_Position` varchar(10) DEFAULT NULL,
//  `Physics CA` int(2) DEFAULT NULL,
//  `Physics Exam` int(2) DEFAULT NULL,
//  `Physics` int(2) DEFAULT NULL,
//  `Physics Rem` varchar(2) DEFAULT NULL,
//  `Phy_Position` varchar(10) DEFAULT NULL,
//  `Chemistry CA` int(2) DEFAULT NULL,
//  `Chemistry Exam` int(2) DEFAULT NULL,
//  `Chemistry` int(2) DEFAULT NULL,
//  `Chemistry Rem` varchar(2) DEFAULT NULL,
//  `Chem_Position` varchar(10) DEFAULT NULL,
//  `Further Maths CA` int(2) DEFAULT NULL,
//  `Further Maths Exam` int(2) DEFAULT NULL,
//  `Further Maths` int(2) DEFAULT NULL,
//  `Further Maths Rem` varchar(2) DEFAULT NULL,
//  `Fmaths_Position` varchar(10) DEFAULT NULL,
//  `Civic Ed CA` int(2) DEFAULT NULL,
//  `Civic Ed Exam` int(2) DEFAULT NULL,
//  `Civic Ed` int(2) DEFAULT NULL,
//  `Civic Ed Rem` varchar(2) DEFAULT NULL,
//  `Civic_Position` varchar(10) DEFAULT NULL,
//  `Computer CA` int(2) DEFAULT NULL,
//  `Computer Exam` int(2) DEFAULT NULL,
//  `Computer` int(2) DEFAULT NULL,
//  `Computer Rem` varchar(2) DEFAULT NULL,
//  `Computer_Position` varchar(10) DEFAULT NULL,
//  `Office Practice CA` int(2) DEFAULT NULL,
//  `Office Practice Exam` int(2) DEFAULT NULL,
//  `Office Practice` int(2) DEFAULT NULL,
//  `Office Practice Rem` varchar(2) DEFAULT NULL,
//  `OP_Position` varchar(10) DEFAULT NULL,
//  `Yoruba CA` int(2) DEFAULT NULL,
//  `Yoruba Exam` int(2) DEFAULT NULL,
//  `Yoruba` int(2) DEFAULT NULL,
//  `Yoruba Rem` varchar(2) DEFAULT NULL,
//  `Yoruba_Position` varchar(10) DEFAULT NULL,
//  `CRS CA` int(1) DEFAULT NULL,
//  `CRS Exam` int(2) DEFAULT NULL,
//  `CRS` int(2) DEFAULT NULL,
//  `CRS Rem` varchar(3) DEFAULT NULL,
//  `CRS_Position` varchar(10) DEFAULT NULL,
//  `IRS CA` int(2) DEFAULT NULL,
//  `IRS Exam` int(2) DEFAULT NULL,
//  `IRS` int(2) DEFAULT NULL,
//  `IRS Rem` varchar(2) DEFAULT NULL,
//  `IRS_Position` varchar(10) DEFAULT NULL,
//  `TD CA` int(2) DEFAULT NULL,
//  `TD Exam` int(2) DEFAULT NULL,
//  `TD` int(2) DEFAULT NULL,
//  `TD Rem` varchar(2) DEFAULT NULL,
//  `TD_Position` varchar(10) DEFAULT NULL,
//  `Catering CA` int(2) DEFAULT NULL,
//  `Catering Exam` int(2) DEFAULT NULL,
//  `Catering` int(2) DEFAULT NULL,
//  `Catering Rem` varchar(2) DEFAULT NULL,
//  `Catering_Position` varchar(10) DEFAULT NULL,
//  `Animal Hus CA` int(2) DEFAULT NULL,
//  `Animal Hus Exam` int(2) DEFAULT NULL,
//  `Animal Hus` int(2) DEFAULT NULL,
//  `Animal Hus Rem` varchar(2) DEFAULT NULL,
//  `Animal_Position` varchar(10) DEFAULT NULL,
//  `Paint_Decor CA` int(2) DEFAULT NULL,
//  `Paint_Decor Exam` int(2) DEFAULT NULL,
//  `Paint_Decor` int(1) DEFAULT NULL,
//  `Paint_Decor Rem` varchar(1) DEFAULT NULL,
//  `PD_Position` varchar(10) DEFAULT NULL,
//  `Average` decimal(4,1) DEFAULT NULL,
//  `Subj Offered` int(2) DEFAULT NULL,
//  `Teacher` varchar(5) DEFAULT NULL,
//  `Principal` varchar(6) DEFAULT NULL,
//  `Punctuality` varchar(1) DEFAULT NULL,
//  `Attendance` varchar(1) DEFAULT NULL,
//  `Reliability` varchar(1) DEFAULT NULL,
//  `Politeness` varchar(1) DEFAULT NULL,
//  `Honesty` varchar(1) DEFAULT NULL,
//  `Self Control` varchar(1) DEFAULT NULL,
//  `Staff Rship` varchar(1) DEFAULT NULL,
//  `Student Rship` varchar(1) DEFAULT NULL,
//  `Initiative` varchar(1) DEFAULT NULL,
//  `Org Ability` varchar(1) DEFAULT NULL,
//   PRIMARY KEY (`ID`))
//   ENGINE = MyISAM AUTO_INCREMENT = 1 DEFAULT CHARSET = utf8;",  tbl);


//            var cmd = new MySql.Data.MySqlClient.MySqlCommand(createTableQuery, connection);
//            cmd.ExecuteNonQuery();
//            MessageBox.Show("Table Created Successfully!");

        }

        private void NewEntry_Load(object sender, EventArgs e)
        {
           // listLoad("SHOW TABLES FROM sis");
           
       

            //read database name
             listLoad2("select SCHEMA_NAME from information_schema.SCHEMATA");
      //
        

                  // DataTable dt = connection.GetSchema("Tables");   //Get list of user tables  
                  //connection.Close(); foreach (DataRow dataRow in dt.Rows)
                  // {

                  //     txtClass.Items.Add(dataRow["TABLE_NAME"].ToString().Trim());

                  // }
            

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
            string clazz = "jss";
            listLoad("SELECT TABLE_NAME FROM information_schema.TABLES where TABLE_SCHEMA='" + txtSess.Text + "' AND TABLE_NAME like'%" + clazz + "%' order by TABLE_NAME ASC");

       //     listLoad("SHOW TABLES FROM db_name [LIKE 'jss']");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
