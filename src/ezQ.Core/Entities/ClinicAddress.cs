namespace ezQ.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClinicAddress")]
    public partial class ClinicAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClinicAddress()
        {
            
        }

        public ClinicAddress(string numberStreet, 
            string city, string provState, 
            string postZipCode, string country)
        {
            NumberStreet = numberStreet;
            City = city;
            ProvState = provState;
            PostZipCode = postZipCode;
            Country = country;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NumberStreet { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }

        [Required]
        [StringLength(20)]
        public string ProvState { get; set; }

        [Required]
        [StringLength(20)]
        public string PostZipCode { get; set; }

        [Required]
        [StringLength(20)]
        public string Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clinic> Clinics { get; set; }
    }
}
