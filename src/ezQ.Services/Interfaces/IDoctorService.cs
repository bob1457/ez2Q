using ezQ.Services.ViewModels;

namespace ezQ.Services.Interfaces
{
    public interface IDoctorService
    {
        void AddDoctorToClinic(DoctorAddViewModel doctorModel);

        //DoctorAddViewModel Add(DoctorAddViewModel doctorModel);
    }
}