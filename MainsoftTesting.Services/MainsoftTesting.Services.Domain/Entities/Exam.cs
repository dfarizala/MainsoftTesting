using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainsoftTesting.Services.Domain.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        public string? ExamName { get; set; }
        public int? EstimatedTime { get; set; }
        public string? Status { get; set; }
        public int? ExamProfile { get; set; }
        public int? ExamTechnology { get; set; }
        public int? NumberOfQuestions { get; set; }
        public string? CrationUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModificationUser { get; set; }
        public DateTime? ModificationDate { get; set; }

    }

    public class Questions
    {
        public int Id { get; set; }
        public int? ExamId { get; set; }
        public int? QuestionType { get; set; }
        public int? QuestionTopic { get; set; }
        public string? QuestionText { get; set; }
        public string? QuestionImage { get; set; }
        public string? CreationUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModificationUser { get; set; }
        public DateTime? ModificationDate { get; set; }

    }

    public class ExamList
    {
        public int Id { get; set; }
        public string? ExamName { get; set; }
        public int? EstimatedTime { get; set; }
        public string? Status { get; set; }
        public string? ExamProfile { get; set; }
        public string? ExamTechnology { get; set; }
        public int? NumberOfQuestions { get; set; }

    }

    public class AssignedExamList
    {
        public int Id { get; set; }
        public string? ExamName { get; set; }
        public string? Profile { get; set; }
        public string? Technology { get; set; }
        public string? UserName { get; set; }
        public string? DocType { get; set; }
        public string? DocNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Status { get; set; }
    }
}
