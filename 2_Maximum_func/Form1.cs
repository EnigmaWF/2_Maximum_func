using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Maximum_func
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string f(double a, double b)
        {
            //счет функций
            double x = (a + 4.0) / b;
            double y = (a + b) / 3.0;
            double z = Math.Sqrt(a * a + b * b);

            //выбираем максимальное значение и возвращаем
            return ("Максимум = " + Math.Max(Math.Max(x, y), z));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*2. Составьте подпрограмму, 
            которая при заданных a и b 
            возвращает максимум трех функций x, y и z, где:

            x = (a+4)/b, 
            y = (a+b)/3,
            z = sqrt(a^2+b^2)*/

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            label1.Text = "" + f(a, b);
        }
    }
}
