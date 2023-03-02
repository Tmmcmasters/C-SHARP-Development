using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string> categories = new List<string> { "Floors", "Walls", "Roofing", "Doors", "Upholstery", "Others", "" };

        public Form1()
        {
            InitializeComponent();
            calculateButton.Click += CalculateButton_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Hide();



            // Adding items to the drop down list
            categoryList.Items.AddRange(categories.ToArray());


            pieGraph.Visible = false;

            pieGraph.Series.Clear();
            pieGraph.Titles.Clear();

            pieGraph.Series.Add("s1");
            pieGraph.Titles.Add(" Materials Estimated Chart");
            pieGraph.Series["s1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            pieGraph.Series["s1"].IsValueShownAsLabel = false;
            //chart1.Series["s1"].Label = "#PERCENT";
            //chart1.Series["s1"].Label = "#VALY";
            pieGraph.Series["s1"].Label = "#VALY (#PERCENT)";

            string[] options = categories.ToArray();
            int[] categoryTotals = { 10, 20, 70, 88, 55, 89, 20 };



            for (int x = 0; x < options.Length; ++x)
            {
                pieGraph.Series["s1"].Points.AddXY(options[x], categoryTotals[x]);
                pieGraph.Series["s1"].Points[x].LegendText = options[x];
            }
        }





        private void CalculateButton_Click(object sender, EventArgs e)
        {
            pieGraph.Visible = true;
            this.Size = new Size(715, 866);
            //Calculates and stores the totals of all total estimated values
            label2.Text = "0";
            const int totalColumnIndex = 4;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int tmpValue = 0;
                if (dataGridView1.Rows[i].Cells[totalColumnIndex].Value != null)
                {
                    int.TryParse(dataGridView1.Rows[i].Cells[totalColumnIndex].Value.ToString(), out tmpValue);
                    label2.Text = Convert.ToString(int.Parse(label2.Text) + tmpValue);
                }
            }

            //Stores two parallel arrays for categories and category totals
            List<string> categoriesThatExist = new List<string>();
            List<double> categoryTotals = new List<double>();
            const int categoryColumnIndex = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int categoryTotalsCounter = 0;
                if (dataGridView1.Rows[i].Cells[categoryColumnIndex].Value != null && dataGridView1.Rows[i].Cells[categoryColumnIndex].Value.ToString() != "")
                {

                    categoriesThatExist.Add(dataGridView1.Rows[i].Cells[categoryColumnIndex].Value.ToString());
                }
                if (i != 0) 
                {
                    if (dataGridView1.Rows[0].Cells[categoryColumnIndex] != null && dataGridView1.Rows[0].Cells[categoryColumnIndex].Value.ToString() != "")
                    {
                        ++categoryTotalsCounter;
                        categoryTotals.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[totalColumnIndex].Value));
                    } else
                    {
                        categoryTotals[categoryTotalsCounter] += Convert.ToDouble(dataGridView1.Rows[0].Cells[totalColumnIndex].Value); 
                    }
                 } else if (dataGridView1.Rows[0].Cells[categoryColumnIndex] != null && dataGridView1.Rows[0].Cells[categoryColumnIndex].Value.ToString() != "")
                {
                    categoryTotals.Add(Convert.ToDouble(dataGridView1.Rows[0].Cells[totalColumnIndex].Value));
                } else
                {
                    break;
                }
            }
            foreach (double logCategoryTotals in categoryTotals)
            {
                Console.WriteLine(logCategoryTotals);
            }
            foreach(string logActualCategories in categoriesThatExist)
            {
                Console.WriteLine(logActualCategories);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Checks if the current cell is in the quantity column
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("quantityColumn", StringComparison.OrdinalIgnoreCase))
            {
                // Tries to parse the entered value as a number
                decimal value;
                bool isNumeric = decimal.TryParse(e.FormattedValue.ToString(), out value);

                if (isNumeric)
                {
                    // If the entered value is numeric, hide textBox1
                    textBox1.Hide();
                }
                else
                {
                    // If the entered value is non-numeric, show textBox1
                    textBox1.Show();
                }
                if (e.FormattedValue.ToString() == "")
                {
                    textBox1.Hide();
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("unitPriceColumn", StringComparison.OrdinalIgnoreCase))
            {
                // Tries to parse the entered value as a number

                decimal value;
                bool isNumeric = decimal.TryParse(e.FormattedValue.ToString(), out value);
                if (isNumeric)
                {
                    // If the entered value is numeric, hide textBox1
                    textBox1.Hide();
                }
                else
                {
                    // If the entered value is non-numeric, show textBox1
                    textBox1.Show();
                }
                if (e.FormattedValue.ToString() == "")
                {
                    textBox1.Hide();
                }
            }
            // Checks if the current cell is in the category column
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("categoryColumn", StringComparison.OrdinalIgnoreCase))
            {
                // Gray out the next row in the category column if the current category is not "Others"
                if (e.FormattedValue.ToString() != "Others")
                {
                    dataGridView1.Rows[e.RowIndex + 1].Cells["categoryColumn"].ReadOnly = true;
                    dataGridView1.Rows[e.RowIndex + 1].Cells["categoryColumn"].Style.BackColor = Color.LightGray;
                }
            }
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            // Add a new category to the drop down list and enable the next row in the category column
            categories.Add("New Category");
            categoryList.Items.Add("New Category");
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["categoryList"].ReadOnly = false;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["categoryList"].Style.BackColor = Color.White;
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            int quanity, item;
            if (dataGridView1.Rows[e.RowIndex].Cells["quantityColumn"]?.Value != null
    && dataGridView1.Rows[e.RowIndex].Cells["unitPriceColumn"]?.Value != null)
            {
                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[quantityColumn.Index].Value.ToString(),
                out quanity) && int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[unitPriceColumn.Index].Value.ToString(), out item))
                {
                    int totalEstimatedValueColumn = quanity * item;
                    dataGridView1.Rows[e.RowIndex].Cells["totalEstimatedValueColumn"].Value = totalEstimatedValueColumn.ToString();
                }
            }




        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clearEverythingButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
            MessageBox.Show("Are you sure?");

        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


