﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public interface IAnotherCarControl
    {
        string ShowFuelMode(Car c);
        string ShowLocation(Car c);
    }
}