namespace Final_Exam_Part_Two
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileRadioButton = new RadioButton();
            inputRadioButton = new RadioButton();
            coOneTextBox = new TextBox();
            coTwoTextBox = new TextBox();
            coOneLabel = new Label();
            coTwoLabel = new Label();
            solveButton = new Button();
            selectFileButton = new Button();
            solutionHeaderLabel = new Label();
            parallelLabel = new Label();
            sameLineLabel = new Label();
            intersectLabel = new Label();
            intersectionSolutionLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // fileRadioButton
            // 
            fileRadioButton.AutoSize = true;
            fileRadioButton.BackColor = Color.Orange;
            fileRadioButton.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            fileRadioButton.Location = new Point(93, 129);
            fileRadioButton.Name = "fileRadioButton";
            fileRadioButton.Size = new Size(237, 39);
            fileRadioButton.TabIndex = 1;
            fileRadioButton.TabStop = true;
            fileRadioButton.Text = "Process Text File";
            fileRadioButton.UseVisualStyleBackColor = false;
            fileRadioButton.CheckedChanged += fileRadioButton_CheckedChanged;
            // 
            // inputRadioButton
            // 
            inputRadioButton.AutoSize = true;
            inputRadioButton.BackColor = Color.Orange;
            inputRadioButton.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            inputRadioButton.Location = new Point(93, 58);
            inputRadioButton.Name = "inputRadioButton";
            inputRadioButton.Size = new Size(245, 39);
            inputRadioButton.TabIndex = 2;
            inputRadioButton.TabStop = true;
            inputRadioButton.Text = "Input Coefficients";
            inputRadioButton.UseVisualStyleBackColor = false;
            inputRadioButton.CheckedChanged += inputRadioButton_CheckedChanged;
            // 
            // coOneTextBox
            // 
            coOneTextBox.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            coOneTextBox.Location = new Point(93, 223);
            coOneTextBox.Name = "coOneTextBox";
            coOneTextBox.Size = new Size(245, 28);
            coOneTextBox.TabIndex = 3;
            // 
            // coTwoTextBox
            // 
            coTwoTextBox.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            coTwoTextBox.Location = new Point(93, 295);
            coTwoTextBox.Name = "coTwoTextBox";
            coTwoTextBox.Size = new Size(245, 28);
            coTwoTextBox.TabIndex = 4;
            // 
            // coOneLabel
            // 
            coOneLabel.AutoSize = true;
            coOneLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            coOneLabel.ForeColor = Color.Orange;
            coOneLabel.Location = new Point(93, 193);
            coOneLabel.Name = "coOneLabel";
            coOneLabel.Size = new Size(159, 27);
            coOneLabel.TabIndex = 5;
            coOneLabel.Text = "Coefficient One";
            // 
            // coTwoLabel
            // 
            coTwoLabel.AutoSize = true;
            coTwoLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            coTwoLabel.ForeColor = Color.Orange;
            coTwoLabel.Location = new Point(93, 265);
            coTwoLabel.Name = "coTwoLabel";
            coTwoLabel.Size = new Size(159, 27);
            coTwoLabel.TabIndex = 6;
            coTwoLabel.Text = "Coefficient Two";
            // 
            // solveButton
            // 
            solveButton.BackColor = Color.FromArgb(128, 255, 128);
            solveButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            solveButton.Location = new Point(281, 353);
            solveButton.Name = "solveButton";
            solveButton.Size = new Size(160, 50);
            solveButton.TabIndex = 7;
            solveButton.Text = "Solve";
            solveButton.UseVisualStyleBackColor = false;
            solveButton.Click += solveButton_Click;
            // 
            // selectFileButton
            // 
            selectFileButton.BackColor = Color.Orange;
            selectFileButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            selectFileButton.Location = new Point(52, 353);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(182, 50);
            selectFileButton.TabIndex = 8;
            selectFileButton.Text = "Select File";
            selectFileButton.UseVisualStyleBackColor = false;
            selectFileButton.Click += selectFileButton_Click;
            // 
            // solutionHeaderLabel
            // 
            solutionHeaderLabel.AutoSize = true;
            solutionHeaderLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            solutionHeaderLabel.ForeColor = Color.FromArgb(128, 255, 128);
            solutionHeaderLabel.Location = new Point(510, 51);
            solutionHeaderLabel.Name = "solutionHeaderLabel";
            solutionHeaderLabel.Size = new Size(157, 45);
            solutionHeaderLabel.TabIndex = 9;
            solutionHeaderLabel.Text = "Solution:";
            // 
            // parallelLabel
            // 
            parallelLabel.AutoSize = true;
            parallelLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            parallelLabel.ForeColor = Color.Red;
            parallelLabel.Location = new Point(442, 123);
            parallelLabel.Name = "parallelLabel";
            parallelLabel.Size = new Size(295, 45);
            parallelLabel.TabIndex = 10;
            parallelLabel.Text = "Lines Are Parallel";
            // 
            // sameLineLabel
            // 
            sameLineLabel.AutoSize = true;
            sameLineLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            sameLineLabel.ForeColor = Color.Red;
            sameLineLabel.Location = new Point(426, 175);
            sameLineLabel.Name = "sameLineLabel";
            sameLineLabel.Size = new Size(337, 45);
            sameLineLabel.TabIndex = 11;
            sameLineLabel.Text = "Lines Are The Same";
            // 
            // intersectLabel
            // 
            intersectLabel.AutoSize = true;
            intersectLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            intersectLabel.ForeColor = Color.Red;
            intersectLabel.Location = new Point(426, 223);
            intersectLabel.Name = "intersectLabel";
            intersectLabel.Size = new Size(273, 45);
            intersectLabel.TabIndex = 12;
            intersectLabel.Text = "Lines Intersect:";
            // 
            // intersectionSolutionLabel
            // 
            intersectionSolutionLabel.AutoSize = true;
            intersectionSolutionLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            intersectionSolutionLabel.ForeColor = Color.FromArgb(128, 255, 128);
            intersectionSolutionLabel.Location = new Point(688, 223);
            intersectionSolutionLabel.Name = "intersectionSolutionLabel";
            intersectionSolutionLabel.Size = new Size(100, 45);
            intersectionSolutionLabel.TabIndex = 13;
            intersectionSolutionLabel.Text = "blank";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(456, 353);
            label1.Name = "label1";
            label1.Size = new Size(211, 76);
            label1.TabIndex = 14;
            label1.Text = "Leave lines between both inputs. \r\nSelect File \r\nThen Click Solve\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(258, 199);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 15;
            label2.Text = "EX(1 2 3)\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(990, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(intersectionSolutionLabel);
            Controls.Add(intersectLabel);
            Controls.Add(sameLineLabel);
            Controls.Add(parallelLabel);
            Controls.Add(solutionHeaderLabel);
            Controls.Add(selectFileButton);
            Controls.Add(solveButton);
            Controls.Add(coTwoLabel);
            Controls.Add(coOneLabel);
            Controls.Add(coTwoTextBox);
            Controls.Add(coOneTextBox);
            Controls.Add(inputRadioButton);
            Controls.Add(fileRadioButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton fileRadioButton;
        private RadioButton inputRadioButton;
        private TextBox coOneTextBox;
        private TextBox coTwoTextBox;
        private Label coOneLabel;
        private Label coTwoLabel;
        private Button solveButton;
        private Button selectFileButton;
        private Label solutionHeaderLabel;
        private Label parallelLabel;
        private Label sameLineLabel;
        private Label intersectLabel;
        private Label intersectionSolutionLabel;
        private Label label1;
        private Label label2;
    }
}