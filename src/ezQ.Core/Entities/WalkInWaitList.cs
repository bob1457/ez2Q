using ezQ.Core.Interfaces;

namespace ezQ.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WalkInWaitList")]
    public partial class WalkInWaitList
    {
        private readonly IRepository<WalkInWaitList> _waitListRepository;

        private WalkInWaitList()
        {
            
        }

        private WalkInWaitList(IRepository<WalkInWaitList> waitListRepository)
        {
            _waitListRepository = waitListRepository;
        }

        #region Attributes

        public long Id { get; set; }

        public int ClinicId { get; set; }

        public long PatientId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime JoinTime { get; set; }

        [Required]
        [StringLength(50)]
        public string WaitStatus { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime StatusChangeTime { get; set; }

        public int ServingDoctorId { get; set; }

        [StringLength(350)]
        public string Notes { get; set; }

        public virtual Patient Patient { get; set; }

        #endregion


        #region

        public void ChangeStatus(WalkInWaitList list, string status)
        {
            list.WaitStatus = status;
            list.StatusChangeTime = DateTime.Now;
            
            _waitListRepository.Update(list);

        }


        #endregion
    }
}
