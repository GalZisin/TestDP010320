using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test12
{
    public abstract class ComputerTemplateBase : TemplateComputerBuildRunner
    {
        protected override void AddGraphicsCard()
        {
            Console.WriteLine("Add Graphics Card...");
        }

        protected override void AddMemory()
        {
            Console.WriteLine("Add Memory...");
        }

        protected override void AddMotherBoard()
        {
            Console.WriteLine("Add Mother Board...");
        }

        protected override void AddProcessor()
        {
            Console.WriteLine("Add Processor...");
        }

        protected override void CreateEnclosure()
        {
            Console.WriteLine("Create Enclosure...");
        }

        protected override void RunExamination()
        {
            Console.WriteLine("Run Examination...");
        }
    }
}
