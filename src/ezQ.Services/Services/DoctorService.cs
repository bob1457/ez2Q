using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ezQ.Core.Entities;
using ezQ.Core.Interfaces;
using ezQ.Services.Interfaces;
using ezQ.Services.ViewModels;




namespace ezQ.Services.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IClinicPatientRepository _clinicReposiotry;


        public DoctorService(IClinicPatientRepository clinicReposiotry)
        {
            _clinicReposiotry = clinicReposiotry;
        }

        public void AddDoctorToClinic(DoctorAddViewModel doctorModel)
        {
            var doctor = new Doctor(doctorModel.FirstName,
                doctorModel.LastName,
                doctorModel.ProfessionalTitle,
                doctorModel.ClinicId,
                doctorModel.ContactTel,
                doctorModel.Notes) {JoinDate = DateTime.Now, UpdateDate = DateTime.Now};


            //_clinicReposiotry.AddDoctorToClinic(doctor);

            //doctor.Add(doctor);

        }

        //No doctor service is required. Actions for Doctor entity can be done via entity's method

        //public DoctorAddViewModel Add(DoctorAddViewModel doctorModel)
        //{
        //    Doctor doctor = Doctor.Create(doctorModel.FirstName, doctorModel.LastName,
        //        doctorModel.ProfessionalTitle, doctorModel.ClinicId, doctorModel.ContactTel, doctorModel.Notes);

        //    _clinicReposiotry.AddDoctorToClinic(doctor);

        //    return AutoMapper.Mapper.Map<Doctor, DoctorAddViewModel>(doctor);

        //}
    }
}
