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
 * Created by: First Last
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
 * This program...
*/
namespace CylinderVolumeToluA
{
    public partial class frmCylinderVolume : Form
    {
        public frmCylinderVolume()
        {
            InitializeComponent();
        }
        private void CalculateVolume (double Radius, double Height)
        {
            double Volume;

            Volume = Math.PI * Math.Pow(Radius, 2);
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
