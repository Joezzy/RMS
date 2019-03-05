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
    public partial class Regjss : Form
    {
        Connect connect = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
       

        public Regjss(string klass, string xex)
        {
            InitializeComponent();

            string logg = klass;
            string sess = xex;
            txtTable.Text = logg;
            txtDb.Text = sess;

        }

        private void Reg_Load(object sender, EventArgs e)
        {

            string dbb = txtDb.Text;
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");
        }


   



        public int calc( string cca,string exm)
        {
            if (cca == "")
               cca = "0";
            if (exm == "")
                exm = "0";


            int ca = Convert.ToInt32(cca);
            int exam = Convert.ToInt32(exm);
          
            int tt = ca + exam;
 
            return tt;
        }

        public string grade(int tt)
        {

            string grade = "";
            if (tt >= 0 && tt <=39)
                grade = "Fail";

            if (tt >= 40 && tt <=49)
                grade = "Pass";

            if (tt >= 50 && tt <=59)
                grade = "Average";

            if (tt >= 60 && tt <=69)
                grade = "Good";

            if (tt >= 70 && tt <= 79)
                grade = "V.Good";

            if (tt >= 80 && tt <= 100)
                grade = "Excellent";
            if (tt == 0)
                grade = "";
                


            return grade;
            
        }

        /// <summary>
        /// calculation for total and grade start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>










      


     
        //validating all the CA boxes
        
        private void mathca_TextChanged(object sender, EventArgs e)
        {
            if (mathca.Text == "")
                mathca.Text = "0";

            int ca = Convert.ToInt32(mathca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                mathca.Text = "";
                mathca.Focus();
            }
            else
            {
                mathtt.Text = Convert.ToString(calc(mathca.Text, mathexam.Text));
                mathremark.Text = grade(calc(mathca.Text, mathexam.Text));
                addUp();
            }
        }

        private void secca_TextChanged(object sender, EventArgs e)
        {
            if (secca.Text == "")
                secca.Text = "0";

            int ca = Convert.ToInt32(secca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                secca.Text = "";
                secca.Focus();
            }
            else
            {
                sectt.Text = Convert.ToString(calc(secca.Text, secexam.Text));
                secremark.Text = grade(calc(secca.Text, secexam.Text));
                addUp();
            }

        }

        private void secexam_TextChanged(object sender, EventArgs e)
        {
            if (secexam.Text == "")
                secexam.Text = "0";

            int ca = Convert.ToInt32(secexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                secexam.Text = "";
                secexam.Focus();
            }
            else
            {
                sectt.Text = Convert.ToString(calc(secca.Text, secexam.Text));
                secremark.Text = grade(calc(secca.Text, secexam.Text));
                addUp();
            }

        }

        private void mathexam_TextChanged(object sender, EventArgs e)
        {
            if (mathexam.Text == "")
                mathexam.Text = "0";

            int ca = Convert.ToInt32(mathexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                mathexam.Text = "";
                mathexam.Focus();
            }
            else
            {
                mathtt.Text = Convert.ToString(calc(mathca.Text, mathexam.Text));
                mathremark.Text = grade(calc(mathca.Text, mathexam.Text));
                addUp();
            }

        }

        private void engca_TextChanged(object sender, EventArgs e)
        {
            if (engca.Text == "")
                engca.Text = "0";

            int ca = Convert.ToInt32(engca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                engca.Text = "";
                engca.Focus();
            }
            else
            {
                engtt.Text = Convert.ToString(calc(engca.Text, engexam.Text));
                engremark.Text = grade(calc(engca.Text, engexam.Text));
                addUp();
            }
        }

        private void ssca_TextChanged(object sender, EventArgs e)
        {
            if (ssca.Text == "")
                ssca.Text = "0";

            int ca = Convert.ToInt32(ssca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                ssca.Text = "";
                ssca.Focus();
            }
            else
            {
                sstt.Text = Convert.ToString(calc(ssca.Text, ssexam.Text));
                ssremark.Text = grade(calc(ssca.Text, ssexam.Text));
                addUp();
            }
        }

        private void bsca_TextChanged(object sender, EventArgs e)
        {
            if (bsca.Text == "")
                bsca.Text = "0";

            int ca = Convert.ToInt32(bsca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                bsca.Text = "";
                bsca.Focus();
            }
            else
            {
                bstt.Text = Convert.ToString(calc(bsca.Text, bsexam.Text));
                bsremark.Text = grade(calc(bsca.Text, bsexam.Text));
                addUp();
            }
        }

        private void btca_TextChanged(object sender, EventArgs e)
        {
            if (btca.Text == "")
                btca.Text = "0";

            int ca = Convert.ToInt32(bsca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                btca.Text = "";
                btca.Focus();
            }
            else
            {
                bttt.Text = Convert.ToString(calc(btca.Text, btexam.Text));
                btremark.Text = grade(calc(btca.Text, btexam.Text));
                addUp();
            }
        }

        private void agricca_TextChanged(object sender, EventArgs e)
        {
            if (agricca.Text == "")
                agricca.Text = "0";

            int ca = Convert.ToInt32(agricca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                agricca.Text = "";
                agricca.Focus();
            }
            else
            {
                agrictt.Text = Convert.ToString(calc(agricca.Text, agricexam.Text));
                agricremark.Text = grade(calc(agricca.Text, agricexam.Text));
                addUp();
            }
        }

        private void heconsca_TextChanged(object sender, EventArgs e)
        {
            if (heconsca.Text == "")
                heconsca.Text = "0";

            int ca = Convert.ToInt32(heconsca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                heconsca.Text = "";
                heconsca.Focus();
            }
            else
            {
                heconstt.Text = Convert.ToString(calc(heconsca.Text, heconsexam.Text));
                heconsremark.Text = grade(calc(heconsca.Text, heconsexam.Text));
                addUp();
            }
        }

        private void civicca_TextChanged(object sender, EventArgs e)
        {
            if (civicca.Text == "")
                civicca.Text = "0";

            int ca = Convert.ToInt32(civicca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                civicca.Text = "";
                civicca.Focus();
            }
            else
            {
                civictt.Text = Convert.ToString(calc(civicca.Text, civicexam.Text));
                civicremark.Text = grade(calc(civicca.Text, civicexam.Text));
                addUp();
            }
        }

        private void csca_TextChanged(object sender, EventArgs e)
        {
            if (csca.Text == "")
                csca.Text = "0";

            int ca = Convert.ToInt32(csca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                csca.Text = "";
                csca.Focus();
            }
            else
            {
                cstt.Text = Convert.ToString(calc(csca.Text, csexam.Text));
                csremark.Text = grade(calc(csca.Text, csexam.Text));
                addUp();
            }
        }

        private void caca_TextChanged(object sender, EventArgs e)
        {
            if (caca.Text == "")
                caca.Text = "0";

            int ca = Convert.ToInt32(caca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                caca.Text = "";
                caca.Focus();
            }
            else
            {
                catt.Text = Convert.ToString(calc(caca.Text, caexam.Text));
                caremark.Text = grade(calc(caca.Text, caexam.Text));
                addUp();
            }
        }

        private void bizca_TextChanged(object sender, EventArgs e)
        {
            if (bizca.Text == "")
                bizca.Text = "0";

            int ca = Convert.ToInt32(bizca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                bizca.Text = "";
                bizca.Focus();
            }
            else
            {
                biztt.Text = Convert.ToString(calc(bizca.Text, bizexam.Text));
                bizremark.Text = grade(calc(bizca.Text, bizexam.Text));
                addUp();
            }
        }

        private void frenchca_TextChanged(object sender, EventArgs e)
        {
            if (frenchca.Text == "")
                frenchca.Text = "0";

            int ca = Convert.ToInt32(frenchca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                frenchca.Text = "";
                frenchca.Focus();
            }
            else
            {
                frenchtt.Text = Convert.ToString(calc(frenchca.Text, frenchexam.Text));
                frenchremark.Text = grade(calc(frenchca.Text, frenchexam.Text));
                addUp();
            }
        }

        private void yorca_TextChanged(object sender, EventArgs e)
        {
            if (yorca.Text == "")
                yorca.Text = "0";

            int ca = Convert.ToInt32(yorca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                yorca.Text = "";
                yorca.Focus();
            }
            else
            {
                yortt.Text = Convert.ToString(calc(yorca.Text, yorexam.Text));
                yorremark.Text = grade(calc(yorca.Text, yorexam.Text));
                addUp();
            }
        }

        private void crsca_TextChanged(object sender, EventArgs e)
        {
            if (crsca.Text == "")
                crsca.Text = "0";

            int ca = Convert.ToInt32(crsca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                crsca.Text = "";
                crsca.Focus();
            }
            else
            {
                crstt.Text = Convert.ToString(calc(crsca.Text, crsexam.Text));
                crsremark.Text = grade(calc(crsca.Text, crsexam.Text));
                addUp();
            }
        }

        private void irsca_TextChanged(object sender, EventArgs e)
        {
            if (irsca.Text == "")
                irsca.Text = "0";

            int ca = Convert.ToInt32(irsca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                irsca.Text = "";
                irsca.Focus();
            }
            else
            {
                irstt.Text = Convert.ToString(calc(irsca.Text, irsexam.Text));
                irsremark.Text = grade(calc(irsca.Text, irsexam.Text));
                addUp();
            }
        }

        private void pheca_TextChanged(object sender, EventArgs e)
        {
            if (pheca.Text == "")
                pheca.Text = "0";

            int ca = Convert.ToInt32(pheca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                pheca.Text = "";
                pheca.Focus();
            }
            else
            {
                phett.Text = Convert.ToString(calc(pheca.Text, pheexam.Text));
                pheremark.Text = grade(calc(pheca.Text, pheexam.Text));
                addUp();
            }
        }

       
        private void irsexam_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //validation for : only numbers allowed
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

     
       //end of CA
        //beginnig of exam

        private void mathexam_Leave_1(object sender, EventArgs e)
        {
            if (mathexam.Text == "")
            {
                MessageBox.Show("box can not be empty, if no value for now please insert 0");
                mathexam.Focus();
            }
            else
            {
                int ca = Convert.ToInt32(mathexam.Text);
                if (ca > 70)
                {
                    MessageBox.Show("C/A can not be more than 70 marks");
                    mathexam.Text = "";
                    mathexam.Focus();
                }
                else
                {
                    mathtt.Text = Convert.ToString(calc(mathca.Text, mathexam.Text));
                    mathremark.Text = grade(calc(mathca.Text, mathexam.Text));
                }
            }
        }
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          //  newToolStripMenuItem.Enabled = false;
            mnuNew.Enabled = false;
            mnuSave.Enabled = true;
            Klear();
            button1.Enabled = true;
            txtSearch.Visible = false;
            listBox1.Visible = false;
        }



        public void InsDelup(string str)
        {

            string dbb = txtDb.Text;
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");

            MySqlCommand cmd = new MySqlCommand(str, con);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if ( txtSurname.Text == "" || txtSession.Text == "" || txtGender.Text == "" || txtClass.Text == "" || txtOthernames.Text == "" || txtTerm.Text == "")
            {
                MessageBox.Show("Complete details in About the Student and session to save");

            }
            else
            {

                string dbb = txtDb.Text;
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");
                con.Open();
                string CmdString = "insert into " + txtTable.Text + " (Surname,Other_Names,Gender,Session,Term,Class," +

                    "Mathematics_CA,Mathematics_Exam,Mathematics,Mathematics_Rem," +
                    "English_Language_CA,English_Language_Exam,English_Language,English_Language_Rem," +
                    "Social_Studies_CA,Social_Studies_Exam,Social_Studies,Social_Studies_Rem," +
                    "Basic_Science_CA,Basic_Science_Exam,Basic_Science,Basic_Science_Rem," +
                    "Basic_Tech_CA,Basic_Tech_Exam,Basic_Tech,Basic_Tech_Rem," +

                    "Agric_Science_CA,Agric_Science_Exam,Agric_Science,Agric_Science_Rem," +
                    "Home_Econs_CA,Home_Econs_Exam,Home_Econs,Home_Econs_Rem," +
                    "Civic_Ed_CA,Civic_Ed_Exam,Civic_Ed,Civic_Ed_Rem," +
                    "Computer_CA,Computer_Exam,Computer,Computer_Rem," +

                    "CCA_CA,CCA_Exam,CCA,CCA_Rem," +
                    "Business_Studies_CA,Business_Studies_Exam,Business_Studies,Business_Studies_Rem," +
                    "PHE_CA,PHE_Exam,PHE,PHE_Rem," +
                    "French_CA,French_Exam,French,French_Rem," +

                    "Yoruba_CA,Yoruba_Exam,Yoruba,Yoruba_Rem," +
                    "CRS_CA,CRS_Exam,CRS,CRS_Rem," +
                    "IRS_CA,IRS_Exam,IRS,IRS_Rem," +
                    "Security_Studies_CA,Security_Studies_Exam,Security_Studies,Security_Studies_Rem,Average," +
                    "Teacher,Principal,Punctuality,Attendance,Reliability,Politeness,Honesty,Self_Control,Staff_Rship,Student_Rship," +

                    "Initiative,Org_Ability) Values (@Surname,@Other_Names,@Gender,@Session,@Term,@Class," +

                    "@Mathematics_CA,@Mathematics_Exam,@Mathematics,@Mathematics_Rem," +
                    "@English_Language_CA,@English_Language_Exam,@English_Language,@English_Language_Rem," +
                    "@Social_Studies_CA,@Social_Studies_Exam,@Social_Studies,@Social_Studies_Rem," +
                    "@Basic_Science_CA,@Basic_Science_Exam,@Basic_Science,@Basic_Science_Rem," +
                    "@Basic_Tech_CA,@Basic_Tech_Exam,@Basic_Tech,@Basic_Tech_Rem," +

                    "@Agric_Science_CA,@Agric_Science_Exam,@Agric_Science,@Agric_Science_Rem," +
                    "@Home_Econs_CA,@Home_Econs_Exam,@Home_Econs,@Home_Econs_Rem," +
                    "@Civic_Ed_CA,@Civic_Ed_Exam,@Civic_Ed,@Civic_Ed_Rem," +
                    "@Computer_CA,@Computer_Exam,@Computer,@Computer_Rem," +

                    "@CCA_CA,@CCA_Exam,@CCA,@CCA_Rem," +
                    "@Business_Studies_CA,@Business_Studies_Exam,@Business_Studies,@Business_Studies_Rem," +
                    "@PHE_CA,@PHE_Exam,@PHE,@PHE_Rem," +
                    "@French_CA,@French_Exam,@French,@French_Rem," +

                    "@Yoruba_CA,@Yoruba_Exam,@Yoruba,@Yoruba_Rem," +
                    "@CRS_CA,@CRS_Exam,@CRS,@CRS_Rem," +
                    "@IRS_CA,@IRS_Exam,@IRS,@IRS_Rem," +
                    "@Security_Studies_CA,@Security_Studies_Exam,@Security_Studies,@Security_Studies_Rem,Average," +
                    "@Teacher,@Principal,@Punctuality,@Attendance,@Reliability,@Politeness,@Honesty,@Self_Control,@Staff_Rship,@Student_Rship," +

                    "@Initiative,@Org_Ability)";

                //connect.InsDelup(CmdString);
                MySqlCommand cmd = new MySqlCommand(CmdString, con);

                cmd.Parameters.Add("@Surname", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@Other_Names", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@Gender", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@Session", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@Term", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@Class", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Mathematics_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Mathematics_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Mathematics", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@Mathematics_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@English_Language_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@English_Language_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@English_Language", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@English_Language_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Social_Studies_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Social_Studies_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Social_Studies", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@Social_Studies_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Basic_Science_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Basic_Science_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Basic_Science", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@Basic_Science_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Basic_Tech_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Basic_Tech_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Basic_Tech", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@Basic_Tech_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Agric_Science_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Agric_Science_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Agric_Science", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@Agric_Science_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Home_Econs_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Home_Econs_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Home_Econs", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@Home_Econs_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Civic_Ed_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Civic_Ed_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Civic_Ed", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@Civic_Ed_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Computer_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Computer_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Computer", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@Computer_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@CCA_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@CCA_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@CCA", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@CCA_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Business_Studies_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Business_Studies_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Business_Studies", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@Business_Studies_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@PHE_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@PHE_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@PHE", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@PHE_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@French_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@French_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@French", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@French_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Yoruba_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Yoruba_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Yoruba", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@Yoruba_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@CRS_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@CRS_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@CRS", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@CRS_Rem", MySqlDbType.VarChar, 45);


                cmd.Parameters.Add("@IRS_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@IRS_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@IRS", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@IRS_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Security_Studies_CA", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Security_Studies_Exam", MySqlDbType.Int32, 2);
                cmd.Parameters.Add("@Security_Studies", MySqlDbType.Int32, 3);
                cmd.Parameters.Add("@Security_Studies_Rem", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Average", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Teacher", MySqlDbType.Text);
                cmd.Parameters.Add("@Principal", MySqlDbType.Text);
                cmd.Parameters.Add("@Punctuality", MySqlDbType.VarChar, 3);
                cmd.Parameters.Add("@Attendance", MySqlDbType.VarChar, 45);

                cmd.Parameters.Add("@Reliability", MySqlDbType.VarChar, 2);
                cmd.Parameters.Add("@Politeness", MySqlDbType.VarChar, 2);
                cmd.Parameters.Add("@Honesty", MySqlDbType.VarChar, 3);
                cmd.Parameters.Add("@Self_Control", MySqlDbType.VarChar, 45);


                cmd.Parameters.Add("@Staff_Rship", MySqlDbType.VarChar, 2);
                cmd.Parameters.Add("@Student_Rship", MySqlDbType.VarChar, 2);
                cmd.Parameters.Add("@Initiative", MySqlDbType.VarChar, 3);
                cmd.Parameters.Add("@Org_Ability", MySqlDbType.VarChar, 45);

                ///////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////////
                //////////////////////////////////////////////////////////
                cmd.Parameters["@Surname"].Value = txtSurname.Text;
                cmd.Parameters["@Other_Names"].Value = txtOthernames.Text;
                cmd.Parameters["@Gender"].Value = txtGender.Text;
                cmd.Parameters["@Session"].Value = txtSession.Text;
                cmd.Parameters["@Term"].Value = txtTerm.Text;
                cmd.Parameters["@Class"].Value = txtClass.Text;


                cmd.Parameters["@Mathematics_CA"].Value = mathca.Text;
                cmd.Parameters["@Mathematics_Exam"].Value = mathexam.Text;
                cmd.Parameters["@Mathematics"].Value = mathtt.Text;
                cmd.Parameters["@Mathematics_Rem"].Value = mathremark.Text;


                cmd.Parameters["@English_Language_CA"].Value = engca.Text;
                cmd.Parameters["@English_Language_Exam"].Value = engexam.Text;
                cmd.Parameters["@English_Language"].Value = engtt.Text;
                cmd.Parameters["@English_Language_Rem"].Value = engremark.Text;


                cmd.Parameters["@Social_Studies_CA"].Value = ssca.Text;
                cmd.Parameters["@Social_Studies_Exam"].Value = ssexam.Text;
                cmd.Parameters["@Social_Studies"].Value = sstt.Text;
                cmd.Parameters["@Social_Studies_Rem"].Value = ssremark.Text;


                cmd.Parameters["@Basic_Science_CA"].Value = bsca.Text;
                cmd.Parameters["@Basic_Science_Exam"].Value = bsexam.Text;
                cmd.Parameters["@Basic_Science"].Value = bstt.Text;
                cmd.Parameters["@Basic_Science_Rem"].Value = bsremark.Text;

                cmd.Parameters["@Basic_Tech_CA"].Value = btca.Text;
                cmd.Parameters["@Basic_Tech_Exam"].Value = btexam.Text;
                cmd.Parameters["@Basic_Tech"].Value = bttt.Text;
                cmd.Parameters["@Basic_Tech_Rem"].Value = btremark.Text;


                cmd.Parameters["@Agric_Science_CA"].Value = agricca.Text;
                cmd.Parameters["@Agric_Science_Exam"].Value = agricexam.Text;
                cmd.Parameters["@Agric_Science"].Value = agrictt.Text;
                cmd.Parameters["@Agric_Science_Rem"].Value = agricremark.Text;

                cmd.Parameters["@Home_Econs_CA"].Value = heconsca.Text;
                cmd.Parameters["@Home_Econs_Exam"].Value = heconsexam.Text;
                cmd.Parameters["@Home_Econs"].Value = heconstt.Text;
                cmd.Parameters["@Home_Econs_Rem"].Value = heconsremark.Text;


                cmd.Parameters["@Civic_Ed_CA"].Value = civicca.Text;
                cmd.Parameters["@Civic_Ed_Exam"].Value = civicexam.Text;
                cmd.Parameters["@Civic_Ed"].Value = civictt.Text;
                cmd.Parameters["@Civic_Ed_Rem"].Value = civicremark.Text;

                cmd.Parameters["@Computer_CA"].Value = csca.Text;
                cmd.Parameters["@Computer_Exam"].Value = csexam.Text;
                cmd.Parameters["@Computer"].Value = cstt.Text;
                cmd.Parameters["@Computer_Rem"].Value = csremark.Text;


                cmd.Parameters["@CCA_CA"].Value = caca.Text;
                cmd.Parameters["@CCA_Exam"].Value = caexam.Text;
                cmd.Parameters["@CCA"].Value = catt.Text;
                cmd.Parameters["@CCA_Rem"].Value = caremark.Text;

                cmd.Parameters["@Business_Studies_CA"].Value = bizca.Text;
                cmd.Parameters["@Business_Studies_Exam"].Value = bizexam.Text;
                cmd.Parameters["@Business_Studies"].Value = biztt.Text;
                cmd.Parameters["@Business_Studies_Rem"].Value = bizremark.Text;


                cmd.Parameters["@PHE_CA"].Value = pheca.Text;
                cmd.Parameters["@PHE_Exam"].Value = pheexam.Text;
                cmd.Parameters["@PHE"].Value = phett.Text;
                cmd.Parameters["@PHE_Rem"].Value = pheremark.Text;

                cmd.Parameters["@French_CA"].Value = frenchca.Text;
                cmd.Parameters["@French_Exam"].Value = frenchexam.Text;
                cmd.Parameters["@French"].Value = frenchtt.Text;
                cmd.Parameters["@French_Rem"].Value = frenchremark.Text;


                cmd.Parameters["@Yoruba_CA"].Value = yorca.Text;
                cmd.Parameters["@Yoruba_Exam"].Value = yorexam.Text;
                cmd.Parameters["@Yoruba"].Value = yortt.Text;
                cmd.Parameters["@Yoruba_Rem"].Value = yorremark.Text;

                cmd.Parameters["@CRS_CA"].Value = crsca.Text;
                cmd.Parameters["@CRS_Exam"].Value = crsexam.Text;
                cmd.Parameters["@CRS"].Value = crstt.Text;
                cmd.Parameters["@CRS_Rem"].Value = crsremark.Text;


                cmd.Parameters["@IRS_CA"].Value = irsca.Text;
                cmd.Parameters["@IRS_Exam"].Value = irsexam.Text;
                cmd.Parameters["@IRS"].Value = irstt.Text;
                cmd.Parameters["@IRS_Rem"].Value = irsremark.Text;

       

                cmd.Parameters["@Security_Studies_CA"].Value = secca.Text;
                cmd.Parameters["@Security_Studies_Exam"].Value = secexam.Text;
                cmd.Parameters["@Security_Studies"].Value = sectt.Text;
                cmd.Parameters["@Security_Studies_Rem"].Value = secremark.Text;


                cmd.Parameters["@Average"].Value = txtAvg.Text;

                cmd.Parameters["@Teacher"].Value = txtTeacher.Text;
                cmd.Parameters["@Principal"].Value = txtPple.Text;
                cmd.Parameters["@Punctuality"].Value = txtPun.Text;
                cmd.Parameters["@Attendance"].Value = txtAtt.Text;


                cmd.Parameters["@Reliability"].Value = txtRel.Text;
                cmd.Parameters["@Politeness"].Value = txtPol.Text;
                cmd.Parameters["@Honesty"].Value = txtHon.Text;
                cmd.Parameters["@Self_Control"].Value = txtSelf.Text;

                cmd.Parameters["@Staff_Rship"].Value = txtStaff.Text;
                cmd.Parameters["@Student_Rship"].Value = txtStudent.Text;
                cmd.Parameters["@Initiative"].Value = txtInit.Text;
                cmd.Parameters["@Org_Ability"].Value = txtOrg.Text;

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Record Saved","Result System");
                Klear();
                mnuNew.Enabled = true;
                mnuSave.Enabled = false;
            }
        }



        void Klear()
        {
             txtSurname.Text="";
            txtOthernames.Text="";
           txtSession.Text="";
           txtTerm.Text=" ";
          txtClass.Text=" ";
      
          txtGender.Text = " ";

             mathca.Text="0";
        mathexam.Text="0";
                mathtt.Text="0";
                 mathremark.Text="";

              engca.Text="0";
          engexam.Text="0";
            engtt.Text="0";
                engremark.Text="";

               ssca.Text="0";
                ssexam.Text="0";
                sstt.Text="0";
                ssremark.Text="";

                 bsca.Text="0";
                bsexam.Text="0";
                bstt.Text="0";
                bsremark.Text="";

                 btca.Text="0";
                btexam.Text="0";
                bttt.Text="0";
                btremark.Text="";

              
                   agricca.Text="0";
                   agricexam.Text="0";
                   agrictt.Text="0";
                   agricremark.Text="";

                heconsca.Text="0";
                heconsexam.Text="0";
                heconstt.Text="0"; 
                heconsremark.Text="";

              civicca.Text="0";
                civicexam.Text="0";
                civictt.Text="0";
                civicremark.Text="";

               csca.Text="0";
                csexam.Text="0";
                cstt.Text="0";
                csremark.Text="";

                  caca.Text="0";
                   caexam.Text="0";
                   catt.Text="0";
                   caremark.Text="";

                 bizca.Text="0";
                bizexam.Text="0";
                biztt.Text="0";
                bizremark.Text="";

             pheca.Text="0";
                pheexam.Text="0";
                phett.Text="0";
                pheremark.Text="";

                 frenchca.Text="0";
                 frenchexam.Text = "0";
                frenchtt.Text="0";
                frenchremark.Text="";

                 yorca.Text="0";
                 yorexam.Text = "0";
                  yortt.Text="0";
                  yorremark.Text="";

               crsca.Text="0";
                crsexam.Text="0";
                crstt.Text="0";
                crsremark.Text="";

                irsca.Text="0";
                irsexam.Text="0";
                irstt.Text="0";
                irsremark.Text="";

                txtPun.Text = "";
                txtAtt.Text = "";
                txtRel.Text = "";
                txtPol.Text = "";
                txtHon.Text = "";
                txtSelf.Text = "";
                txtStaff.Text = "";
                txtStudent.Text = "";
                txtInit.Text = "";
                txtOrg.Text = "";
      
        }

        public void listRead(string qry)
        {

            string dbb = txtDb.Text;
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");

            MySqlCommand cmd = new MySqlCommand(qry, con);
            MySqlDataReader reader;



            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                reader.Read();
                txtId.Text = reader["ID"].ToString();
                txtSurname.Text = reader["Surname"].ToString();
                txtOthernames.Text = reader["Other_Names"].ToString();
                txtGender.Text = reader["Gender"].ToString();
                txtClass.Text = reader["Class"].ToString();
                txtTerm.Text = reader["Term"].ToString();
                txtSession.Text = reader["Session"].ToString();
             

                mathca.Text = reader["Mathematics_CA"].ToString();
                mathexam.Text = reader["mathematics_Exam"].ToString(); 
                mathtt.Text = reader["Mathematics"].ToString();
                mathremark.Text = reader["Mathematics_Rem"].ToString();

                engca.Text = reader["English_Language_CA"].ToString();
                engexam.Text = reader["English_Language_Exam"].ToString();
                engtt.Text = reader["English_Language"].ToString();
                engremark.Text = reader["English_Language_Rem"].ToString();

                ssca.Text = reader["Social_Studies_CA"].ToString();
                ssexam.Text = reader["Social_Studies_Exam"].ToString();
                sstt.Text = reader["Social_Studies"].ToString();
                ssremark.Text = reader["Social_Studies_Rem"].ToString();

                bsca.Text = reader["Basic_Science_CA"].ToString();
                bsexam.Text = reader["Basic_Science_Exam"].ToString();
                bstt.Text = reader["Basic_Science"].ToString();
                bsremark.Text = reader["Basic_Science_Rem"].ToString();

                btca.Text = reader["Basic_Tech_CA"].ToString();
                btexam.Text = reader["Basic_Tech_Exam"].ToString();
                bttt.Text = reader["Basic_Tech"].ToString();
                btremark.Text = reader["Basic_Tech_Rem"].ToString();

                agricca.Text = reader["Agric_Science_CA"].ToString();
                agricexam.Text = reader["Agric_Science_Exam"].ToString();
                agrictt.Text = reader["Agric_Science"].ToString();
                agricremark.Text = reader["Agric_Science_Rem"].ToString();

                heconsca.Text = reader["Home_Econs_CA"].ToString();
                heconsexam.Text = reader["Home_Econs_Exam"].ToString();
                heconstt.Text = reader["Home_Econs"].ToString();
                heconsremark.Text = reader["Home_Econs_Rem"].ToString();

                civicca.Text = reader["Civic_Ed_CA"].ToString();
                civicexam.Text = reader["Civic_Ed_Exam"].ToString();
                civictt.Text = reader["Civic_Ed"].ToString();
                civicremark.Text = reader["Civic_Ed_Rem"].ToString();

                csca.Text = reader["Computer_CA"].ToString();
                csexam.Text = reader["Computer_Exam"].ToString();
                cstt.Text = reader["Computer"].ToString();
                csremark.Text = reader["Computer_Rem"].ToString();

                caca.Text = reader["CCA_CA"].ToString();
                caexam.Text = reader["CCA_Exam"].ToString();
                catt.Text = reader["CCA"].ToString();
                caremark.Text = reader["CCA_Rem"].ToString();

                bizca.Text = reader["Business_Studies_CA"].ToString();
                bizexam.Text = reader["Business_Studies_Exam"].ToString();
                biztt.Text = reader["Business_Studies"].ToString();
                bizremark.Text = reader["Business_Studies_Rem"].ToString();

                frenchca.Text = reader["French_CA"].ToString();
                frenchexam.Text = reader["French_Exam"].ToString();
                frenchtt.Text = reader["French"].ToString();
                frenchremark.Text = reader["French_Rem"].ToString();

                yorca.Text = reader["Yoruba_CA"].ToString();
                yorexam.Text = reader["Yoruba_Exam"].ToString();
                yortt.Text = reader["Yoruba"].ToString();
                yorremark.Text = reader["Yoruba_Rem"].ToString();

                crsca.Text = reader["CRS_CA"].ToString();
                crsexam.Text = reader["CRS_Exam"].ToString();
                crstt.Text = reader["CRS"].ToString();
                crsremark.Text = reader["CRS_Rem"].ToString();

                irsca.Text = reader["IRS_CA"].ToString();
                irsexam.Text = reader["IRS_Exam"].ToString();
                irstt.Text = reader["IRS"].ToString();
                irsremark.Text = reader["IRS_Rem"].ToString();

                pheca.Text = reader["PHE_CA"].ToString();
                pheexam.Text = reader["PHE_Exam"].ToString();
                phett.Text = reader["PHE"].ToString();
                pheremark.Text = reader["PHE_Rem"].ToString();

                secca.Text = reader["Security_Studies_CA"].ToString();
                secexam.Text = reader["Security_Studies_Exam"].ToString();
                sectt.Text = reader["Security_Studies"].ToString();
                secremark.Text = reader["Security_Studies_Rem"].ToString();

                txtTeacher.Text = reader["Teacher"].ToString();
                txtPple.Text = reader["Principal"].ToString();

                txtPun.Text = reader["Punctuality"].ToString();
                txtAtt.Text = reader["Attendance"].ToString();
                txtRel.Text = reader["Reliability"].ToString();
                txtPol.Text = reader["Politeness"].ToString();
                txtHon.Text = reader["Honesty"].ToString();
                txtSelf.Text = reader["Self_Control"].ToString();
                txtStaff.Text = reader["Staff_Rship"].ToString();
                txtStudent.Text = reader["Student_Rship"].ToString();
                txtInit.Text = reader["Initiative"].ToString();
                txtOrg.Text = reader["Org_Ability"].ToString();

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void listLoad(string str)
        {

            string dbb = txtDb.Text;
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");

            MySqlCommand cm = new MySqlCommand(str, con);
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    listBox1.Items.Add(dr["Surname"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            if (txtSurname.Text == "" || txtSession.Text == "" || txtGender.Text == "" || txtClass.Text == "" || txtOthernames.Text == "" || txtTerm.Text == "")
            {
                MessageBox.Show("Complete details in About the Student and session to save");

            }
            else
            {

                string dbb = txtDb.Text;
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");
                con.Open();
                try
                {
                    string CmdString = "UPDATE " + txtTable.Text + " SET Surname=@Surname,Other_Names=@Other_Names,Gender=@Gender,Session=@Session,Term=@Term,Class=@Class," +

                        "Mathematics_CA=@Mathematics_CA,Mathematics_Exam=@Mathematics_Exam,Mathematics=@Mathematics,Mathematics_Rem=@Mathematics_Rem," +
                        "English_Language_CA=@English_Language_CA,English_Language_Exam=@English_Language_Exam,English_Language=@English_Language,English_Language_Rem=@English_Language_Rem," +
                        "Social_Studies_CA=@Social_Studies_CA,Social_Studies_Exam=@Social_Studies_Exam,Social_Studies=@Social_Studies,Social_Studies_Rem=@Social_Studies_Rem," +
                        "Basic_Science_CA=@Basic_Science_CA,Basic_Science_Exam=@Basic_Science_Exam,Basic_Science=@Basic_Science,Basic_Science_Rem=@Basic_Science_Rem," +
                        "Basic_Tech_CA=@Basic_Tech_CA,Basic_Tech_Exam=@Basic_Tech_Exam,Basic_Tech=@Basic_Tech,Basic_Tech_Rem=@Basic_Tech_Rem," +

                        "Agric_Science_CA=@Agric_Science_CA,Agric_Science_Exam=@Agric_Science_Exam,Agric_Science=@Agric_Science,Agric_Science_Rem=@Agric_Science_Rem," +
                        "Home_Econs_CA=@Home_Econs_CA,Home_Econs_Exam=@Home_Econs_Exam,Home_Econs=@Home_Econs,Home_Econs_Rem=@Home_Econs_Rem," +
                        "Civic_Ed_CA=@Civic_Ed_CA,Civic_Ed_Exam=@Civic_Ed_Exam,Civic_Ed=@Civic_Ed,Civic_Ed_Rem=@Civic_Ed_Rem," +
                        "Computer_CA=@Computer_CA,Computer_Exam=@Computer_Exam,Computer=@Computer,Computer_Rem=@Computer_Rem," +

                        "CCA_CA=@CCA_CA,CCA_Exam=@CCA_Exam,CCA=@CCA,CCA_Rem=@CCA_Rem," +
                        "Business_Studies_CA=@Business_Studies_CA,Business_Studies_Exam=@Business_Studies_Exam,Business_Studies=@Business_Studies,Business_Studies_Rem=@Business_Studies_Rem," +
                        "PHE_CA=@PHE_CA,PHE_Exam=@PHE_Exam,PHE=@PHE,PHE_Rem=@PHE_Rem," +
                        "French_CA=@French_CA,French_Exam=@French_Exam,French=@French,French_Rem=@French_Rem," +

                        "Yoruba_CA=@Yoruba_CA,Yoruba_Exam=@Yoruba_Exam,Yoruba=@Yoruba,Yoruba_Rem=@Yoruba_Rem," +
                        "CRS_CA=@CRS_CA,CRS_Exam=@CRS_Exam,CRS=@CRS,CRS_Rem=@CRS_Rem," +
                        "IRS_CA=@IRS_CA,IRS_Exam=@IRS_Exam,IRS=@IRS,IRS_Rem=@IRS_Rem," +
                        "Security_Studies_CA=@Security_Studies_CA,Security_Studies_Exam=@Security_Studies_Exam,Security_Studies=@Security_Studies,Security_Studies_Rem=@Security_Studies_Rem,Average=Average," +

                        "Teacher=@Teacher, Principal=@Principal, Punctuality=@Punctuality, Attendance=@Attendance, Reliability=@Reliability, Politeness=@Politeness, Honesty=@Honesty,Self_Control=@Self_Control,Staff_Rship=@Staff_Rship,Student_Rship=@Student_Rship," +

                        "Initiative=@Initiative,Org_Ability=@Org_Ability WHERE id=@id";

                    //connect.InsDelup(CmdString);


                    MySqlCommand cmd = new MySqlCommand(CmdString, con);
                    cmd.Parameters.Add("@id", MySqlDbType.Int64, 45);
                    cmd.Parameters.Add("@Surname", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Other_Names", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Gender", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Session", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Term", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Class", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Mathematics_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Mathematics_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Mathematics", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@Mathematics_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@English_Language_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@English_Language_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@English_Language", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@English_Language_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Social_Studies_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Social_Studies_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Social_Studies", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@Social_Studies_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Basic_Science_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Basic_Science_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Basic_Science", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@Basic_Science_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Basic_Tech_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Basic_Tech_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Basic_Tech", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@Basic_Tech_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Agric_Science_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Agric_Science_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Agric_Science", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@Agric_Science_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Home_Econs_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Home_Econs_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Home_Econs", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@Home_Econs_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Civic_Ed_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Civic_Ed_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Civic_Ed", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@Civic_Ed_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Computer_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Computer_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Computer", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@Computer_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@CCA_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@CCA_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@CCA", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@CCA_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Business_Studies_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Business_Studies_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Business_Studies", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@Business_Studies_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@PHE_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@PHE_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@PHE", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@PHE_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@French_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@French_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@French", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@French_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Yoruba_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Yoruba_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Yoruba", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@Yoruba_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@CRS_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@CRS_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@CRS", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@CRS_Rem", MySqlDbType.VarChar, 45);


                    cmd.Parameters.Add("@IRS_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@IRS_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@IRS", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@IRS_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Security_Studies_CA", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Security_Studies_Exam", MySqlDbType.Int32, 2);
                    cmd.Parameters.Add("@Security_Studies", MySqlDbType.Int32, 3);
                    cmd.Parameters.Add("@Security_Studies_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Average", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Teacher", MySqlDbType.Text);
                    cmd.Parameters.Add("@Principal", MySqlDbType.Text);
                    cmd.Parameters.Add("@Punctuality", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Attendance", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Reliability", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Politeness", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Honesty", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Self_Control", MySqlDbType.VarChar, 45);


                    cmd.Parameters.Add("@Staff_Rship", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Student_Rship", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Initiative", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Org_Ability", MySqlDbType.VarChar, 45);

                    ///////////////////////////////////////////////////////////////////////
                    ///////////////////////////////////////////////
                    //////////////////////////////////////////////////////////
                    cmd.Parameters["@id"].Value = txtId.Text;
                    cmd.Parameters["@Surname"].Value = txtSurname.Text;
                    cmd.Parameters["@Other_Names"].Value = txtOthernames.Text;
                    cmd.Parameters["@Gender"].Value = txtGender.Text;
                    cmd.Parameters["@Session"].Value = txtSession.Text;
                    cmd.Parameters["@Term"].Value = txtTerm.Text;
                    cmd.Parameters["@Class"].Value = txtClass.Text;


                    cmd.Parameters["@Mathematics_CA"].Value = mathca.Text;
                    cmd.Parameters["@Mathematics_Exam"].Value = mathexam.Text;
                    cmd.Parameters["@Mathematics"].Value = mathtt.Text;
                    cmd.Parameters["@Mathematics_Rem"].Value = mathremark.Text;


                    cmd.Parameters["@English_Language_CA"].Value = engca.Text;
                    cmd.Parameters["@English_Language_Exam"].Value = engexam.Text;
                    cmd.Parameters["@English_Language"].Value = engtt.Text;
                    cmd.Parameters["@English_Language_Rem"].Value = engremark.Text;


                    cmd.Parameters["@Social_Studies_CA"].Value = ssca.Text;
                    cmd.Parameters["@Social_Studies_Exam"].Value = ssexam.Text;
                    cmd.Parameters["@Social_Studies"].Value = sstt.Text;
                    cmd.Parameters["@Social_Studies_Rem"].Value = ssremark.Text;


                    cmd.Parameters["@Basic_Science_CA"].Value = bsca.Text;
                    cmd.Parameters["@Basic_Science_Exam"].Value = bsexam.Text;
                    cmd.Parameters["@Basic_Science"].Value = bstt.Text;
                    cmd.Parameters["@Basic_Science_Rem"].Value = bsremark.Text;

                    cmd.Parameters["@Basic_Tech_CA"].Value = btca.Text;
                    cmd.Parameters["@Basic_Tech_Exam"].Value = btexam.Text;
                    cmd.Parameters["@Basic_Tech"].Value = bttt.Text;
                    cmd.Parameters["@Basic_Tech_Rem"].Value = btremark.Text;


                    cmd.Parameters["@Agric_Science_CA"].Value = agricca.Text;
                    cmd.Parameters["@Agric_Science_Exam"].Value = agricexam.Text;
                    cmd.Parameters["@Agric_Science"].Value = agrictt.Text;
                    cmd.Parameters["@Agric_Science_Rem"].Value = agricremark.Text;

                    cmd.Parameters["@Home_Econs_CA"].Value = heconsca.Text;
                    cmd.Parameters["@Home_Econs_Exam"].Value = heconsexam.Text;
                    cmd.Parameters["@Home_Econs"].Value = heconstt.Text;
                    cmd.Parameters["@Home_Econs_Rem"].Value = heconsremark.Text;


                    cmd.Parameters["@Civic_Ed_CA"].Value = civicca.Text;
                    cmd.Parameters["@Civic_Ed_Exam"].Value = civicexam.Text;
                    cmd.Parameters["@Civic_Ed"].Value = civictt.Text;
                    cmd.Parameters["@Civic_Ed_Rem"].Value = civicremark.Text;

                    cmd.Parameters["@Computer_CA"].Value = csca.Text;
                    cmd.Parameters["@Computer_Exam"].Value = csexam.Text;
                    cmd.Parameters["@Computer"].Value = cstt.Text;
                    cmd.Parameters["@Computer_Rem"].Value = csremark.Text;


                    cmd.Parameters["@CCA_CA"].Value = caca.Text;
                    cmd.Parameters["@CCA_Exam"].Value = caexam.Text;
                    cmd.Parameters["@CCA"].Value = catt.Text;
                    cmd.Parameters["@CCA_Rem"].Value = caremark.Text;

                    cmd.Parameters["@Business_Studies_CA"].Value = bizca.Text;
                    cmd.Parameters["@Business_Studies_Exam"].Value = bizexam.Text;
                    cmd.Parameters["@Business_Studies"].Value = biztt.Text;
                    cmd.Parameters["@Business_Studies_Rem"].Value = bizremark.Text;


                    cmd.Parameters["@PHE_CA"].Value = pheca.Text;
                    cmd.Parameters["@PHE_Exam"].Value = pheexam.Text;
                    cmd.Parameters["@PHE"].Value = phett.Text;
                    cmd.Parameters["@PHE_Rem"].Value = pheremark.Text;

                    cmd.Parameters["@French_CA"].Value = frenchca.Text;
                    cmd.Parameters["@French_Exam"].Value = frenchexam.Text;
                    cmd.Parameters["@French"].Value = frenchtt.Text;
                    cmd.Parameters["@French_Rem"].Value = frenchremark.Text;


                    cmd.Parameters["@Yoruba_CA"].Value = yorca.Text;
                    cmd.Parameters["@Yoruba_Exam"].Value = yorexam.Text;
                    cmd.Parameters["@Yoruba"].Value = yortt.Text;
                    cmd.Parameters["@Yoruba_Rem"].Value = yorremark.Text;

                    cmd.Parameters["@CRS_CA"].Value = crsca.Text;
                    cmd.Parameters["@CRS_Exam"].Value = crsexam.Text;
                    cmd.Parameters["@CRS"].Value = crstt.Text;
                    cmd.Parameters["@CRS_Rem"].Value = crsremark.Text;


                    cmd.Parameters["@IRS_CA"].Value = irsca.Text;
                    cmd.Parameters["@IRS_Exam"].Value = irsexam.Text;
                    cmd.Parameters["@IRS"].Value = irstt.Text;
                    cmd.Parameters["@IRS_Rem"].Value = irsremark.Text;



                    cmd.Parameters["@Security_Studies_CA"].Value = secca.Text;
                    cmd.Parameters["@Security_Studies_Exam"].Value = secexam.Text;
                    cmd.Parameters["@Security_Studies"].Value = sectt.Text;
                    cmd.Parameters["@Security_Studies_Rem"].Value = secremark.Text;


                    cmd.Parameters["@Average"].Value = txtAvg.Text;

                    cmd.Parameters["@Teacher"].Value = txtTeacher.Text;
                    cmd.Parameters["@Principal"].Value = txtPple.Text;
                    cmd.Parameters["@Punctuality"].Value = txtPun.Text;
                    cmd.Parameters["@Attendance"].Value = txtAtt.Text;


                    cmd.Parameters["@Reliability"].Value = txtRel.Text;
                    cmd.Parameters["@Politeness"].Value = txtPol.Text;
                    cmd.Parameters["@Honesty"].Value = txtHon.Text;
                    cmd.Parameters["@Self_Control"].Value = txtSelf.Text;

                    cmd.Parameters["@Staff_Rship"].Value = txtStaff.Text;
                    cmd.Parameters["@Student_Rship"].Value = txtStudent.Text;
                    cmd.Parameters["@Initiative"].Value = txtInit.Text;
                    cmd.Parameters["@Org_Ability"].Value = txtOrg.Text;

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Record Updated");
                }catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }
                Klear();
                listBox1.Items.Clear();
                listLoad("select Surname  from " + txtTable.Text + "");
                mnuUpdate.Enabled = false;
                mnuDelete.Enabled = false;
                mnuNew.Enabled = true;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listRead("SELECT * FROM " + txtTable.Text + " WHERE Surname='" + listBox1.Text.ToString() + "'");
            mnuSave.Enabled = false;
            mnuUpdate.Enabled = true;
            mnuDelete.Enabled = true;
            mnuNew.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            txtSearch.Visible = true;
            listBox1.Visible = true;
            listBox1.Items.Clear();
            listLoad("select Surname from " + txtTable.Text + "");
        }

        public void UDQuery(string qry){
        
            
            string dbb = txtDb.Text;
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");
            MySqlCommand cmd;
            con.Open();


            cmd = con.CreateCommand();
            cmd.CommandText = qry;

            cmd.ExecuteNonQuery();


            con.Close();

        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "GDC Report", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {

                UDQuery("Delete  from " + txtTable.Text + "   where id= " + Convert.ToInt32(txtId.Text.Trim()) + "");

                MessageBox.Show("Record Deleted", "GDC Report");
                listBox1.Items.Clear(); listLoad("select Surname  from jss");
                Klear();
                mnuUpdate.Enabled = false;
                mnuDelete.Enabled = false;
                mnuNew.Enabled = true;
            }
            else
            {

            }

          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        
           
            {
                listLoad("select Surname  from " + txtTable.Text + "  where Surname like'%" + txtSearch.Text + "%' order by Surname ASC");
            }

        }



        void addUp()
        {
            float avg;
            int mat= Convert.ToInt32(mathtt.Text);
            int eng = Convert.ToInt32(engtt.Text);
            int ss = Convert.ToInt32(sstt.Text);
            int bs = Convert.ToInt32(bstt.Text);
            int bt = Convert.ToInt32(bttt.Text);
            int ag = Convert.ToInt32(agrictt.Text);
            int hc = Convert.ToInt32(heconstt.Text);
            int cd = Convert.ToInt32(civictt.Text);
            int cs = Convert.ToInt32(cstt.Text);
            int cca = Convert.ToInt32(catt.Text);
            int biz = Convert.ToInt32(biztt.Text);
            int fr = Convert.ToInt32(frenchtt.Text);
            int yor = Convert.ToInt32(yortt.Text);
            int crs = Convert.ToInt32(crstt.Text);
            int irs = Convert.ToInt32(irstt.Text);
            int phe = Convert.ToInt32(phett.Text);
            int sec = Convert.ToInt32(sectt.Text);

           float  tt = mat + eng + ss + bs + bt + ag + hc + cd + cs + cca + biz + fr + yor + crs + irs + phe + sec;
            avg = (tt / 1600)*100;
           // txtAvg.Text = Convert.ToString(avg);
           txtAvg.Text= String.Format("{0:0.0}",avg);
            
            
        }
     

        private void secexam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void engexam_TextChanged(object sender, EventArgs e)
        {
            if (engexam.Text == "")
                engexam.Text = "0";

            int ca = Convert.ToInt32(engexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                engexam.Text = "";
                engexam.Focus();
            }
            else
            {
                engtt.Text = Convert.ToString(calc(engca.Text, engexam.Text));
                engremark.Text = grade(calc(engca.Text, engexam.Text));
                addUp();
            }
        }

        private void ssexam_TextChanged(object sender, EventArgs e)
        {
            if (ssexam.Text == "")
                ssexam.Text = "0";

            int ca = Convert.ToInt32(ssexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                ssexam.Text = "";
                ssexam.Focus();
            }
            else
            {
                sstt.Text = Convert.ToString(calc(ssca.Text, ssexam.Text));
                ssremark.Text = grade(calc(ssca.Text, ssexam.Text));
                addUp();
            }
        }

        private void bsexam_TextChanged(object sender, EventArgs e)
        {
            if (bsexam.Text == "")
                bsexam.Text = "0";

            int ca = Convert.ToInt32(bsexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                bsexam.Text = "";
                bsexam.Focus();
            }
            else
            {
                bstt.Text = Convert.ToString(calc(bsca.Text, bsexam.Text));
                bsremark.Text = grade(calc(bsca.Text, bsexam.Text));
                addUp();
            }
        }

        private void btexam_TextChanged(object sender, EventArgs e)
        {

            if (btexam.Text == "")
                btexam.Text = "0";

            int ca = Convert.ToInt32(btexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                btexam.Text = "";
                btexam.Focus();
            }
            else
            {
                bttt.Text = Convert.ToString(calc(btca.Text, btexam.Text));
                btremark.Text = grade(calc(btca.Text, btexam.Text));
                addUp();
            }
        }

        private void agricexam_TextChanged(object sender, EventArgs e)
        {

            if (agricexam.Text == "")
                agricexam.Text = "0";

            int ca = Convert.ToInt32(agricexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                agricexam.Text = "";
                agricexam.Focus();
            }
            else
            {
                agrictt.Text = Convert.ToString(calc(agricca.Text, agricexam.Text));
                agricremark.Text = grade(calc(agricca.Text, agricexam.Text));
                addUp();
            }
        }

        private void heconsexam_TextChanged(object sender, EventArgs e)
        {
            if (heconsexam.Text == "")
                heconsexam.Text = "0";

            int ca = Convert.ToInt32(heconsexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                heconsexam.Text = "";
                heconsexam.Focus();
            }
            else
            {
                heconstt.Text = Convert.ToString(calc(heconsca.Text, heconsexam.Text));
                heconsremark.Text = grade(calc(heconsca.Text, heconsexam.Text));
                addUp();
            }
        }

        private void civicexam_TextChanged(object sender, EventArgs e)
        {
            if (civicexam.Text == "")
                civicexam.Text = "0";

            int ca = Convert.ToInt32(civicexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                civicexam.Text = "";
                civicexam.Focus();
            }
            else
            {
                civictt.Text = Convert.ToString(calc(civicca.Text, civicexam.Text));
                civicremark.Text = grade(calc(civicca.Text, civicexam.Text));
                addUp();
            }
        }

        private void csexam_TextChanged(object sender, EventArgs e)
        {
            if (csexam.Text == "")
                csexam.Text = "0";

            int ca = Convert.ToInt32(csexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                csexam.Text = "";
                csexam.Focus();
            }
            else
            {
                cstt.Text = Convert.ToString(calc(csca.Text, csexam.Text));
                csremark.Text = grade(calc(csca.Text, csexam.Text));
                addUp();
            }
        }

        private void caexam_TextChanged(object sender, EventArgs e)
        {

            if (caexam.Text == "")
                caexam.Text = "0";

            int ca = Convert.ToInt32(caexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                caexam.Text = "";
                caexam.Focus();
            }
            else
            {
                catt.Text = Convert.ToString(calc(caca.Text, caexam.Text));
                caremark.Text = grade(calc(caca.Text, caexam.Text));
                addUp();
            }
        }

        private void bizexam_TextChanged(object sender, EventArgs e)
        {
            if (bizexam.Text == "")
                bizexam.Text = "0";

            int ca = Convert.ToInt32(bizexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                bizexam.Text = "";
                bizexam.Focus();
            }
            else
            {
                biztt.Text = Convert.ToString(calc(bizca.Text, bizexam.Text));
                bizremark.Text = grade(calc(bizca.Text, bizexam.Text));
                addUp();
            }
        }

        private void frenchexam_TextChanged(object sender, EventArgs e)
        {

            if (frenchexam.Text == "")
                frenchexam.Text = "0";

            int ca = Convert.ToInt32(frenchexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                frenchexam.Text = "";
                frenchexam.Focus();
            }
            else
            {
                frenchtt.Text = Convert.ToString(calc(frenchca.Text, frenchexam.Text));
                frenchremark.Text = grade(calc(frenchca.Text, frenchexam.Text));
                addUp();
            }
        }

        private void yorexam_TextChanged(object sender, EventArgs e)
        {
            if (yorexam.Text == "")
                yorexam.Text = "0";

            int ca = Convert.ToInt32(yorexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                yorexam.Text = "";
                yorexam.Focus();
            }
            else
            {
                yortt.Text = Convert.ToString(calc(yorca.Text, yorexam.Text));
                yorremark.Text = grade(calc(yorca.Text, yorexam.Text));
                addUp();
            }
        }

        private void crsexam_TextChanged(object sender, EventArgs e)
        {
            if (crsexam.Text == "")
                crsexam.Text = "0";

            int ca = Convert.ToInt32(crsexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                crsexam.Text = "";
                crsexam.Focus();
            }
            else
            {
                crstt.Text = Convert.ToString(calc(crsca.Text, crsexam.Text));
                crsremark.Text = grade(calc(crsca.Text, crsexam.Text));
                addUp();
            }
        }

        private void irsexam_TextChanged(object sender, EventArgs e)
        {

            if (irsexam.Text == "")
                irsexam.Text = "0";

            int ca = Convert.ToInt32(irsexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                irsexam.Text = "";
                irsexam.Focus();
            }
            else
            {
                irstt.Text = Convert.ToString(calc(irsca.Text, irsexam.Text));
                irsremark.Text = grade(calc(irsca.Text, irsexam.Text));
                addUp();
            }
        }

        private void pheexam_TextChanged(object sender, EventArgs e)
        {

            if (pheexam.Text == "")
                pheexam.Text = "0";

            int ca = Convert.ToInt32(pheexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("C/A can not be more than 70 marks");
                pheexam.Text = "";
                pheexam.Focus();
            }
            else
            {
                phett.Text = Convert.ToString(calc(pheca.Text, pheexam.Text));
                pheremark.Text = grade(calc(pheca.Text, pheexam.Text));
                addUp();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked ==true)
            {
                crsca.Enabled = true;
                crsexam.Enabled = true;
                irsca.Text = "0";
                irsexam.Text = "0";
                irsca.Enabled = false;
                irsexam.Enabled = false;
                irsremark.Text = "";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                irsca.Enabled = true;
                irsexam.Enabled = true;
                crsca.Text = "0";
                crsexam.Text = "0";
                crsca.Enabled = false;
                crsexam.Enabled = false;
                crsremark.Text = "";
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSession_TextChanged(object sender, EventArgs e)
        {

        }


}
}