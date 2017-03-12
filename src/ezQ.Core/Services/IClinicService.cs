using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ezQ.Core.Entities;

namespace ezQ.Core.Services
{
    public interface IClinicService
    {
        void Add(Clinic clinic, ClinicAddress address);
        void Update(Clinic clinic, ClinicAddress address);
        void Delete(Clinic clinic, ClinicAddress address);

    }
}
