using ezQ.Core.Interfaces;

namespace ezQ.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        private readonly IRepository<Doctor> _doctorRepository;

        public Doctor()
        {
            
        }
        
        public Doctor(IRepository<Doctor> doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        #region Attributes

        public Doctor(string firstName, string lastName, 
            string professionalTitle, int clinicId, 
            string contactTel, string notes)
        {
            FirstName = firstName;
            LastName = lastName;
            ProfessionalTitle = professionalTitle;
            ClinicId = clinicId;
            ContactTel = contactTel;
            Notes = notes;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string ProfessionalTitle { get; set; }

        public int ClinicId { get; set; }

        [Required]
        [StringLength(20)]
        public string ContactTel { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime JoinDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UpdateDate { get; set; }

        [StringLength(450)]
        public string Notes { get; set; }

        #endregion

        #region Behavors

        public void Add(Doctor doctor)
        {
            _doctorRepository.Add(doctor);
        }

        public static Doctor Create(string firstName, string lastName, string proTitle, int clinicId, string contactTel, string notes) //create a new object - Factory pattern
        {
            return Create(firstName, lastName, proTitle, clinicId, contactTel, notes );
        }



        public void Update(Doctor doctor)
        {
            doctor.UpdateDate = DateTime.Now;

            _doctorRepository.Update(doctor);
        }


        public void Deactivate(Doctor doctor)
        {
            doctor.IsActive = false;
            _doctorRepository.Update(doctor);
        }

        public void Activate(Doctor doctor)
        {
            doctor.IsActive = true;
            _doctorRepository.Update(doctor);
        }


        #endregion
    }
}
