﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ezQ.Core.Services;


namespace ezQ.Services
{
    public class TestService : ITestService
    {

        public string GetTaxRate()
        {
            return "3.9999";
        }
    }
}
