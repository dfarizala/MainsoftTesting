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

    public class AssignedExamListModel
    {
        [Display(Name = "Id")] public int Id { get; set; }
        [Display(Name = "Examen")] public string? ExamName { get; set; }
        [Display(Name = "Perfil")] public string? Profile { get; set; }
        [Display(Name = "Tecnología")] public string? Technology { get; set; }
        [Display(Name = "Candidato")] public string? UserName { get; set; }
        [Display(Name = "Tipo de documento")] public string? DocType { get; set; }
        [Display(Name = "Documento")] public string? DocNumber { get; set; }
        [Display(Name = "Iniciado")] public DateTime? StartDate { get; set; }
        [Display(Name = "Finalizado")] public DateTime? EndDate { get; set; }
        [Display(Name = "Estado")] public string? Status { get; set; }
    }
}
