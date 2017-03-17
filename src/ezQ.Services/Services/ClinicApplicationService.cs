using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ezQ.Core.Entities;
using ezQ.Core.Interfaces;
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
        private readonly IRepository<Doctor> _doctorReposiotry;
        private readonly IClinicService _clinicService;
        

        public ClinicApplicationService(IClinicPatientRepository clinicPatientRepository, 
            IRepository<Doctor> clinicReposiotry
            )
        {
            _clinicPatientRepository = clinicPatientRepository;
            _doctorReposiotry = clinicReposiotry;
            
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

            var clinic = _clinicService.AddClinic(clinicAddViewModel.ClinicName, clinicAddViewModel.ClinicDesc, clinicAddViewModel.ClinicContactTel, clinicAddViewModel.ClinicCategoryId, clinicAddViewModel.ClinicTypeId,
                clinicAddViewModel.NumberStreet, clinicAddViewModel.City, clinicAddViewModel.ProvState, clinicAddViewModel.PostZipCode, clinicAddViewModel.Country);

            
            _clinicPatientRepository.AddClinic(clinic, clinic.ClinicAddress);
        }

        
        public void AddDcotor(DoctorAddViewModel doctorAddViewModel)
        {
            Doctor doctor = Doctor.Create(doctorAddViewModel.FirstName, doctorAddViewModel.LastName,
                doctorAddViewModel.ProfessionalTitle, doctorAddViewModel.ClinicId, doctorAddViewModel.ContactTel, doctorAddViewModel.Notes);

            //Doctor doctor = new Doctor(doctorAddViewModel.FirstName, doctorAddViewModel.LastName,
            //    doctorAddViewModel.ProfessionalTitle, doctorAddViewModel.ClinicId, doctorAddViewModel.ContactTel, doctorAddViewModel.Notes);

            doctor.JoinDate = DateTime.Now;
            doctor.UpdateDate = DateTime.Now;

            _doctorReposiotry.Add(doctor);

            //return AutoMapper.Mapper.Map<Doctor, DoctorAddViewModel>(doctor);
        }
    }
}
