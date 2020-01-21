namespace AlbertiCipher
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
            this.para = new System.Windows.Forms.TextBox();
            this.en = new System.Windows.Forms.Button();
            this.de = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seed = new System.Windows.Forms.TextBox();
            this.rot = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.TextBox();
            this.test = new System.Windows.Forms.Button();
            this.tbox = new System.Windows.Forms.TextBox();
            this.test2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // para
            // 
            this.para.Location = new System.Drawing.Point(12, 44);
            this.para.Multiline = true;
            this.para.Name = "para";
            this.para.Size = new System.Drawing.Size(441, 179);
            this.para.TabIndex = 0;
            this.para.TabStop = false;
            this.para.TextChanged += new System.EventHandler(this.para_TextChanged);
            this.para.KeyDown += new System.Windows.Forms.KeyEventHandler(this.para_KeyDown);
            // 
            // en
            // 
            this.en.Location = new System.Drawing.Point(471, 22);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(75, 23);
            this.en.TabIndex = 1;
            this.en.TabStop = false;
            this.en.Text = "Encrypt";
            this.en.UseVisualStyleBackColor = true;
            this.en.Click += new System.EventHandler(this.en_Click);
            // 
            // de
            // 
            this.de.Location = new System.Drawing.Point(571, 22);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(75, 23);
            this.de.TabIndex = 1;
            this.de.TabStop = false;
            this.de.Text = "Decrypt";
            this.de.UseVisualStyleBackColor = true;
            this.de.Click += new System.EventHandler(this.de_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ROT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seed";
            // 
            // seed
            // 
            this.seed.Location = new System.Drawing.Point(478, 148);
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(121, 22);
            this.seed.TabIndex = 2;
            // 
            // rot
            // 
            this.rot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rot.FormattingEnabled = true;
            this.rot.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.rot.Location = new System.Drawing.Point(478, 83);
            this.rot.Name = "rot";
            this.rot.Size = new System.Drawing.Size(121, 24);
            this.rot.TabIndex = 1;
            this.rot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rot_KeyDown);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 235);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(441, 179);
            this.result.TabIndex = 0;
            this.result.TabStop = false;
            this.result.KeyDown += new System.Windows.Forms.KeyEventHandler(this.result_KeyDown);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(462, 189);
            this.test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(59, 34);
            this.test.TabIndex = 7;
            this.test.TabStop = false;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            this.test.KeyDown += new System.Windows.Forms.KeyEventHandler(this.test_KeyDown);
            // 
            // tbox
            // 
            this.tbox.Location = new System.Drawing.Point(459, 227);
            this.tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox.Multiline = true;
            this.tbox.Name = "tbox";
            this.tbox.ReadOnly = true;
            this.tbox.Size = new System.Drawing.Size(200, 194);
            this.tbox.TabIndex = 0;
            this.tbox.TabStop = false;
            this.tbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_KeyDown);
            // 
            // test2
            // 
            this.test2.Location = new System.Drawing.Point(526, 189);
            this.test2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(132, 34);
            this.test2.TabIndex = 7;
            this.test2.TabStop = false;
            this.test2.Text = "Test with Seed";
            this.test2.UseVisualStyleBackColor = true;
            this.test2.Click += new System.EventHandler(this.test2_Click);
            this.test2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.test_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 423);
            this.Controls.Add(this.tbox);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.test);
            this.Controls.Add(this.rot);
            this.Controls.Add(this.seed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.de);
            this.Controls.Add(this.en);
            this.Controls.Add(this.result);
            this.Controls.Add(this.para);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Alberti Cipher Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox para;
        private System.Windows.Forms.Button en;
        private System.Windows.Forms.Button de;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seed;
        private System.Windows.Forms.ComboBox rot;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.TextBox tbox;
        private System.Windows.Forms.Button test2;
    }
}

