using System;
using System.Windows.Forms;
using MetroFramework;
using System.IO;
using System.Web;
using System.Net;

namespace Browser
{
    public partial class Browser : MetroFramework.Forms.MetroForm
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                webBrowser1.Navigate("http://www.google.com");
            }
            catch
            {
                MessageBox.Show("Could Not Load Web Page", "ERROR Loading Page", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        WebBrowser webTab = null;


        private void metroButton1_Click(object sender, EventArgs e)
        {
        }

        private void Go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(URL.Text);
            link.Text = "http://" + URL.Text;
            URL.Clear();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.GoBack();
            }
            catch
            {
                MessageBox.Show("We Cannot Go Back", "Cant Go Back", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Foward_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.GoForward();
            }
            catch
            {
                MessageBox.Show("We Cannot Go Foward", "Cant Go Foward", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com");
            link.Text = "http://www.google.com";
        }

        private void TabName_Tick(object sender, EventArgs e)
        {
            
        }
    }

}
