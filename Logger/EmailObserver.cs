﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class EmailObserver : WritterOb
    {
        public override void Notify(Poruka p)
        {
            Console.WriteLine("Sent EMAIL-->");
            Console.WriteLine(p);
        }
    }
}
