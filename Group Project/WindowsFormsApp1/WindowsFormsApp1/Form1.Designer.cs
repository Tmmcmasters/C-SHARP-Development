﻿namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.calculateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.categoryList = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEstimatedValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.pieGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.calculateButton.Location = new System.Drawing.Point(40, 346);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(133, 51);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(414, 346);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 51);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(750, 346);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(133, 51);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load(-_/*-*\\_-)";
            this.loadButton.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 304);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(305, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(363, 45);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Incorrect Input Type";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(230, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 50);
            this.button4.TabIndex = 6;
            this.button4.Text = "Add Category";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // pieGraph
            // 
            this.pieGraph.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.pieGraph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.pieGraph.Legends.Add(legend3);
            this.pieGraph.Location = new System.Drawing.Point(40, 494);
            this.pieGraph.Name = "pieGraph";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.pieGraph.Series.Add(series3);
            this.pieGraph.Size = new System.Drawing.Size(600, 280);
            this.pieGraph.TabIndex = 7;
            this.pieGraph.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(924, 474);
            this.Controls.Add(this.pieGraph);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.calculateButton);
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
    }
}

