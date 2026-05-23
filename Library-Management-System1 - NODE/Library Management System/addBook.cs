using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Library_Management_System
{
    public partial class addBook : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string API = "http://localhost:3000";

        public addBook()
        {
            InitializeComponent();
        }

        // =========================
        // ADD BOOK
        // =========================
        private async void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text.Trim();  // BOOK NAME
            string isbn = textBox2.Text.Trim();  // ISBN NO
            string author = textBox3.Text.Trim();  // AUTHOR
            string edition = textBox5.Text.Trim();  // EDITION
            string description = richTextBox1.Text.Trim(); // DESCRIPTION
            string publishedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Book Name and ISBN are required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var payload = new
            {
                title,
                isbn,
                author,
                genre = edition,   // maps "edition" → "genre" column in your DB
                description,
                publishedDate,
                quantity = 1
            };

            try
            {
                button1.Enabled = false;
                button1.Text = "Saving...";

                var json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync($"{API}/books", content);
                var body = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<dynamic>(body);

                if (result.status == "success")
                {
                    MessageBox.Show("Book Added Successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Error: " + result.message, "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("API Error: " + ex.Message, "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                button1.Enabled = true;
                button1.Text = "Add Book";
            }
        }

        // =========================
        // BACK TO DASHBOARD
        // =========================
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            mainDashbboard dash = new mainDashbboard();
            dash.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainDashbboard().Show();
        }

        // =========================
        // CLEAR FORM
        // =========================
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            richTextBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        // =========================
        // EMPTY EVENTS
        // =========================
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}