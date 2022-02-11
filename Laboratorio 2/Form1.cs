using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            webBrowser1.Navigate(new Uri("https://" + comboBox1.SelectedItem.ToString()));
        }

        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome(); 
        }

        private void páginaSiguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void páginaAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            webBrowser1.GoHome();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            webBrowser1.Navigate(textBox1.Text.ToString()+".com", "https://www.google.com/");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string target = "http://www.google.com";
            System.Diagnostics.Process.Start(target);
        }
    }
}
