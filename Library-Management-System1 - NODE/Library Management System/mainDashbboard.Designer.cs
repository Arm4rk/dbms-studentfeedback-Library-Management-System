namespace Library_Management_System
{
    partial class mainDashbboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Panel panelDividerAccent;
        private System.Windows.Forms.Panel panelBadge;
        private System.Windows.Forms.Panel panelGrid;

        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblSystemSubtitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblPageSub;
        private System.Windows.Forms.Label lblBadgeText;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.lblSystemSubtitle = new System.Windows.Forms.Label();
            this.panelDividerAccent = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.lblPageSub = new System.Windows.Forms.Label();
            this.panelBadge = new System.Windows.Forms.Panel();
            this.lblBadgeText = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.panelBadge.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMain.Controls.Add(this.lblSystemTitle);
            this.panelMain.Controls.Add(this.lblSystemSubtitle);
            this.panelMain.Controls.Add(this.panelDividerAccent);
            this.panelMain.Controls.Add(this.panelCard);
            this.panelMain.Controls.Add(this.lblVersion);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(960, 620);
            this.panelMain.TabIndex = 0;
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblSystemTitle.ForeColor = System.Drawing.Color.White;
            this.lblSystemTitle.Location = new System.Drawing.Point(0, 30);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(960, 50);
            this.lblSystemTitle.TabIndex = 0;
            this.lblSystemTitle.Text = "LIBRARY MANAGEMENT SYSTEM";
            this.lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSystemSubtitle
            // 
            this.lblSystemSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSystemSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSystemSubtitle.Location = new System.Drawing.Point(0, 83);
            this.lblSystemSubtitle.Name = "lblSystemSubtitle";
            this.lblSystemSubtitle.Size = new System.Drawing.Size(960, 25);
            this.lblSystemSubtitle.TabIndex = 1;
            this.lblSystemSubtitle.Text = "Manage books, issue records, returns, and account access.";
            this.lblSystemSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDividerAccent
            // 
            this.panelDividerAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.panelDividerAccent.Location = new System.Drawing.Point(405, 118);
            this.panelDividerAccent.Name = "panelDividerAccent";
            this.panelDividerAccent.Size = new System.Drawing.Size(150, 4);
            this.panelDividerAccent.TabIndex = 2;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelCard.Controls.Add(this.labelTitle);
            this.panelCard.Controls.Add(this.lblPageSub);
            this.panelCard.Controls.Add(this.panelBadge);
            this.panelCard.Controls.Add(this.panelGrid);
            this.panelCard.Location = new System.Drawing.Point(190, 155);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(580, 360);
            this.panelCard.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.labelTitle.Location = new System.Drawing.Point(40, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(500, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Admin Dashboard";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPageSub
            // 
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPageSub.Location = new System.Drawing.Point(40, 70);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(500, 25);
            this.lblPageSub.TabIndex = 1;
            this.lblPageSub.Text = "Select an action from the dashboard below.";
            this.lblPageSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBadge
            // 
            this.panelBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelBadge.Controls.Add(this.lblBadgeText);
            this.panelBadge.Location = new System.Drawing.Point(220, 105);
            this.panelBadge.Name = "panelBadge";
            this.panelBadge.Size = new System.Drawing.Size(140, 28);
            this.panelBadge.TabIndex = 2;
            // 
            // lblBadgeText
            // 
            this.lblBadgeText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBadgeText.ForeColor = System.Drawing.Color.White;
            this.lblBadgeText.Location = new System.Drawing.Point(0, 0);
            this.lblBadgeText.Name = "lblBadgeText";
            this.lblBadgeText.Size = new System.Drawing.Size(140, 28);
            this.lblBadgeText.TabIndex = 0;
            this.lblBadgeText.Text = "DASHBOARD";
            this.lblBadgeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelGrid.Controls.Add(this.button1);
            this.panelGrid.Controls.Add(this.button3);
            this.panelGrid.Controls.Add(this.button4);
            this.panelGrid.Controls.Add(this.button6);
            this.panelGrid.Controls.Add(this.button9);
            this.panelGrid.Location = new System.Drawing.Point(65, 160);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(450, 165);
            this.panelGrid.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(155, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 48);
            this.button3.TabIndex = 1;
            this.button3.Text = "Issue Book";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(310, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 48);
            this.button4.TabIndex = 2;
            this.button4.Text = "View FeedBack";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(75, 80);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 48);
            this.button6.TabIndex = 3;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(235, 80);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 48);
            this.button9.TabIndex = 4;
            this.button9.Text = "Logout";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblVersion.Location = new System.Drawing.Point(0, 585);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(960, 22);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "v2.0.0 | Admin Console";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainDashbboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainDashbboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Dashboard";
            this.Load += new System.EventHandler(this.mainDashbboard_Load);
            this.panelMain.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.panelBadge.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}