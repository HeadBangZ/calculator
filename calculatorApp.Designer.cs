namespace CalculatorApp
{
    partial class CalculatorApp
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
			this.resultBox = new System.Windows.Forms.TextBox();
			this.num1 = new System.Windows.Forms.Button();
			this.num2 = new System.Windows.Forms.Button();
			this.num3 = new System.Windows.Forms.Button();
			this.num4 = new System.Windows.Forms.Button();
			this.num5 = new System.Windows.Forms.Button();
			this.num6 = new System.Windows.Forms.Button();
			this.num7 = new System.Windows.Forms.Button();
			this.num8 = new System.Windows.Forms.Button();
			this.num9 = new System.Windows.Forms.Button();
			this.num0 = new System.Windows.Forms.Button();
			this.resultField = new System.Windows.Forms.Label();
			this.add = new System.Windows.Forms.Button();
			this.minus = new System.Windows.Forms.Button();
			this.division = new System.Windows.Forms.Button();
			this.multiplication = new System.Windows.Forms.Button();
			this.numC = new System.Windows.Forms.Button();
			this.numDot = new System.Windows.Forms.Button();
			this.equalBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// resultBox
			// 
			this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultBox.Location = new System.Drawing.Point(4, 62);
			this.resultBox.Multiline = true;
			this.resultBox.Name = "resultBox";
			this.resultBox.Size = new System.Drawing.Size(378, 76);
			this.resultBox.TabIndex = 0;
			this.resultBox.Text = "0";
			this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// num1
			// 
			this.num1.BackColor = System.Drawing.SystemColors.Highlight;
			this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num1.Location = new System.Drawing.Point(4, 146);
			this.num1.Name = "num1";
			this.num1.Size = new System.Drawing.Size(90, 90);
			this.num1.TabIndex = 1;
			this.num1.Text = "1";
			this.num1.UseVisualStyleBackColor = false;
			this.num1.Click += new System.EventHandler(this.numberBtn);
			// 
			// num2
			// 
			this.num2.BackColor = System.Drawing.SystemColors.Highlight;
			this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num2.Location = new System.Drawing.Point(100, 146);
			this.num2.Name = "num2";
			this.num2.Size = new System.Drawing.Size(90, 90);
			this.num2.TabIndex = 2;
			this.num2.Text = "2";
			this.num2.UseVisualStyleBackColor = false;
			this.num2.Click += new System.EventHandler(this.numberBtn);
			// 
			// num3
			// 
			this.num3.BackColor = System.Drawing.SystemColors.Highlight;
			this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num3.Location = new System.Drawing.Point(196, 146);
			this.num3.Name = "num3";
			this.num3.Size = new System.Drawing.Size(90, 90);
			this.num3.TabIndex = 3;
			this.num3.Text = "3";
			this.num3.UseVisualStyleBackColor = false;
			this.num3.Click += new System.EventHandler(this.numberBtn);
			// 
			// num4
			// 
			this.num4.BackColor = System.Drawing.SystemColors.Highlight;
			this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num4.Location = new System.Drawing.Point(4, 242);
			this.num4.Name = "num4";
			this.num4.Size = new System.Drawing.Size(90, 90);
			this.num4.TabIndex = 4;
			this.num4.Text = "4";
			this.num4.UseVisualStyleBackColor = false;
			this.num4.Click += new System.EventHandler(this.numberBtn);
			// 
			// num5
			// 
			this.num5.BackColor = System.Drawing.SystemColors.Highlight;
			this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num5.Location = new System.Drawing.Point(100, 242);
			this.num5.Name = "num5";
			this.num5.Size = new System.Drawing.Size(90, 90);
			this.num5.TabIndex = 5;
			this.num5.Text = "5";
			this.num5.UseVisualStyleBackColor = false;
			this.num5.Click += new System.EventHandler(this.numberBtn);
			// 
			// num6
			// 
			this.num6.BackColor = System.Drawing.SystemColors.Highlight;
			this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num6.Location = new System.Drawing.Point(196, 242);
			this.num6.Name = "num6";
			this.num6.Size = new System.Drawing.Size(90, 90);
			this.num6.TabIndex = 6;
			this.num6.Text = "6";
			this.num6.UseVisualStyleBackColor = false;
			this.num6.Click += new System.EventHandler(this.numberBtn);
			// 
			// num7
			// 
			this.num7.BackColor = System.Drawing.SystemColors.Highlight;
			this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num7.Location = new System.Drawing.Point(4, 338);
			this.num7.Name = "num7";
			this.num7.Size = new System.Drawing.Size(90, 90);
			this.num7.TabIndex = 7;
			this.num7.Text = "7";
			this.num7.UseVisualStyleBackColor = false;
			this.num7.Click += new System.EventHandler(this.numberBtn);
			// 
			// num8
			// 
			this.num8.BackColor = System.Drawing.SystemColors.Highlight;
			this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num8.Location = new System.Drawing.Point(100, 338);
			this.num8.Name = "num8";
			this.num8.Size = new System.Drawing.Size(90, 90);
			this.num8.TabIndex = 8;
			this.num8.Text = "8";
			this.num8.UseVisualStyleBackColor = false;
			this.num8.Click += new System.EventHandler(this.numberBtn);
			// 
			// num9
			// 
			this.num9.BackColor = System.Drawing.SystemColors.Highlight;
			this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num9.Location = new System.Drawing.Point(196, 338);
			this.num9.Name = "num9";
			this.num9.Size = new System.Drawing.Size(90, 90);
			this.num9.TabIndex = 9;
			this.num9.Text = "9";
			this.num9.UseVisualStyleBackColor = false;
			this.num9.Click += new System.EventHandler(this.numberBtn);
			// 
			// num0
			// 
			this.num0.BackColor = System.Drawing.SystemColors.Highlight;
			this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num0.Location = new System.Drawing.Point(100, 434);
			this.num0.Name = "num0";
			this.num0.Size = new System.Drawing.Size(90, 90);
			this.num0.TabIndex = 10;
			this.num0.Text = "0";
			this.num0.UseVisualStyleBackColor = false;
			this.num0.Click += new System.EventHandler(this.numberBtn);
			// 
			// resultField
			// 
			this.resultField.AutoSize = true;
			this.resultField.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultField.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.resultField.Location = new System.Drawing.Point(4, 13);
			this.resultField.Name = "resultField";
			this.resultField.Size = new System.Drawing.Size(0, 42);
			this.resultField.TabIndex = 11;
			// 
			// add
			// 
			this.add.BackColor = System.Drawing.SystemColors.Highlight;
			this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add.Location = new System.Drawing.Point(292, 146);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(90, 90);
			this.add.TabIndex = 12;
			this.add.Text = "+";
			this.add.UseVisualStyleBackColor = false;
			this.add.Click += new System.EventHandler(this.operatorBtn);
			// 
			// minus
			// 
			this.minus.BackColor = System.Drawing.SystemColors.Highlight;
			this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minus.Location = new System.Drawing.Point(292, 242);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(90, 90);
			this.minus.TabIndex = 13;
			this.minus.Text = "-";
			this.minus.UseVisualStyleBackColor = false;
			this.minus.Click += new System.EventHandler(this.operatorBtn);
			// 
			// division
			// 
			this.division.BackColor = System.Drawing.SystemColors.Highlight;
			this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.division.Location = new System.Drawing.Point(292, 338);
			this.division.Name = "division";
			this.division.Size = new System.Drawing.Size(90, 90);
			this.division.TabIndex = 14;
			this.division.Text = "/";
			this.division.UseVisualStyleBackColor = false;
			this.division.Click += new System.EventHandler(this.operatorBtn);
			// 
			// multiplication
			// 
			this.multiplication.BackColor = System.Drawing.SystemColors.Highlight;
			this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.multiplication.Location = new System.Drawing.Point(292, 434);
			this.multiplication.Name = "multiplication";
			this.multiplication.Size = new System.Drawing.Size(90, 90);
			this.multiplication.TabIndex = 15;
			this.multiplication.Text = "*";
			this.multiplication.UseVisualStyleBackColor = false;
			this.multiplication.Click += new System.EventHandler(this.operatorBtn);
			// 
			// numC
			// 
			this.numC.BackColor = System.Drawing.SystemColors.Highlight;
			this.numC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numC.Location = new System.Drawing.Point(196, 434);
			this.numC.Name = "numC";
			this.numC.Size = new System.Drawing.Size(90, 90);
			this.numC.TabIndex = 16;
			this.numC.Text = "C";
			this.numC.UseVisualStyleBackColor = false;
			this.numC.Click += new System.EventHandler(this.numC_Click);
			// 
			// numDot
			// 
			this.numDot.BackColor = System.Drawing.SystemColors.Highlight;
			this.numDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numDot.Location = new System.Drawing.Point(4, 434);
			this.numDot.Name = "numDot";
			this.numDot.Size = new System.Drawing.Size(90, 90);
			this.numDot.TabIndex = 17;
			this.numDot.Text = ".";
			this.numDot.UseVisualStyleBackColor = false;
			this.numDot.Click += new System.EventHandler(this.numberBtn);
			// 
			// equalBtn
			// 
			this.equalBtn.BackColor = System.Drawing.SystemColors.Highlight;
			this.equalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equalBtn.Location = new System.Drawing.Point(4, 530);
			this.equalBtn.Name = "equalBtn";
			this.equalBtn.Size = new System.Drawing.Size(378, 90);
			this.equalBtn.TabIndex = 18;
			this.equalBtn.Text = "=";
			this.equalBtn.UseVisualStyleBackColor = false;
			this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
			// 
			// CalculatorApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 629);
			this.Controls.Add(this.equalBtn);
			this.Controls.Add(this.numDot);
			this.Controls.Add(this.numC);
			this.Controls.Add(this.multiplication);
			this.Controls.Add(this.division);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.add);
			this.Controls.Add(this.resultField);
			this.Controls.Add(this.num0);
			this.Controls.Add(this.num9);
			this.Controls.Add(this.num8);
			this.Controls.Add(this.num7);
			this.Controls.Add(this.num6);
			this.Controls.Add(this.num5);
			this.Controls.Add(this.num4);
			this.Controls.Add(this.num3);
			this.Controls.Add(this.num2);
			this.Controls.Add(this.num1);
			this.Controls.Add(this.resultBox);
			this.Name = "CalculatorApp";
			this.Text = "CalculatorApp";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Label resultField;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button numC;
        private System.Windows.Forms.Button numDot;
        private System.Windows.Forms.Button equalBtn;
    }
}

