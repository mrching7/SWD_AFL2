using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract  class Object
    {
        public abstract void CrossStreet();

        public abstract int Location { set; get; }

        public abstract int State { get; }

    }
}
