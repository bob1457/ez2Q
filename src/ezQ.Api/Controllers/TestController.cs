using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Mvc;
using System.Web.UI.WebControls;
using ezQ.Core.Services;



namespace ezQ.Api.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : BaseApiController
    {
        private readonly ITestService _testService;

        //public TestController()
        //{

        //}

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [Route("rate2")]
        public string Get()
        {
            //return "3.900000";

            //var rate = _testService.GetTaxRate();

            //return rate.ToString();

            return _testService.GetTaxRate();


        }

        [Route("act")]
        public string Act()
        {
            //return "3.900000";

            //var rate = _testService.GetTaxRate();

            //return rate.ToString();

            return _testService.GetActionDone();


        }

        [Route("act2")]
        public void Act2()
        {
            //return "3.900000";

            //var rate = _testService.GetTaxRate();

            //return rate.ToString();

             _testService.AppServiceAction();

            //return "All done!";
        }
    }
}
