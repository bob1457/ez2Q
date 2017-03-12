using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ezQ.Core.Entities;

namespace ezQ.Services.ViewModels
{
    public class ClinicPatientViewModel
    {
        public string ClinicName { get; set; }
        public string ClinicDesc { get; set; }
        public string ClinicContactTel { get; set; }
        public string ClinicWebsite { get; set; }
        public string ClinicCategory { get; set; }
        public string ClinicType { get; set; }


        public string NumberStreet { get; set; }
        public string City { get; set; }
        public string ProvState { get; set; }
        public string PostZipCode { get; set; }
        public string Country { get; set; }

        public List<Doctor> Doctors { get; set; }
        public List<WalkInWaitList> WaitLists { get; set; } 

    }
}
