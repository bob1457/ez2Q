using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ezQ.Services.ViewModels;

namespace ezQ.Data.Interfaces
{
    public interface IClinicRepository
    {
        IEnumerable<ClinicAddViewModel> GetAllClinic();

        ClinicAddViewModel GetClinicById(int id);
    }
}
