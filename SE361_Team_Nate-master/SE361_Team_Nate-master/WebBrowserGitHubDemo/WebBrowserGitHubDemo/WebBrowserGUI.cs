using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserGitHubDemo
{
    public partial class WebBrowserGUI : Form
    {
        public WebBrowserGUI()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            wbrDisplay.Navigate(txtURL.Text);
        }

        private void buMax_Click(object sender, EventArgs e)
        {
           txtURL.Text = string.Empty;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            wbrDisplay.Navigate("google.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wbrDisplay.Navigate("google.com");
        }


        ///:)
    }
}
