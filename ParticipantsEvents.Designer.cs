namespace EventMGTNew
{
    partial class ParticipantsEvents
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            textBox7 = new TextBox();
            label8 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 348);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(21, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(999, 280);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 6);
            label1.Name = "label1";
            label1.Size = new Size(304, 45);
            label1.TabIndex = 0;
            label1.Text = "Available Events";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(15, 407);
            panel2.Name = "panel2";
            panel2.Size = new Size(1046, 438);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.ControlLightLight;
            dateTimePicker1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(729, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 34);
            dateTimePicker1.TabIndex = 24;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ControlLight;
            textBox7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(199, 223);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(250, 34);
            textBox7.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 223);
            label8.Name = "label8";
            label8.Size = new Size(172, 30);
            label8.TabIndex = 22;
            label8.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(492, 227);
            label5.Name = "label5";
            label5.Size = new Size(158, 30);
            label5.TabIndex = 3;
            label5.Text = "Booking Date";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ControlLight;
            textBox5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(729, 129);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 34);
            textBox5.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLight;
            textBox3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(199, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 34);
            textBox3.TabIndex = 18;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button4.Location = new Point(573, 358);
            button4.Name = "button4";
            button4.Size = new Size(319, 51);
            button4.TabIndex = 17;
            button4.Text = "Clear Form";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Teal;
            button5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(201, 358);
            button5.Name = "button5";
            button5.Size = new Size(319, 51);
            button5.TabIndex = 14;
            button5.Text = "Register to Event";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ControlLight;
            textBox4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBox4.Location = new Point(729, 35);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 34);
            textBox4.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(199, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 34);
            textBox1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(492, 134);
            label6.Name = "label6";
            label6.Size = new Size(166, 30);
            label6.TabIndex = 4;
            label6.Text = "Email Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 129);
            label4.Name = "label4";
            label4.Size = new Size(126, 30);
            label4.TabIndex = 2;
            label4.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(492, 40);
            label3.Name = "label3";
            label3.Size = new Size(154, 32);
            label3.TabIndex = 1;
            label3.Text = "Event Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(21, 33);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 0;
            label2.Text = "Event ID";
            // 
            // ParticipantsEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ParticipantsEvents";
            Size = new Size(1079, 877);
            Load += ParticipantsEvents_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox textBox5;
        private TextBox textBox3;
        private Button button4;
        private Button button5;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
    }
}
