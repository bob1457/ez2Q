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
        private readonly IDoctorService _doctorService;

        public ClinicApplicationService(IClinicPatientRepository clinicPatientRepository, 
            IRepository<Doctor> clinicReposiotry, 
            IClinicService clinicService, IDoctorService doctorService)
        {
            _clinicPatientRepository = clinicPatientRepository;
            _doctorReposiotry = clinicReposiotry;
            _clinicService = clinicService;
            _doctorService = doctorService;
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

        //public void AddDoctor(DoctorAddViewModel doctorModel)
        //{
        //    _doctorService.Add(doctorModel);

        //}

        //public DoctorAddViewModel AddDoctor(DoctorAddViewModel doctorModel)
        //{
        //    Doctor doctor = Doctor.Create(doctorModel.FirstName, doctorModel.LastName,
        //        doctorModel.ProfessionalTitle, doctorModel.ClinicId, doctorModel.ContactTel, doctorModel.Notes);

        //    _clinicReposiotry.Add(doctor);

        //    return AutoMapper.Mapper.Map<Doctor, DoctorAddViewModel>(doctor);

        //}






        public void AddDcotor(DoctorAddViewModel doctorAddViewModel)
        {
            //Doctor doctor = Doctor.Create(doctorAddViewModel.FirstName, doctorAddViewModel.LastName,
            //    doctorAddViewModel.ProfessionalTitle, doctorAddViewModel.ClinicId, doctorAddViewModel.ContactTel, doctorAddViewModel.Notes);

            Doctor doctor = new Doctor(doctorAddViewModel.FirstName, doctorAddViewModel.LastName,
                doctorAddViewModel.ProfessionalTitle, doctorAddViewModel.ClinicId, doctorAddViewModel.ContactTel, doctorAddViewModel.Notes);

            doctor.JoinDate = DateTime.Now;
            doctor.UpdateDate = DateTime.Now;

            _doctorReposiotry.Add(doctor);

            //return AutoMapper.Mapper.Map<Doctor, DoctorAddViewModel>(doctor);
        }
    }
}
