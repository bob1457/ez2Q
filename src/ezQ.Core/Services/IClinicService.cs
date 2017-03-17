using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ezQ.Core.Entities;

namespace ezQ.Core.Services
{
    public interface IClinicService
    {
        void Add(Clinic clinic, ClinicAddress address);

        Clinic AddClinic(string clinicName, string clinicDesc, string clinicContactTel, int clinicCategoryId, int clinicTypeId,
            string clinicAddressStreet, string clinicAddressCity, string clinicAddressProvState, string clinicAddressPostZipCode, string clinicAddressCountry);

        void Update(Clinic clinic, ClinicAddress address);
        void Delete(Clinic clinic, ClinicAddress address);

    }
}
