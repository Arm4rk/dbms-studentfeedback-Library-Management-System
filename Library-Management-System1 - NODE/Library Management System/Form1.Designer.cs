namespace Library_Management_System
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Panel panelDivider;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblSystemSubtitle;
        private System.Windows.Forms.Label lblWelcomeHead;
        private System.Windows.Forms.Label lblWelcomeSub;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblVersion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.lblSystemSubtitle = new System.Windows.Forms.Label();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblWelcomeHead = new System.Windows.Forms.Label();
            this.lblWelcomeSub = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(45, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "USER LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(210, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMain.Controls.Add(this.lblSystemTitle);
            this.panelMain.Controls.Add(this.lblSystemSubtitle);
            this.panelMain.Controls.Add(this.panelDivider);
            this.panelMain.Controls.Add(this.panelCard);
            this.panelMain.Controls.Add(this.lblFooter);
            this.panelMain.Controls.Add(this.lblVersion);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 560);
            this.panelMain.TabIndex = 0;
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblSystemTitle.ForeColor = System.Drawing.Color.White;
            this.lblSystemTitle.Location = new System.Drawing.Point(0, 35);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(900, 50);
            this.lblSystemTitle.TabIndex = 0;
            this.lblSystemTitle.Text = "LIBRARY MANAGEMENT SYSTEM";
            this.lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSystemSubtitle
            // 
            this.lblSystemSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSystemSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSystemSubtitle.Location = new System.Drawing.Point(0, 88);
            this.lblSystemSubtitle.Name = "lblSystemSubtitle";
            this.lblSystemSubtitle.Size = new System.Drawing.Size(900, 25);
            this.lblSystemSubtitle.TabIndex = 1;
            this.lblSystemSubtitle.Text = "Manage books, members, employees, and transactions in one system.";
            this.lblSystemSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDivider
            // 
            this.panelDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.panelDivider.Location = new System.Drawing.Point(375, 122);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(150, 4);
            this.panelDivider.TabIndex = 2;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelCard.Controls.Add(this.label1);
            this.panelCard.Controls.Add(this.lblWelcomeHead);
            this.panelCard.Controls.Add(this.lblWelcomeSub);
            this.panelCard.Controls.Add(this.lblInstruction);
            this.panelCard.Controls.Add(this.button1);
            this.panelCard.Controls.Add(this.button3);
            this.panelCard.Location = new System.Drawing.Point(250, 155);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(400, 310);
            this.panelCard.TabIndex = 3;
            // 
            // lblWelcomeHead
            // 
            this.lblWelcomeHead.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcomeHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblWelcomeHead.Location = new System.Drawing.Point(30, 76);
            this.lblWelcomeHead.Name = "lblWelcomeHead";
            this.lblWelcomeHead.Size = new System.Drawing.Size(340, 24);
            this.lblWelcomeHead.TabIndex = 1;
            this.lblWelcomeHead.Text = "Your digital reading companion.";
            this.lblWelcomeHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcomeSub
            // 
            this.lblWelcomeSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWelcomeSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblWelcomeSub.Location = new System.Drawing.Point(40, 110);
            this.lblWelcomeSub.Name = "lblWelcomeSub";
            this.lblWelcomeSub.Size = new System.Drawing.Size(320, 45);
            this.lblWelcomeSub.TabIndex = 2;
            this.lblWelcomeSub.Text = "Access your library dashboard and manage records from one place.";
            this.lblWelcomeSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblInstruction.Location = new System.Drawing.Point(45, 175);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(310, 20);
            this.lblInstruction.TabIndex = 3;
            this.lblInstruction.Text = "SELECT AN OPTION TO CONTINUE";
            this.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFooter
            // 
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFooter.Location = new System.Drawing.Point(0, 500);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(900, 22);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "Secure and simple library management access.";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblVersion.Location = new System.Drawing.Point(0, 525);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(900, 22);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "v2.0.0 | Welcome";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}