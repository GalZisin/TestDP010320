using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test10
{
    public class ColorfullWindowFrame: DecoratoBase
    {
        public ColorfullWindowFrame(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return this.window.GetDetails() + "Colorfull Window Frame";
        }
    }
}
