namespace EventMGTNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.minimize_8;
            pictureBox2.Location = new Point(437, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(34, 36, 49);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            textBox1.ForeColor = Color.DimGray;
            textBox1.Location = new Point(81, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(381, 32);
            textBox1.TabIndex = 6;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources._211652_close_icon;
            pictureBox6.Location = new Point(474, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(200, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(29, 214);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(29, 309);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(34, 36, 49);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            textBox2.ForeColor = Color.DimGray;
            textBox2.Location = new Point(81, 316);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 32);
            textBox2.TabIndex = 16;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(23, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 5);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(29, 354);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 5);
            panel2.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(142, 138);
            label1.Name = "label1";
            label1.Size = new Size(198, 32);
            label1.TabIndex = 19;
            label1.Text = "Ready to Login";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.AppWorkspace;
            checkBox1.Location = new Point(29, 408);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(223, 36);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(273, 408);
            button1.Name = "button1";
            button1.Size = new Size(189, 36);
            button1.TabIndex = 21;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(60, 493);
            button2.Name = "button2";
            button2.Size = new Size(381, 43);
            button2.TabIndex = 22;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(508, 611);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += mouse_Down;
            MouseMove += mouse_Move;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox textBox2;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
    }
}
