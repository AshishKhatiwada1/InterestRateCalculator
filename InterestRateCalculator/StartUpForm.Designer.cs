namespace InterestRateCalculator
{
    partial class StartUpForm
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
            this.btnInterest = new System.Windows.Forms.Button();
            this.btnCompound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInterest
            // 
            this.btnInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterest.Location = new System.Drawing.Point(2, 39);
            this.btnInterest.Name = "btnInterest";
            this.btnInterest.Size = new System.Drawing.Size(576, 480);
            this.btnInterest.TabIndex = 0;
            this.btnInterest.Text = "Calculate Interest";
            this.btnInterest.UseVisualStyleBackColor = true;
            this.btnInterest.Click += new System.EventHandler(this.btnInterest_Click);
            // 
            // btnCompound
            // 
            this.btnCompound.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompound.Location = new System.Drawing.Point(625, 39);
            this.btnCompound.Name = "btnCompound";
            this.btnCompound.Size = new System.Drawing.Size(567, 480);
            this.btnCompound.TabIndex = 2;
            this.btnCompound.Text = "Calculate Compound Interest";
            this.btnCompound.UseVisualStyleBackColor = true;
            this.btnCompound.Click += new System.EventHandler(this.btnCompound_Click);
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 531);
            this.Controls.Add(this.btnCompound);
            this.Controls.Add(this.btnInterest);
            this.Name = "StartUpForm";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInterest;
        private System.Windows.Forms.Button btnCompound;
    }
}

