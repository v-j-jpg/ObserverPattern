using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public abstract class LogExtended : Log
    {
        public abstract void  PosaljiSMS(Poruka p);
        public abstract void PosaljiEmail(Poruka p);
        public abstract void PosaljiWCF(Poruka p);


    }
}
