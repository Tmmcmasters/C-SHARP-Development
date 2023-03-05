namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.calculateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryList = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEstimatedValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pieGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearEverythingButton = new System.Windows.Forms.Button();
            this.budgetComboBox = new System.Windows.Forms.ComboBox();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.categoryBudgetLabel = new System.Windows.Forms.Label();
            this.priceBudgetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.PaleGreen;
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.calculateButton.Location = new System.Drawing.Point(30, 281);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 41);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(445, 281);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 41);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(562, 281);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(100, 41);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load(-_/*-*\\_-)";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryList,
            this.itemColumn,
            this.quantityColumn,
            this.unitPriceColumn,
            this.totalEstimatedValueColumn});
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 247);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // categoryList
            // 
            this.categoryList.HeaderText = "Category";
            this.categoryList.MinimumWidth = 6;
            this.categoryList.Name = "categoryList";
            this.categoryList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryList.Width = 125;
            // 
            // itemColumn
            // 
            this.itemColumn.HeaderText = "Item";
            this.itemColumn.MinimumWidth = 6;
            this.itemColumn.Name = "itemColumn";
            this.itemColumn.Width = 125;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.MinimumWidth = 6;
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Width = 125;
            // 
            // unitPriceColumn
            // 
            this.unitPriceColumn.HeaderText = "Unit Price";
            this.unitPriceColumn.MinimumWidth = 6;
            this.unitPriceColumn.Name = "unitPriceColumn";
            this.unitPriceColumn.Width = 125;
            // 
            // totalEstimatedValueColumn
            // 
            this.totalEstimatedValueColumn.HeaderText = "Total Estimated Value";
            this.totalEstimatedValueColumn.MinimumWidth = 6;
            this.totalEstimatedValueColumn.Name = "totalEstimatedValueColumn";
            this.totalEstimatedValueColumn.ReadOnly = true;
            this.totalEstimatedValueColumn.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(30, 336);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(273, 38);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Incorrect Input Type";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(172, 281);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 41);
            this.button4.TabIndex = 6;
            this.button4.Text = "Add Category";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // pieGraph
            // 
            this.pieGraph.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.pieGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieGraph.Legends.Add(legend2);
            this.pieGraph.Location = new System.Drawing.Point(30, 401);
            this.pieGraph.Margin = new System.Windows.Forms.Padding(2);
            this.pieGraph.Name = "pieGraph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pieGraph.Series.Add(series2);
            this.pieGraph.Size = new System.Drawing.Size(450, 228);
            this.pieGraph.TabIndex = 7;
            this.pieGraph.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(422, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(535, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.TabIndex = 9;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // clearEverythingButton
            // 
            this.clearEverythingButton.BackColor = System.Drawing.Color.Red;
            this.clearEverythingButton.Location = new System.Drawing.Point(311, 281);
            this.clearEverythingButton.Name = "clearEverythingButton";
            this.clearEverythingButton.Size = new System.Drawing.Size(94, 41);
            this.clearEverythingButton.TabIndex = 10;
            this.clearEverythingButton.Text = "CLEAR EVERYTHING";
            this.clearEverythingButton.UseVisualStyleBackColor = false;
            this.clearEverythingButton.Click += new System.EventHandler(this.clearEverythingButton_Click_1);
            // 
            // budgetComboBox
            // 
            this.budgetComboBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetComboBox.FormattingEnabled = true;
            this.budgetComboBox.Location = new System.Drawing.Point(712, 122);
            this.budgetComboBox.Name = "budgetComboBox";
            this.budgetComboBox.Size = new System.Drawing.Size(144, 38);
            this.budgetComboBox.TabIndex = 11;
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetLabel.ForeColor = System.Drawing.Color.LightGreen;
            this.budgetLabel.Location = new System.Drawing.Point(794, 9);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(173, 45);
            this.budgetLabel.TabIndex = 12;
            this.budgetLabel.Text = "BUDGETS";
            this.budgetLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(913, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 41);
            this.textBox2.TabIndex = 13;
            // 
            // categoryBudgetLabel
            // 
            this.categoryBudgetLabel.AutoSize = true;
            this.categoryBudgetLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBudgetLabel.ForeColor = System.Drawing.Color.LightGreen;
            this.categoryBudgetLabel.Location = new System.Drawing.Point(739, 96);
            this.categoryBudgetLabel.Name = "categoryBudgetLabel";
            this.categoryBudgetLabel.Size = new System.Drawing.Size(80, 23);
            this.categoryBudgetLabel.TabIndex = 14;
            this.categoryBudgetLabel.Text = "Category";
            // 
            // priceBudgetLabel
            // 
            this.priceBudgetLabel.AutoSize = true;
            this.priceBudgetLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBudgetLabel.ForeColor = System.Drawing.Color.LightGreen;
            this.priceBudgetLabel.Location = new System.Drawing.Point(925, 96);
            this.priceBudgetLabel.Name = "priceBudgetLabel";
            this.priceBudgetLabel.Size = new System.Drawing.Size(108, 23);
            this.priceBudgetLabel.TabIndex = 15;
            this.priceBudgetLabel.Text = "Price Budget";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1070, 385);
            this.Controls.Add(this.priceBudgetLabel);
            this.Controls.Add(this.categoryBudgetLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.budgetComboBox);
            this.Controls.Add(this.clearEverythingButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pieGraph);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.calculateButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEstimatedValueColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearEverythingButton;
        private System.Windows.Forms.ComboBox budgetComboBox;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label categoryBudgetLabel;
        private System.Windows.Forms.Label priceBudgetLabel;
    }
}

