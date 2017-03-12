namespace ezQ.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClinicCategory")]
    public partial class ClinicCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClinicCategory()
        {
            Clinics = new HashSet<Clinic>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ClinicCategoryName { get; set; }

        [StringLength(350)]
        public string ClinicCategoryDesc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clinic> Clinics { get; set; }
    }
}
