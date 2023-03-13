using System;
using System.IO;
using System.Windows.Forms;

namespace Final_Exam_Part_Two

{
    public partial class Form1 : Form
    {
        private bool isFileSelected = false;
        private string[] lines;
        public Form1()
        {
            InitializeComponent();
        }
        private void fileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fileRadioButton.Checked)
            {
                coOneTextBox.Enabled = false;
                coTwoTextBox.Enabled = false;
                selectFileButton.Enabled = true;
            }
            else
            {
                coOneTextBox.Enabled = true;
                coTwoTextBox.Enabled = true;
                selectFileButton.Enabled = false;
            }
        }

        private void inputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (inputRadioButton.Checked)
            {
                selectFileButton.Enabled = false;
                coOneTextBox.Enabled = true;
                coTwoTextBox.Enabled = true;
            }
            else
            {
                selectFileButton.Enabled = true;
                coOneTextBox.Enabled = false;
                coTwoTextBox.Enabled = false;
            }
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                lines = File.ReadAllLines(filename);
                isFileSelected = true;
            }
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            double[] coefficients1 = new double[3];
            double[] coefficients2 = new double[3];
            bool success1 = false;
            bool success2 = false;

            if (isFileSelected)
            {
                if (lines.Length >= 2)
                {
                    success1 = TryParseCoefficients(lines[0], coefficients1);
                    success2 = TryParseCoefficients(lines[1], coefficients2);
                }
            }
            else
            {
                success1 = TryParseCoefficients(coOneTextBox.Text, coefficients1);
                success2 = TryParseCoefficients(coTwoTextBox.Text, coefficients2);
            }

            if (success1 && success2)
            {
                double a1 = coefficients1[0];
                double b1 = coefficients1[1];
                double c1 = coefficients1[2];
                double a2 = coefficients2[0];
                double b2 = coefficients2[1];
                double c2 = coefficients2[2];

                double determinant = a1 * b2 - a2 * b1;

                if (determinant == 0)
                {
                    if (c1 == c2)
                    {
                        sameLineLabel.Visible = true;
                        intersectLabel.Visible = false;
                        intersectionSolutionLabel.Visible = false;
                        parallelLabel.Visible = false;
                    }
                    else
                    {
                        sameLineLabel.Visible = false;
                        intersectLabel.Visible = false;
                        intersectionSolutionLabel.Visible = false;
                        parallelLabel.Visible = true;
                    }
                }
                else
                {
                    double x = (b2 * c1 - b1 * c2) / determinant;
                    double y = (a1 * c2 - a2 * c1) / determinant;
                    sameLineLabel.Visible = false;
                    parallelLabel.Visible = false;
                    intersectLabel.Visible = true;
                    intersectionSolutionLabel.Visible = true;
                    intersectionSolutionLabel.Text = $"({x.ToString("0.00")}, {y.ToString("0.00")})";

                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid coefficients or select a valid file.");
            }
        }




        private bool TryParseCoefficients(string input, double[] coefficients)
        {
            bool success = false;
            string[] parts = input.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 3)
            {
                success = double.TryParse(parts[0], out coefficients[0]) &&
                          double.TryParse(parts[1], out coefficients[1]) &&
                          double.TryParse(parts[2], out coefficients[2]);
            }
            return success;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}





