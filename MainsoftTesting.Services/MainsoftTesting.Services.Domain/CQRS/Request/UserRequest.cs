using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainsoftTesting.Services.Domain.CQRS.Request
{
    public class AddUserRequest
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? CellPhone { get; set; }
        public string? Phone { get; set; }
        public string? Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public string? DocType { get; set; }
        public string? DocNumber { get; set; }
        public string? Address { get; set; }
        public string? Nationality { get; set; }
        public int Age { get; set; }
        public string? BirthCity { get; set; }
        public string? JobSituation { get; set; }
        public string? LastJobCompany { get; set; }
        public string? LastJobCity { get; set; }
        public string? LastJobName { get; set; }
        public string? LastJobReasson { get; set; }
        public string? AcademicLevel { get; set; }
        public string? AcademicInstitution { get; set; }
        public string? DegreeFinalization { get; set; }
        public string? DegreeTitle { get; set; }

    }
}
