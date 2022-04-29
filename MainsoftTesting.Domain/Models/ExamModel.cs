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
        [Display(Name = "Id")] public int Id { get; set; }
        [Display(Name = "Examen")] public string? ExamName { get; set; }
        [Display(Name = "Tiempo estimado")] public int? EstimatedTime { get; set; }
        [Display(Name = "Estado")] public string? Status { get; set; }
        [Display(Name = "Perfil")] public string? ExamProfile { get; set; }
        [Display(Name = "Tecnología")] public string? ExamTechnology { get; set; }
        [Display(Name = "No. de preguntas")] public int? NumberOfQuestions { get; set; }

    }
}
