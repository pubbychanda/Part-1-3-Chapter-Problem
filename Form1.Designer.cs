
namespace Part_3___Chapter_Problem
{
    partial class BasicInput
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.txtHeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.Location = new System.Drawing.Point(112, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(289, 28);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "This App Will Compare Your height to the tallest person in the world, and predict" +
    " your life expectancy.";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 95);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(94, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age(whole years): ";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(25, 69);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(81, 13);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Height(metres): ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name(first): ";
            // 
            // lblResults
            // 
            this.lblResults.Location = new System.Drawing.Point(12, 125);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(289, 82);
            this.lblResults.TabIndex = 7;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(226, 89);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 8;
            this.btnInput.Text = "Get Results!";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(112, 92);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(38, 20);
            this.numAge.TabIndex = 9;
            this.numAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHeight
            // 
            this.txtHeight.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtHeight.Location = new System.Drawing.Point(112, 66);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 10;
            // 
            // BasicInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 216);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtName);
            this.Name = "BasicInput";
            this.Text = "Life Expectancy";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox txtHeight;
    }
}

