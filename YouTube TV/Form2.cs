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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public CefSharp.WinForms.ChromiumWebBrowser browser;

        private void Form1_Load(object sender, EventArgs e)
        {

            

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
