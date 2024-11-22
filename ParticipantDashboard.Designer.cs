namespace EventMGTNew
{
    partial class ParticipantDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticipantDashboard));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ham_btn = new PictureBox();
            sidebar = new FlowLayoutPanel();
            pnHome = new Panel();
            button1 = new Button();
            pnEvents = new Panel();
            button2 = new Button();
            pnBookings = new Panel();
            button4 = new Button();
            pnLogout = new Panel();
            button6 = new Button();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            participantRegistrations1 = new ParticipantRegistrations();
            participantsEvents1 = new ParticipantsEvents();
            dashboard1 = new Dashboard();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ham_btn).BeginInit();
            sidebar.SuspendLayout();
            pnHome.SuspendLayout();
            pnEvents.SuspendLayout();
            pnBookings.SuspendLayout();
            pnLogout.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(ham_btn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1335, 66);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += mouse_Down;
            panel1.MouseMove += mouse_Move;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 7);
            label1.Name = "label1";
            label1.Size = new Size(458, 52);
            label1.TabIndex = 12;
            label1.Text = "Organizer Dashboard ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.minimize_81;
            pictureBox2.Location = new Point(1237, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._211652_close_icon1;
            pictureBox3.Location = new Point(1289, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // ham_btn
            // 
            ham_btn.Image = Properties.Resources.more;
            ham_btn.Location = new Point(12, 7);
            ham_btn.Name = "ham_btn";
            ham_btn.Size = new Size(53, 51);
            ham_btn.SizeMode = PictureBoxSizeMode.StretchImage;
            ham_btn.TabIndex = 11;
            ham_btn.TabStop = false;
            ham_btn.Click += ham_btn_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.ActiveCaptionText;
            sidebar.Controls.Add(pnHome);
            sidebar.Controls.Add(pnEvents);
            sidebar.Controls.Add(pnBookings);
            sidebar.Controls.Add(pnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 66);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(252, 881);
            sidebar.TabIndex = 1;
            sidebar.Paint += sidebar_Paint;
            // 
            // pnHome
            // 
            pnHome.Controls.Add(button1);
            pnHome.Location = new Point(3, 3);
            pnHome.Name = "pnHome";
            pnHome.Size = new Size(247, 88);
            pnHome.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, -5);
            button1.Name = "button1";
            button1.Size = new Size(247, 100);
            button1.TabIndex = 3;
            button1.Text = "     Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnEvents
            // 
            pnEvents.Controls.Add(button2);
            pnEvents.Location = new Point(3, 97);
            pnEvents.Name = "pnEvents";
            pnEvents.Size = new Size(247, 88);
            pnEvents.TabIndex = 20;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, -5);
            button2.Name = "button2";
            button2.Size = new Size(247, 100);
            button2.TabIndex = 3;
            button2.Text = "      Events";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pnBookings
            // 
            pnBookings.Controls.Add(button4);
            pnBookings.Location = new Point(3, 191);
            pnBookings.Name = "pnBookings";
            pnBookings.Size = new Size(247, 88);
            pnBookings.TabIndex = 22;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, -5);
            button4.Name = "button4";
            button4.Size = new Size(247, 100);
            button4.TabIndex = 3;
            button4.Text = "     Registrations";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pnLogout
            // 
            pnLogout.Controls.Add(button6);
            pnLogout.Location = new Point(3, 285);
            pnLogout.Name = "pnLogout";
            pnLogout.Size = new Size(247, 88);
            pnLogout.TabIndex = 23;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, -5);
            button6.Name = "button6";
            button6.Size = new Size(247, 100);
            button6.TabIndex = 3;
            button6.Text = "     Log-Out";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // SidebarTimer
            // 
            SidebarTimer.Interval = 10;
            SidebarTimer.Tick += SidebarTimer_Tick;
            // 
            // participantRegistrations1
            // 
            participantRegistrations1.BackColor = Color.FromArgb(34, 36, 49);
            participantRegistrations1.Dock = DockStyle.Fill;
            participantRegistrations1.Location = new Point(252, 66);
            participantRegistrations1.Name = "participantRegistrations1";
            participantRegistrations1.Size = new Size(1083, 881);
            participantRegistrations1.TabIndex = 2;
            participantRegistrations1.Load += participantRegistrations1_Load;
            // 
            // participantsEvents1
            // 
            participantsEvents1.BackColor = Color.FromArgb(34, 36, 49);
            participantsEvents1.Dock = DockStyle.Fill;
            participantsEvents1.Location = new Point(252, 66);
            participantsEvents1.Name = "participantsEvents1";
            participantsEvents1.Size = new Size(1083, 881);
            participantsEvents1.TabIndex = 3;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = Color.FromArgb(34, 36, 49);
            dashboard1.Dock = DockStyle.Fill;
            dashboard1.Location = new Point(252, 66);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1083, 881);
            dashboard1.TabIndex = 4;
            dashboard1.Load += dashboard1_Load;
            // 
            // ParticipantDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(1335, 947);
            Controls.Add(dashboard1);
            Controls.Add(participantsEvents1);
            Controls.Add(participantRegistrations1);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ParticipantDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParticipantDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ham_btn).EndInit();
            sidebar.ResumeLayout(false);
            pnHome.ResumeLayout(false);
            pnEvents.ResumeLayout(false);
            pnBookings.ResumeLayout(false);
            pnLogout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel sidebar;
        private Panel pnHome;
        private Button button1;
        private Panel pnEvents;
        private Button button2;
        private Panel pnBookings;
        private Button button4;
        private Panel pnLogout;
        private Button button6;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox ham_btn;
        private System.Windows.Forms.Timer SidebarTimer;
        private ParticipantRegistrations participantRegistrations1;
        private ParticipantsEvents participantsEvents1;
        private Dashboard dashboard1;
    }
}