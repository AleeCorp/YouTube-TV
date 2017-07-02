using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace YouTube_TV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            InitializeComponent();
            
        }

        public void SplashStart()

        {
            Application.Run(new Form2());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
                      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // this.progressBar1.Increment(1);
           // Form2 frm = new Form2();
            //frm.Show();
            //this.Close();
        }
    }
}
