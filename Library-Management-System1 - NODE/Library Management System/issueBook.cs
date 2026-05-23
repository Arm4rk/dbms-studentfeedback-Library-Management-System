using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class issueBook : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly string baseUrl = "http://localhost:3000/";

        public issueBook()
        {
            InitializeComponent();
            this.Load += issueBook_Load;
        }

        public class Book
        {
            public string id { get; set; }
            public string title { get; set; }

            public override string ToString()
            {
                return title;
            }
        }

        public class ApiResponse<T>
        {
            public string status { get; set; }
            public T data { get; set; }
            public string message { get; set; }
        }

        private async void issueBook_Load(object sender, EventArgs e)
        {
            await LoadBooks();
        }

        private async Task LoadBooks()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl + "books");
                string json = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Books API error: " + json);
                    return;
                }

                ApiResponse<List<Book>> result =
                    JsonConvert.DeserializeObject<ApiResponse<List<Book>>>(json);

                comboBoxBooks.Items.Clear();

                if (result == null || result.status != "success" || result.data == null)
                {
                    MessageBox.Show("No books loaded from API.");
                    return;
                }

                foreach (Book book in result.data)
                {
                    if (book != null && !string.IsNullOrEmpty(book.id) && !string.IsNullOrEmpty(book.title))
                    {
                        comboBoxBooks.Items.Add(book);
                    }
                }

                comboBoxBooks.SelectedIndex = -1;
                comboBoxBooks.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxBooks.SelectedItem == null)
                {
                    MessageBox.Show("Please select a book.");
                    return;
                }

                string borrowerName = textBoxBorrower.Text.Trim();

                if (string.IsNullOrEmpty(borrowerName))
                {
                    MessageBox.Show("Please enter borrower name.");
                    return;
                }

                Book selectedBook = comboBoxBooks.SelectedItem as Book;

                if (selectedBook == null)
                {
                    MessageBox.Show("Invalid selected book.");
                    return;
                }

                var payload = new
                {
                    book_id = selectedBook.id,
                    borrower_name = borrowerName,
                    issue_date = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    return_date = dateTimePicker2.Value.ToString("yyyy-MM-dd")
                };

                string json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(baseUrl + "issue", content);
                string resultJson = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Issue API error: " + resultJson);
                    return;
                }

                ApiResponse<object> apiResult =
                    JsonConvert.DeserializeObject<ApiResponse<object>>(resultJson);

                if (apiResult == null)
                {
                    MessageBox.Show("Invalid response from API.");
                    return;
                }

                if (apiResult.status == "error")
                {
                    MessageBox.Show(apiResult.message);
                    return;
                }

                MessageBox.Show("Book issued successfully!");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            comboBoxBooks.SelectedIndex = -1;
            comboBoxBooks.Text = "";

            textBoxBorrower.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new mainDashbboard().Show();
        }
    }
}