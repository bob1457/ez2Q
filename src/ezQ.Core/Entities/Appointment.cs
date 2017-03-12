namespace ezQ.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }

        public long PatientId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime AppointmentStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime AppoinitmentEndTime { get; set; }

        [Required]
        [StringLength(10)]
        public string AppointmentStatus { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UpdateDate { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
