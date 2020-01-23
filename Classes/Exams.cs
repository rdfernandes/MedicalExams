using System;
using System.ComponentModel.DataAnnotations;

namespace MedicalExams.Classes
{
    /// <summary>
    /// Class necessary to prepare Exams
    /// </summary>
    internal class Exams
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        public int UserNumber { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserDateOfBirth { get; set; }
        public string SelectedExams { get; set; }
        public int TotalSelectedExams { get; set; }
    }
}