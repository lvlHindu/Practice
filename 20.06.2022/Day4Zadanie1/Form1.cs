using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day4Zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dolg = 100000;
            l1.Text = "Долг по кредиту: " + dolg;
        }
        double dolg;

        private void b1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Math.Round(Convert.ToDouble(tb1.Text), 2);
                if(x <= 0)
                {
                    MessageBox.Show("Неее так кредиты не гасятся!!!");                    
                }                
                else
                Plata(x);
            }
            catch
            {
                MessageBox.Show("Вы кредит-то гасить собираетесь?");
            }
        }
        public void Plata(double p)
        {
            if (p >= dolg)
            {
                double c = p - dolg;
                dolg = 0;
                l1.Text = "Долг по кредиту: " + dolg;
                l1.Text += "\nКредит погашен\n";
                l1.Text += "Переплата: " + (c);
            }
            if (p < dolg)
            {
                dolg -= p;
                l1.Text = "Платёж принят\n";
                l1.Text += "Долг по кредиту: " + dolg;
            }
        }               
        private void b2_Click(object sender, EventArgs e)
        {
            dolg = 100000;
            l1.Text = "Долг по кредиту: " + dolg;
        }
    }
}
