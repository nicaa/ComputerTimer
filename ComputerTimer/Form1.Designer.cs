namespace ComputerTimer
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
            this.SleepBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HourTxt = new System.Windows.Forms.TextBox();
            this.MinTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AbortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SleepBtn
            // 
            this.SleepBtn.Location = new System.Drawing.Point(89, 39);
            this.SleepBtn.Name = "SleepBtn";
            this.SleepBtn.Size = new System.Drawing.Size(46, 23);
            this.SleepBtn.TabIndex = 0;
            this.SleepBtn.Text = "OK";
            this.SleepBtn.UseVisualStyleBackColor = true;
            this.SleepBtn.Click += new System.EventHandler(this.SleepBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Values press OK to shutdown";
            // 
            // HourTxt
            // 
            this.HourTxt.Location = new System.Drawing.Point(7, 39);
            this.HourTxt.Name = "HourTxt";
            this.HourTxt.Size = new System.Drawing.Size(25, 20);
            this.HourTxt.TabIndex = 2;
            // 
            // MinTxt
            // 
            this.MinTxt.Location = new System.Drawing.Point(47, 39);
            this.MinTxt.Name = "MinTxt";
            this.MinTxt.Size = new System.Drawing.Size(25, 20);
            this.MinTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "HH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "MM";
            // 
            // AbortBtn
            // 
            this.AbortBtn.Location = new System.Drawing.Point(158, 39);
            this.AbortBtn.Name = "AbortBtn";
            this.AbortBtn.Size = new System.Drawing.Size(75, 23);
            this.AbortBtn.TabIndex = 6;
            this.AbortBtn.Text = "Abort";
            this.AbortBtn.UseVisualStyleBackColor = true;
            this.AbortBtn.Click += new System.EventHandler(this.AbortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(236, 89);
            this.Controls.Add(this.AbortBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MinTxt);
            this.Controls.Add(this.HourTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SleepBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Computer Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SleepBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HourTxt;
        private System.Windows.Forms.TextBox MinTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AbortBtn;
    }
}

