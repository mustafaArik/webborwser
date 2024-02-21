using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser_yapalim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            txt_adres.Text = "https://www." + txt_adres.Text;
            webBrowser1.Navigate(txt_adres.Text);
        }

        private void txt_adres_Enter(object sender, EventArgs e)
        {
            label1.Visible = true;
            if (txt_adres.Text == "https://www.")
                txt_adres.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

            if (webBrowser1.CanGoForward == false)
                button4.Enabled = false;
                

        }

        private void txt_adres_Leave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            webBrowser1.Navigate(listBox1.SelectedValue.ToString());

            
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            listBox1.Items.Add(webBrowser1.Url);
            txt_adres.Text = webBrowser1.Url.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
