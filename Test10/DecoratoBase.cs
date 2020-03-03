using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test10
{
    public abstract class DecoratoBase : IWindow
    {
        protected IWindow window;
        public abstract string GetDetails();
        public DecoratoBase(IWindow window)
        {
            this.window = window;
        } 
    }
}
