using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatorial_VictorFernandes_2003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button ite = (sender as Button);
            Double num = double.Parse(txt.Text);
            label.Text = Convert.ToString(Iterative(num));
        }

        private double Iterative(double num)
        {
            double result = 1;
            for (double i = 1; i < num+1; i++)
            {
                result *= i;
            }
                return result;
        }

        private double Recursive(double num)
        {
            double result;
            if (num == 0) return 1;
            result = num * Recursive(num - 1);
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button rec = (sender as Button);
            Double num = double.Parse(txt.Text);
            label.Text = Convert.ToString(Recursive(num));
        }


    }
}
