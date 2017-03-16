using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezQ.Services.ViewModels
{
    public class DoctorAddViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProfessionalTitle { get; set; }

        public int ClinicId { get; set; }

        public string ContactTel { get; set; }

        public bool IsActive { get; set; }

        public string Notes { get; set; }
    }
}
