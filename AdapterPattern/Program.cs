﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.PatternCode;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerAdapter powerAdapter = new PowerAdapter();

            var result = powerAdapter.ThreePinMethod();
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}