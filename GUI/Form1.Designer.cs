namespace GUI
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
            solveButton = new Button();
            itemsTextBox = new TextBox();
            seedTextBox = new TextBox();
            capacityTextBox = new TextBox();
            label1 = new Label();
            itemsLabel = new Label();
            seedLabel = new Label();
            capacityLabel = new Label();
            SuspendLayout();
            // 
            // solveButton
            // 
            solveButton.Location = new Point(118, 100);
            solveButton.Name = "solveButton";
            solveButton.Size = new Size(100, 30);
            solveButton.TabIndex = 0;
            solveButton.Text = "Solve";
            solveButton.UseVisualStyleBackColor = true;
            // 
            // itemsTextBox
            // 
            itemsTextBox.Location = new Point(12, 58);
            itemsTextBox.Name = "itemsTextBox";
            itemsTextBox.Size = new Size(100, 23);
            itemsTextBox.TabIndex = 1;
            // 
            // seedTextBox
            // 
            seedTextBox.Location = new Point(118, 58);
            seedTextBox.Name = "seedTextBox";
            seedTextBox.Size = new Size(100, 23);
            seedTextBox.TabIndex = 2;
            // 
            // capacityTextBox
            // 
            capacityTextBox.Location = new Point(224, 58);
            capacityTextBox.Name = "capacityTextBox";
            capacityTextBox.Size = new Size(100, 23);
            capacityTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // itemsLabel
            // 
            itemsLabel.AutoSize = true;
            itemsLabel.Location = new Point(35, 40);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new Size(56, 15);
            itemsLabel.TabIndex = 4;
            itemsLabel.Text = "no. items";
            // 
            // seedLabel
            // 
            seedLabel.AutoSize = true;
            seedLabel.Location = new Point(153, 40);
            seedLabel.Name = "seedLabel";
            seedLabel.Size = new Size(31, 15);
            seedLabel.TabIndex = 5;
            seedLabel.Text = "seed";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new Point(250, 40);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(51, 15);
            capacityLabel.TabIndex = 6;
            capacityLabel.Text = "capacity";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 545);
            Controls.Add(capacityLabel);
            Controls.Add(seedLabel);
            Controls.Add(itemsLabel);
            Controls.Add(label1);
            Controls.Add(capacityTextBox);
            Controls.Add(seedTextBox);
            Controls.Add(itemsTextBox);
            Controls.Add(solveButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button solveButton;
        private TextBox itemsTextBox;
        private TextBox seedTextBox;
        private TextBox capacityTextBox;
        private Label label1;
        private Label itemsLabel;
        private Label seedLabel;
        private Label capacityLabel;
    }
}
