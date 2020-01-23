using System;
using System.ComponentModel.DataAnnotations;

namespace MedicalExams.Classes
{
    /// <summary>
    /// Class necessary to prepare Exams
    /// </summary>
    internal class ExamTypes
    {
        public int Id { get; set; }
        public string Exam { get; set; }
    }
}
