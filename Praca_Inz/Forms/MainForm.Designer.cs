namespace Praca_Inz
{
    partial class MainForm
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
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_logo2 = new System.Windows.Forms.Label();
            this.label_logo1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconPictureBox_StatusConn = new FontAwesome.Sharp.IconPictureBox();
            this.label_conn_status = new System.Windows.Forms.Label();
            this.iconButton_Settings = new FontAwesome.Sharp.IconButton();
            this.iconButton_Reports = new FontAwesome.Sharp.IconButton();
            this.iconButton_Stats = new FontAwesome.Sharp.IconButton();
            this.iconButton_homepg = new FontAwesome.Sharp.IconButton();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_main = new System.Windows.Forms.Label();
            this.panel_main_window = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_StatusConn)).BeginInit();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel_logo.Controls.Add(this.label1);
            this.panel_logo.Controls.Add(this.label_logo2);
            this.panel_logo.Controls.Add(this.label_logo1);
            this.panel_logo.Controls.Add(this.iconPictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(193, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parkingowy";
            // 
            // label_logo2
            // 
            this.label_logo2.AutoSize = true;
            this.label_logo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_logo2.ForeColor = System.Drawing.Color.White;
            this.label_logo2.Location = new System.Drawing.Point(84, 40);
            this.label_logo2.Name = "label_logo2";
            this.label_logo2.Size = new System.Drawing.Size(65, 21);
            this.label_logo2.TabIndex = 2;
            this.label_logo2.Text = "System";
            // 
            // label_logo1
            // 
            this.label_logo1.AutoSize = true;
            this.label_logo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_logo1.ForeColor = System.Drawing.Color.White;
            this.label_logo1.Location = new System.Drawing.Point(84, 19);
            this.label_logo1.Name = "label_logo1";
            this.label_logo1.Size = new System.Drawing.Size(107, 21);
            this.label_logo1.TabIndex = 1;
            this.label_logo1.Text = "Nowoczesny";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 88;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(90, 88);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_menu.Controls.Add(this.panel4);
            this.panel_menu.Controls.Add(this.iconButton_Settings);
            this.panel_menu.Controls.Add(this.iconButton_Reports);
            this.panel_menu.Controls.Add(this.iconButton_Stats);
            this.panel_menu.Controls.Add(this.iconButton_homepg);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(6);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(193, 595);
            this.panel_menu.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconPictureBox_StatusConn);
            this.panel4.Controls.Add(this.label_conn_status);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 535);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 60);
            this.panel4.TabIndex = 9;
            // 
            // iconPictureBox_StatusConn
            // 
            this.iconPictureBox_StatusConn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox_StatusConn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.iconPictureBox_StatusConn.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox_StatusConn.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.iconPictureBox_StatusConn.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox_StatusConn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_StatusConn.IconSize = 42;
            this.iconPictureBox_StatusConn.Location = new System.Drawing.Point(12, 6);
            this.iconPictureBox_StatusConn.Name = "iconPictureBox_StatusConn";
            this.iconPictureBox_StatusConn.Size = new System.Drawing.Size(48, 42);
            this.iconPictureBox_StatusConn.TabIndex = 7;
            this.iconPictureBox_StatusConn.TabStop = false;
            // 
            // label_conn_status
            // 
            this.label_conn_status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_conn_status.AutoSize = true;
            this.label_conn_status.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_conn_status.ForeColor = System.Drawing.Color.White;
            this.label_conn_status.Location = new System.Drawing.Point(66, 16);
            this.label_conn_status.Name = "label_conn_status";
            this.label_conn_status.Size = new System.Drawing.Size(104, 20);
            this.label_conn_status.TabIndex = 8;
            this.label_conn_status.Text = "Niepołączony";
            // 
            // iconButton_Settings
            // 
            this.iconButton_Settings.BackColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Settings.FlatAppearance.BorderSize = 0;
            this.iconButton_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Settings.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton_Settings.ForeColor = System.Drawing.Color.White;
            this.iconButton_Settings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconButton_Settings.IconColor = System.Drawing.Color.White;
            this.iconButton_Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Settings.Location = new System.Drawing.Point(0, 337);
            this.iconButton_Settings.Name = "iconButton_Settings";
            this.iconButton_Settings.Size = new System.Drawing.Size(193, 79);
            this.iconButton_Settings.TabIndex = 6;
            this.iconButton_Settings.Text = "      Ustawienia";
            this.iconButton_Settings.UseVisualStyleBackColor = false;
            this.iconButton_Settings.Click += new System.EventHandler(this.iconButton_Settings_Click);
            // 
            // iconButton_Reports
            // 
            this.iconButton_Reports.BackColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton_Reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Reports.FlatAppearance.BorderSize = 0;
            this.iconButton_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Reports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton_Reports.ForeColor = System.Drawing.Color.White;
            this.iconButton_Reports.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.iconButton_Reports.IconColor = System.Drawing.Color.White;
            this.iconButton_Reports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Reports.Location = new System.Drawing.Point(0, 258);
            this.iconButton_Reports.Name = "iconButton_Reports";
            this.iconButton_Reports.Size = new System.Drawing.Size(193, 79);
            this.iconButton_Reports.TabIndex = 5;
            this.iconButton_Reports.Text = "Raporty";
            this.iconButton_Reports.UseVisualStyleBackColor = false;
            this.iconButton_Reports.Click += new System.EventHandler(this.iconButton_Reports_Click);
            // 
            // iconButton_Stats
            // 
            this.iconButton_Stats.BackColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton_Stats.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Stats.FlatAppearance.BorderSize = 0;
            this.iconButton_Stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Stats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton_Stats.ForeColor = System.Drawing.Color.White;
            this.iconButton_Stats.IconChar = FontAwesome.Sharp.IconChar.Poll;
            this.iconButton_Stats.IconColor = System.Drawing.Color.White;
            this.iconButton_Stats.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Stats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Stats.Location = new System.Drawing.Point(0, 179);
            this.iconButton_Stats.Name = "iconButton_Stats";
            this.iconButton_Stats.Size = new System.Drawing.Size(193, 79);
            this.iconButton_Stats.TabIndex = 4;
            this.iconButton_Stats.Text = "  Statystyki";
            this.iconButton_Stats.UseVisualStyleBackColor = false;
            this.iconButton_Stats.Click += new System.EventHandler(this.iconButton_Stats_Click);
            // 
            // iconButton_homepg
            // 
            this.iconButton_homepg.BackColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton_homepg.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_homepg.FlatAppearance.BorderSize = 0;
            this.iconButton_homepg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_homepg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton_homepg.ForeColor = System.Drawing.Color.White;
            this.iconButton_homepg.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton_homepg.IconColor = System.Drawing.Color.White;
            this.iconButton_homepg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_homepg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_homepg.Location = new System.Drawing.Point(0, 100);
            this.iconButton_homepg.Name = "iconButton_homepg";
            this.iconButton_homepg.Size = new System.Drawing.Size(193, 79);
            this.iconButton_homepg.TabIndex = 3;
            this.iconButton_homepg.Text = "           Strona Główna";
            this.iconButton_homepg.UseVisualStyleBackColor = false;
            this.iconButton_homepg.Click += new System.EventHandler(this.iconButton_homepg_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_top.Controls.Add(this.label_main);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(193, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(832, 100);
            this.panel_top.TabIndex = 2;
            // 
            // label_main
            // 
            this.label_main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_main.AutoSize = true;
            this.label_main.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_main.ForeColor = System.Drawing.Color.White;
            this.label_main.Location = new System.Drawing.Point(303, 30);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(224, 41);
            this.label_main.TabIndex = 0;
            this.label_main.Text = "Strona Główna";
            // 
            // panel_main_window
            // 
            this.panel_main_window.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel_main_window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main_window.Location = new System.Drawing.Point(193, 100);
            this.panel_main_window.Name = "panel_main_window";
            this.panel_main_window.Size = new System.Drawing.Size(832, 495);
            this.panel_main_window.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(193, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 60);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_main_window);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_StatusConn)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel_menu;
        private Panel panel_logo;
        private Panel panel_top;
        private Label label_main;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Label label_logo2;
        private Label label_logo1;
        private FontAwesome.Sharp.IconButton iconButton_homepg;
        private FontAwesome.Sharp.IconButton iconButton_Settings;
        private FontAwesome.Sharp.IconButton iconButton_Reports;
        private FontAwesome.Sharp.IconButton iconButton_Stats;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_StatusConn;
        private Label label_conn_status;
        private Panel panel4;
        private Panel panel_main_window;
        private Panel panel1;
    }
}