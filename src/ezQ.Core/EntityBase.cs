using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezQ.Core
{
    public abstract class EntityBase<T>
    {
        public T Id { get; set; }
    }
}
