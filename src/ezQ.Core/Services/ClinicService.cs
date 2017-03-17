using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using ezQ.Core.Entities;

namespace ezQ.Core.Services
{
    public class ClinicService : IClinicService
    {
        //DI Implementation

        public ClinicService()
        {
            
        }
        public void Add(Entities.Clinic clinic, Entities.ClinicAddress address)
        {
            throw new NotImplementedException();
        }

        public Clinic AddClinic( string clinicName, string clinicDesc, string clinicContactTel, int clinicCategoryId, int clinicTypeId, 
            string clinicAddressStreet, string clinicAddressCity, string clinicAddressProvState, string clinicAddressPostZipCode, string clinicAddressCountry)
        {
            var clinicAddress = new ClinicAddress(clinicAddressStreet, clinicAddressCity, clinicAddressProvState,
                clinicAddressPostZipCode, clinicAddressCountry);


            //clinic.ClinicAddress = address;

            return new Clinic
            {
                ClinicName = clinicName,
                ClinicDesc = clinicDesc,
                ClinicContactTel = clinicContactTel,
                ClinicCategoryId = clinicCategoryId,
                ClinicTypeId = clinicTypeId,
                ClinicAddress = clinicAddress,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            //}(clinic.ClinicName,
            //    clinic.ClinicDesc,
            //    clinic.ClinicContactTel,
            //    clinic.ClinicWebsite,
            //    clinic.ClinicCategoryId,
            //    clinic.ClinicTypeId);



        }

        public void Update(Entities.Clinic clinic, Entities.ClinicAddress address)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entities.Clinic clinic, Entities.ClinicAddress address)
        {
            throw new NotImplementedException();
        }
    }
}
