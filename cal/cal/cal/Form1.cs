using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal { 

    public partial class exp : Form  
    {
        float a, b;
        double a1, b1;
        int count;
        bool znak = true;
        public bool tm = false;




        public exp()
        {
            InitializeComponent();



        }
        



        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = ((a * float.Parse(textBox1.Text) / 100));
                    textBox1.Text = b.ToString();
                    break;
                case 666:
                    b1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = (Math.Pow(a1, b1)).ToString();
                    break;

               default:
                    break;
            }

        }


        private int Power()
        {
            int b1 = Convert.ToInt32(textBox1.Text);
            if (b1 == 0)
                return 1;
            else 
                
        }

        private void CheckABS()
        {
            string s = textBox1.Text;
            if (s[0] == '-')
            {
                textBox1.Clear();
                for (int i=1; i<s.Count(); i++ )
                {
                    textBox1.Text = textBox1.Text + s[i];
                }
            }
        }
        

        private void Button1_Click(object sender, EventArgs e)
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

        private void Button8_Click(object sender, EventArgs e)
        {

            calculate();
            label1.Text = "";

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "х";
            znak = true;
        }

        private void Division_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Point_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Percent_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label1.Text = a.ToString() + "%";
            znak = true;
        }

        

        private void Expansion_Click(object sender, EventArgs e)
        {
            tm = !tm;
            if (this.Width < 350 && tm == true)
            {
                while (!(this.Width == 600))
                {
                    this.Width += 1;
                    if (this.Width == 464)
                    {
                        expansion.Text = "<";
                        tm = false;

                    }


                }

            }


            if (this.Width > 400 && tm == true)
            {
                while (!(this.Width == 230))
                {

                    this.Width -= 1;

                    if (this.Width == 311)
                    {
                        expansion.Text = ">";
                        tm = false;

                    }


                }

            }
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            int a = 1;
            try
            {
                Convert.ToInt32(textBox1.Text);

            }
            catch
            {

                MessageBox.Show("Введите, пожалуйста целое число.", "Ошибка!");
                a = 0;

            }

            if (a == 0)
            {

            }
            else
            {
                for (int i = 2; i <= Convert.ToInt32(textBox1.Text); i++)
                {

                    a = a * i;
                }
                textBox1.Text = a.ToString();
                znak = true;
                
            }
        }

        private void Abs_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            //textBox1.Text = Math.Abs(Convert.ToDouble(textBox1.Text)).ToString();
            CheckABS();
            znak = true;
        }

        private void Square_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = ((Convert.ToDouble(textBox1.Text)) * Convert.ToDouble(textBox1.Text)).ToString();
            znak = true;
            
        }

        private void Cube_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = ((Convert.ToDouble(textBox1.Text)) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)).ToString();
            znak = true;
        }

        private void OneDiv_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) == 0) MessageBox.Show("Деление на ноль невозможно.", "Ошибка!");
            else
            {
                if (textBox1.Text == "") textBox1.Text = "0";
                textBox1.Text = (1 / (Convert.ToDouble(textBox1.Text))).ToString();
                znak = true;
                
            }
        }

        private void LnX_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Log(Convert.ToDouble(textBox1.Text)).ToString();
            znak = true;
            
        }

        private void ExpX_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Exp(Convert.ToDouble(textBox1.Text)).ToString();
            znak = true;
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Sin(Convert.ToDouble(textBox1.Text)).ToString();
            znak = true;
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Cos(Convert.ToDouble(textBox1.Text)).ToString();
            znak = true;
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Tan(Convert.ToDouble(textBox1.Text)).ToString();
            znak = true;
        }

        private void Cot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = (1/(Math.Tan(Convert.ToDouble(textBox1.Text)))).ToString();
            znak = true;
        }

        private void Log_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Log10(Convert.ToDouble(textBox1.Text)).ToString();
            znak = true;
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {

        }

        private void XN_Click(object sender, EventArgs e)
        {
            a1 = (Convert.ToDouble(textBox1.Text));
            textBox1.Clear();
            count = 666;
            label1.Text = a1.ToString() + "^";
            znak = true;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            textBox1.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();

            znak = true;
        }

       


            

            
        

        

       
    }
}

      
    

