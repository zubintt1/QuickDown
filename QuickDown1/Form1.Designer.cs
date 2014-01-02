namespace QuickDown1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.btn_y1 = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkbx1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.OliveDrab;
            this.btn_search.Location = new System.Drawing.Point(576, 36);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(81, 30);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(125, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 30);
            this.textBox1.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(6, 41);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(104, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Video Link";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_n1);
            this.groupBox2.Controls.Add(this.btn_y1);
            this.groupBox2.Controls.Add(this.lbl4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.lbl3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.lbl2);
            this.groupBox2.Location = new System.Drawing.Point(0, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // btn_n1
            // 
            this.btn_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n1.ForeColor = System.Drawing.Color.Red;
            this.btn_n1.Location = new System.Drawing.Point(518, 137);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(75, 31);
            this.btn_n1.TabIndex = 6;
            this.btn_n1.Text = "No";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Visible = false;
            // 
            // btn_y1
            // 
            this.btn_y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_y1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_y1.Location = new System.Drawing.Point(211, 137);
            this.btn_y1.Name = "btn_y1";
            this.btn_y1.Size = new System.Drawing.Size(75, 31);
            this.btn_y1.TabIndex = 5;
            this.btn_y1.Text = "Yes";
            this.btn_y1.UseVisualStyleBackColor = true;
            this.btn_y1.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(571, 82);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(58, 25);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "MB ?";
            this.lbl4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(445, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 3;
            this.textBox3.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(12, 82);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(438, 25);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Do you want to download the entire series of size ";
            this.lbl3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(371, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 27);
            this.textBox2.TabIndex = 1;
            this.textBox2.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(6, 26);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(319, 25);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Total number of videos in the series";
            this.lbl2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl5);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Location = new System.Drawing.Point(0, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(716, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl5.Location = new System.Drawing.Point(324, 84);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(83, 31);
            this.lbl5.TabIndex = 1;
            this.lbl5.Text = "Done";
            this.lbl5.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(82, 40);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(547, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBar2);
            this.groupBox4.Location = new System.Drawing.Point(0, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(716, 88);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(82, 36);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(547, 23);
            this.progressBar2.TabIndex = 0;
            this.progressBar2.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkbx1);
            this.groupBox5.Location = new System.Drawing.Point(722, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(446, 571);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // chkbx1
            // 
            this.chkbx1.BackColor = System.Drawing.SystemColors.MenuText;
            this.chkbx1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkbx1.FormattingEnabled = true;
            this.chkbx1.Location = new System.Drawing.Point(3, 16);
            this.chkbx1.Name = "chkbx1";
            this.chkbx1.Size = new System.Drawing.Size(437, 559);
            this.chkbx1.Sorted = true;
            this.chkbx1.TabIndex = 0;
            this.chkbx1.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(0, 526);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(716, 47);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Made by Zubin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 578);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.Button btn_y1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox chkbx1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

