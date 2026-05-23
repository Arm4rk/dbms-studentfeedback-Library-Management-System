using System;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class mainDashbboard : Form
    {
        public string UserRole { get; private set; }
        public string AuthToken { get; private set; }

        // ================= DEFAULT CONSTRUCTOR =================
        public mainDashbboard()
        {
            InitializeComponent();
        }

        // ================= LOGIN CONSTRUCTOR =================
        public mainDashbboard(string role, string token)
        {
            InitializeComponent();
            UserRole = role;
            AuthToken = token;
            this.Text = $"Dashboard — {role}";
        }

        // ================= LOAD =================
        private void mainDashbboard_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UserRole))
            {
                if (UserRole != "Admin")
                {
                    button1.Enabled = false;
                }
            }
        }

        // ================= ADD BOOK =================
        private void button1_Click(object sender, EventArgs e)
        {
            new addBook().Show();
            this.Hide();
        }

        // ================= ISSUE BOOK =================
        private void button3_Click(object sender, EventArgs e)
        {
            new issueBook().Show();
            this.Hide();
        }

        // ================= RETURN BOOK / FORM 3 =================
        private void button4_Click(object sender, EventArgs e)
        {
            new FeedbackDetails().Show();
            this.Hide();
        }

        // ================= EXIT =================
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ================= LOGOUT =================
        private void button9_Click_1(object sender, EventArgs e)
        {
            new UserLogin().Show();
            this.Hide();
        }
    }
}