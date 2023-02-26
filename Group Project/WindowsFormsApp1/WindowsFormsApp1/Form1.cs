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
        private List<string> categories = new List<string> { "Floors", "Walls", "Roofing", "Doors", "Upholstery", "Others" };
        
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


            pieGraph.Visible= false;
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
            int[] categoryTotals = { 10, 20, 70, 88, 55, 89 };



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
    }
}


