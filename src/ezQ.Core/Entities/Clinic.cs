using ezQ.Core.Interfaces;

namespace ezQ.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clinic")]
    public partial class Clinic
    {
        private readonly IRepository<Clinic> _clinicRepository;

        public Clinic()
        {

        }

        //DI Implementation

        public Clinic(IRepository<Clinic> clinicRepository )
        {
            _clinicRepository = clinicRepository;
        }
        
        
        public Clinic(string clinicName, string clinicDesc, string clinicContactTel, 
            string clinicWebsite, int clinicCategoryId, int clinicTypeId)
        {
            ClinicName = clinicName;
            ClinicDesc = clinicDesc;
            ClinicContactTel = clinicContactTel;
            ClinicWebsite = clinicWebsite;
            ClinicCategoryId = clinicCategoryId;
            ClinicTypeId = clinicTypeId;
        }
        
        #region Attributes

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ClinicName { get; set; }

        [StringLength(350)]
        public string ClinicDesc { get; set; }

        public int ClinicAddressId { get; set; }

        [Required]
        [StringLength(20)]
        public string ClinicContactTel { get; set; }

        [StringLength(150)]
        public string ClinicWebsite { get; set; }

        public int ClinicCategoryId { get; set; }

        public int ClinicTypeId { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UpdateDate { get; set; }

        

        //Navigaton

        public virtual ClincType ClinicType { get; set; }

        public virtual ClinicAddress ClinicAddress { get; set; }

        public virtual ClinicCategory ClinicCategory { get; set; }

        #endregion

        #region Behaviors

        
        public void Deactivate(Clinic clinic)
        {
            clinic.IsActive = false;
            _clinicRepository.Update(clinic);
        }

        public void Activate(Clinic clinic)
        {
            clinic.IsActive = true;
            _clinicRepository.Update(clinic);
        }

        #endregion

    }
}
