using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezQ.Services.ViewModels
{
    public class ClinicAddViewModel
    {
        public string ClinicName { get; set; }
        public string ClinicDesc { get; set; }
        public string ClinicContactTel { get; set; }
        public string ClinicWebsite { get; set; }
        public int ClinicCategoryId { get; set; }
        public int ClinicTypeId { get; set; }


        public string NumberStreet { get; set; }
        public string City { get; set; }
        public string ProvState { get; set; }
        public string PostZipCode { get; set; }
        public string Country { get; set; }
    }
}
