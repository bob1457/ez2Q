using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using ezQ.Services.Interfaces;
using ezQ.Services.ViewModels;

namespace ezQ.Api.Controllers
{
    [RoutePrefix("api/clinic")]
    public class ClinicController : BaseApiController
    {
        private readonly IClinicApplicationService _clinicApplicationService;
        //private readonly IDoctorService _doctorService;

        public ClinicController(IClinicApplicationService clinicPatientService, IDoctorService doctorService)
        {
            _clinicApplicationService = clinicPatientService;
            //_doctorService = doctorService;
        }

        [Route("create")]
        public IHttpActionResult AddClinic(ClinicAddViewModel clinicModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _clinicApplicationService.AddClinic(clinicModel);
            }
            catch (Exception)
            {
                
                throw;
            }

            return Ok();
        }

        [Route("all")]
        public IHttpActionResult GetAllClinics()
        {
            

            return Ok();
        }

        [Route("addDoctor")]
        public IHttpActionResult AddDoctorToClinic(DoctorAddViewModel doctorModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _clinicApplicationService.AddDcotor(doctorModel);
            }
            catch (Exception)
            {

                throw;
            }

            return Ok();
        }
    }
}
