using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows;
using MedicalExams.Classes;

namespace MedicalExams
{
    /// <summary>
    /// Interaction logic for ExamDetails.xaml
    /// </summary>
    public partial class ExamDetails : Window
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Id"></param>
        public ExamDetails(int Id)
        {
            InitializeComponent();

            // Call Translation for System Language
            this.Resources.MergedDictionaries.Add(new Languages().SetLanguageDictionary());

            this.LoadData(Id);
        }

        /// <summary>
        /// Call Web API and get all Exams Data
        /// </summary>
        /// <param name="Id"></param>
        public void LoadData(int Id)
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
                HttpResponseMessage response = client.GetAsync("/api/Exams/"+Id).Result;
                if (response.IsSuccessStatusCode)
                {
                    var item = response.Content.ReadAsAsync<Exams>().Result;

                    Exams ex = new Exams();
                    ex.Id = item.Id;
                    ex.CreatedDate = item.CreatedDate;
                    ex.UserNumber = item.UserNumber;
                    ex.UserName = item.UserName;
                    ex.UserDateOfBirth = item.UserDateOfBirth;
                    ex.SelectedExams = item.SelectedExams;
                    ex.TotalSelectedExams = item.TotalSelectedExams;

                    this.ProcessIdText.Text = ex.Id.ToString();
                    this.CreatedDateText.Text = ex.CreatedDate.ToString();
                    this.UserNumberText.Text = ex.UserNumber.ToString();
                    this.UserNameText.Text = ex.UserName;
                    this.UserDateOfBirthText.Text = ex.UserDateOfBirth;
                    this.TotalSelectedExamsText.Text = ex.TotalSelectedExams.ToString();
                    this.SelectedExamsText.Text = ex.SelectedExams;
                }
                else
                {
                    MessageBox.Show("Error Code " + response.StatusCode + ": Message - " + response.ReasonPhrase);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(rd["Error.WebAPINotFoundText"].ToString(), rd["Error.WebAPINotFoundTitle"].ToString());
            }
        }
    }
}
