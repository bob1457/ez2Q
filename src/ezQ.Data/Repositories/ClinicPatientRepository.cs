using System;
using System.Collections.Generic;
using ezQ.Core.Entities;
using ezQ.Services.Interfaces;
using ezQ.Services.ViewModels;

namespace ezQ.Data.Repositories
{
    public class ClinicPatientRepository : IClinicPatientRepository
    {
        //Data context
        private readonly ezQDbContext _context = new ezQDbContext();


        public IEnumerable<ClinicAddViewModel> GetAllClinic()
        {
            throw new NotImplementedException();
        }

        public ClinicAddViewModel GetClinicById(int id)
        {
            throw new NotImplementedException();
        }
         

        public void AddClinic(Clinic clinic, ClinicAddress address)
        {
            //throw new NotImplementedException();
            
            //clinic.ClinicAddress = address;

            _context.Clinics.Add(clinic);

            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }



        public IEnumerable<Clinic> GetClinics()
        {
            //throw new NotImplementedException();
            return _context.Clinics.Include("Doctor");
        }


        
        public void AddDoctorToClinic(Doctor doctor)
        {
            _context.Doctors.Add(doctor);

            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
