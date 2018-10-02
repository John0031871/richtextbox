using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace richtextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(textBox1.Text);
                double cuberoot = Math.Pow(d, 1.0 / 3.0);
                label1.Text = cuberoot.ToString();
            }
            catch
            {
                label1.Text = "Not a number";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(textBox1.Text);
                double cuberoot = Math.(d, );
                label1.Text = cuberoot.ToString();
            }
            catch
            {
                label1.Text = "Not a number";
            }
        }
    }
}
