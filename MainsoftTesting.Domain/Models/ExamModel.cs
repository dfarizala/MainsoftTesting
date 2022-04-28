using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MainsoftTesting.Domain.Models
{
    public class ExamModel
    {

    }

    public class ExamListModel
    {
        public int Id { get; set; }
        public string? ExamName { get; set; }
        public int? EstimatedTime { get; set; }
        public string? Status { get; set; }
        public string? ExamProfile { get; set; }
        public string? ExamTechnology { get; set; }
        public int? NumberOfQuestions { get; set; }

    }
}
