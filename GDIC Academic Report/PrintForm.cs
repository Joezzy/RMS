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
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.jss' table. You can move, or remove it, as needed.
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.jssTableAdapter.Fill(this.DataSet1.jss,textBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
