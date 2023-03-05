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
    public partial class InputBox : Form
    {
        public string UserInput { get; private set; }
        public InputBox(string prompt)
        {
            InitializeComponent();
           enterCategoryLabel.Text = prompt;
        }

      
        private void okayCategoryButton_Click(object sender, EventArgs e)
        {
            UserInput = categoryTextBox.Text;
            DialogResult = DialogResult.OK;
        }

        private void cancelCategoryButton_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void InputBox_Load(object sender, EventArgs e)
        {

        }
    }
}
