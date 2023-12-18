using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBases
{
    public partial class Form1 : Form  
    {
        private double SH;
        private double TOL;
        public Form1()
        {
            InitializeComponent();
        }


        private void Kd_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        private void u_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void Kbee_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Zv_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Sig = 0;
            double p = 0;
            double x;
            
            double V = double.Parse(v.Text);
            double F = double.Parse(f.Text); 


            if (choose.Text.Equals("прорезиненный ремень малое постоянное межосевое расстояние"))
            {
                Sig = 1.6;
            } else if(choose.Text.Equals("прорезиненный ремень постоянное достаточное"))
            {
                Sig = 1.8;
            } else if(choose.Text.Equals("прорезиненный ремень периодически регулируемое"))
            {
                Sig = 1.8;
            } else if (choose.Text.Equals("синтетический ремень периодически регулируемое"))
            {
                Sig = 4.5;
            } else if (choose.Text.Equals("прорезиненный ремень автоматически регулируемое постоянное натяжение"))
            {
                Sig = 2.0;
            } else if(choose.Text.Equals("прорезиненный ремень автомат. рег. переменное"))
            {
                Sig = 2.4;
            } else if(choose.Text.Equals("синтетический ремень авт. рег. пост."))
            {
                Sig = 7.5;
            } else if(choose.Text.Equals("синтетический ремень авт. рег. пер."))
            {
                Sig = 10;
            }


            if(tk.Text.Equals("прорезиненная"))
            {
                p = 1.4 * 10 * 10 * 10;
            } else if (tk.Text.Equals("синтетическая 1 тип"))
            {
                p = 0.6 * 10 * 10 * 10;
            } else if(tk.Text.Equals("синтетическая 2 тип'"))
            {
                p = 1.2 * 10 * 10 * 10;
            }


            if(nat.Text.Equals("автоматическое"))
            {
                x = 1;
            } else
            {
                x = 0;
            }

            double Q1 = Sig * SH * TOL + F / 2;
            double Q2 = Sig * SH * TOL - F / 2;
            double Gum = 180 - double.Parse(alpha.Text);

            double R = Math.Sqrt(((Q1 * Q1) + (Q2 * Q2)) + 2 * Q1 * Q2 * Math.Cos(Gum));

            double sigC = (p * V * V) / Math.Pow(10, 6);

            double Q0 = (Sig + (1 - x) * sigC) * SH * TOL;

            double Ugol = Math.Atan((F / (2 * Sig * SH * TOL)) + Math.Tan(Gum / 2));
        
            answerR.Text = R.ToString();
            answerQ0.Text = Q0.ToString();
            if(Ugol > 65)
            {
                result.Text = "Расчёт неверный";
            } else
            {
                result.Text = "Успешно";
            }
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void T1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void generate()
        {
            
        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void interlayer_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tol.Text.Equals("0.4"))
            {
                TOL = 0.4;
            } else if (tol.Text.Equals("0.5"))
            {
                TOL = 0.5;
            }
            else if (tol.Text.Equals("0.6"))
            {
                TOL = 0.6;
            }
            else if (tol.Text.Equals("1.0"))
            {
                TOL = 1.0;
            }
            else if (tol.Text.Equals("1.1"))
            {
                TOL = 1.1;
            }
            else if (tol.Text.Equals("1.2"))
            {
                TOL = 1.2;
            }
            else if (tol.Text.Equals("3.0"))
            {
                TOL = 3.0;
            }
            else if (tol.Text.Equals("3.6"))
            {
                TOL = 3.6;
            }
            else if (tol.Text.Equals("3.75"))
            {
                TOL = 3.75;
            }
            else if (tol.Text.Equals("4.0"))
            {
                TOL = 4.0;
            }
            else if (tol.Text.Equals("4.5"))
            {
                TOL = 4.5;
            }
            else if (tol.Text.Equals("4.8"))
            {
                TOL = 4.8;
            }
            else if (tol.Text.Equals("5.0"))
            {
                TOL = 5.0;
            }
            else if (tol.Text.Equals("6.0"))
            {
                TOL = 6.0;
            }
            else if (tol.Text.Equals("6.25"))
            {
                TOL = 6.25;
            }
            else if (tol.Text.Equals("7.2"))
            {
                TOL = 7.2;
            }
            else if (tol.Text.Equals("7.5"))
            {
                TOL = 7.5;
            }
            else
            {
                TOL = 9.0;
            }
        }

        private void sh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sh.Text.Equals("10"))
            {
                SH = 10;
            } else if(sh.Text.Equals("15"))
            {
                SH = 15;
            }
            else if (sh.Text.Equals("20"))
            {
                SH = 20;
            }
            else if (sh.Text.Equals("25"))
            {
                SH = 25;
            }
            else if (sh.Text.Equals("30"))
            {
                SH = 30;
            }
            else if (sh.Text.Equals("40"))
            {
                SH = 40;
            }
            else if (sh.Text.Equals("50"))
            {
                SH = 50;
            }
            else if (sh.Text.Equals("60"))
            {
                SH = 60;
            }
            else if (sh.Text.Equals("80"))
            {
                SH = 80;
            }
            else if (sh.Text.Equals("100"))
            {
                SH = 100;
            }
            else if (sh.Text.Equals("112"))
            {
                SH = 112;
            }
            else if (sh.Text.Equals("250"))
            {
                SH = 250;
            }
        }
    }
}
