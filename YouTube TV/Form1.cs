using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;

namespace YouTube_TV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public CefSharp.WinForms.ChromiumWebBrowser browser;

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This project was created by AleeCorp! To exit press Alt+F4. This will take some time please wait...");

            browser = new CefSharp.WinForms.ChromiumWebBrowser("www.youtube.com/tv");
            {
                Dock = DockStyle.Fill;
                Size = new Size(514, 421);
                Location = new Point(0, 0);
            }
            this.panel1.Controls.Add(browser);
        }
    }
}
