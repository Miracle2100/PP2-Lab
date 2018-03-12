﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double a, b;
        double s;
        int method;
        bool znak;

        public Form1()
        {
            InitializeComponent();
        }
        private double factorial(double n)
        {

            if (n == 0)
                return 1;
            else return n * factorial(n - 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            method = 2;
            label1.Text =  a.ToString()+ "-" ;
            znak = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            method = 3;
            label1.Text = a.ToString()+ "-" ;
            znak = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            method = 4;
            label1.Text = a.ToString() + "*"  ;
            znak = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            method = 1;
            label1.Text = a.ToString()+ "+"  ;
            znak = true;


        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
              textBox1.Text +=  "," ;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = factorial(double.Parse(textBox1.Text));
            textBox1.Text = a.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text) * double.Parse(textBox1.Text);

            textBox1.Text = a.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            method = 5;
            label1.Text = a.ToString() + "^y";
            znak = true;

        }

        private void button23_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            method = 6;
            label1.Text = a.ToString() + "^(1/y)";
            znak = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a = Math.Log10(double.Parse(textBox1.Text));
            textBox1.Text = a.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            a = Math.Log(double.Parse(textBox1.Text));
            textBox1.Text = a.ToString();

        }

        private void button26_Click(object sender, EventArgs e)
        {
            a = Math.Pow(10,double.Parse(textBox1.Text));
            textBox1.Text = a.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            a = Math.Sqrt(double.Parse(textBox1.Text));
            textBox1.Text = a.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            a = Math.Exp(double.Parse(textBox1.Text));
            textBox1.Text = a.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
           
            s += double.Parse(textBox1.Text);

        }

        private void button31_Click(object sender, EventArgs e)
        {
           
            s -= double.Parse(textBox1.Text);

        }

        private void button32_Click(object sender, EventArgs e)
        {
           textBox1.Text = s.ToString();

        }

        private void button33_Click(object sender, EventArgs e)
        {
            s = 0;
            
        }

        private void button29_Click(object sender, EventArgs e)
        {
            s = double.Parse(textBox1.Text);

        }

        private void button35_Click(object sender, EventArgs e)
        {   if (radioButton1.Checked)
            {
                a = Math.Sin(double.Parse(textBox1.Text));

                textBox1.Text = a.ToString();
            }
            else if (radioButton2.Checked)
            {
                a = Math.Asin(double.Parse(textBox1.Text));
                textBox1.Text = a.ToString();
            }
            else textBox1.Text = "";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a = Math.Cos(double.Parse(textBox1.Text));
                textBox1.Text = a.ToString();
            }
            else if (radioButton2.Checked)
            {
                a = Math.Acos(double.Parse(textBox1.Text));
                textBox1.Text = a.ToString();
            }
            
            else textBox1.Text = "";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a = Math.Tan(double.Parse(textBox1.Text));
                textBox1.Text = a.ToString();
            }
            else if( radioButton2.Checked)
            {
                a = Math.Atan(double.Parse(textBox1.Text));
                textBox1.Text = a.ToString();
            }
            else textBox1.Text = "";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            method = 7;
            label1.Text = a.ToString() + "%";
            znak = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calculate()
        {

            switch(method)
            {


                case 1:
                    b = a + double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a / double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a * double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = Math.Pow(a, double.Parse(textBox1.Text));
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    b = Math.Pow(a, 1/double.Parse(textBox1.Text));
                    textBox1.Text = b.ToString();
                    break;
                case 7:
                    b = a % double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                default:
                break;
        }

         }

          

        
        
    }
}