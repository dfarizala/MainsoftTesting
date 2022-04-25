using System;
using System.Collections.Generic;

namespace MainsoftTesting.Services.Persistence.Models
{
    public partial class Recruiter
    {
        public Recruiter()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string? RecruiterName { get; set; }
        public int? Role { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? Status { get; set; }
        public string? CreationUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModificationUser { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
