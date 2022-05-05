namespace MainsoftTesting.Website.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QuestionOptions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestionOptions()
        {
            UserExamAnswers = new HashSet<UserExamAnswers>();
        }

        public int id { get; set; }

        public int? QuestionHeaderId { get; set; }

        [StringLength(500)]
        public string OptionText { get; set; }

        public int? IsCorrect { get; set; }

        [StringLength(20)]
        public string CreationUser { get; set; }

        public DateTime? CreationDate { get; set; }

        [StringLength(20)]
        public string ModificationUser { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual QuestionHeader QuestionHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserExamAnswers> UserExamAnswers { get; set; }
    }
}
