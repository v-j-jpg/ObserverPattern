using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class SMSObserver : WritterOb
    {
        public override void Notify(Poruka p)
        {
            Console.WriteLine("Sent SMS-->");
            Console.WriteLine(p);
        }
    }
}
