using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tolu Adebayo
 * Created on: 29-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
 * This program calculates the volume of a cylinder
*/
namespace CylinderVolumeToluA
{
    public partial class frmCylinderVolume : Form
    {
        public frmCylinderVolume()
        {
            InitializeComponent();
        }
        private double CalculateVolume (double Radius, double Height)
        {
            // identify double
            double Volume;
            // Get the formula
            Volume = Math.Round( Math.PI * Math.Pow(Radius, 2) * Height, 2);
            // Return Volume
            return Volume;
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // identiy Doubles
            double userHeight;
            double userRadius;
            double Volume;
            // Convert the nukmbers in the text box to doubles
            userHeight = Convert.ToDouble(txtHeight.Text);
            userRadius = Convert.ToDouble(txtRadius.Text);
            // Call the function
            Volume = CalculateVolume(userRadius, userHeight);
            // Show Message Box
           MessageBox.Show("The Volume is: " + Volume + " Cubic Units" , "Volume Answer");
        }
    }
}
