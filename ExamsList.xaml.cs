using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows;
using System.Windows.Controls;

using MedicalExams.Classes;

namespace MedicalExams
{
    /// <summary>
    /// Interaction logic for ExamsList.xaml
    /// </summary>
    public partial class ExamsList : Window
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ExamsList()
        {
            InitializeComponent();

            // Call Translation for System Language
            this.Resources.MergedDictionaries.Add(new Languages().SetLanguageDictionary());

            // Call LoadData to get Data from Web API
            this.LoadData();
        }

        /// <summary>
        /// Call Web API and get all Exams Data
        /// </summary>
        public void LoadData()
        {
            // setting
            string WebApiUrl = ConfigurationManager.AppSettings["WebApiURL"].ToString();

            // Code to call API
            // First need to install a Nudget Package if is not exists: "Microsoft.AspNet.WebApi.Client"

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(WebApiUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            ResourceDictionary rd = this.Resources.MergedDictionaries[0];

            try
            {
                HttpResponseMessage response = client.GetAsync("/api/Exams").Result;
                if (response.IsSuccessStatusCode)
                {
                    var items = response.Content.ReadAsAsync<IEnumerable<Exams>>().Result;

                    List<Exams> listExams = new List<Exams>();
                    foreach (var i in items)
                    {
                        Exams ex = new Exams();
                        ex.Id = i.Id;
                        ex.CreatedDate = i.CreatedDate;
                        ex.TotalSelectedExams = i.TotalSelectedExams;
                        listExams.Add(ex);
                    }

                    this.ExamsListView.ItemsSource = listExams;
                }
                else
                {
                    MessageBox.Show("Error Code " + response.StatusCode + ": Message - " + response.ReasonPhrase);
                }
            } catch (Exception)
            {
                MessageBox.Show(rd["Error.WebAPINotFoundText"].ToString(), rd["Error.WebAPINotFoundTitle"].ToString());
            }
        }

        /// <summary>
        /// When click on ExamRowButton to see Exam Details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExamRowButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            ExamDetails examDetails = new ExamDetails((int)button.Tag);
            examDetails.ShowDialog();
        }

        /// <summary>
        /// When click on NewExamButton to create a new exam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewExamButton_Click(object sender, RoutedEventArgs e)
        {
            InsertNewExam inserNewExam = new InsertNewExam();
            inserNewExam.ShowDialog();
        }

        /// <summary>
        /// When click on RefreshButton to reload all data from Web API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            this.LoadData();
        }
    }
}