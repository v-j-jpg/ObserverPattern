using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
   public abstract class WritterOb
    {
        public WritterOb() { }

        public abstract void Notify(Poruka p);

    }
}
