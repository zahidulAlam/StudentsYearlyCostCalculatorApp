namespace YearlyCostCalculator
{
    partial class yearlyCostCalculatorUI
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
            this.yearlyCostGroupBox = new System.Windows.Forms.GroupBox();
            this.discountCheckBox = new System.Windows.Forms.CheckBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.calculateTotalAmountButton = new System.Windows.Forms.Button();
            this.selectClassLabelo = new System.Windows.Forms.Label();
            this.yearlyCostGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearlyCostGroupBox
            // 
            this.yearlyCostGroupBox.Controls.Add(this.discountCheckBox);
            this.yearlyCostGroupBox.Controls.Add(this.classComboBox);
            this.yearlyCostGroupBox.Controls.Add(this.calculateTotalAmountButton);
            this.yearlyCostGroupBox.Controls.Add(this.selectClassLabelo);
            this.yearlyCostGroupBox.Location = new System.Drawing.Point(12, 23);
            this.yearlyCostGroupBox.Name = "yearlyCostGroupBox";
            this.yearlyCostGroupBox.Size = new System.Drawing.Size(455, 254);
            this.yearlyCostGroupBox.TabIndex = 0;
            this.yearlyCostGroupBox.TabStop = false;
            this.yearlyCostGroupBox.Text = "Calculator for yearly cost of a student";
            // 
            // discountCheckBox
            // 
            this.discountCheckBox.AutoSize = true;
            this.discountCheckBox.Location = new System.Drawing.Point(137, 132);
            this.discountCheckBox.Name = "discountCheckBox";
            this.discountCheckBox.Size = new System.Drawing.Size(192, 17);
            this.discountCheckBox.TabIndex = 4;
            this.discountCheckBox.Text = "Get 5% discount for early admission";
            this.discountCheckBox.UseVisualStyleBackColor = true;
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(168, 73);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(161, 21);
            this.classComboBox.TabIndex = 3;
            // 
            // calculateTotalAmountButton
            // 
            this.calculateTotalAmountButton.Location = new System.Drawing.Point(104, 181);
            this.calculateTotalAmountButton.Name = "calculateTotalAmountButton";
            this.calculateTotalAmountButton.Size = new System.Drawing.Size(225, 53);
            this.calculateTotalAmountButton.TabIndex = 2;
            this.calculateTotalAmountButton.Text = "Calculate total amount for one year";
            this.calculateTotalAmountButton.UseVisualStyleBackColor = true;
            this.calculateTotalAmountButton.Click += new System.EventHandler(this.calculateTotalAmountButton_Click);
            // 
            // selectClassLabelo
            // 
            this.selectClassLabelo.AutoSize = true;
            this.selectClassLabelo.Location = new System.Drawing.Point(75, 73);
            this.selectClassLabelo.Name = "selectClassLabelo";
            this.selectClassLabelo.Size = new System.Drawing.Size(65, 13);
            this.selectClassLabelo.TabIndex = 0;
            this.selectClassLabelo.Text = "Select Class";
            // 
            // yearlyCostCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 298);
            this.Controls.Add(this.yearlyCostGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "yearlyCostCalculatorUI";
            this.Text = "Yearly Cost Calculator";
            this.Load += new System.EventHandler(this.yearlyCostCalculatorUI_Load);
            this.yearlyCostGroupBox.ResumeLayout(false);
            this.yearlyCostGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox yearlyCostGroupBox;
        private System.Windows.Forms.CheckBox discountCheckBox;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Button calculateTotalAmountButton;
        private System.Windows.Forms.Label selectClassLabelo;
    }
}

