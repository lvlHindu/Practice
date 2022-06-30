using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day4Zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
        long Factorial(long n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        private void b1_Click(object sender, EventArgs e)
        {
            try
            {
                long x = Convert.ToInt32(tb1.Text);
                tb2.Text = Convert.ToString(Factorial(x));
            }
            catch
            {
                MessageBox.Show("Надо ввести кол-во клиентов");
            }
        }
    }
}
