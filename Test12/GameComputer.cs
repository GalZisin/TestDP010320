using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test12
{
    public class GameComputer : ComputerTemplateBase
    {
        protected override void AddGraphicsCard()
        {
            Console.WriteLine("Add Strong Graphics Card...");
        }

        protected override void AddMemory()
        {
            Console.WriteLine("Add A lot of Memory...");
        }

        protected override void AddMotherBoard()
        {
            Console.WriteLine("Add A lot of Memory...");
        }

        protected override void AddProcessor()
        {
            base.AddProcessor();
        }

        protected override void CreateEnclosure()
        {
            base.CreateEnclosure();
        }
    }
}
