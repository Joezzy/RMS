using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GDIC_Academic_Report
{
    public partial class Splash : Form
    {
          DateTime thisday = DateTime.Today;
        string filepath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Microsoft.xx.dll";
        string filepath2 = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Microsoft.dll.dll";
        string filepath3 = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Microsoft.dlc.dll";
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }
        int timeleft = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //int i;
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = 100;
            //for (i = 0; i <= 100; i++)
            //{
            //    //  int n = 0;
            //    // i= i + 1;
            //    progressBar1.Value = i;
            //}

            if (timeleft <0)
            {

                timeleft = timeleft - 1;
                textBox1.Text = timeleft.ToString();
                progressBar1.Value++;
               
            }
            else
            {
                 MDIParent1 myfrm = new MDIParent1();
                this.Hide();
                myfrm.Show();
            }
                //timer1.Stop();
                ////string dat = thisday.ToString("d");
                //string mat = File.ReadAllText(filepath);
                //string dll = File.ReadAllText(filepath2);
                //string dlc = File.ReadAllText(filepath3);

                //DateTime dat = Convert.ToDateTime(mat);

                //if (thisday > dat)
                //{
                //    if (dlc == dll)
                //    {
                //        Login myfrm = new Login();
                //        this.Hide();
                //        myfrm.Show();
                //    }
                //    else
                //    {
                //        Authen myfrm = new Authen();
                //        this.Hide();
                //        myfrm.Show();
                //    }
                //}
                //else
                //{

                //}

            
        }

        private void Splash_Load(object sender, EventArgs e)
        {
          //  timer1.Start();

        }
    }
}
