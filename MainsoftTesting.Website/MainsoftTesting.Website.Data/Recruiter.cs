namespace MainsoftTesting.Website.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recruiter")]
    public partial class Recruiter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recruiter()
        {
            Users = new HashSet<Users>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(500)]
        public string RecruiterName { get; set; }

        public int? Role { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(1000)]
        public string Password { get; set; }

        public int? Status { get; set; }

        [StringLength(20)]
        public string CreationUser { get; set; }

        public DateTime? CreationDate { get; set; }

        [StringLength(20)]
        public string ModificationUser { get; set; }

        public DateTime? ModificationDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users> Users { get; set; }
    }
}
