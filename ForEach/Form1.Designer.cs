namespace ForEach
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
            this.PnlControls = new System.Windows.Forms.Panel();
            this.BtnRandomNumbers = new System.Windows.Forms.Button();
            this.BtnAddControls = new System.Windows.Forms.Button();
            this.TxtCount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtLogs = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.PnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlControls
            // 
            this.PnlControls.AutoScroll = true;
            this.PnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlControls.Controls.Add(this.progressBar2);
            this.PnlControls.Controls.Add(this.progressBar1);
            this.PnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlControls.Location = new System.Drawing.Point(0, 0);
            this.PnlControls.Name = "PnlControls";
            this.PnlControls.Size = new System.Drawing.Size(887, 939);
            this.PnlControls.TabIndex = 0;
            // 
            // BtnRandomNumbers
            // 
            this.BtnRandomNumbers.Location = new System.Drawing.Point(938, 198);
            this.BtnRandomNumbers.Name = "BtnRandomNumbers";
            this.BtnRandomNumbers.Size = new System.Drawing.Size(298, 84);
            this.BtnRandomNumbers.TabIndex = 1;
            this.BtnRandomNumbers.Text = "BtnRandomNumbers";
            this.BtnRandomNumbers.UseVisualStyleBackColor = true;
            this.BtnRandomNumbers.Click += new System.EventHandler(this.BtnRandomNumbers_Click);
            // 
            // BtnAddControls
            // 
            this.BtnAddControls.Location = new System.Drawing.Point(938, 108);
            this.BtnAddControls.Name = "BtnAddControls";
            this.BtnAddControls.Size = new System.Drawing.Size(298, 84);
            this.BtnAddControls.TabIndex = 2;
            this.BtnAddControls.Text = "BtnAddControls";
            this.BtnAddControls.UseVisualStyleBackColor = true;
            this.BtnAddControls.Click += new System.EventHandler(this.BtnAddControls_Click);
            // 
            // TxtCount
            // 
            this.TxtCount.Location = new System.Drawing.Point(938, 57);
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.Size = new System.Drawing.Size(298, 38);
            this.TxtCount.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(938, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 96);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(938, 678);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 125);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtLogs
            // 
            this.TxtLogs.Location = new System.Drawing.Point(1262, 213);
            this.TxtLogs.Multiline = true;
            this.TxtLogs.Name = "TxtLogs";
            this.TxtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLogs.Size = new System.Drawing.Size(510, 632);
            this.TxtLogs.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(938, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(298, 100);
            this.button3.TabIndex = 6;
            this.button3.Text = "Start Thread";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(938, 560);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(298, 112);
            this.button4.TabIndex = 7;
            this.button4.Text = "Stop Thread";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 884);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(885, 53);
            this.progressBar1.TabIndex = 7;
            // 
            // progressBar2
            // 
            this.progressBar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar2.Location = new System.Drawing.Point(0, 831);
            this.progressBar2.Maximum = 2000;
            this.progressBar2.Minimum = 1001;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(885, 53);
            this.progressBar2.TabIndex = 8;
            this.progressBar2.Value = 1001;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 939);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TxtLogs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtCount);
            this.Controls.Add(this.BtnAddControls);
            this.Controls.Add(this.BtnRandomNumbers);
            this.Controls.Add(this.PnlControls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PnlControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlControls;
        private System.Windows.Forms.Button BtnRandomNumbers;
        private System.Windows.Forms.Button BtnAddControls;
        private System.Windows.Forms.TextBox TxtCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtLogs;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

