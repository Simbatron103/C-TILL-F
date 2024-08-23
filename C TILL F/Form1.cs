using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_TILL_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = 32 + celsius * (9 / 5);
            return fahrenheit;
        }

        public string CelsiusToFahrenheitWithStrings(string celsius)
        {
            double celsiusDouble = double.Parse(celsius);
            double fahrenheit = CelsiusToFahrenheit(celsiusDouble);
            return fahrenheit.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           textBox2.Text = CelsiusToFahrenheitWithStrings(textBox1.Text);
            textBox4.Text = CelsiusToFahrenheitWithStrings(textBox3.Text);
            textBox6.Text = CelsiusToFahrenheitWithStrings(textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = FahrenheitTocelsiusWithStrings(textBox2.Text);
            textBox3.Text = FahrenheitTocelsiusWithStrings(textBox4.Text);
            textBox5.Text = FahrenheitTocelsiusWithStrings(textBox6.Text);
           
        }
        public double fahrenheitToCelsius(double fahranheit)
        {
            double celsius = fahranheit - 32 * (9 / 5);
            return celsius;

        }
        public string FahrenheitTocelsiusWithStrings(string fahrenheit)
        {
            double fahrenheitDouble = double.Parse(fahrenheit);
            double celsius = fahrenheitToCelsius(fahrenheitDouble);
            return celsius.ToString();
        }

    }
}
