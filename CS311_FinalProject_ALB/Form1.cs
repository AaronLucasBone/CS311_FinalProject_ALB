using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_FinalProject_ALB
{
    public partial class Form1 : Form
    {

        double o = 0.0;
        double i = 0.0;
        String tempS = "";
        double tempNum = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
                if (rbMetersToFeet.Checked == true)
                {
                    i = string2Dub();
                    tempNum = metersToFeet(i);
                    lblNumOutput.Text = tempNum.ToString();
                }//end Meters to Feet
                else if (rbMetersToFeet.Checked == true)
                {
                    i = string2Dub();
                    tempNum = feetToMeters(i);
                    lblNumOutput.Text = tempNum.ToString();
                }
                else if (rbKilometersToMiles.Checked == true)
                {
                    i = string2Dub(); 
                    tempNum = kilometersToMiles(i);
                    lblNumOutput.Text = tempNum.ToString();
                }
                else if (rbMilesToKilometers.Checked == true)
                {
                    i = string2Dub();
                    tempNum = milesToKilometers(i);
                    lblNumOutput.Text = tempNum.ToString();
                }
                else if (rbCelsiusToFahrenheit.Checked == true)
                {
                    i = string2Dub();
                    tempNum = celsiusToFahrenheit(i);
                    lblNumOutput.Text = tempNum.ToString();
                }
                else if (rbFahrenheitToCelsius.Checked == true)
                {
                    i = string2Dub();
                    tempNum = fahrenheitToCelsius(i);
                    lblNumOutput.Text = tempNum.ToString();
                }
                else if (rbKilogramsToPounds.Checked == true)
                {
                    i = string2Dub();
                    tempNum = kilogramsToPounds(i);
                    lblNumOutput.Text = tempNum.ToString();
                }
                else if (rbPoundsToKilograms.Checked == true)
                {
                    i = string2Dub();
                    tempNum = poundsToKilograms(i);
                    lblNumOutput.Text = tempNum.ToString();
                }
                else if (rbGramsToOunces.Checked == true)
                {
                    i = string2Dub();
                    tempNum = gramsToOunces(i);
                    lblNumOutput.Text = tempNum.ToString();
                }
                else if (rbOuncesToGrams.Checked == true)
                {
                    i = string2Dub();
                    tempNum = ouncesToGrams(i);
                    lblNumOutput.Text = tempNum.ToString();
                }
        }

        private double string2Dub()
        {
            tempS = txtInput.Text;
            bool success = Double.TryParse(tempS, out double x);

            if (success)
            {
                double r = 0.0;
                r=x;
                return r;
            }
            else
            {
                MessageBox.Show("Invalid Input");
                return 0.0;
            }
            

        }



//Meters to Feet
            private double metersToFeet(double i)
        {
            lblInput.Text = "Meters";
            lblOutput.Text = "Feet";
            return Math.Round(o = i * 3.28084, 3);
        }//end metersToFeet

        private double feetToMeters(double i)
        {
            lblInput.Text = "Feet";
            lblOutput.Text = "Meters";
            return Math.Round(o = i / 3.28084, 3);
        }//end feetToMeters


//Kilometers to Miles

        private double kilometersToMiles(double i)
        {
            lblInput.Text = "KiloMeters";
            lblOutput.Text = "Miles";
            return Math.Round(o = i / 0.621371, 3);
        }//end kilometersToMiles

        private double milesToKilometers(double i)
        {
            lblInput.Text = "Miles";
            lblOutput.Text = "KiloMeters";
            return Math.Round(o = i * 0.621371, 3);
        }//end MilesToKiloMeters

//Celsius to Fahrenheit

        private double celsiusToFahrenheit(double i)
        {
            lblInput.Text = "Celsius";
            lblOutput.Text = "Fahrenheit";
            return Math.Round(o = (i * (9 / 5) + 32), 3);
        }//end ctf

        private double fahrenheitToCelsius(double i)
        {
            lblInput.Text = "Fahrenheit";
            lblOutput.Text = "Celsius";
            return Math.Round(o = (i-32)*(5 / 9), 3);
        }//end ftc

 //Kilogram to Pounds

        private double kilogramsToPounds(double i)
        {
            lblInput.Text = "KiloGrams";
            lblOutput.Text = "Pounds";
            return Math.Round(o = i * 2.2046, 3);
        }//end kilotoPound

        private double poundsToKilograms(double i)
        {
            lblInput.Text = "Pounds";
            lblOutput.Text = "KiloGrams";
            return Math.Round(o = i / 2.2046, 3);
        }//end kilotoPound

 //Grams to ounces (and vice versa)

        private double gramsToOunces(double i)
        {
            lblInput.Text = "Grams";
            lblOutput.Text = "Ounces";
            return Math.Round(o = i / 0.03527, 3);
        }//end gramsToOunces

        private double ouncesToGrams(double i)
        {
            lblInput.Text = "Ounces";
            lblOutput.Text = "Grams";
            return Math.Round(o = i / 0.03527, 3);
        }//end gramsToOunces

//----------------------------------------------

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled != char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only Use Numeric Values in Deciaml Form!");
            }
            else
            {

            }
        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
