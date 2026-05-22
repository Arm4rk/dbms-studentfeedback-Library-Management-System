using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class FeedbackDetails : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly string apiUrl = "http://localhost:3000/api/feedback";

        public FeedbackDetails()
        {
            InitializeComponent();
            this.Load += FeedbackDetails_Load;
        }

        public class Feedback
        {
            public int feedback_id { get; set; }
            public string academic_year { get; set; }
            public string semester { get; set; }
            public string feedback_date { get; set; }
            public string branch { get; set; }
            public string section { get; set; }
            public string subject { get; set; }
            public string ques1 { get; set; }
            public string ques2i { get; set; }
            public string ques2ii { get; set; }
            public string ques2iii { get; set; }
            public string ques2iv { get; set; }
            public string ques2v { get; set; }
            public string ques3 { get; set; }
            public string ques4 { get; set; }
            public string remarks { get; set; }
            public string created_at { get; set; }
        }

        private async void FeedbackDetails_Load(object sender, EventArgs e)
        {
            await LoadFeedback();
        }

        private async Task LoadFeedback()
        {
            try
            {
                buttonRefresh.Enabled = false;
                labelTotal.Text = "Loading feedback records...";

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                string json = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        "Feedback API Error:\n" + json,
                        "API Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    labelTotal.Text = "Failed to load feedback records.";
                    return;
                }

                List<Feedback> feedbacks = JsonConvert.DeserializeObject<List<Feedback>>(json);

                if (feedbacks == null || feedbacks.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    labelTotal.Text = "No library feedback records found.";
                    return;
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = feedbacks;

                labelTotal.Text = "Total Library Feedback Records: " + feedbacks.Count;

                RenameColumns();
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cannot connect to Node.js API.\n\nMake sure server.js is running on port 3000.\n\nError: " + ex.Message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                labelTotal.Text = "Connection failed.";
            }
            finally
            {
                buttonRefresh.Enabled = true;
            }
        }

        private void RenameColumns()
        {
            if (dataGridView1.Columns["feedback_id"] != null)
                dataGridView1.Columns["feedback_id"].HeaderText = "ID";

            if (dataGridView1.Columns["academic_year"] != null)
                dataGridView1.Columns["academic_year"].HeaderText = "Academic Year";

            if (dataGridView1.Columns["semester"] != null)
                dataGridView1.Columns["semester"].HeaderText = "Semester";

            if (dataGridView1.Columns["feedback_date"] != null)
                dataGridView1.Columns["feedback_date"].HeaderText = "Date";

            if (dataGridView1.Columns["branch"] != null)
                dataGridView1.Columns["branch"].HeaderText = "Department / Course";

            if (dataGridView1.Columns["section"] != null)
                dataGridView1.Columns["section"].HeaderText = "Year & Section";

            if (dataGridView1.Columns["subject"] != null)
                dataGridView1.Columns["subject"].HeaderText = "Feedback Category";

            if (dataGridView1.Columns["ques1"] != null)
                dataGridView1.Columns["ques1"].HeaderText = "Book Availability";

            if (dataGridView1.Columns["ques2i"] != null)
                dataGridView1.Columns["ques2i"].HeaderText = "Borrowing Process";

            if (dataGridView1.Columns["ques2ii"] != null)
                dataGridView1.Columns["ques2ii"].HeaderText = "Returning Process";

            if (dataGridView1.Columns["ques2iii"] != null)
                dataGridView1.Columns["ques2iii"].HeaderText = "Staff Assistance";

            if (dataGridView1.Columns["ques2iv"] != null)
                dataGridView1.Columns["ques2iv"].HeaderText = "Cleanliness & Organization";

            if (dataGridView1.Columns["ques2v"] != null)
                dataGridView1.Columns["ques2v"].HeaderText = "Finding Resources";

            if (dataGridView1.Columns["ques3"] != null)
                dataGridView1.Columns["ques3"].HeaderText = "System Usefulness";

            if (dataGridView1.Columns["ques4"] != null)
                dataGridView1.Columns["ques4"].HeaderText = "Overall Service";

            if (dataGridView1.Columns["remarks"] != null)
                dataGridView1.Columns["remarks"].HeaderText = "Remarks";

            if (dataGridView1.Columns["created_at"] != null)
                dataGridView1.Columns["created_at"].HeaderText = "Date Submitted";
        }

        private void FormatGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            if (dataGridView1.Columns["remarks"] != null)
            {
                dataGridView1.Columns["remarks"].Width = 220;
                dataGridView1.Columns["remarks"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            dataGridView1.ClearSelection();
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await LoadFeedback();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new mainDashbboard().Show();
        }
    }
}