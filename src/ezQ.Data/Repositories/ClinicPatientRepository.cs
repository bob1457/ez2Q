using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ezQ.Core.Entities;
using ezQ.Services.Interfaces;
using ezQ.Services.ViewModels;
using ezQ.Data.Interfaces;

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
            
            clinic.ClinicAddress = address;

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

    }
}
