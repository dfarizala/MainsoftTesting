using System;
using System.ComponentModel.DataAnnotations;

namespace MainsoftTesting.Domain.Models
{
    public class CreateUserViewModel
    {
        [Display(Name = "Id")]
        public string? Id { get; set; }
        [Display(Name = "Nombre")] 
        public string? Name { get; set; }
        [Display(Name = "Apellido")]
        public string? LastName { get; set; }
        [Display(Name = "Celular")]
        public string? CellPhone { get; set; }
        [Display(Name = "Teléfono")]
        public string? Phone { get; set; }
        [Display(Name = "Género")]
        public string? Gender { get; set; }
        [Display(Name = "Estado civil")]
        public string? MaritalStatus { get; set; }
        [Display(Name = "Tipo de documento")]
        public string? DocType { get; set; }
        [Display(Name = "Número de documento")]
        public string? DocNumber { get; set; }
        [Display(Name = "Dirección")]
        public string? Address { get; set; }
        [Display(Name = "Correo")]
        public string? Email { get; set; }
        [Display(Name = "Nacionalidad")]
        public string? Nationality { get; set; }
        [Display(Name = "Edad")]
        public int Age { get; set; }
        [Display(Name = "Ciudad de nacimiento")]
        public string? BirthCity { get; set; }
        [Display(Name = "Siotuacion laboral")]
        public string? JobSituation { get; set; }
        [Display(Name = "Nombre de la ultima empresa donde trabajó")]
        public string? LastJobCompany { get; set; }
        [Display(Name = "Ciudad de la ultima empresa donde trabajó")]
        public string? LastJobCity { get; set; }
        [Display(Name = "Ultimo cargo")]
        public string? LastJobName { get; set; }
        [Display(Name = "Motivo de retiro")]
        public string? LastJobReasson { get; set; }
        [Display(Name = "Nivel académico")]
        public string? AcademicLevel { get; set; }
        [Display(Name = "Institución educativa")]
        public string? AcademicInstitution { get; set; }
        [Display(Name = "Año de finalización")]
        public string? DegreeFinalization { get; set; }
        [Display(Name = "Título obtenido")]
        public string? DegreeTitle { get; set; }

    }
}
