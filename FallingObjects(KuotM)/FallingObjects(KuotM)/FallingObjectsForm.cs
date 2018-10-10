/*
 * Created by: Kuot Mariak
 * Created on: 27-09-2018
 * Created for: ICS3U Programming
 * Major Assignment – #2 - Falling Objects
 * Falling Objects...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjects_KuotM_
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();
        }
        // This declares the variables
        double time, height;
       

        private void frmFallingObjects_Load(object sender, EventArgs e)
        {
            // This hides the labels
            lblStateHeight.Hide();
            lblHeightAnswer.Hide();

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // This converts the string from the txt to a double
            time = double.Parse(txtTime.Text);

            // Calculate the height the object is above the ground
            height = 100 - 0.5 * 9.81 * Math.Pow(time,2);

            // This rounds the answer to two decimal places
            height = Math.Round(height, 2);

            // This shows the labels when clicked
            lblStateHeight.Show();
            lblHeightAnswer.Show();

            // This converts the height to a label
            lblHeightAnswer.Text = Convert.ToString(height);
        }
    }
}
