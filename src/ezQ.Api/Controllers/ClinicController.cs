using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ezQ.Services.Interfaces;
using ezQ.Services.ViewModels;

namespace ezQ.Api.Controllers
{
    [RoutePrefix("api/clinic")]
    public class ClinicController : BaseApiController
    {
        private readonly IClinicApplicationService _clinicApplicationService;

        public ClinicController(IClinicApplicationService clinicPatientService)
        {
            _clinicApplicationService = clinicPatientService;
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
    }
}
