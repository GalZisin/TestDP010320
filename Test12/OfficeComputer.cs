using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test12
{
    public class OfficeComputer : ComputerTemplateBase
    {
        protected override void AddGraphicsCard()
        {
            Console.WriteLine("Add Medium Graphics Card...");
        }

        protected override void AddMemory()
        {
            Console.WriteLine("Add Medium Memory...");
        }

        protected override void AddMotherBoard()
        {
            Console.WriteLine("Add Medium Mother Board...");
        }

        protected override void AddProcessor()
        {
            Console.WriteLine("Add Medium Processor...");
        }

        protected override void CreateEnclosure()
        {
            Console.WriteLine("Add Medium Enclosure...");
        }
    }
}
