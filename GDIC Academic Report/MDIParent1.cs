using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDIC_Academic_Report
{
    public partial class MDIParent1 : Form
    {
      

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void jSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   Regjss childForm = new Regjss();
        //    childForm.MdiParent = this;
          //  childForm.Show();

        }

        private void sSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Regsss childForm = new Regsss();
        //    childForm.MdiParent = this;
            //childForm.Show();
        }

      

        private void jSSResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm prt = new PrintForm();
           // prt.MdiParent = this;
            prt.Show();
        }

        private void sSSResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm2 prt = new PrintForm2();
           // prt.MdiParent = this;
            prt.Show();
        }

        private void jSSRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resultjss rez = new Resultjss();
            //Regjss childForm = new Regjss();
           // rez.MdiParent = this;
            rez.Show();
        }

        private void sSSRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Resultsss rez = new Resultsss();
            //Regjss childForm = new Regjss();
          //  rez.MdiParent = this;
            rez.Show();
        }

        private void jSSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // SubPosition prt = new SubPosition();
           // prt.MdiParent = this;
           // prt.Show();
        }

        private void sSSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //SubPosition2 prt = new SubPosition2();
          //  prt.MdiParent = this;
           // prt.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exportRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void newStudentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newClassRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NewFile nf = new NewFile();
            //nf.Show();
        }

        private void enterRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // NewEntry ne = new NewEntry();
           // ne.Show();
        }

        private void jSSToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            
            NewEntry n1 = new NewEntry();
            n1.Show();
        }

        private void sSSToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            NewEntry2 n1 = new NewEntry2();
            n1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSes nf = new NewSes();
            nf.Show();
        }

        private void jSSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewFile n = new NewFile();
            n.Show();
        }

        private void sSSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewFile2 n = new NewFile2();
            n.Show();
        }

        private void exportRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            export rec = new export();
            // rec.MdiParent = this;
            rec.Show();
        }

     

     
  

    }
}
