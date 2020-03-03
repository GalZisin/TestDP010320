using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test10
{
    public class BaseWindow :IWindow
    {
        public string GetDetails()
        {
            return "Window frame";

        }
    }
}
