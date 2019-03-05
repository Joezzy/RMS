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
    public partial class Regsss : Form
    {
        Connect connect = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=sis;Uid=root;Pwd=;");

        public Regsss(string klass,string xex)
        {
            InitializeComponent();
            string logg = klass;
            string sess = xex;
            txtTable.Text = logg;
            txtDb.Text = sess;
        }

        public int calc(string cca, string exm)
        {
            if (cca == "")
                cca = "0";
            if (exm == "")
                exm = "0";


            int ca = Convert.ToInt32(cca);
            int exam = Convert.ToInt32(exm);

            int tt = ca + exam;
            //  mathtt.Text = Convert.ToString(tt);
            return tt;
        }

        public string grade(int tt)
        {

            string grade = "";
            if (tt >= 0 && tt <=39)
                grade = "F9";

            if (tt >= 40 && tt <=44)
                grade = "E8";

            if (tt >= 45 && tt <=49)
                grade = "D7";

            if (tt >= 50 && tt <=54)
                grade = "C6";

            if (tt >= 55 && tt <=59)
                grade = "C5";

            if (tt >= 60 && tt <=64)
                grade = "C4";

            if (tt >= 65 && tt <= 69)
                grade = "B3";

            if (tt >= 70 && tt <=74)
                grade = "B2";
            if (tt >= 75 && tt < 100)
                grade = "A1";
            if (tt == 0)
                grade = "ABS";



            return grade;

        }

        void readBox()
        {
            if (Convert.ToInt32(chemca.Text) > 0 || Convert.ToInt32(chemexam.Text) > 0)
            {
                rbnChem.Checked = true;
            }
            else
            {
                rbnChem.Checked = false;
            }
            //
            if (Convert.ToInt32(phyca.Text) > 0 || Convert.ToInt32(phyexam.Text) > 0)
            {
                rbnPhy.Checked = true;
            }
            else
            {
                rbnPhy.Checked = false;
            }

            //
            if (Convert.ToInt32(fmathca.Text) > 0 || Convert.ToInt32(fmathexam.Text) > 0)
            {
                rbnFm.Checked = true;
            }
            else
            {
                rbnFm.Checked = false;
            }
            //
            if (Convert.ToInt32(govca.Text) > 0 || Convert.ToInt32(govexam.Text) > 0)
            {
                rbnGov.Checked = true;
            }
            else
            {
                rbnGov.Checked = false;
            }
            //
            if (Convert.ToInt32(opca.Text) > 0 || Convert.ToInt32(opexam.Text) > 0)
            {
                rbnOp.Checked = true;
            }
            else
            {
                rbnOp.Checked = false;
            }
            //
            if (Convert.ToInt32(commca.Text) > 0 || Convert.ToInt32(commexam.Text) > 0)
            {
                rbnComm.Checked = true;
            }
            else
            {
                rbnComm.Checked = false;
            }
            //

            if (Convert.ToInt32(acctca.Text) > 0 || Convert.ToInt32(acctexam.Text) > 0)
            {
                rbnAcc.Checked = true;
            }
            else
            {
                rbnAcc.Checked = false;
            }
            //
            if (Convert.ToInt32(agricca.Text) > 0 || Convert.ToInt32(agricexam.Text) > 0)
            {
                rbnAg.Checked = true;
            }
            else
            {
                rbnAg.Checked = false;
            }
            //
            if (Convert.ToInt32(crsca.Text) > 0 || Convert.ToInt32(crsexam.Text) > 0)
            {
                rbnCrs.Checked = true;
            }
            else
            {
                rbnCrs.Checked = false;
            }
            //

            if (Convert.ToInt32(irsca.Text) > 0 || Convert.ToInt32(irsexam.Text) > 0)
            {
                rbnIrs.Checked = true;
            }
            else
            {
                rbnIrs.Checked = false;
            }
            //

            if (Convert.ToInt32(geoca.Text) > 0 || Convert.ToInt32(geoexam.Text) > 0)
            {
                rbnGeo.Checked = true;
            }
            else
            {
                rbnGeo.Checked = false;
            }
            //

            if (Convert.ToInt32(litca.Text) > 0 || Convert.ToInt32(litexam.Text) > 0)
            {
                rbnLit.Checked = true;
            }
            else
            {
                rbnLit.Checked = false;
            }
            //

            if (Convert.ToInt32(tdca.Text) > 0 || Convert.ToInt32(tdexam.Text) > 0)
            {
                rbnTd.Checked = true;
            }
            else
            {
                rbnTd.Checked = false;
            }
            //

            if (Convert.ToInt32(catca.Text) > 0 || Convert.ToInt32(catexam.Text) > 0)
            {
                rbnCat.Checked = true;
            }

            else
            {
                rbnCat.Checked = false;
            }
            //
            if (Convert.ToInt32(ahca.Text) > 0 || Convert.ToInt32(ahexam.Text) > 0)
            {
                rbnAh.Checked = true;
            }
            else
            {
                rbnAh.Checked = false;
            }
            //
            if (Convert.ToInt32(pdca.Text) > 0 || Convert.ToInt32(pdexam.Text) > 0)
            {
                rbnPd.Checked = true;
            }
            else
            {
                rbnPd.Checked = false;
            }
            //
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            mnuNew.Enabled = false;
            mnuSave.Enabled = true;
         
           Klear();
            button1.Enabled = true;
            txtSearch.Visible = false;
            listBox1.Visible = false;
            disAble();
        }

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

        private void bioca_TextChanged(object sender, EventArgs e)
        {
            if (bioca.Text == "")
                bioca.Text = "0";

            int ca = Convert.ToInt32(bioca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                bioca.Text = "";
                bioca.Focus();
            }
            else
            {
                biott.Text = Convert.ToString(calc(bioca.Text, bioexam.Text));
                bioremark.Text = grade(calc(bioca.Text, bioexam.Text));
                addUp();
            } 
        }

        private void econsca_TextChanged(object sender, EventArgs e)
        {

            if (econsca.Text == "")
                econsca.Text = "0";

            int ca = Convert.ToInt32(econsca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                econsca.Text = "";
                econsca.Focus();
            }
            else
            {
                econstt.Text = Convert.ToString(calc(econsca.Text, econsexam.Text));
                econsremark.Text = grade(calc(econsca.Text, econsexam.Text));
                addUp();
            } 
        }

        private void fmathca_TextChanged(object sender, EventArgs e)
        {
            if (fmathca.Text == "")
                fmathca.Text = "0";

            int ca = Convert.ToInt32(fmathca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                fmathca.Text = "";
                fmathca.Focus();
            }
            else
            {
                fmathtt.Text = Convert.ToString(calc(fmathca.Text, fmathexam.Text));
                fmathremark.Text = grade(calc(fmathca.Text, fmathexam.Text));
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

        private void commca_TextChanged(object sender, EventArgs e)
        {
            if (commca.Text == "")
                commca.Text = "0";

            int ca = Convert.ToInt32(commca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                commca.Text = "";
                commca.Focus();
            }
            else
            {
                commtt.Text = Convert.ToString(calc(commca.Text, commexam.Text));
                commremark.Text = grade(calc(commca.Text, commexam.Text));
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

        private void litca_TextChanged(object sender, EventArgs e)
        {
            if (litca.Text == "")
                litca.Text = "0";

            int ca = Convert.ToInt32(litca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                litca.Text = "";
                litca.Focus();
            }
            else
            {
                littt.Text = Convert.ToString(calc(litca.Text, litexam.Text));
                litremark.Text = grade(calc(litca.Text, litexam.Text));
                addUp();
            } 

        }

        private void govca_TextChanged(object sender, EventArgs e)
        {
            if (govca.Text == "")
                govca.Text = "0";

            int ca = Convert.ToInt32(govca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                govca.Text = "";
                govca.Focus();
            }
            else
            {
                govtt.Text = Convert.ToString(calc(govca.Text, govexam.Text));
                govremark.Text = grade(calc(govca.Text, govexam.Text));
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

        private void opca_TextChanged(object sender, EventArgs e)
        {
            if (opca.Text == "")
                opca.Text = "0";

            int ca = Convert.ToInt32(opca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                opca.Text = "";
                opca.Focus();
            }
            else
            {
                optt.Text = Convert.ToString(calc(opca.Text, opexam.Text));
                opremark.Text = grade(calc(opca.Text, opexam.Text));
                addUp();
            } 
        }

        private void chemca_TextChanged(object sender, EventArgs e)
        {
            if (chemca.Text == "")
                chemca.Text = "0";

            int ca = Convert.ToInt32(chemca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                chemca.Text = "";
                chemca.Focus();
            }
            else
            {
                chemtt.Text = Convert.ToString(calc(chemca.Text, chemexam.Text));
                chemremark.Text = grade(calc(chemca.Text, chemexam.Text));
                addUp();
            } 
        }

        private void phyca_TextChanged(object sender, EventArgs e)
        {

            if (phyca.Text == "")
                phyca.Text = "0";

            int ca = Convert.ToInt32(phyca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                phyca.Text = "";
                phyca.Focus();
            }
            else
            {
                phytt.Text = Convert.ToString(calc(phyca.Text, phyexam.Text));
                phyremark.Text = grade(calc(phyca.Text, phyexam.Text));
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

        private void geoca_TextChanged(object sender, EventArgs e)
        {
            if (geoca.Text == "")
                geoca.Text = "0";

            int ca = Convert.ToInt32(geoca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                geoca.Text = "";
                geoca.Focus();
            }
            else
            {
                geott.Text = Convert.ToString(calc(geoca.Text, geoexam.Text));
                georemark.Text = grade(calc(geoca.Text, geoexam.Text));
                addUp();
            } 
        }

        private void acctca_TextChanged(object sender, EventArgs e)
        {
            if (acctca.Text == "")
                acctca.Text = "0";

            int ca = Convert.ToInt32(acctca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                acctca.Text = "";
                acctca.Focus();
            }
            else
            {
                accttt.Text = Convert.ToString(calc(acctca.Text, acctexam.Text));
                acctremark.Text = grade(calc(acctca.Text, acctexam.Text));
                addUp();
            }
        }

        private void tdca_TextChanged(object sender, EventArgs e)
        {
            if (tdca.Text == "")
                tdca.Text = "0";

            int ca = Convert.ToInt32(tdca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                tdca.Text = "";
               tdca.Focus();
            }
            else
            {
                tdtt.Text = Convert.ToString(calc(tdca.Text, tdexam.Text));
                tdremark.Text = grade(calc(tdca.Text, tdexam.Text));
                addUp();
            }
        }

        private void catca_TextChanged(object sender, EventArgs e)
        {
            if (catca.Text == "")
                catca.Text = "0";

            int ca = Convert.ToInt32(catca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                catca.Text = "";
                catca.Focus();
            }
            else
            {
                cattt.Text = Convert.ToString(calc(catca.Text, catexam.Text));
                catremark.Text = grade(calc(catca.Text, catexam.Text));
                addUp();
            }
        }

        private void ahca_TextChanged(object sender, EventArgs e)
        {
            if (ahca.Text == "")
                ahca.Text = "0";

            int ca = Convert.ToInt32(ahca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                ahca.Text = "";
                ahca.Focus();
            }
            else
            {
                ahtt.Text = Convert.ToString(calc(ahca.Text, ahexam.Text));
                ahremark.Text = grade(calc(ahca.Text, ahexam.Text));
                addUp();
            }
        }

        private void pdca_TextChanged(object sender, EventArgs e)
        {
            if (pdca.Text == "")
                pdca.Text = "0";

            int ca = Convert.ToInt32(pdca.Text);
            if (ca > 30)
            {
                MessageBox.Show("C/A can not be more than 30 marks");
                pdca.Text = "";
                pdca.Focus();
            }
            else
            {
                pdtt.Text = Convert.ToString(calc(pdca.Text, pdexam.Text));
                pdremark.Text = grade(calc(pdca.Text, pdexam.Text));
                addUp();
            }
        }

        private void engexam_TextChanged(object sender, EventArgs e)
        {
            if (engexam.Text == "")
                engexam.Text = "0";

            int ca = Convert.ToInt32(engexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
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

        private void bioexam_TextChanged(object sender, EventArgs e)
        {
            if (bioexam.Text == "")
                bioexam.Text = "0";

            int ca = Convert.ToInt32(bioexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                bioexam.Text = "";
                bioexam.Focus();
            }
            else
            {
                biott.Text = Convert.ToString(calc(bioca.Text, bioexam.Text));
                bioremark.Text = grade(calc(bioca.Text, bioexam.Text));
                addUp();
            }
        }

        private void econsexam_TextChanged(object sender, EventArgs e)
        {
            if (econsexam.Text == "")
                econsexam.Text = "0";

            int ca = Convert.ToInt32(econsexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                econsexam.Text = "";
                econsexam.Focus();
            }
            else
            {
                econstt.Text = Convert.ToString(calc(econsca.Text, econsexam.Text));
                econsremark.Text = grade(calc(econsca.Text, econsexam.Text));
                addUp();
            }
        }

        private void fmathexam_TextChanged(object sender, EventArgs e)
        {
            if (fmathexam.Text == "")
                fmathexam.Text = "0";

            int ca = Convert.ToInt32(fmathexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                fmathexam.Text = "";
                fmathexam.Focus();
            }
            else
            {
                fmathtt.Text = Convert.ToString(calc(fmathca.Text, fmathexam.Text));
                fmathremark.Text = grade(calc(fmathca.Text, fmathexam.Text));
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
                MessageBox.Show("Exam can not be more than 70 marks");
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

        private void commexam_TextChanged(object sender, EventArgs e)
        {
            if (commexam.Text == "")
                commexam.Text = "0";

            int ca = Convert.ToInt32(commexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                commexam.Text = "";
                commexam.Focus();
            }
            else
            {
                commtt.Text = Convert.ToString(calc(commca.Text, commexam.Text));
                commremark.Text = grade(calc(commca.Text, commexam.Text));
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
                MessageBox.Show("Exam can not be more than 70 marks");
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

        private void litexam_TextChanged(object sender, EventArgs e)
        {
            if (litexam.Text == "")
                litexam.Text = "0";

            int ca = Convert.ToInt32(litexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                litexam.Text = "";
                litexam.Focus();
            }
            else
            {
                littt.Text = Convert.ToString(calc(litca.Text, litexam.Text));
                litremark.Text = grade(calc(litca.Text, litexam.Text));
                addUp();
            }
        }

        private void govexam_TextChanged(object sender, EventArgs e)
        {
            if (govexam.Text == "")
                govexam.Text = "0";

            int ca = Convert.ToInt32(govexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                govexam.Text = "";
                govexam.Focus();
            }
            else
            {
                govtt.Text = Convert.ToString(calc(govca.Text, govexam.Text));
                govremark.Text = grade(calc(govca.Text, govexam.Text));
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
                MessageBox.Show("Exam can not be more than 70 marks");
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

        private void opexam_TextChanged(object sender, EventArgs e)
        {
            if (opexam.Text == "")
                opexam.Text = "0";

            int ca = Convert.ToInt32(opexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                opexam.Text = "";
                opexam.Focus();
            }
            else
            {
                optt.Text = Convert.ToString(calc(opca.Text, opexam.Text));
                opremark.Text = grade(calc(opca.Text, opexam.Text));
                addUp();
            }
        }

        private void chemexam_TextChanged(object sender, EventArgs e)
        {

            if (chemexam.Text == "")
                chemexam.Text = "0";

            int ca = Convert.ToInt32(chemexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                chemexam.Text = "";
                chemexam.Focus();
            }
            else
            {
                chemtt.Text = Convert.ToString(calc(chemca.Text, chemexam.Text));
                chemremark.Text = grade(calc(chemca.Text, chemexam.Text));
                addUp();
            }
        }

        private void phyexam_TextChanged(object sender, EventArgs e)
        {
            if (phyexam.Text == "")
                phyexam.Text = "0";

            int ca = Convert.ToInt32(phyexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                phyexam.Text = "";
                phyexam.Focus();
            }
            else
            {
                phytt.Text = Convert.ToString(calc(phyca.Text, phyexam.Text));
                phyremark.Text = grade(calc(phyca.Text, phyexam.Text));
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
                MessageBox.Show("Exam can not be more than 70 marks");
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
                MessageBox.Show("Exam can not be more than 70 marks");
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
                MessageBox.Show("Exam can not be more than 70 marks");
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

        private void geoexam_TextChanged(object sender, EventArgs e)
        {
            if (geoexam.Text == "")
                geoexam.Text = "0";

            int ca = Convert.ToInt32(geoexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                geoexam.Text = "";
                geoexam.Focus();
            }
            else
            {
                geott.Text = Convert.ToString(calc(geoca.Text, geoexam.Text));
                georemark.Text = grade(calc(geoca.Text, geoexam.Text));
                addUp();
            }
        }

        private void acctexam_TextChanged(object sender, EventArgs e)
        {
            if (acctexam.Text == "")
                acctexam.Text = "0";

            int ca = Convert.ToInt32(acctexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                acctexam.Text = "";
                acctexam.Focus();
            }
            else
            {
                accttt.Text = Convert.ToString(calc(acctca.Text, acctexam.Text));
                acctremark.Text = grade(calc(acctca.Text, acctexam.Text));
                addUp();
            }
        }

        private void tdexam_TextChanged(object sender, EventArgs e)
        {
            if (tdexam.Text == "")
                tdexam.Text = "0";

            int ca = Convert.ToInt32(tdexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                tdexam.Text = "";
                tdexam.Focus();
            }
            else
            {
                tdtt.Text = Convert.ToString(calc(tdca.Text, tdexam.Text));
                tdremark.Text = grade(calc(tdca.Text, tdexam.Text));
                addUp();
            }
        }

        private void catexam_TextChanged(object sender, EventArgs e)
        {
            if (catexam.Text == "")
                catexam.Text = "0";

            int ca = Convert.ToInt32(catexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                catexam.Text = "";
                catexam.Focus();
            }
            else
            {
                cattt.Text = Convert.ToString(calc(catca.Text, catexam.Text));
                catremark.Text = grade(calc(catca.Text, catexam.Text));
                addUp();
            }
        }

      

        private void ahexam_TextChanged(object sender, EventArgs e)
        {
            if (ahexam.Text == "")
                ahexam.Text = "0";

            int ca = Convert.ToInt32(ahexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                ahexam.Text = "";
                ahexam.Focus();
            }
            else
            {
                ahtt.Text = Convert.ToString(calc(ahca.Text, ahexam.Text));
                ahremark.Text = grade(calc(ahca.Text, ahexam.Text));
                addUp();
            }
        }

        private void pdexam_TextChanged(object sender, EventArgs e)
        {
            if (pdexam.Text == "")
                pdexam.Text = "0";

            int ca = Convert.ToInt32(pdexam.Text);
            if (ca > 70)
            {
                MessageBox.Show("Exam can not be more than 70 marks");
                pdexam.Text = "";
                pdexam.Focus();
            }
            else
            {
                pdtt.Text = Convert.ToString(calc(pdca.Text, pdexam.Text));
                pdtt.Text = grade(calc(pdca.Text, pdexam.Text));
            }
        }

        private void litremark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            txtSearch.Visible = true;
            listBox1.Visible = true;
            listBox1.Items.Clear();
            listLoad("select Surname from " + txtTable.Text + "");
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {

            string dbb = txtDb.Text;
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");
            if (txtSurname.Text == "" || txtSession.Text == "" || txtGender.Text == "" || txtClass.Text == "" || txtOthernames.Text == "" || txtTerm.Text == "")
            {
                MessageBox.Show("Complete details in About the Student and session to save");

            }
            else
            {
                     if ( txtSurname.Text == "" || txtSession.Text == "" || txtGender.Text == "" || txtClass.Text == "" || txtOthernames.Text == "" || txtTerm.Text == "")
            {
                MessageBox.Show("Complete details in About the Student and session to save");

            }
            else
            {
                con.Open();
                string CmdString = "insert into " + txtTable.Text + " (Surname,Other_Names,Gender,Session,Term,Class," +

                    "Mathematics_CA,Mathematics_Exam,Mathematics,Mathematics_Rem," +
                    "English_Language_CA,English_Language_Exam,English_Language,English_Language_Rem," +
                    "Biology_CA,Biology_Exam,Biology,Biology_Rem," +
                    "Economics_CA, Economics_Exam, Economics, Economics_Rem," +
                    "Further_Maths_CA,Further_Maths_Exam,Further_Maths,Further_Maths_Rem," +

                    "Agric_Science_CA,Agric_Science_Exam,Agric_Science,Agric_Science_Rem," +
                    "Commerce_CA,Commerce_Exam,Commerce,Commerce_Rem," +
                    "Civic_Ed_CA,Civic_Ed_Exam,Civic_Ed,Civic_Ed_Rem," +
                    "Computer_CA,Computer_Exam,Computer,Computer_Rem," +

                    "Lit_In_Eng_CA,Lit_In_Eng_Exam,Lit_In_Eng,Lit_In_Eng_Rem," +
                    "Government_CA,Government_Exam,Government,Government_Rem," +
                    "Office_Practice_CA,Office_Practice_Exam,Office_Practice,Office_Practice_Rem," +
                    "Chemistry_CA,Chemistry_Exam,Chemistry,Chemistry_Rem," +
                     "Physics_CA,Physics_Exam,Physics,Physics_Rem," +
                      "Geography_CA,Geography_Exam,Geography,Geography_Rem," +
                      "Accounting_CA,Accounting_Exam,Accounting,Accounting_Rem," +

                      "TD_CA,TD_Exam,TD,TD_Rem," +
                      "Catering_CA,Catering_Exam,Catering,Catering_Rem," +
                      "Animal_Hus_CA,Animal_Hus_Exam,Animal_Hus,Animal_Hus_Rem," +
                      "Paint_Decor_CA,Paint_Decor_Exam,Paint_Decor,Paint_Decor_Rem," +

                    "Yoruba_CA,Yoruba_Exam,Yoruba,Yoruba_Rem," +
                    "CRS_CA,CRS_Exam,CRS,CRS_Rem," +
                    "IRS_CA,IRS_Exam,IRS,IRS_Rem," +
                    "Average,Subj_Offered,Teacher,Principal,"+
                    "Punctuality,Attendance,Reliability,Politeness,Honesty,Self_Control,Staff_Rship,Student_Rship,"+
                    "Initiative,Org_Ability) Values (@Surname,@Other_Names,@Gender,@Session,@Term,@Class," +

                    "@Mathematics_CA,@Mathematics_Exam,@Mathematics,@Mathematics_Rem," +
                    "@English_Language_CA,@English_Language_Exam,@English_Language,@English_Language_Rem," +
                    "@Biology_CA,@Biology_Exam,@Biology,@Biology_Rem," +
                    "@Economics_CA,@Economics_Exam,@Economics,@Economics_Rem," +
                    "@Further_Maths_CA,@Further_Maths_Exam,@Further_Maths,@Further_Maths_Rem," +

                    "@Agric_Science_CA,@Agric_Science_Exam,@Agric_Science,@Agric_Science_Rem," +
                    "@Commerce_CA,@Commerce_Exam,@Commerce,@Commerce_Rem," +
                    "@Civic_Ed_CA,@Civic_Ed_Exam,@Civic_Ed,@Civic_Ed_Rem," +
                    "@Computer_CA,@Computer_Exam,@Computer,@Computer_Rem," +

                    "@Lit_In_Eng_CA,@Lit_In_Eng_Exam,@Lit_In_Eng,@Lit_In_Eng_Rem," +
                    "@Government_CA,@Government_Exam,@Government,@Government_Rem," +
                    "@Office_Practice_CA,@Office_Practice_Exam,@Office_Practice,@Office_Practice_Rem," +
                    "@Chemistry_CA,@Chemistry_Exam,@Chemistry,@Chemistry_Rem," +
                     "@Physics_CA,@Physics_Exam,@Physics,@Physics_Rem," +
                      "@Geography_CA,@Geography_Exam,@Geography,@Geography_Rem," +
                      "@Accounting_CA,@Accounting_Exam,@Accounting,@Accounting_Rem," +
                      "@TD_CA,@TD_Exam,@TD,@TD_Rem," +
                      "@Catering_CA,@Catering_Exam,@Catering,@Catering_Rem," +
                      "@Animal_Hus_CA,@Animal_Hus_Exam,@Animal_Hus,@Animal_Hus_Rem," +
                      "@Paint_Decor_CA,@Paint_Decor_Exam,@Paint_Decor,@Paint_Decor_Rem," +

                    "@Yoruba_CA,@Yoruba_Exam,@Yoruba,@Yoruba_Rem," +
                    "@CRS_CA,@CRS_Exam,@CRS,@CRS_Rem," +
                    "@IRS_CA,@IRS_Exam,@IRS,@IRS_Rem," +
                    "@Average,@Subj_Offered,@Teacher,@Principal,"+
                    "@Punctuality,@Attendance,@Reliability,@Politeness,@Honesty,@Self_Control,@Staff_Rship,@Student_Rship,"+
                    "@Initiative,@Org_Ability)";

                    
               MySqlCommand cmd = new MySqlCommand(CmdString, con);


               cmd.Parameters.Add("@Surname", MySqlDbType.VarChar, 45);
               cmd.Parameters.Add("@Other_Names", MySqlDbType.VarChar, 45);
               cmd.Parameters.Add("@Gender", MySqlDbType.VarChar, 45);
               cmd.Parameters.Add("@Session", MySqlDbType.VarChar, 45);
               cmd.Parameters.Add("@Term", MySqlDbType.VarChar, 45);
               cmd.Parameters.Add("@Class", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@Mathematics_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Mathematics_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Mathematics", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Mathematics_Rem", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@English_Language_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@English_Language_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@English_Language", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@English_Language_Rem", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@Biology_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Biology_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Biology", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Biology_Rem", MySqlDbType.VarChar, 45);


               cmd.Parameters.Add("@Economics_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Economics_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Economics", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Economics_Rem", MySqlDbType.VarChar, 2);

               cmd.Parameters.Add("@Geography_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Geography_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Geography", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Geography_Rem", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@Agric_Science_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Agric_Science_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Agric_Science", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Agric_Science_rem", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@Commerce_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Commerce_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Commerce", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Commerce_Rem", MySqlDbType.VarChar, 45);


               cmd.Parameters.Add("@Accounting_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Accounting_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Accounting", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Accounting_Rem", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@Government_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Government_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Government", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Government_Rem", MySqlDbType.VarChar, 45);


               cmd.Parameters.Add("@Lit_In_Eng_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Lit_In_Eng_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Lit_In_Eng", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Lit_In_Eng_Rem", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@Physics_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Physics_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Physics", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Physics_Rem", MySqlDbType.VarChar, 45);


               cmd.Parameters.Add("@Chemistry_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Chemistry_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Chemistry", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Chemistry_Rem", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@Further_Maths_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Further_Maths_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Further_Maths", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Further_Maths_Rem", MySqlDbType.VarChar, 45);


               cmd.Parameters.Add("@Civic_Ed_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Civic_Ed_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Civic_Ed", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Civic_Ed_Rem", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@Computer_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Computer_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Computer", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Computer_Rem", MySqlDbType.VarChar, 45);


               cmd.Parameters.Add("@Office_Practice_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Office_Practice_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Office_Practice", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Office_Practice_Rem", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@Yoruba_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Yoruba_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Yoruba", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Yoruba_Rem", MySqlDbType.VarChar, 45);


               cmd.Parameters.Add("@CRS_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@CRS_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@CRS", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@CRS_Rem", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@IRS_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@IRS_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@IRS", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@IRS_Rem", MySqlDbType.VarChar, 45);


               cmd.Parameters.Add("@TD_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@TD_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@TD", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@TD_Rem", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@Catering_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Catering_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Catering", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Catering_Rem", MySqlDbType.VarChar, 45);


               cmd.Parameters.Add("@Animal_Hus_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Animal_Hus_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Animal_Hus", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Animal_Hus_Rem", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@Paint_Decor_CA", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Paint_Decor_Exam", MySqlDbType.VarChar, 2);
               cmd.Parameters.Add("@Paint_Decor", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Paint_Decor_Rem", MySqlDbType.VarChar, 45);

               cmd.Parameters.Add("@Average", MySqlDbType.VarChar, 6);
               cmd.Parameters.Add("@Subj_Offered", MySqlDbType.VarChar, 3);
               cmd.Parameters.Add("@Teacher", MySqlDbType.Text);
               cmd.Parameters.Add("@Principal", MySqlDbType.Text);
               cmd.Parameters.Add("@Punctuality", MySqlDbType.VarChar, 45);
               cmd.Parameters.Add("@Attendance", MySqlDbType.VarChar, 45);
               cmd.Parameters.Add("@Reliability", MySqlDbType.VarChar, 45);
               cmd.Parameters.Add("@Politeness", MySqlDbType.VarChar, 45);
               cmd.Parameters.Add("@Honesty", MySqlDbType.VarChar, 45);
               cmd.Parameters.Add("@Self_Control", MySqlDbType.VarChar, 45);
               cmd.Parameters.Add("@Staff_Rship", MySqlDbType.VarChar, 45);
               cmd.Parameters.Add("@Student_Rship", MySqlDbType.VarChar, 45);
               cmd.Parameters.Add("@Initiative", MySqlDbType.VarChar, 45);
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

                 cmd.Parameters["@Biology_CA"].Value = bioca.Text;
                cmd.Parameters["@Biology_Exam"].Value = bioexam.Text;
                cmd.Parameters["@Biology"].Value = biott.Text;
                cmd.Parameters["@Biology_Rem"].Value = bioremark.Text;

                cmd.Parameters["@Economics_CA"].Value = econsca.Text;
                cmd.Parameters["@Economics_Exam"].Value = econsexam.Text;
                cmd.Parameters["@Economics"].Value = econstt.Text;
                cmd.Parameters["@Economics_Rem"].Value = econsremark.Text;

                 cmd.Parameters["@Geography_CA"].Value = geoca.Text;
                cmd.Parameters["@Geography_Exam"].Value = geoexam.Text;
                cmd.Parameters["@Geography"].Value = geott.Text;
                cmd.Parameters["@Geography_Rem"].Value = georemark.Text;

                cmd.Parameters["@Agric_Science_CA"].Value = agricca.Text;
                cmd.Parameters["@Agric_Science_Exam"].Value = agricexam.Text;
                cmd.Parameters["@Agric_Science"].Value = agrictt.Text;
                cmd.Parameters["@Agric_Science_Rem"].Value = agricremark.Text;

  cmd.Parameters["@Commerce_CA"].Value = commca.Text;
                cmd.Parameters["@Commerce_Exam"].Value = commexam.Text;
                cmd.Parameters["@Commerce"].Value = commtt.Text;
                cmd.Parameters["@Commerce_Rem"].Value = commremark.Text;

  cmd.Parameters["@Accounting_CA"].Value = acctca.Text;
                cmd.Parameters["@Accounting_Exam"].Value = acctexam.Text;
                cmd.Parameters["@Accounting"].Value = accttt.Text;
                cmd.Parameters["@Accounting_Rem"].Value = acctremark.Text;

  cmd.Parameters["@Government_CA"].Value = govca.Text;
                cmd.Parameters["@Government_Exam"].Value = govexam.Text;
                cmd.Parameters["@Government"].Value = govtt.Text;
                cmd.Parameters["@Government_Rem"].Value = govremark.Text;

                cmd.Parameters["@Lit_In_Eng_CA"].Value = litca.Text;
                  cmd.Parameters["@Lit_In_Eng_Exam"].Value = litexam.Text;
                cmd.Parameters["@Lit_In_Eng"].Value = littt.Text;
                cmd.Parameters["@Lit_In_Eng_Rem"].Value = litremark.Text;

  cmd.Parameters["@Physics_CA"].Value = phyca.Text;
                cmd.Parameters["@Physics_Exam"].Value = phyexam.Text;
                cmd.Parameters["@Physics"].Value = phytt.Text;
                cmd.Parameters["@Physics_Rem"].Value = phyremark.Text;

  cmd.Parameters["@Chemistry_CA"].Value = chemca.Text;
                cmd.Parameters["@Chemistry_Exam"].Value = chemexam.Text;
                cmd.Parameters["@Chemistry"].Value = chemtt.Text;
                cmd.Parameters["@Chemistry_Rem"].Value = chemremark.Text;

  cmd.Parameters["@Further_Maths_CA"].Value = fmathca.Text;
                cmd.Parameters["@Further_Maths_Exam"].Value = fmathexam.Text;
                cmd.Parameters["@Further_Maths"].Value = fmathtt.Text;
                cmd.Parameters["@Further_Maths_Rem"].Value = fmathremark.Text;

                   cmd.Parameters["@Civic_Ed_CA"].Value = civicca.Text;
                cmd.Parameters["@Civic_Ed_Exam"].Value = civicexam.Text;
                cmd.Parameters["@Civic_Ed"].Value = civictt.Text;
                cmd.Parameters["@Civic_Ed_Rem"].Value = civicremark.Text;

                 cmd.Parameters["@Computer_CA"].Value = csca.Text;
                cmd.Parameters["@Computer_Exam"].Value = csexam.Text;
                cmd.Parameters["@Computer"].Value = cstt.Text;
                cmd.Parameters["@Computer_Rem"].Value = csremark.Text;

                 cmd.Parameters["@Office_Practice_CA"].Value = opca.Text;
                cmd.Parameters["@Office_Practice_Exam"].Value = opexam.Text;
                cmd.Parameters["@Office_Practice"].Value = optt.Text;
                cmd.Parameters["@Office_Practice_Rem"].Value = opremark.Text;

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

                cmd.Parameters["@TD_CA"].Value = tdca.Text;
                cmd.Parameters["@TD_Exam"].Value = tdexam.Text;
                cmd.Parameters["@TD"].Value = tdtt.Text;
                cmd.Parameters["@TD_Rem"].Value = tdremark.Text;

                cmd.Parameters["@Catering_CA"].Value = catca.Text;
                cmd.Parameters["@Catering_Exam"].Value = catexam.Text;
                cmd.Parameters["@Catering"].Value = cattt.Text;
                cmd.Parameters["@Catering_Rem"].Value = catremark.Text;

                cmd.Parameters["@Animal_Hus_CA"].Value = ahca.Text;
                cmd.Parameters["@Animal_Hus_Exam"].Value = ahexam.Text;
                cmd.Parameters["@Animal_Hus"].Value = ahtt.Text;
                cmd.Parameters["@Animal_Hus_Rem"].Value = ahremark.Text;

                cmd.Parameters["@Paint_Decor_CA"].Value = pdca.Text;
                cmd.Parameters["@Paint_Decor_Exam"].Value = pdexam.Text;
                cmd.Parameters["@Paint_Decor"].Value = pdtt.Text;
                cmd.Parameters["@Paint_Decor_Rem"].Value = pdremark.Text;

                cmd.Parameters["@Average"].Value = txtAvg.Text;
                cmd.Parameters["@Subj_Offered"].Value = txtNosub.Text;
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
                MessageBox.Show("Record Saved", "Result System");


                Klear();
                mnuNew.Enabled = true;
                mnuSave.Enabled = false;
                disAble();
            }
            }
        }

        void Klear()
        {
            txtSurname.Text = "";
            txtOthernames.Text = "";
            txtSession.Text = "";
            txtTerm.Text = " ";
            txtClass.Text = " ";
          
            txtGender.Text = " ";

            mathca.Text = "0";
            mathexam.Text = "0";
            mathtt.Text = "0";
            mathremark.Text = "";

            engca.Text = "0";
            engexam.Text = "0";
            engtt.Text = "0";
            engremark.Text = "";

            bioca.Text = "0";
            bioexam.Text = "0";
            biott.Text = "0";
            bioremark.Text = "";

            econsca.Text = "0";
            econsexam.Text = "0";
            econstt.Text = "0";
            econsremark.Text = "";

            fmathca.Text = "0";
            fmathexam.Text = "0";
            fmathtt.Text = "0";
            fmathremark.Text = "";


            agricca.Text = "0";
            agricexam.Text = "0";
            agrictt.Text = "0";
            agricremark.Text = "";

            commca.Text = "0";
            commexam.Text = "0";
            commtt.Text = "0";
            commremark.Text = "";

            civicca.Text = "0";
            civicexam.Text = "0";
            civictt.Text = "0";
            civicremark.Text = "";

            csca.Text = "0";
            csexam.Text = "0";
            cstt.Text = "0";
            csremark.Text = "";

            litca.Text = "0";
            litexam.Text = "0";
            littt.Text = "0";
            litremark.Text = "";

            govca.Text = "0";
            govexam.Text = "0";
            govtt.Text = "0";
           govremark.Text = "";

            opca.Text = "0";
           opexam.Text = "0";
            optt.Text = "0";
           opremark.Text = "";

            chemca.Text = "0";
            chemexam.Text = "0";
            chemtt.Text = "0";
            chemremark.Text = "";

            phyca.Text = "0";
            phyexam.Text = "0";
            phytt.Text = "0";
            phyremark.Text = "";

            yorca.Text = "0";
            yorexam.Text = "0";
            yortt.Text = "0";
            yorremark.Text = "";

            crsca.Text = "0";
            crsexam.Text = "0";
            crstt.Text = "0";
            crsremark.Text = "";

            irsca.Text = "0";
            irsexam.Text = "0";
            irstt.Text = "0";
            irsremark.Text = "";

            geoca.Text = "0";
            geoexam.Text = "0";
            geott.Text = "0";
            georemark.Text = "";

           acctca.Text = "0";
            acctexam.Text = "0";
            accttt.Text = "0";
           acctremark.Text = "";

           tdca.Text = "0";
           tdexam.Text = "0";
           tdtt.Text = "0";
           tdremark.Text = "";

           catca.Text = "0";
           catexam.Text = "0";
           cattt.Text = "0";
           catremark.Text = "";

        ahca.Text = "0";
        ahexam.Text = "0";
        ahtt.Text = "0";
        ahremark.Text = "";

        pdca.Text = "0";
        pdexam.Text = "0";
        pdtt.Text = "0";
        pdremark.Text = "";

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

        public void UDQuery(string qry)
        {
            MySqlCommand cmd;
            con.Open();


            cmd = con.CreateCommand();
            cmd.CommandText = qry;

            cmd.ExecuteNonQuery();


            con.Close();

        }

        public void listRead(string qry)
        {

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

                bioca.Text = reader["Biology_CA"].ToString();
                bioexam.Text = reader["Biology_Exam"].ToString();
                biott.Text = reader["Biology"].ToString();
                bioremark.Text = reader["Biology_Rem"].ToString();

                econsca.Text = reader["Economics_CA"].ToString();
                econsexam.Text = reader["Economics_Exam"].ToString();
                econstt.Text = reader["Economics"].ToString();
                econsremark.Text = reader["Economics_Rem"].ToString();

                fmathca.Text = reader["Further_Maths_CA"].ToString();
                fmathexam.Text = reader["Further_Maths_Exam"].ToString();
                fmathtt.Text = reader["Further_Maths"].ToString();
                fmathremark.Text = reader["Further_Maths_Rem"].ToString();

                agricca.Text = reader["Agric_Science_CA"].ToString();
                agricexam.Text = reader["Agric_Science_Exam"].ToString();
                agrictt.Text = reader["Agric_Science"].ToString();
                agricremark.Text = reader["Agric_Science_Rem"].ToString();

                commca.Text = reader["Commerce_CA"].ToString();
                commexam.Text = reader["Commerce_Exam"].ToString();
                commtt.Text = reader["Commerce"].ToString();
                commremark.Text = reader["Commerce_Rem"].ToString();

                civicca.Text = reader["Civic_Ed_CA"].ToString();
                civicexam.Text = reader["Civic_Ed_Exam"].ToString();
                civictt.Text = reader["Civic_Ed"].ToString();
                civicremark.Text = reader["Civic_Ed_Rem"].ToString();

                csca.Text = reader["Computer_CA"].ToString();
                csexam.Text = reader["Computer_Exam"].ToString();
                cstt.Text = reader["Computer"].ToString();
                csremark.Text = reader["Computer_Rem"].ToString();

                litca.Text = reader["Lit_in_Eng_CA"].ToString();
                litexam.Text = reader["Lit_in_Eng_Exam"].ToString();
                littt.Text = reader["Lit_in_Eng"].ToString();
                litremark.Text = reader["Lit_in_Eng_Rem"].ToString();

                govca.Text = reader["Government_CA"].ToString();
                govexam.Text = reader["Government_Exam"].ToString();
                govtt.Text = reader["Government"].ToString();
                govremark.Text = reader["Government_Rem"].ToString();

                opca.Text = reader["Office_Practice_CA"].ToString();
                opexam.Text = reader["Office_Practice_Exam"].ToString();
                optt.Text = reader["Office_Practice"].ToString();
                opremark.Text = reader["Office_Practice_Rem"].ToString();

             chemca.Text = reader["Chemistry_CA"].ToString();
             chemexam.Text = reader["Chemistry_Exam"].ToString();
             chemtt.Text = reader["Chemistry"].ToString();
             chemremark.Text = reader["Chemistry_Rem"].ToString();

             phyca.Text = reader["Physics_CA"].ToString();
             phyexam.Text = reader["Physics_Exam"].ToString();
             phytt.Text = reader["Physics"].ToString();
             phyremark.Text = reader["Physics_Rem"].ToString();



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

                geoca.Text = reader["Geography_CA"].ToString();
                geoexam.Text = reader["Geography_Exam"].ToString();
                geott.Text = reader["Geography"].ToString();
                georemark.Text = reader["Geography_Rem"].ToString();

                acctca.Text = reader["Accounting_CA"].ToString();
                acctexam.Text = reader["Accounting_Exam"].ToString();
                accttt.Text = reader["Accounting"].ToString();
                acctremark.Text = reader["Accounting_Rem"].ToString();

                tdca.Text = reader["TD_CA"].ToString();
                tdexam.Text = reader["TD_Exam"].ToString();
                tdtt.Text = reader["TD"].ToString();
                tdremark.Text = reader["TD_Rem"].ToString();

                catca.Text = reader["Catering_CA"].ToString();
                catexam.Text = reader["Catering_Exam"].ToString();
                cattt.Text = reader["Catering"].ToString();
                catremark.Text = reader["Catering_Rem"].ToString();

                ahca.Text = reader["Animal_Hus_CA"].ToString();
                ahexam.Text = reader["Animal_Hus_Exam"].ToString();
                ahtt.Text = reader["Animal_Hus"].ToString();
                ahremark.Text = reader["Animal_Hus_Rem"].ToString();

                pdca.Text = reader["Paint_Decor_CA"].ToString();
                pdexam.Text = reader["Paint_Decor_Exam"].ToString();
                pdtt.Text = reader["Paint_Decor"].ToString();
                pdremark.Text = reader["Paint_Decor_Rem"].ToString();

               txtNosub.Text = reader["Subj_Offered"].ToString();
                txtTeacher.Text = reader["Teacher"].ToString();
                txtPple.Text = reader["Principal"].ToString();

          txtPun.Text = reader["Punctuality"].ToString();
          txtAtt.Text =reader["Attendance"].ToString();
          txtRel.Text =reader["Reliability"].ToString();
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

        void addUp()
        {
            float avg;
            int mat = Convert.ToInt32(mathtt.Text);
            int eng = Convert.ToInt32(engtt.Text);
            int ss = Convert.ToInt32(biott.Text);
            int bs = Convert.ToInt32(econstt.Text);
            int bt = Convert.ToInt32(fmathtt.Text);
            int ag = Convert.ToInt32(agrictt.Text);
            int hc = Convert.ToInt32(commtt.Text);
            int cd = Convert.ToInt32(civictt.Text);
            int cs = Convert.ToInt32(cstt.Text);
            int cca = Convert.ToInt32(govtt.Text);
            int biz = Convert.ToInt32(littt.Text);
            int fr = Convert.ToInt32(optt.Text);
            int yor = Convert.ToInt32(yortt.Text);
            int crs = Convert.ToInt32(crstt.Text);
            int irs = Convert.ToInt32(irstt.Text);
            int phe = Convert.ToInt32(chemtt.Text);
            int sec = Convert.ToInt32(phytt.Text);


            int geo = Convert.ToInt32(geott.Text);
            int acc = Convert.ToInt32(accttt.Text);
            int td = Convert.ToInt32(tdtt.Text);
            int cat = Convert.ToInt32(cattt.Text);
            int ah = Convert.ToInt32(ahtt.Text);
            int pd = Convert.ToInt32(pdtt.Text);
            int sub;
            sub = Convert.ToInt32(txtNosub.Text);
            int subtt = sub * 100;
            float tt = mat + eng + ss + bs + bt + ag + hc + cd + cs + cca + biz + fr + yor + crs + irs + phe + sec + geo + acc + td + cat + ah + pd;
            avg = (tt / subtt) * 100;
            // txtAvg.Text = Convert.ToString(avg);
            txtAvg.Text = String.Format("{0:0.0}", avg);



        }
     

        private void Regsss_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


            {
                listLoad("select Surname  from " + txtTable.Text + "  where Surname like'%" + txtSearch.Text + "%' order by Surname ASC");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listRead("SELECT * FROM " + txtTable.Text + " WHERE Surname='" + listBox1.Text.ToString() + "'");
            mnuSave.Enabled = false;
            mnuUpdate.Enabled = true;
            mnuDelete.Enabled = true;
            mnuNew.Enabled = false;
            readBox();
         
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            string dbb = txtDb.Text;
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "GDC Report", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                con.Open();
                MySqlCommand comm = new MySqlCommand("delete from " + txtTable.Text + " where id=" + txtId.Text + "", con);
                try
                {
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted", "Result System");

                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "Error Deleting Records ");
                    throw;
                    //
                }
                con.Close();

                listBox1.Items.Clear(); listLoad("select Surname  from " + txtTable.Text + "");
                Klear();
                mnuUpdate.Enabled = false;
                mnuDelete.Enabled = false;
                mnuNew.Enabled = true;
            }
            else
            {

            }
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {

            string dbb = txtDb.Text;
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=" + dbb + ";Uid=root;Pwd=;");

            if (txtSurname.Text == "" || txtSession.Text == "" || txtGender.Text == "" || txtClass.Text == "" || txtOthernames.Text == "" || txtTerm.Text == "")
            {
                MessageBox.Show("Complete details in About the Student and session to save");

            }
            else
            {
                if (txtSurname.Text == "" || txtSession.Text == "" || txtGender.Text == "" || txtClass.Text == "" || txtOthernames.Text == "" || txtTerm.Text == "")
                {
                    MessageBox.Show("Complete details in About the Student and session to save");

                }
                else
                {
                    con.Open();
                    string CmdString ="UPDATE " + txtTable.Text + " SET Surname=@Surname,Other_Names=@Other_Names,Gender=@Gender,Session=@Session,Term=@Term,Class=@Class," +

                        "Mathematics_CA=@Mathematics_CA,Mathematics_Exam=@Mathematics_Exam,Mathematics=@Mathematics,Mathematics_Rem=@Mathematics_Rem," +
                        "English_Language_CA=@English_Language_CA,English_Language_Exam=@English_Language_Exam,English_Language=@English_Language,English_Language_Rem=@English_Language_Rem," +
                      
                        "Biology_CA=@Biology_CA,Biology_Exam=@Biology_Exam,Biology=@Biology,Biology_Rem=@Biology_Rem," +

                        "Economics_CA=@Economics_CA,Economics_Exam=@Economics_Exam,Economics=@Economics,Economics_Rem=@Economics_Rem," +

                        "Further_Maths_CA=@Further_Maths_CA,Further_Maths_Exam=@Further_Maths_Exam,Further_Maths=@Further_Maths,Further_Maths_Rem=@Further_Maths_Rem," +

                        "Agric_Science_CA=@Agric_Science_CA,Agric_Science_Exam=@Agric_Science_Exam,Agric_Science=@Agric_Science,Agric_Science_Rem=@Agric_Science_Rem," +
                        "Commerce_CA=@Commerce_CA,Commerce_Exam=@Commerce_Exam,Commerce=@Commerce,Commerce_Rem=@Commerce_Rem," +
                        "Civic_Ed_CA=@Civic_Ed_CA,Civic_Ed_Exam=@Civic_Ed_Exam,Civic_Ed=@Civic_Ed,Civic_Ed_Rem=@Civic_Ed_Rem," +
                        "Computer_CA=@Computer_CA,Computer_Exam=@Computer_Exam,Computer=@Computer,Computer_Rem=@Computer_Rem," +

                        "Lit_In_Eng_CA=@Lit_In_Eng_CA,Lit_In_Eng_Exam=@Lit_In_Eng_Exam,Lit_In_Eng=@Lit_In_Eng,Lit_In_Eng_Rem=@Lit_In_Eng_Rem," +
                        "Government_CA=@Government_CA,Government_Exam=@Government_Exam,Government=@Government,Government_Rem=@Government_Rem," +
                        "Office_Practice_CA=@Office_Practice_CA,Office_Practice_Exam=@Office_Practice_Exam,Office_Practice=@Office_Practice, Office_Practice_Rem=@Office_Practice_Rem," +
                        "Chemistry_CA=@Chemistry_CA,Chemistry_Exam=@Chemistry_Exam,Chemistry=@Chemistry,Chemistry_Rem=@Chemistry_Rem," +
                         "Physics_CA=@Physics_CA,Physics_Exam=@Physics_Exam,Physics=@Physics,Physics_Rem=@Physics_Rem," +
                          "Geography_CA=@Geography_CA,Geography_Exam=@Geography_Exam,Geography=@Geography,Geography_Rem=@Geography_Rem," +
                          "Accounting_CA=@Accounting_CA,Accounting_Exam=@Accounting_Exam,Accounting=@Accounting,Accounting_Rem=@Accounting_Rem," +

                          "TD_CA=@TD_CA,TD_Exam=@TD_Exam,TD=@TD,TD_Rem=@TD_Rem," +
                          "Catering_CA=@Catering_CA,Catering_Exam=@Catering_Exam,Catering=@Catering,Catering_Rem=@Catering_Rem," +
                          "Animal_Hus_CA=@Animal_Hus_CA,Animal_Hus_Exam=@Animal_Hus_Exam,Animal_Hus=@Animal_Hus,Animal_Hus_Rem=@Animal_Hus_Rem," +
                          "Paint_Decor_CA=@Paint_Decor_CA,Paint_Decor_Exam=@Paint_Decor_Exam,Paint_Decor=@Paint_Decor,Paint_Decor_Rem=@Paint_Decor_Rem," +

                        "Yoruba_CA=@Yoruba_CA,Yoruba_Exam=@Yoruba_Exam,Yoruba=@Yoruba,Yoruba_Rem=@Yoruba_Rem," +
                        "CRS_CA=@CRS_CA,CRS_Exam=@CRS_Exam,CRS=@CRS,CRS_Rem=@CRS_Rem," +
                        "IRS_CA=@IRS_CA,IRS_Exam=@IRS_Exam,IRS=@IRS,IRS_Rem=@IRS_Rem," +
                        "Average=@Average,Subj_Offered=@Subj_Offered,Teacher=@Teacher,Principal=@Principal," +
                        "Punctuality=@Punctuality,Attendance=@Attendance,Reliability=@Reliability,Politeness=@Politeness,Honesty=@Honesty,"+
                        "Self_Control=@Self_Control,Staff_Rship=@Staff_Rship,Student_Rship=@Student_Rship," +
                        "Initiative=@Initiative,Org_Ability=@Org_Ability WHERE id=@id";


                    MySqlCommand cmd = new MySqlCommand(CmdString, con);

                    cmd.Parameters.Add("@id", MySqlDbType.Int64, 45);
                    cmd.Parameters.Add("@Surname", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Other_Names", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Gender", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Session", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Term", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Class", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Mathematics_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Mathematics_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Mathematics", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Mathematics_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@English_Language_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@English_Language_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@English_Language", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@English_Language_Rem", MySqlDbType.VarChar, 45);

                   cmd.Parameters.Add("@Biology_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Biology_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Biology", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Biology_Rem", MySqlDbType.VarChar, 45);


                    cmd.Parameters.Add("@Economics_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Economics_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Economics", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Economics_Rem", MySqlDbType.VarChar, 2);

                    cmd.Parameters.Add("@Geography_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Geography_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Geography", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Geography_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Agric_Science_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Agric_Science_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Agric_Science", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Agric_Science_rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Commerce_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Commerce_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Commerce", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Commerce_Rem", MySqlDbType.VarChar, 45);


                    cmd.Parameters.Add("@Accounting_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Accounting_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Accounting", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Accounting_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Government_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Government_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Government", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Government_Rem", MySqlDbType.VarChar, 45);


                    cmd.Parameters.Add("@Lit_In_Eng_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Lit_In_Eng_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Lit_In_Eng", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Lit_In_Eng_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Physics_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Physics_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Physics", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Physics_Rem", MySqlDbType.VarChar, 45);


                    cmd.Parameters.Add("@Chemistry_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Chemistry_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Chemistry", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Chemistry_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Further_Maths_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Further_Maths_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Further_Maths", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Further_Maths_Rem", MySqlDbType.VarChar, 45);


                    cmd.Parameters.Add("@Civic_Ed_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Civic_Ed_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Civic_Ed", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Civic_Ed_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Computer_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Computer_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Computer", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Computer_Rem", MySqlDbType.VarChar, 45);


                    cmd.Parameters.Add("@Office_Practice_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Office_Practice_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Office_Practice", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Office_Practice_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Yoruba_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Yoruba_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Yoruba", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Yoruba_Rem", MySqlDbType.VarChar, 45);


                    cmd.Parameters.Add("@CRS_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@CRS_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@CRS", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@CRS_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@IRS_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@IRS_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@IRS", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@IRS_Rem", MySqlDbType.VarChar, 45);


                    cmd.Parameters.Add("@TD_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@TD_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@TD", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@TD_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Catering_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Catering_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Catering", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Catering_Rem", MySqlDbType.VarChar, 45);


                    cmd.Parameters.Add("@Animal_Hus_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Animal_Hus_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Animal_Hus", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Animal_Hus_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Paint_Decor_CA", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Paint_Decor_Exam", MySqlDbType.VarChar, 2);
                    cmd.Parameters.Add("@Paint_Decor", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Paint_Decor_Rem", MySqlDbType.VarChar, 45);

                    cmd.Parameters.Add("@Average", MySqlDbType.VarChar, 6);
                    cmd.Parameters.Add("@Subj_Offered", MySqlDbType.VarChar, 3);
                    cmd.Parameters.Add("@Teacher", MySqlDbType.Text);
                    cmd.Parameters.Add("@Principal", MySqlDbType.Text);
                    cmd.Parameters.Add("@Punctuality", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Attendance", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Reliability", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Politeness", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Honesty", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Self_Control", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Staff_Rship", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Student_Rship", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@Initiative", MySqlDbType.VarChar, 45);
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

                    cmd.Parameters["@Biology_CA"].Value = bioca.Text;
                    cmd.Parameters["@Biology_Exam"].Value = bioexam.Text;
                    cmd.Parameters["@Biology"].Value = biott.Text;
                    cmd.Parameters["@Biology_Rem"].Value = bioremark.Text;

                    cmd.Parameters["@Economics_CA"].Value = econsca.Text;
                    cmd.Parameters["@Economics_Exam"].Value = econsexam.Text;
                    cmd.Parameters["@Economics"].Value = econstt.Text;
                    cmd.Parameters["@Economics_Rem"].Value = econsremark.Text;

                    cmd.Parameters["@Geography_CA"].Value = geoca.Text;
                    cmd.Parameters["@Geography_Exam"].Value = geoexam.Text;
                    cmd.Parameters["@Geography"].Value = geott.Text;
                    cmd.Parameters["@Geography_Rem"].Value = georemark.Text;

                    cmd.Parameters["@Agric_Science_CA"].Value = agricca.Text;
                    cmd.Parameters["@Agric_Science_Exam"].Value = agricexam.Text;
                    cmd.Parameters["@Agric_Science"].Value = agrictt.Text;
                    cmd.Parameters["@Agric_Science_Rem"].Value = agricremark.Text;

                    cmd.Parameters["@Commerce_CA"].Value = commca.Text;
                    cmd.Parameters["@Commerce_Exam"].Value = commexam.Text;
                    cmd.Parameters["@Commerce"].Value = commtt.Text;
                    cmd.Parameters["@Commerce_Rem"].Value = commremark.Text;

                    cmd.Parameters["@Accounting_CA"].Value = acctca.Text;
                    cmd.Parameters["@Accounting_Exam"].Value = acctexam.Text;
                    cmd.Parameters["@Accounting"].Value = accttt.Text;
                    cmd.Parameters["@Accounting_Rem"].Value = acctremark.Text;

                    cmd.Parameters["@Government_CA"].Value = govca.Text;
                    cmd.Parameters["@Government_Exam"].Value = govexam.Text;
                    cmd.Parameters["@Government"].Value = govtt.Text;
                    cmd.Parameters["@Government_Rem"].Value = govremark.Text;

                    cmd.Parameters["@Lit_In_Eng_CA"].Value = litca.Text;
                    cmd.Parameters["@Lit_In_Eng_Exam"].Value = litexam.Text;
                    cmd.Parameters["@Lit_In_Eng"].Value = littt.Text;
                    cmd.Parameters["@Lit_In_Eng_Rem"].Value = litremark.Text;

                    cmd.Parameters["@Physics_CA"].Value = phyca.Text;
                    cmd.Parameters["@Physics_Exam"].Value = phyexam.Text;
                    cmd.Parameters["@Physics"].Value = phytt.Text;
                    cmd.Parameters["@Physics_Rem"].Value = phyremark.Text;

                    cmd.Parameters["@Chemistry_CA"].Value = chemca.Text;
                    cmd.Parameters["@Chemistry_Exam"].Value = chemexam.Text;
                    cmd.Parameters["@Chemistry"].Value = chemtt.Text;
                    cmd.Parameters["@Chemistry_Rem"].Value = chemremark.Text;

                    cmd.Parameters["@Further_Maths_CA"].Value = fmathca.Text;
                    cmd.Parameters["@Further_Maths_Exam"].Value = fmathexam.Text;
                    cmd.Parameters["@Further_Maths"].Value = fmathtt.Text;
                    cmd.Parameters["@Further_Maths_Rem"].Value = fmathremark.Text;

                    cmd.Parameters["@Civic_Ed_CA"].Value = civicca.Text;
                    cmd.Parameters["@Civic_Ed_Exam"].Value = civicexam.Text;
                    cmd.Parameters["@Civic_Ed"].Value = civictt.Text;
                    cmd.Parameters["@Civic_Ed_Rem"].Value = civicremark.Text;

                    cmd.Parameters["@Computer_CA"].Value = csca.Text;
                    cmd.Parameters["@Computer_Exam"].Value = csexam.Text;
                    cmd.Parameters["@Computer"].Value = cstt.Text;
                    cmd.Parameters["@Computer_Rem"].Value = csremark.Text;

                    cmd.Parameters["@Office_Practice_CA"].Value = opca.Text;
                    cmd.Parameters["@Office_Practice_Exam"].Value = opexam.Text;
                    cmd.Parameters["@Office_Practice"].Value = optt.Text;
                    cmd.Parameters["@Office_Practice_Rem"].Value = opremark.Text;

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

                    cmd.Parameters["@TD_CA"].Value = tdca.Text;
                    cmd.Parameters["@TD_Exam"].Value = tdexam.Text;
                    cmd.Parameters["@TD"].Value = tdtt.Text;
                    cmd.Parameters["@TD_Rem"].Value = tdremark.Text;

                    cmd.Parameters["@Catering_CA"].Value = catca.Text;
                    cmd.Parameters["@Catering_Exam"].Value = catexam.Text;
                    cmd.Parameters["@Catering"].Value = cattt.Text;
                    cmd.Parameters["@Catering_Rem"].Value = catremark.Text;

                    cmd.Parameters["@Animal_Hus_CA"].Value = ahca.Text;
                    cmd.Parameters["@Animal_Hus_Exam"].Value = ahexam.Text;
                    cmd.Parameters["@Animal_Hus"].Value = ahtt.Text;
                    cmd.Parameters["@Animal_Hus_Rem"].Value = ahremark.Text;

                    cmd.Parameters["@Paint_Decor_CA"].Value = pdca.Text;
                    cmd.Parameters["@Paint_Decor_Exam"].Value = pdexam.Text;
                    cmd.Parameters["@Paint_Decor"].Value = pdtt.Text;
                    cmd.Parameters["@Paint_Decor_Rem"].Value = pdremark.Text;

                    cmd.Parameters["@Average"].Value = txtAvg.Text;
                    cmd.Parameters["@Subj_Offered"].Value = txtNosub.Text;
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
                    Klear();
                    listBox1.Items.Clear();
                    listLoad("select Surname  from " + txtTable.Text + "");
                    mnuUpdate.Enabled = false;
                    mnuDelete.Enabled = false;
                    mnuNew.Enabled = true;
                    disAble();

                }

            }
        }

        int subj;
        int sub = 0;

        void chekk( CheckBox subject,TextBox ca,TextBox ex ,TextBox rem)
        {
            
       
            subj = Convert.ToInt32(txtNosub.Text);
            if (subject.Checked == true)
            {
                ca.Enabled = true;
                ex.Enabled = true;
                sub = subj + 1;
                txtNosub.Text = Convert.ToString(sub);

            }
            else
            {
                ca.Enabled = false;
                ex.Enabled = false;
                ca.Text = "0";
                ex.Text = "0";
                rem.Text = "";
                sub = subj - 1;
                txtNosub.Text = Convert.ToString(sub);
            }
        }
        private void rbnChem_CheckedChanged(object sender, EventArgs e)
        {
            chekk(rbnChem, chemca, chemexam, chemremark);
        }



        private void rbnPhy_CheckedChanged(object sender, EventArgs e)
        {
            chekk(rbnPhy, phyca, phyexam, phyremark);
        }

        private void rbnFm_CheckedChanged(object sender, EventArgs e)
        {
            chekk(rbnFm, fmathca, fmathexam, fmathremark);
        }

        private void rbnAg_CheckedChanged(object sender, EventArgs e)
        {
            chekk(rbnAg, agricca, agricexam, agricremark);
        }

        private void rbnGov_CheckedChanged(object sender, EventArgs e)
        {
            chekk(rbnGov, govca, govexam, govremark);

        }
        private void rbnOp_CheckedChanged(object sender, EventArgs e)
        {
            chekk(rbnOp, opca, opexam, opremark);
        }

        private void rbnComm_CheckedChanged(object sender, EventArgs e)
        {
            chekk(rbnComm, commca, commexam, commremark);
        }

        private void rbnAcc_CheckedChanged(object sender, EventArgs e)
        {
            chekk(rbnAcc, acctca, acctexam, acctremark);
        }

  

        private void rbnCrs_CheckedChanged(object sender, EventArgs e)
        {
            chekk(rbnCrs, crsca, crsexam, crsremark);
        }

        private void rbnIrs_CheckedChanged(object sender, EventArgs e)
        {
            chekk(rbnIrs, irsca, irsexam, irsremark);
        }

        private void rbnGeo_CheckedChanged(object sender, EventArgs e)
        {
            chekk(rbnGeo, geoca, geoexam, georemark);
        }

        private void rbnLit_CheckedChanged(object sender, EventArgs e)
        {
            chekk(rbnLit, litca, litexam, litremark);
        }

        private void rbnTd_CheckedChanged(object sender, EventArgs e)
        {
            chekk(rbnTd, tdca, tdexam, tdremark);
        }


        void voc( RadioButton cat,TextBox ca,TextBox ex, TextBox rem)
        {
           
            if (cat.Checked == true)
            {
                ca.Enabled = true;
                ex.Enabled = true;
            }
            else
            {
                ca.Enabled = false;
                ex.Enabled = false;
                ca.Text = "0";
                ex.Text = "0";
                rem.Text = "";
            }
        

        }

        private void rbnCat_CheckedChanged(object sender, EventArgs e)
        {
            voc(rbnCat, catca, catexam, catremark);
        }

        private void rbnAh_CheckedChanged(object sender, EventArgs e)
        {
            voc(rbnAh, ahca, ahexam, ahremark);
        }

        private void rbnPd_CheckedChanged(object sender, EventArgs e)
        {
            voc(rbnPd, pdca, pdexam, pdremark);
        }


        void disAble()
        {
            rbnAcc.Checked = false;
            rbnAg.Checked = false;
            rbnAh.Checked = false;
            rbnCat.Checked = false;
            rbnChem.Checked = false;
            rbnComm.Checked = false;
            rbnCrs.Checked = false;
            rbnFm.Checked = false;
            rbnGeo.Checked = false;
            rbnGov.Checked = false;
            rbnIrs.Checked = false;
            rbnLit.Checked = false;
            rbnOp.Checked = false;
            rbnPd.Checked = false;
            rbnPhy.Checked = false;
            rbnTd.Checked = false;
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       
}
      

}
