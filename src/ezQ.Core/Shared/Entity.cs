﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezQ.Core.Shared
{
    public abstract class Entity
    {
        public virtual long Id { get; protected set; }
        
    }
}
