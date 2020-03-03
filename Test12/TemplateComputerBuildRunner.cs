using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test12
{
    public abstract class TemplateComputerBuildRunner
    {
           protected abstract void CreateEnclosure();
           protected abstract void AddMotherBoard();
           protected abstract void AddProcessor();
           protected abstract void AddGraphicsCard();
           protected abstract void AddMemory();
           protected abstract void RunExamination();

        public void Run()
        {
            CreateEnclosure();
            AddMotherBoard();
            AddProcessor();
            AddGraphicsCard();
            AddMemory();
            RunExamination();
        }
    }
}
