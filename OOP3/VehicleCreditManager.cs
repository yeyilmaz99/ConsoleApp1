﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("taşıt kredisi ödeme planı hesaplandı");
        }

        public void DoSomeThing()
        {
            throw new NotImplementedException();
        }
    }
}
