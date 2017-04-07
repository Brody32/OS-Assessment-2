// This program was originally written by Gail Mosdell (February 2017), Edited by Brody Mountford
// It forms the base of a converter program for the OS-Assessment Two for Cert IV
// Date : March 2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp
{
    public partial class frm_Main : Form
    {
        public frm_Main() //Initialize the Form
        {
            InitializeComponent();
        }

        double dbl_UofM, dbl_Convert; // Global Variables

        public double[] constants = new double[5] // Constant Values
        {
            0.3937, //CM_TO_INCH
            0.0328084, //CM_TO_FEET
            3.28084, //METRES_TO_FEET
            0.621371, //KM_TO_MILES
            1.8 //CELSIUS_TO_FAHREN
        };
        
        private void btn_Convert_Click(object sender, EventArgs e) // RUN CONVERSION METHODS
        {
            listBox_Out.Items.Clear();
            Convert_CM_to_Inches();
            Convert_CM_to_Feet();
            Convert_M_to_Feet();
            Convert_KM_to_Miles();
            Convert_Celsius_to_Fahren();
        } 

        private void Convert_CM_to_Inches() // CONVERT CENTIMETRES TO INCHES
        {
            // CM to Inch
            // 1 Centimetre : 0.3937 Inches
            double CM_TO_INCH = constants[0];

            // validate user entry and convert to a double

            if (!double.TryParse(txt_CM_TO_INCH.Text, out dbl_UofM)) //If no numeric value is entered open a messagebox error is displayed
            {
                inputError();
            }
            else // Output answer to listBox
            {
                dbl_Convert = dbl_UofM * CM_TO_INCH;
                listBox_Out.Items.Add(txt_CM_TO_INCH.Text + " centimetres is converted to");
                listBox_Out.Items.Add(dbl_Convert.ToString() + " inches.");
                listBox_Out.Items.Add("");
            }
        }

        private void Convert_CM_to_Feet() // CONVERT CENTIMETRES TO FEET
        {
            // CM to Feet
            // 1 Centimetre : 0.0328084 Feet
            double CM_TO_FEET = constants[1];

            // validate user entry and convert to a double

            if (!double.TryParse(txt_CM_TO_FEET.Text, out dbl_UofM)) //If no numeric value is entered open a messagebox error is displayed
            {
                inputError();
            }
            else // Output answer to listBox
            {
                dbl_Convert = dbl_UofM * CM_TO_FEET;
                listBox_Out.Items.Add(txt_CM_TO_FEET.Text + " centimetres is converted to ");
                listBox_Out.Items.Add(dbl_Convert.ToString() + " feet.");
                listBox_Out.Items.Add("");
            }
        }

        private void Convert_M_to_Feet() // CONVERT METRES TO FEET
        {
            // M to Feet
            // 1 Metre : 3.28084 Feet
            double M_TO_FEET = constants[2];

            // validate user entry and convert to a double

            if (!double.TryParse(txt_M_TO_FEET.Text, out dbl_UofM)) //If no numeric value is entered open a messagebox error is displayed
            {
                inputError();
            }
            else // Output answer to listBox
            {
                dbl_Convert = dbl_UofM * M_TO_FEET;
                listBox_Out.Items.Add(txt_M_TO_FEET.Text + " metres is converted to ");
                listBox_Out.Items.Add(dbl_Convert.ToString() + " feet.");
                listBox_Out.Items.Add("");
            }
        }
        
        private void Convert_KM_to_Miles() // CONVERT KILOMETRES TO MILES
        {
            // Kilometres to Miles
            // 1 Kilometre : 0.621371 Miles
            double KM_TO_MILE = constants[3];

            // validate user entry and convert to a double

            if (!double.TryParse(txt_KM_TO_MILE.Text, out dbl_UofM)) //If no numeric value is entered open a messagebox error is displayed
            {
                inputError();
            }
            else // Output answer to listBox
            {
                dbl_Convert = dbl_UofM * KM_TO_MILE;
                listBox_Out.Items.Add(txt_KM_TO_MILE.Text + " kilometres is converted to ");
                listBox_Out.Items.Add(dbl_Convert.ToString() + " miles.");
                listBox_Out.Items.Add("");
            }
        }

        private void Convert_Celsius_to_Fahren() // CONVERT CELSIUS TO FAHRENHEIT
        {
            // Celsius to Fahrenheit
            // 0° Celsius : 32° Fahrenheit
            // When calculating Fahrenheit, Celsius must be multiplied by 1.8 and increased by 32 (32 is added later within the convert method)
            double CELSIUS_TO_FAHREN = constants[4];

            // validate user entry and convert to a double

            if (!double.TryParse(txt_CELSIUS_TO_FAHREN.Text, out dbl_UofM)) //If no numeric value is entered open a messagebox error is displayed
            {
                inputError();
            }
            else // Output answer to listBox
            {
                dbl_Convert = (dbl_UofM * CELSIUS_TO_FAHREN) + 32;
                listBox_Out.Items.Add(txt_CELSIUS_TO_FAHREN.Text + "° celsius is converted to ");
                listBox_Out.Items.Add(dbl_Convert.ToString() + "° fahrenheit.");
                listBox_Out.Items.Add("");
            }
        }

        private void inputError() //displays error when user input is invalid
        {
            listBox_Out.Items.Add("A numeric must be entered.");
            listBox_Out.Items.Add("Please re-enter the value.");
            listBox_Out.Items.Add("");
        }
    }
}

