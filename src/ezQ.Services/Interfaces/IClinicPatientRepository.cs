using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ezQ.Core.Entities;
using ezQ.Services.ViewModels;

namespace ezQ.Services.Interfaces
{
    public interface IClinicPatientRepository
    {
        IEnumerable<ClinicAddViewModel> GetAllClinic();

        ClinicAddViewModel GetClinicById(int id);

        //void AddClinic(ClinicAddViewModel clinic);

        void AddClinic(Clinic clinic, ClinicAddress address);
    }
}
