namespace WindowsFormsApp1
{
    partial class InputBox
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
            this.enterCategoryLabel = new System.Windows.Forms.Label();
            this.okayCategoryButton = new System.Windows.Forms.Button();
            this.cancelCategoryButton = new System.Windows.Forms.Button();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterCategoryLabel
            // 
            this.enterCategoryLabel.AutoSize = true;
            this.enterCategoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterCategoryLabel.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCategoryLabel.Location = new System.Drawing.Point(31, 9);
            this.enterCategoryLabel.Name = "enterCategoryLabel";
            this.enterCategoryLabel.Size = new System.Drawing.Size(667, 92);
            this.enterCategoryLabel.TabIndex = 0;
            this.enterCategoryLabel.Text = "Enter the category:";
            this.enterCategoryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // okayCategoryButton
            // 
            this.okayCategoryButton.BackColor = System.Drawing.Color.LightGreen;
            this.okayCategoryButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okayCategoryButton.Location = new System.Drawing.Point(89, 341);
            this.okayCategoryButton.Name = "okayCategoryButton";
            this.okayCategoryButton.Size = new System.Drawing.Size(131, 54);
            this.okayCategoryButton.TabIndex = 1;
            this.okayCategoryButton.Text = "OK";
            this.okayCategoryButton.UseVisualStyleBackColor = false;
            this.okayCategoryButton.Click += new System.EventHandler(this.okayCategoryButton_Click);
            // 
            // cancelCategoryButton
            // 
            this.cancelCategoryButton.BackColor = System.Drawing.Color.Red;
            this.cancelCategoryButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelCategoryButton.Location = new System.Drawing.Point(558, 341);
            this.cancelCategoryButton.Name = "cancelCategoryButton";
            this.cancelCategoryButton.Size = new System.Drawing.Size(116, 54);
            this.cancelCategoryButton.TabIndex = 2;
            this.cancelCategoryButton.Text = "Cancel";
            this.cancelCategoryButton.UseVisualStyleBackColor = false;
            this.cancelCategoryButton.Click += new System.EventHandler(this.cancelCategoryButton_Click);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryTextBox.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTextBox.Location = new System.Drawing.Point(209, 182);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(320, 45);
            this.categoryTextBox.TabIndex = 3;
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.cancelCategoryButton);
            this.Controls.Add(this.okayCategoryButton);
            this.Controls.Add(this.enterCategoryLabel);
            this.Name = "InputBox";
            this.Text = "InputBox";
            this.Load += new System.EventHandler(this.InputBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterCategoryLabel;
        private System.Windows.Forms.Button okayCategoryButton;
        private System.Windows.Forms.Button cancelCategoryButton;
        private System.Windows.Forms.TextBox categoryTextBox;
    }
}