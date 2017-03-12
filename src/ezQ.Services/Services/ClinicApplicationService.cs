using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ezQ.Core.Entities;
using ezQ.Core.Services;
using ezQ.Services;
using ezQ.Services.Interfaces;
using ezQ.Services.ViewModels;


namespace ezQ.Services.Services
{
    public class ClinicApplicationService : IClinicApplicationService
    {
        //DI Implementation
        //
        private readonly IClinicPatientRepository _clinicPatientRepository;
        private readonly IClinicService _clinicService;

        public ClinicApplicationService(IClinicPatientRepository clinicPatientRepository, IClinicService clinicService)
        {
            _clinicPatientRepository = clinicPatientRepository;
            _clinicService = clinicService;
        }


        public ViewModels.ClinicPatientViewModel GetAllClinics()
        {
            throw new NotImplementedException();
        }

        public ViewModels.ClinicPatientViewModel GetClinicById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddClinic(ClinicAddViewModel clinicAddViewModel)
        {
            //throw new NotImplementedException();

            //Create object for repository operations
            //
            var clinic = new Clinic(clinicAddViewModel.ClinicName, 
                clinicAddViewModel.ClinicDesc, 
                clinicAddViewModel.ClinicContactTel,
                clinicAddViewModel.ClinicWebsite,
                clinicAddViewModel.ClinicCategoryId,
                clinicAddViewModel.ClinicTypeId);

            var clinicAddress = new ClinicAddress(clinicAddViewModel.NumberStreet,
                clinicAddViewModel.City,
                clinicAddViewModel.ProvState,
                clinicAddViewModel.PostZipCode,
                clinicAddViewModel.Country);

            clinic.CreateDate = DateTime.Now;
            clinic.UpdateDate = DateTime.Now;

            _clinicPatientRepository.AddClinic(clinic, clinicAddress);
        }
    }
}
