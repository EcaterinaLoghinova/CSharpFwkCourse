﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobilePhone = new SimCorpMobile();
            Console.WriteLine(mobilePhone);
            Console.ReadKey();
        }
    }
}
