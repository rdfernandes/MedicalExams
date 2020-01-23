using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using MedicalExams.Classes;
using Newtonsoft.Json;
using Notifications.Wpf;

namespace MedicalExams
{
    /// <summary>
    /// Interaction logic for InsertNewExam.xaml
    /// </summary>
    public partial class InsertNewExam : Window
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public InsertNewExam()
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
            //string WebApiUrl = Settings.Default.WebAPIURL;
            string WebApiUrl = ConfigurationManager.AppSettings["WebApiURL"].ToString();

            // Code to call API
            // First need to install a Nudget Package if is not exists: "Microsoft.AspNet.WebApi.Client"

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(WebApiUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            ResourceDictionary rd = this.Resources.MergedDictionaries[0];

            try
            {
                HttpResponseMessage response = client.GetAsync("/api/ExamTypes").Result;
                if (response.IsSuccessStatusCode)
                {
                    var items = response.Content.ReadAsAsync<IEnumerable<ExamTypes>>().Result;

                    List<ExamTypes> listExamTypes = new List<ExamTypes>();
                    foreach (var i in items)
                    {
                        ExamTypes ex = new ExamTypes();
                        ex.Id = i.Id;
                        ex.Exam = i.Exam;
                        listExamTypes.Add(ex);
                    }

                    this.ExamsListBox.ItemsSource = listExamTypes;
                }
                else
                {
                    MessageBox.Show("Error Code " + response.StatusCode + ": Message - " + response.ReasonPhrase);
                }

                this.TotalSelectedExamsText.Text = 0 + " " + rd["InsertNewExam.TotalSelectedExams"];
            }
            catch (Exception)
            {
                MessageBox.Show(rd["Error.WebAPINotFoundText"].ToString(), rd["Error.WebAPINotFoundTitle"].ToString());
            }
        }

        /// <summary>
        /// Clear all data in this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            this.UserNumber.Text = this.UserName.Text = this.UserDateOfBirth.Text = "";
            ExamsListBox.UnselectAll();

            ResourceDictionary rd = this.Resources.MergedDictionaries[0];
            object theValue = rd["InsertNewExam.TotalSelectedExams"];

            this.TotalSelectedExamsText.Text = 0 + " " + theValue;
            this.SaveButton.IsEnabled = false;
            this.ClearButton.IsEnabled = false;
        }

        /// <summary>
        /// Update the count in the top when choose some listboxItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExamsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int total = 0;

            foreach (object o in ExamsListBox.SelectedItems)
            {
                total++;
            }

            ResourceDictionary rd = this.Resources.MergedDictionaries[0];
            object theValue = rd["InsertNewExam.TotalSelectedExams"];

            this.TotalSelectedExamsText.Text = total + " " + theValue;
            this.VerifyActiveSaveButton();
        }

        /// <summary>
        /// Save all data, close the window and send data to the Web API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary rd = this.Resources.MergedDictionaries[0];

            string selectedExams = "";
            int totalExams = 0;
            foreach (ExamTypes li in this.ExamsListBox.SelectedItems)
            {
                if (totalExams == 0)
                    selectedExams = li.Exam;
                else
                    selectedExams += ", " + li.Exam;

                totalExams++;
            }

            Exams exams = new Exams();
            exams.UserNumber = Int32.Parse(this.UserNumber.Text);
            exams.UserName = this.UserName.Text;
            exams.UserDateOfBirth = (this.UserDateOfBirth.SelectedDate).Value.ToShortDateString();
            exams.SelectedExams = selectedExams;
            exams.TotalSelectedExams = totalExams;

            // setting
            string WebApiUrl = ConfigurationManager.AppSettings["WebApiURL"].ToString();

            // Code to call API
            // First need to install a Nudget Package if is not exists: "Microsoft.AspNet.WebApi.Client"

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(WebApiUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string serializedObject = JsonConvert.SerializeObject(exams);
                var httpContent = new StringContent(serializedObject, Encoding.UTF8, "application/json");

                using (var responseMessage = await client.PostAsync("/api/Exams", httpContent))
                {
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        var notificationManager = new NotificationManager();

                        notificationManager.Show(
                            new NotificationContent { Title = rd["Message.ProcessAddedTitle"].ToString(), Message = rd["Message.ProcessAddedText"].ToString() },
                            areaName: "WindowArea");
                    }
                    else
                    {
                        MessageBox.Show("Error Code " + responseMessage.StatusCode + ": Message - " + responseMessage.ReasonPhrase);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(rd["Error.WebAPINotFoundText"].ToString(), rd["Error.WebAPINotFoundTitle"].ToString());
            }

            this.StartCloseTimer();
        }

        /// <summary>
        /// Responsable to close window after 10 seconds
        /// </summary>
        private void StartCloseTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10d);
            timer.Tick += TimerTick;
            timer.Start();
        }

        /// <summary>
        /// responsable to count the timer to close window after X time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerTick(object sender, EventArgs e)
        {
            DispatcherTimer timer = (DispatcherTimer)sender;
            timer.Stop();
            timer.Tick -= TimerTick;
            Close();
        }

        /// <summary>
        /// Validate UserDateOfBirth Text Input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserDateOfBirthValidationDatePicker(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("([12][0-9]{3}-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01]))|((0|[1-9]|[12][0-9]|3[01])-(0[1-9]|1[0-2])-[12][0-9]{3})");
            e.Handled = regex.IsMatch(e.Text);

            this.VerifyActiveSaveButton();
        }

        /// <summary>
        /// Validate UserName Text Input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserNameValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z_]+(a-zA-Z_+)*$");
            e.Handled = regex.IsMatch(e.Text);

            this.VerifyActiveSaveButton();
        }

        /// <summary>
        /// Validate UserNumber Text Input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserNumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

            this.VerifyActiveSaveButton();
        }

        /// <summary>
        /// Responsable to enable or disable the Clear Button
        /// </summary>
        private void VerifyActiveClearButton()
        {
            if (this.UserNumber.Text.Length >= 0 || this.UserName.Text.Length >= 0 || this.UserDateOfBirth.SelectedDate.HasValue == true || this.ExamsListBox.SelectedItems.Count > 0)
                this.ClearButton.IsEnabled = true;
            else
                this.ClearButton.IsEnabled = false;
        }

        /// <summary>
        /// Responsable to enable or disable the Save Button
        /// </summary>
        private void VerifyActiveSaveButton()
        {
            this.VerifyActiveClearButton();

            if (this.UserNumber.Text.Length == 9 && this.UserName.Text.Length > 5 && this.UserDateOfBirth.SelectedDate.HasValue == true && this.ExamsListBox.SelectedItems.Count >= 1)
                this.SaveButton.IsEnabled = true;
            else
                this.SaveButton.IsEnabled = false;
        }
    }
}