namespace EventMGTNew
{
    partial class NewUser
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
            panel1 = new Panel();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnCreateUser = new Button();
            cmbRole = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnCreateUser);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(23, 448);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 411);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBox5.Location = new Point(728, 197);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(248, 34);
            textBox5.TabIndex = 20;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(29, 51);
            label8.Name = "label8";
            label8.Size = new Size(91, 25);
            label8.TabIndex = 21;
            label8.Text = "User ID";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBox4.Location = new Point(728, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(248, 34);
            textBox4.TabIndex = 19;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBox6.Location = new Point(210, 42);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(248, 34);
            textBox6.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBox3.Location = new Point(210, 197);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 34);
            textBox3.TabIndex = 18;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBox2.Location = new Point(210, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 34);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBox1.Location = new Point(728, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 34);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button4.Location = new Point(823, 342);
            button4.Name = "button4";
            button4.Size = new Size(154, 53);
            button4.TabIndex = 15;
            button4.Text = "Clear Form";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button3.Location = new Point(565, 342);
            button3.Name = "button3";
            button3.Size = new Size(154, 53);
            button3.TabIndex = 14;
            button3.Text = "Delete User";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button2.Location = new Point(315, 342);
            button2.Name = "button2";
            button2.Size = new Size(154, 53);
            button2.TabIndex = 13;
            button2.Text = "Update User";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = Color.Teal;
            btnCreateUser.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateUser.Location = new Point(63, 342);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(154, 53);
            btnCreateUser.TabIndex = 12;
            btnCreateUser.Text = "Add User";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += button1_Click;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = SystemColors.ControlLight;
            cmbRole.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "admin", "organizer", "participant" });
            cmbRole.Location = new Point(210, 273);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(248, 33);
            cmbRole.TabIndex = 11;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label7.Location = new Point(29, 281);
            label7.Name = "label7";
            label7.Size = new Size(57, 25);
            label7.TabIndex = 5;
            label7.Text = "Role";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label6.Location = new Point(547, 199);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 4;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label5.Location = new Point(547, 124);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 3;
            label5.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label4.Location = new Point(29, 206);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 2;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label3.Location = new Point(29, 124);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 1;
            label3.Text = "Email Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(547, 51);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 0;
            label2.Text = "Full Name";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(23, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 394);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 16);
            label1.Name = "label1";
            label1.Size = new Size(191, 42);
            label1.TabIndex = 1;
            label1.Text = "Users Data";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(971, 316);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NewUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NewUser";
            Size = new Size(1079, 877);
            Load += NewUser_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbRole;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnCreateUser;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private TextBox textBox6;
    }
}
