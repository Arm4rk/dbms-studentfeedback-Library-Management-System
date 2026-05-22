using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class UserLogin : Form
    {
        private const string ApiBase = "http://localhost:3000/login";

        public UserLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private void UserLogin_Load(object sender, EventArgs e)
        {
            // optional - leave empty
        }
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0'; // show password
                btnShowPassword.Text = "🙈";
            }
            else
            {
                textBox2.PasswordChar = '*'; // hide password
                btnShowPassword.Text = "👁";
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter email and password");
                return;
            }

            button1.Enabled = false;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var data = new
                    {
                        email = email,
                        password = password
                    };

                    string json = JsonSerializer.Serialize(data);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(ApiBase, content);
                    string result = await response.Content.ReadAsStringAsync();

                    MessageBox.Show(result);

                    if (result.Contains("success"))
                    {
                        MessageBox.Show("Login Successful!");

                        mainDashbboard dash = new mainDashbboard();
                        dash.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                button1.Enabled = true;
            }
        }
    }
}