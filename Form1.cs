using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class Form1 : Form
    {

        float Points; float Credits; float GPA;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0.00";
            textBox2.Text = "0.00";
            textBox3.Text = "0.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Points = (float)Convert.ToDouble(textBox1.Text);
            Credits = (float)Convert.ToDouble(textBox2.Text);
            GPA = (float)Convert.ToDouble(textBox3.Text);

            if (radioButton1.Checked)
            {
                textBox3.Text = "0.00";
                GPA = Points / Credits;
                label4.Text = "GPA =" + GPA.ToString();
            }

            if (radioButton2.Checked)
            {
                textBox1.Text = "0.00";
                Points = GPA * Credits;
                label4.Text = "Points Needed to Acheive Desired GPA is " + Points.ToString();
            }

            if (radioButton3.Checked)
            {
                textBox2.Text = "0.00";
                Credits = Points /GPA ;
                label4.Text = "Credtis Needed to Acheive Desired GPA is " + Credits.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdvancedGPAForm().Show();
        }
    }
}
