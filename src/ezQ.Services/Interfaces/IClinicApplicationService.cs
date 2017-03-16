using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ezQ.Services.ViewModels;

namespace ezQ.Services.Interfaces
{
    public interface IClinicApplicationService
    {
        ViewModels.ClinicPatientViewModel GetAllClinics();

        ViewModels.ClinicPatientViewModel GetClinicById(int id);

        void AddClinic(ClinicAddViewModel clinicAddViewModel);

        void AddDcotor(DoctorAddViewModel doctorAddViewModel);
    }
}
