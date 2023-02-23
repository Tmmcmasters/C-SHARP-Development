using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Hide();

            //Drop Down column attempt
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Options";
            comboBoxColumn.Name = "optionsColumn";
            comboBoxColumn.Items.AddRange("Option 1", "Option 2", "Option 3");

            dataGridView1.Columns.Add(comboBoxColumn);

            DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
            comboBoxCell.DataSource = new string[] { "Option 1", "Option 2", "Option 3" };
            dataGridView1.Rows[0].Cells[0] = comboBoxCell;



        }
        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // assuming column 0 is the drop-down column
            {
                DataGridViewComboBoxCell comboBoxCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                string selectedValue = comboBoxCell.Value.ToString();
                // do something with selectedValue
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
    }
}


