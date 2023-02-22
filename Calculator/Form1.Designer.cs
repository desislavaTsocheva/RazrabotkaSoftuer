namespace Calculator
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
            this.sum_button = new System.Windows.Forms.Button();
            this.sub_button = new System.Windows.Forms.Button();
            this.multy_button = new System.Windows.Forms.Button();
            this.divide_button = new System.Windows.Forms.Button();
            this.power_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sum_button
            // 
            this.sum_button.Location = new System.Drawing.Point(22, 223);
            this.sum_button.Name = "sum_button";
            this.sum_button.Size = new System.Drawing.Size(157, 71);
            this.sum_button.TabIndex = 0;
            this.sum_button.Text = "SUM";
            this.sum_button.UseVisualStyleBackColor = true;
            this.sum_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // sub_button
            // 
            this.sub_button.Location = new System.Drawing.Point(185, 223);
            this.sub_button.Name = "sub_button";
            this.sub_button.Size = new System.Drawing.Size(158, 71);
            this.sub_button.TabIndex = 1;
            this.sub_button.Text = "SUBSTRACT";
            this.sub_button.UseVisualStyleBackColor = true;
            this.sub_button.Click += new System.EventHandler(this.sub_button_Click);
            // 
            // multy_button
            // 
            this.multy_button.Location = new System.Drawing.Point(349, 223);
            this.multy_button.Name = "multy_button";
            this.multy_button.Size = new System.Drawing.Size(158, 71);
            this.multy_button.TabIndex = 2;
            this.multy_button.Text = "MULTIPLAY";
            this.multy_button.UseVisualStyleBackColor = true;
            this.multy_button.Click += new System.EventHandler(this.multy_button_Click);
            // 
            // divide_button
            // 
            this.divide_button.Location = new System.Drawing.Point(61, 336);
            this.divide_button.Name = "divide_button";
            this.divide_button.Size = new System.Drawing.Size(158, 71);
            this.divide_button.TabIndex = 3;
            this.divide_button.Text = "DIVIDE";
            this.divide_button.UseVisualStyleBackColor = true;
            this.divide_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // power_button
            // 
            this.power_button.Location = new System.Drawing.Point(310, 336);
            this.power_button.Name = "power_button";
            this.power_button.Size = new System.Drawing.Size(158, 71);
            this.power_button.TabIndex = 4;
            this.power_button.Text = "POWER";
            this.power_button.UseVisualStyleBackColor = true;
            this.power_button.Click += new System.EventHandler(this.power_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(185, 449);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(158, 71);
            this.clear_button.TabIndex = 5;
            this.clear_button.Text = "CLEAR";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "NUMBER 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "NUMBER 2";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(61, 137);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(159, 50);
            this.txtNum1.TabIndex = 8;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(283, 136);
            this.txtNum2.Multiline = true;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(159, 51);
            this.txtNum2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "ENTER NUMBERS ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 614);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 89);
            this.textBox3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 569);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(519, 753);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.power_button);
            this.Controls.Add(this.divide_button);
            this.Controls.Add(this.multy_button);
            this.Controls.Add(this.sub_button);
            this.Controls.Add(this.sum_button);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sum_button;
        private Button sub_button;
        private Button multy_button;
        private Button divide_button;
        private Button power_button;
        private Button clear_button;
        private Label label1;
        private Label label2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
    }
}