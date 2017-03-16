using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezQ.Services.ViewModels
{
    public class DoctorViewModel
    {
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string ProfessionalTitle { get; set; }

        public int ClinicId { get; set; }
        
        public string ContactTel { get; set; }

        public bool IsActive { get; set; }
        
        public DateTime JoinDate { get; set; }
        
        public DateTime UpdateDate { get; set; }
       
        public string Notes { get; set; }




        public string ClinicName { get; set; }
        public string ClinicDesc { get; set; }
        public string ClinicContactTel { get; set; }
        public string ClinicWebsite { get; set; }
        public string ClinicCategory { get; set; }
        public string ClinicType { get; set; }


    }
}
