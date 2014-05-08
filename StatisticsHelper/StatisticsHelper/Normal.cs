using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatisticsHelper
{
    /// <summary>
    /// The main (only) form of the application
    /// </summary>
    public partial class Normal : Form
    {
        /// <summary>
        /// Initializes the form.
        /// </summary>
        public Normal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Solves the x-value from the z-score, mean, and standard deviation.
        /// </summary>
        private void SolveXFromZ()
        {
            double z = Convert.ToDouble(textZ.Text);
            double avg = Convert.ToDouble(textAvg.Text);
            double stdev = Convert.ToDouble(textStDev.Text);

            textX.Text = NormalDistribution.SolveXFromZ(z, stdev, avg).ToString();
        }

        /// <summary>
        /// Solves the x-value from the p-value.
        /// </summary>
        private void SolveXFromP()
        {
            //First solve the z-score for the given p-value, then solve the x-value based on the z-score
            SolveZFromP();
            SolveXFromZ();
        }

        /// <summary>
        /// Solves the mean from the z-score, x-value, and standard deviation.
        /// </summary>
        private void SolveAvgFromZ()
        {
            double x = Convert.ToDouble(textX.Text);
            double z = Convert.ToDouble(textZ.Text);
            double stdev = Convert.ToDouble(textStDev.Text);

            textAvg.Text = NormalDistribution.SolveAvgFromZ(x, z, stdev).ToString();
        }

        /// <summary>
        /// Solves the mean from the p-value.
        /// </summary>
        private void SolveAvgFromP()
        {
            //First solve the z-score from the p-value, then solve the mean from the z-score.
            SolveZFromP();
            SolveAvgFromZ();
        }

        /// <summary>
        /// Solves the standard deviation from the z-score, mean, and x-value.
        /// </summary>
        private void SolveStDevFromZ()
        {
            double x = Convert.ToDouble(textX.Text);
            double z = Convert.ToDouble(textZ.Text);
            double avg = Convert.ToDouble(textAvg.Text);

            textStDev.Text = NormalDistribution.SolveStDevFromZ(x, avg, z).ToString();
        }

        /// <summary>
        /// Solves the standard deviation from the p-value.
        /// </summary>
        private void SolveStDevFromP()
        {
            //First solve the z-score from the p-value, then solve the standard deviation from the z-score.
            SolveZFromP();
            SolveStDevFromZ();
        }

        /// <summary>
        /// Solves the z-score from the x-value, mean, and standard deviation.
        /// </summary>
        private void SolveZFromX()
        {
            double x = Convert.ToDouble(textX.Text);
            double avg = Convert.ToDouble(textAvg.Text);
            double stdev = Convert.ToDouble(textStDev.Text);

            textZ.Text = NormalDistribution.SolveZFromX(x, avg, stdev).ToString();
        }

        /// <summary>
        /// Solves the z-score from the p-value.
        /// </summary>
        private void SolveZFromP()
        {
            NormalDistribution.Proportion proportionType = NormalDistribution.Proportion.LessThan;

            if (dropdownProportionType.SelectedItem == "Greater Than")
                proportionType = NormalDistribution.Proportion.GreaterThan;

            double p = Convert.ToDouble(textP.Text);

            textZ.Text = NormalDistribution.GetZFromProportion(proportionType, p).ToString();
        }

        /// <summary>
        /// Solves the p-value from the z-value.
        /// </summary>
        private void SolvePFromZ()
        {
            NormalDistribution.Proportion proportionType = NormalDistribution.Proportion.LessThan;

            if (dropdownProportionType.SelectedItem == "Greater Than")
                proportionType = NormalDistribution.Proportion.GreaterThan;

            double z = Convert.ToDouble(textZ.Text);

            textP.Text = NormalDistribution.GetProportionFromZ(proportionType, z).ToString();
        }

        /// <summary>
        /// Solves the p-value from the x-value.
        /// </summary>
        private void SolvePFromX()
        {
            //First solve the z-score based on the x-value, then solve the p-value from the z-score.
            SolveZFromX();
            SolvePFromZ();
        }

        /// <summary>
        /// Makes the appropriate calculations, based on a button click.
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">Information about the button click event.</param>
        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                switch (((Button)sender).Name)
                {
                    case "buttonAvg":
                        SolveAvgFromZ();
                        SolvePFromZ();
                        break;
                    case "buttonAvgFromP":
                        SolveAvgFromP();
                        break;
                    case "buttonP":
                        SolvePFromZ();
                        textX.Text = "";
                        textAvg.Text = "";
                        textStDev.Text = "";
                        break;
                    case "buttonPFromX":
                        SolvePFromX();
                        break;
                    case "buttonStDev":
                        SolveStDevFromZ();
                        SolvePFromZ();
                        break;
                    case "buttonStDevFromP":
                        SolveStDevFromP();
                        break;
                    case "buttonX":
                        SolveXFromZ();
                        SolvePFromZ();
                        break;
                    case "buttonXFromP":
                        SolveXFromP();
                        break;
                    case "buttonZ":
                        SolveZFromX();
                        SolvePFromZ();
                        break;
                    case "buttonZFromP":
                        SolveZFromP();
                        textX.Text = "";
                        textAvg.Text = "";
                        textStDev.Text = "";
                        break;
                    default:
                        MessageBox.Show("An error occurred.", "Error");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Input is invalid. Please check and try again.", "Error");
            }
        }
    }
}
