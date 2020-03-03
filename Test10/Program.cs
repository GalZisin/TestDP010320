using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test10
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindow baseWindow = new BaseWindow();
            IWindow backgroundFlashing = new BackgroundFlashing(baseWindow);
            IWindow _3dLightning = new _3dLightning(baseWindow);
            IWindow shading = new Shading(baseWindow);
            IWindow colorfullWindowFrame = new ColorfullWindowFrame(baseWindow);
            IWindow partialMirroring = new PartialMirroring(baseWindow);
    
            IWindow funnyWindow = new BackgroundFlashing(new ColorfullWindowFrame(new BaseWindow()));

            Console.WriteLine(funnyWindow.GetDetails());

            Console.WriteLine(baseWindow.GetDetails());
            Console.WriteLine(backgroundFlashing.GetDetails());
            Console.WriteLine(_3dLightning.GetDetails());
            Console.WriteLine(shading.GetDetails());
            Console.WriteLine(colorfullWindowFrame.GetDetails());
            Console.WriteLine(partialMirroring.GetDetails());


            Console.ReadLine();
        }
    }
}
