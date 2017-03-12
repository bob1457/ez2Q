﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezQ.Core.Events
{
    public class DomainEventRecord
    {
        public string Type { get; set; }
        public List<KeyValuePair<string, string>> Args { get; set; }
        public string CorrelationID { get; set; }
        public DateTime Created { get; set; }
    }
}
