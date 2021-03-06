﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test10
{
    public class PartialMirroring : DecoratoBase
    {
        public PartialMirroring(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return this.window.GetDetails() + "Partial Mirroring";
        }
    }
}
