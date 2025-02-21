
namespace PayCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.earnedOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.earnedLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.pretaxLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pretaxOutput = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.hoursInput = new System.Windows.Forms.TextBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.payRateInput = new System.Windows.Forms.TextBox();
            this.payRateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // earnedOutput
            // 
            this.earnedOutput.BackColor = System.Drawing.Color.White;
            this.earnedOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earnedOutput.ForeColor = System.Drawing.Color.Black;
            this.earnedOutput.Location = new System.Drawing.Point(171, 375);
            this.earnedOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.earnedOutput.Name = "earnedOutput";
            this.earnedOutput.Size = new System.Drawing.Size(104, 25);
            this.earnedOutput.TabIndex = 20;
            this.earnedOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.White;
            this.taxOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.ForeColor = System.Drawing.Color.Black;
            this.taxOutput.Location = new System.Drawing.Point(171, 321);
            this.taxOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(104, 25);
            this.taxOutput.TabIndex = 19;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // earnedLabel
            // 
            this.earnedLabel.AutoSize = true;
            this.earnedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earnedLabel.ForeColor = System.Drawing.Color.White;
            this.earnedLabel.Location = new System.Drawing.Point(80, 375);
            this.earnedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.earnedLabel.Name = "earnedLabel";
            this.earnedLabel.Size = new System.Drawing.Size(71, 25);
            this.earnedLabel.TabIndex = 18;
            this.earnedLabel.Text = "Earned";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.White;
            this.taxLabel.Location = new System.Drawing.Point(112, 321);
            this.taxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(39, 25);
            this.taxLabel.TabIndex = 17;
            this.taxLabel.Text = "Tax";
            // 
            // pretaxLabel
            // 
            this.pretaxLabel.AutoSize = true;
            this.pretaxLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretaxLabel.ForeColor = System.Drawing.Color.White;
            this.pretaxLabel.Location = new System.Drawing.Point(86, 264);
            this.pretaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pretaxLabel.Name = "pretaxLabel";
            this.pretaxLabel.Size = new System.Drawing.Size(65, 25);
            this.pretaxLabel.TabIndex = 16;
            this.pretaxLabel.Text = "Pretax";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(-1, -2);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(340, 52);
            this.titleLabel.TabIndex = 15;
            this.titleLabel.Text = "Pay Calculator";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pretaxOutput
            // 
            this.pretaxOutput.BackColor = System.Drawing.Color.White;
            this.pretaxOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretaxOutput.ForeColor = System.Drawing.Color.Black;
            this.pretaxOutput.Location = new System.Drawing.Point(171, 264);
            this.pretaxOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pretaxOutput.Name = "pretaxOutput";
            this.pretaxOutput.Size = new System.Drawing.Size(104, 25);
            this.pretaxOutput.TabIndex = 14;
            this.pretaxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcButton
            // 
            this.calcButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.ForeColor = System.Drawing.Color.White;
            this.calcButton.Location = new System.Drawing.Point(111, 183);
            this.calcButton.Margin = new System.Windows.Forms.Padding(2);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(122, 37);
            this.calcButton.TabIndex = 13;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // hoursInput
            // 
            this.hoursInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursInput.Location = new System.Drawing.Point(207, 81);
            this.hoursInput.Margin = new System.Windows.Forms.Padding(2);
            this.hoursInput.Name = "hoursInput";
            this.hoursInput.Size = new System.Drawing.Size(68, 29);
            this.hoursInput.TabIndex = 12;
            this.hoursInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.ForeColor = System.Drawing.Color.White;
            this.hoursLabel.Location = new System.Drawing.Point(57, 81);
            this.hoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(132, 25);
            this.hoursLabel.TabIndex = 11;
            this.hoursLabel.Text = "Hours Worked";
            // 
            // payRateInput
            // 
            this.payRateInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payRateInput.Location = new System.Drawing.Point(207, 125);
            this.payRateInput.Margin = new System.Windows.Forms.Padding(2);
            this.payRateInput.Name = "payRateInput";
            this.payRateInput.Size = new System.Drawing.Size(68, 29);
            this.payRateInput.TabIndex = 22;
            this.payRateInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // payRateLabel
            // 
            this.payRateLabel.AutoSize = true;
            this.payRateLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payRateLabel.ForeColor = System.Drawing.Color.White;
            this.payRateLabel.Location = new System.Drawing.Point(106, 125);
            this.payRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.payRateLabel.Name = "payRateLabel";
            this.payRateLabel.Size = new System.Drawing.Size(83, 25);
            this.payRateLabel.TabIndex = 21;
            this.payRateLabel.Text = "Pay Rate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.payRateInput);
            this.Controls.Add(this.payRateLabel);
            this.Controls.Add(this.earnedOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.earnedLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.pretaxLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pretaxOutput);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.hoursInput);
            this.Controls.Add(this.hoursLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pay Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label earnedOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label earnedLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label pretaxLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label pretaxOutput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox hoursInput;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.TextBox payRateInput;
        private System.Windows.Forms.Label payRateLabel;
    }
}

