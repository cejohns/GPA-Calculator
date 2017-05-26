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
    public partial class AdvancedGPAForm : Form
    {
        float PointsEarned; float Credits; float GPA; float Grades;


        public AdvancedGPAForm()
        {
            InitializeComponent();
            textBox1.Text = "0.00";
            textBox2.Text = "0.00";
            textBox3.Text = "0.00";
            textBox4.Text = "0.00";
            textBox5.Text = "0.00";
            textBox6.Text = "0.00";
            textBox7.Text = "0.00";
            textBox15.Text = "0.00";
            textBox16.Text = "0.00";
            textBox17.Text = "0.00";
            textBox18.Text = "0.00";
            textBox19.Text = "0.00";
            textBox20.Text = "0.00";
            textBox21.Text = "0.00";
           

            comboBox1.Items.Add("A+");
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("A-");
            comboBox1.Items.Add("B+");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("B-");
            comboBox1.Items.Add("C+");
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("C-");
            comboBox1.Items.Add("D+");
            comboBox1.Items.Add("D");
            comboBox1.Items.Add("F");

            comboBox2.Items.Add("A+");
            comboBox2.Items.Add("A");
            comboBox2.Items.Add("A-");
            comboBox2.Items.Add("B+");
            comboBox2.Items.Add("B");
            comboBox2.Items.Add("B-");
            comboBox2.Items.Add("C+");
            comboBox2.Items.Add("C");
            comboBox2.Items.Add("C-");
            comboBox2.Items.Add("D+");
            comboBox2.Items.Add("D");
            comboBox2.Items.Add("F");

            comboBox3.Items.Add("A+");
            comboBox3.Items.Add("A");
            comboBox3.Items.Add("A-");
            comboBox3.Items.Add("B+");
            comboBox3.Items.Add("B");
            comboBox3.Items.Add("B-");
            comboBox3.Items.Add("C+");
            comboBox3.Items.Add("C");
            comboBox3.Items.Add("C-");
            comboBox3.Items.Add("D+");
            comboBox3.Items.Add("D");
            comboBox3.Items.Add("F");

            comboBox4.Items.Add("A+");
            comboBox4.Items.Add("A");
            comboBox4.Items.Add("A-");
            comboBox4.Items.Add("B+");
            comboBox4.Items.Add("B");
            comboBox4.Items.Add("B-");
            comboBox4.Items.Add("C+");
            comboBox4.Items.Add("C");
            comboBox4.Items.Add("C-");
            comboBox4.Items.Add("D+");
            comboBox4.Items.Add("D");
            comboBox4.Items.Add("F");

            comboBox5.Items.Add("A+");
            comboBox5.Items.Add("A");
            comboBox5.Items.Add("A-");
            comboBox5.Items.Add("B+");
            comboBox5.Items.Add("B");
            comboBox5.Items.Add("B-");
            comboBox5.Items.Add("C+");
            comboBox5.Items.Add("C");
            comboBox5.Items.Add("C-");
            comboBox5.Items.Add("D+");
            comboBox5.Items.Add("D");
            comboBox5.Items.Add("F");

            comboBox6.Items.Add("A+");
            comboBox6.Items.Add("A");
            comboBox6.Items.Add("A-");
            comboBox6.Items.Add("B+");
            comboBox6.Items.Add("B");
            comboBox6.Items.Add("B-");
            comboBox6.Items.Add("C+");
            comboBox6.Items.Add("C");
            comboBox6.Items.Add("C-");
            comboBox6.Items.Add("D+");
            comboBox6.Items.Add("D");
            comboBox6.Items.Add("F");

            comboBox7.Items.Add("A+");
            comboBox7.Items.Add("A");
            comboBox7.Items.Add("A-");
            comboBox7.Items.Add("B+");
            comboBox7.Items.Add("B");
            comboBox7.Items.Add("B-");
            comboBox7.Items.Add("C+");
            comboBox7.Items.Add("C");
            comboBox7.Items.Add("C-");
            comboBox7.Items.Add("D+");
            comboBox7.Items.Add("D");
            comboBox7.Items.Add("F");
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Credits = (float)Convert.ToDouble(textBox1.Text) + (float)Convert.ToDouble(textBox2.Text) + (float)Convert.ToDouble(textBox3.Text) + (float)Convert.ToDouble(textBox4.Text) + (float)Convert.ToDouble(textBox5.Text) + (float)Convert.ToDouble(textBox6.Text) + (float)Convert.ToDouble(textBox7.Text);
            PointsEarned = (float)Convert.ToDouble(textBox15.Text) + (float)Convert.ToDouble(textBox16.Text) + (float)Convert.ToDouble(textBox17.Text) + (float)Convert.ToDouble(textBox18.Text) + (float)Convert.ToDouble(textBox19.Text) + (float)Convert.ToDouble(textBox20.Text) + (float)Convert.ToDouble(textBox21.Text);
            GPA = PointsEarned / Credits;
            label14.Text = "GPA =" + GPA.ToString();
            label10.Text = Credits.ToString();
            label11.Text = PointsEarned.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Credits = (float)Convert.ToDouble(textBox1.Text);

            if (comboBox1.SelectedIndex == 0)
            {
                Grades = 4.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox1.Text);
                textBox15.Text = PointsEarned.ToString();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Grades = 4.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox1.Text);
                textBox15.Text = PointsEarned.ToString();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Grades = 3.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox1.Text);
                textBox15.Text = PointsEarned.ToString();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Grades = 3.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox1.Text);
                textBox15.Text = PointsEarned.ToString();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                Grades = 3.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox1.Text);
                textBox15.Text = PointsEarned.ToString();
            }
            if (comboBox1.SelectedIndex == 5)
            {
                Grades = 2.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox1.Text);
                textBox15.Text = PointsEarned.ToString();
            }
            if (comboBox1.SelectedIndex == 6)
            {
                Grades = 2.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox1.Text);
                textBox15.Text = PointsEarned.ToString();
            }
            if (comboBox1.SelectedIndex == 7)
            {
                Grades = 2.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox1.Text);
                textBox15.Text = PointsEarned.ToString();
            }
            if (comboBox1.SelectedIndex == 8)
            {
                Grades = 1.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox1.Text);
                textBox15.Text = PointsEarned.ToString();
            }
            if (comboBox1.SelectedIndex == 9)
            {
                Grades = 1.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox1.Text);
                textBox15.Text = PointsEarned.ToString();
            }
            if (comboBox1.SelectedIndex == 10)
            {
                Grades = 1.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox1.Text);
                textBox15.Text = PointsEarned.ToString();
            }
            if (comboBox1.SelectedIndex == 11)
            {
                Grades = 0.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox1.Text);
                textBox15.Text = PointsEarned.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Credits = (float)Convert.ToDouble(textBox2.Text);

            if (comboBox2.SelectedIndex == 0)
            {
                Grades = 4.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox2.Text);
                textBox16.Text = PointsEarned.ToString();
            }
            if (comboBox2.SelectedIndex == 1)
            {
                Grades = 4.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox2.Text);
                textBox16.Text = PointsEarned.ToString();
            }
            if (comboBox2.SelectedIndex == 2)
            {
                Grades = 3.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox2.Text);
                textBox16.Text = PointsEarned.ToString();
            }
            if (comboBox2.SelectedIndex == 3)
            {
                Grades = 3.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox2.Text);
                textBox16.Text = PointsEarned.ToString();
            }
            if (comboBox2.SelectedIndex == 4)
            {
                Grades = 3.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox2.Text);
                textBox16.Text = PointsEarned.ToString();
            }
            if (comboBox2.SelectedIndex == 5)
            {
                Grades = 2.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox2.Text);
                textBox16.Text = PointsEarned.ToString();
            }
            if (comboBox2.SelectedIndex == 6)
            {
                Grades = 2.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox2.Text);
                textBox16.Text = PointsEarned.ToString();
            }
            if (comboBox2.SelectedIndex == 7)
            {
                Grades = 2.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox2.Text);
                textBox16.Text = PointsEarned.ToString();
            }
            if (comboBox2.SelectedIndex == 8)
            {
                Grades = 1.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox2.Text);
                textBox16.Text = PointsEarned.ToString();
            }
            if (comboBox2.SelectedIndex == 9)
            {
                Grades = 1.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox2.Text);
                textBox16.Text = PointsEarned.ToString();
            }
            if (comboBox2.SelectedIndex == 10)
            {
                Grades = 1.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox2.Text);
                textBox16.Text = PointsEarned.ToString();
            }
            if (comboBox2.SelectedIndex == 11)
            {
                Grades = 0.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox2.Text);
                textBox16.Text = PointsEarned.ToString();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Credits = (float)Convert.ToDouble(textBox3.Text);

            if (comboBox3.SelectedIndex == 0)
            {
                Grades = 4.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox3.Text);
                textBox17.Text = PointsEarned.ToString();
            }
            if (comboBox3.SelectedIndex == 1)
            {
                Grades = 4.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox3.Text);
                textBox17.Text = PointsEarned.ToString();
            }
            if (comboBox3.SelectedIndex == 2)
            {
                Grades = 3.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox3.Text);
                textBox17.Text = PointsEarned.ToString();
            }
            if (comboBox3.SelectedIndex == 3)
            {
                Grades = 3.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox3.Text);
                textBox17.Text = PointsEarned.ToString();
            }
            if (comboBox3.SelectedIndex == 4)
            {
                Grades = 3.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox3.Text);
                textBox17.Text = PointsEarned.ToString();
            }
            if (comboBox3.SelectedIndex == 5)
            {
                Grades = 2.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox3.Text);
                textBox17.Text = PointsEarned.ToString();
            }
            if (comboBox3.SelectedIndex == 6)
            {
                Grades = 2.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox3.Text);
                textBox17.Text = PointsEarned.ToString();
            }
            if (comboBox3.SelectedIndex == 7)
            {
                Grades = 2.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox3.Text);
                textBox17.Text = PointsEarned.ToString();
            }
            if (comboBox3.SelectedIndex == 8)
            {
                Grades = 1.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox3.Text);
                textBox17.Text = PointsEarned.ToString();
            }
            if (comboBox3.SelectedIndex == 9)
            {
                Grades = 1.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox3.Text);
                textBox17.Text = PointsEarned.ToString();
            if (comboBox3.SelectedIndex == 10)
            {
                Grades = 1.00f;
                    PointsEarned = Grades * (float)Convert.ToDouble(textBox3.Text);
                    textBox17.Text = PointsEarned.ToString();
                }
                if (comboBox3.SelectedIndex == 11)
                {
                    Grades = 0.00f;
                    PointsEarned = Grades * (float)Convert.ToDouble(textBox3.Text);
                    textBox17.Text = PointsEarned.ToString();
                }     }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Credits = (float)Convert.ToDouble(textBox4.Text);

            if (comboBox4.SelectedIndex == 0)
            {
                Grades = 4.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox4.Text);
                textBox18.Text = PointsEarned.ToString();
            }
            if (comboBox4.SelectedIndex == 1)
            {
                Grades = 4.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox4.Text);
                textBox18.Text = PointsEarned.ToString();
            }
            if (comboBox4.SelectedIndex == 2)
            {
                Grades = 3.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox4.Text);
                textBox18.Text = PointsEarned.ToString();
            }
            if (comboBox4.SelectedIndex == 3)
            {
                Grades = 3.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox4.Text);
                textBox18.Text = PointsEarned.ToString();
            }
            if (comboBox4.SelectedIndex == 4)
            {
                Grades = 3.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox4.Text);
                textBox18.Text = PointsEarned.ToString();
            }
            if (comboBox4.SelectedIndex == 5)
            {
                Grades = 2.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox4.Text);
                textBox18.Text = PointsEarned.ToString();
            }
            if (comboBox4.SelectedIndex == 6)
            {
                Grades = 2.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox4.Text);
                textBox18.Text = PointsEarned.ToString();
            }
            if (comboBox4.SelectedIndex == 7)
            {
                Grades = 2.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox4.Text);
                textBox18.Text = PointsEarned.ToString();
            }
            if (comboBox4.SelectedIndex == 8)
            {
                Grades = 1.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox4.Text);
                textBox18.Text = PointsEarned.ToString();
            }
            if (comboBox4.SelectedIndex == 9)
            {
                Grades = 1.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox4.Text);
                textBox18.Text = PointsEarned.ToString();
            }
            if (comboBox4.SelectedIndex == 10)
            {
                Grades = 1.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox4.Text);
                textBox18.Text = PointsEarned.ToString();
            }
            if (comboBox4.SelectedIndex == 11)
            {
                Grades = 0.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox4.Text);
                textBox18.Text = PointsEarned.ToString();
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Credits = (float)Convert.ToDouble(textBox5.Text);

            if (comboBox5.SelectedIndex == 0)
            {
                Grades = 4.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox5.Text);
                textBox19.Text = PointsEarned.ToString();
            }
            if (comboBox5.SelectedIndex == 1)
            {
                Grades = 4.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox5.Text);
                textBox19.Text = PointsEarned.ToString();
            }
            if (comboBox5.SelectedIndex == 2)
            {
                Grades = 3.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox5.Text);
                textBox19.Text = PointsEarned.ToString();
            }
            if (comboBox5.SelectedIndex == 3)
            {
                Grades = 3.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox5.Text);
                textBox19.Text = PointsEarned.ToString();
            }
            if (comboBox5.SelectedIndex == 4)
            {
                Grades = 3.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox5.Text);
                textBox19.Text = PointsEarned.ToString();
            }
            if (comboBox5.SelectedIndex == 5)
            {
                Grades = 2.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox5.Text);
                textBox19.Text = PointsEarned.ToString();
            }
            if (comboBox5.SelectedIndex == 6)
            {
                Grades = 2.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox5.Text);
                textBox19.Text = PointsEarned.ToString();
            }
            if (comboBox5.SelectedIndex == 7)
            {
                Grades = 2.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox5.Text);
                textBox19.Text = PointsEarned.ToString();
            }
            if (comboBox5.SelectedIndex == 8)
            {
                Grades = 1.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox5.Text);
                textBox19.Text = PointsEarned.ToString();
            }
            if (comboBox5.SelectedIndex == 9)
            {
                Grades = 1.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox5.Text);
                textBox19.Text = PointsEarned.ToString();
            }
            if (comboBox5.SelectedIndex == 10)
            {
                Grades = 1.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox5.Text);
                textBox19.Text = PointsEarned.ToString();
            }
            if (comboBox5.SelectedIndex == 11)
            {
                Grades = 0.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox5.Text);
                textBox19.Text = PointsEarned.ToString();
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Credits = (float)Convert.ToDouble(textBox6.Text);

            if (comboBox6.SelectedIndex == 0)
            {
                Grades = 4.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox6.Text);
                textBox20.Text = PointsEarned.ToString();
            }
            if (comboBox6.SelectedIndex == 1)
            {
                Grades = 4.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox6.Text);
                textBox20.Text = PointsEarned.ToString();
            }
            if (comboBox6.SelectedIndex == 2)
            {
                Grades = 3.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox6.Text);
                textBox20.Text = PointsEarned.ToString();
            }
            if (comboBox6.SelectedIndex == 3)
            {
                Grades = 3.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox6.Text);
                textBox20.Text = PointsEarned.ToString();
            }
            if (comboBox6.SelectedIndex == 4)
            {
                Grades = 3.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox6.Text);
                textBox20.Text = PointsEarned.ToString();
            }
            if (comboBox6.SelectedIndex == 5)
            {
                Grades = 2.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox6.Text);
                textBox20.Text = PointsEarned.ToString();
            }
            if (comboBox6.SelectedIndex == 6)
            {
                Grades = 2.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox6.Text);
                textBox20.Text = PointsEarned.ToString();
            }
            if (comboBox6.SelectedIndex == 7)
            {
                Grades = 2.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox6.Text);
                textBox20.Text = PointsEarned.ToString();
            }
            if (comboBox6.SelectedIndex == 8)
            {
                Grades = 1.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox6.Text);
                textBox20.Text = PointsEarned.ToString();
            }
            if (comboBox6.SelectedIndex == 9)
            {
                Grades = 1.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox6.Text);
                textBox20.Text = PointsEarned.ToString();
            }
            if (comboBox6.SelectedIndex == 10)
            {
                Grades = 1.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox6.Text);
                textBox20.Text = PointsEarned.ToString();
            }
            if (comboBox6.SelectedIndex == 11)
            {
                Grades = 0.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox6.Text);
                textBox20.Text = PointsEarned.ToString();
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Credits = (float)Convert.ToDouble(textBox7.Text);

            if (comboBox7.SelectedIndex == 0)
            {
                Grades = 4.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox7.Text);
                textBox21.Text = PointsEarned.ToString();
            }
            if (comboBox7.SelectedIndex == 1)
            {
                Grades = 4.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox7.Text);
                textBox21.Text = PointsEarned.ToString();
            }
            if (comboBox7.SelectedIndex == 2)
            {
                Grades = 3.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox7.Text);
                textBox21.Text = PointsEarned.ToString();
            }
            if (comboBox7.SelectedIndex == 3)
            {
                Grades = 3.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox7.Text);
                textBox21.Text = PointsEarned.ToString();
            }
            if (comboBox7.SelectedIndex == 4)
            {
                Grades = 3.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox7.Text);
                textBox21.Text = PointsEarned.ToString();
            }
            if (comboBox7.SelectedIndex == 5)
            {
                Grades = 2.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox7.Text);
                textBox21.Text = PointsEarned.ToString();
            }
            if (comboBox7.SelectedIndex == 6)
            {
                Grades = 2.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox7.Text);
                textBox21.Text = PointsEarned.ToString();
            }
            if (comboBox7.SelectedIndex == 7)
            {
                Grades = 2.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox7.Text);
                textBox21.Text = PointsEarned.ToString();
            }
            if (comboBox7.SelectedIndex == 8)
            {
                Grades = 1.66f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox7.Text);
                textBox21.Text = PointsEarned.ToString();
            }
            if (comboBox7.SelectedIndex == 9)
            {
                Grades = 1.33f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox7.Text);
                textBox21.Text = PointsEarned.ToString();
            }
            if (comboBox7.SelectedIndex == 10)
            {
                Grades = 1.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox7.Text);
                textBox21.Text = PointsEarned.ToString();
            }
            if (comboBox7.SelectedIndex == 11)
            {
                Grades = 0.00f;
                PointsEarned = Grades * (float)Convert.ToDouble(textBox7.Text);
                textBox21.Text = PointsEarned.ToString();
            }
        }

       
    }
}
