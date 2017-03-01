using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ezQ.Core.Entities;

namespace ezQ.Core.Services
{
    public class TestService : ITestService
    {
        public string GetTaxRate()
        {
            return "9.999";
        }


        public string GetActionDone()
        {
            //throw new NotImplementedException();

            var test = new TestEntity();

            return test.ActionOne();
        }


        public void AppServiceAction()
        {
            throw new NotImplementedException();
        }
    }
}
