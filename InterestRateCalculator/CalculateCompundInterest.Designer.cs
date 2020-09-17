namespace InterestRateCalculator
{
    partial class CalculateCompundInterest
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNoOfTimes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.tbPrincipal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(276, 39);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 106);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(4, 37);
            this.lblRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(100, 13);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Yearly Interest Rate";
            // 
            // tbRate
            // 
            this.tbRate.Location = new System.Drawing.Point(132, 39);
            this.tbRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRate.Name = "tbRate";
            this.tbRate.Size = new System.Drawing.Size(124, 20);
            this.tbRate.TabIndex = 3;
            this.tbRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRate_KeyDown);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(257, 39);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(15, 13);
            this.lblPercent.TabIndex = 4;
            this.lblPercent.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many times It is compounded In a Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            // 
            // tbNoOfTimes
            // 
            this.tbNoOfTimes.Location = new System.Drawing.Point(241, 10);
            this.tbNoOfTimes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNoOfTimes.Name = "tbNoOfTimes";
            this.tbNoOfTimes.Size = new System.Drawing.Size(31, 20);
            this.tbNoOfTimes.TabIndex = 6;
            this.tbNoOfTimes.TextChanged += new System.EventHandler(this.tbNoOfTimes_TextChanged);
            this.tbNoOfTimes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNoOfTimes_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "For How Many Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "For How Many Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "=";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(132, 58);
            this.tbYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(124, 20);
            this.tbYear.TabIndex = 6;
            this.tbYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbYear_KeyDown);
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(132, 76);
            this.tbMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(124, 20);
            this.tbMonth.TabIndex = 6;
            this.tbMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMonth_KeyDown);
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Location = new System.Drawing.Point(132, 102);
            this.tbPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.Size = new System.Drawing.Size(125, 20);
            this.tbPrincipal.TabIndex = 3;
            this.tbPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPrincipal_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Principal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "=";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 711);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(7, 149);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 30);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CalculateCompundInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 656);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbNoOfTimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrincipal);
            this.Controls.Add(this.tbRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.btnCalculate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CalculateCompundInterest";
            this.Text = "CalculateCompundInterest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNoOfTimes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.TextBox tbPrincipal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
    }
}