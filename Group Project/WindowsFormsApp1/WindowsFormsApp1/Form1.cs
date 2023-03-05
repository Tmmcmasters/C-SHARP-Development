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
using System.IO;


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
                                    
        }





        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //PIE GRAPH INITIATION
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

            this.Size = new Size(834, 866);
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
            int currentCategoryIndex = -1;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[categoryColumnIndex].Value != null && dataGridView1.Rows[i].Cells[categoryColumnIndex].Value.ToString() != "")
                {
                    string currentCategory = dataGridView1.Rows[i].Cells[categoryColumnIndex].Value.ToString();
                    if (!categoriesThatExist.Contains(currentCategory))
                    {
                        categoriesThatExist.Add(currentCategory);
                        categoryTotals.Add(0);
                        currentCategoryIndex++;
                    }
                }

                if (currentCategoryIndex >= 0)
                {
                    double totalEstimatedValue = Convert.ToDouble(dataGridView1.Rows[i].Cells[totalColumnIndex].Value);
                    categoryTotals[currentCategoryIndex] += totalEstimatedValue;
                }
            }
            foreach (double logCategoryTotals in categoryTotals)
            {
                Console.WriteLine(logCategoryTotals);
            }
            foreach (string logActualCategories in categoriesThatExist)
            {
                Console.WriteLine(logActualCategories);
            }

            //Outputing Categorys and Category Totals to Pie Graph
            for (int x = 0; x < categoriesThatExist.Count; ++x)
            {
                pieGraph.Series["s1"].Points.AddXY(categoriesThatExist[x], categoryTotals[x]);
                pieGraph.Series["s1"].Points[x].LegendText = categoriesThatExist[x];
            }
            pieGraph.Visible = true;
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
            //Cell validating, highlight row
            int categoryColumnIndex = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[categoryColumnIndex].FormattedValue as string))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
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
            using (var inputBox = new InputBox("Enter the category:"))
            {
                if (inputBox.ShowDialog() == DialogResult.OK)
                {
                    string userInput = inputBox.UserInput;
                    categories.Add(userInput);
                    categoryList.Items.Add(userInput);
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["categoryList"].ReadOnly = false;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["categoryList"].Style.BackColor = Color.White;
                }
            }
            
        }

        //Calculates the total estimated value column
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

               
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //Clear button
        private void clearEverythingButton_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
            MessageBox.Show("Are you sure you want to clear everything!?");
        }

        //Save Button 
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Please select a folder to save";
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "txt|*.txt|bin|*.bin|all|*.*";    // Choose the file type
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string file = sfd.FileName;
                using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.Create)))
                {
                    int filledRow = 0;
                    foreach (DataGridViewRow dataRow in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell item in dataRow.Cells)
                        {
                            if (item.Value != null)
                            {
                                filledRow++;
                                break;
                            }
                        }
                    }

                    writer.Write(dataGridView1.Columns.Count);
                    writer.Write(filledRow); // dataGridView1.Rows.Count);
                    foreach (DataGridViewRow dataRow in dataGridView1.Rows)  // Write each filled row
                    {
                        bool filled = false;
                        foreach (DataGridViewCell item in dataRow.Cells)
                        {
                            if (item.Value != null)
                            {
                                filled = true;
                                break;
                            }
                        }
                        if (filled)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                            {
                                object cellData = dataRow.Cells[j].Value;
                                if (cellData == null)
                                {
                                    writer.Write(false);
                                    writer.Write(false);
                                }
                                else
                                {
                                    writer.Write(true);
                                    writer.Write(cellData.ToString());
                                }
                            }
                        }
                    }

                }
            }
            Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Title = "Please select a file to load";
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "txt|*.txt|bin|*.bin|all|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string file = sfd.FileName;
                using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
                {
                    int cols = reader.ReadInt32();    // Get the columns number
                    int rows = reader.ReadInt32();    // Get the rows number
                    for (int i = 0; i < rows; ++i)
                    {
                        dataGridView1.Rows.Add();
                        for (int j = 0; j < cols; ++j)
                        {
                            if (reader.ReadBoolean())  // if "true", read the cell.
                            {
                                dataGridView1.Rows[i].Cells[j].Value = reader.ReadString();
                            }
                            else reader.ReadBoolean();
                        }
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        //Trying to highlight the every row for which a category is selected.
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Yellow;

        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            int categoryColumnIndex = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[categoryColumnIndex].FormattedValue as string))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }
    }
}


