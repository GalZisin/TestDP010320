using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test14_2
{
    public class MyStack
    {
        public Stack<StackInstance> s = new Stack<StackInstance>();
  
        public int maxElement = 0;
        public int minElement = 0;
        public void GetMax()
        {
            if(s.Count == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine($"Max element is: {maxElement}");
            }  
        }
        public void GetMin()
        {
            if (s.Count == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else if(s.Count == 1)
            {
                Console.WriteLine($"Min and Max are equals");
            }
            else
            {
                Console.WriteLine($"Min element is: {minElement}");
            }
        }
        public void Peek()
        {
            if(s.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            int t = s.Peek().currentNum;
            Console.WriteLine($"Top most element is: {t}");
         
        }
        public void Pop()
        {
            if (s.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            
            StackInstance t = s.Peek();
            maxElement = t.previousMax;
            minElement = t.previousMin;
            Console.WriteLine($"Top Most Element Removed: {t.currentNum}");
            s.Pop();

            GetMax();
            GetMin();
       
        }
        // Removes top element from MyStack  
        public void push(int x)
        {
            StackInstance ss = null;
            // Insert new number into the stack  
            if (s.Count == 0)
            {
                ss = new StackInstance { currentNum = x, previousMax = 0, previousMin = 0};
                maxElement = x;
                minElement = x;
                s.Push(ss);
                Console.WriteLine($"Number Inserted: {x}");
                GetMax();
                GetMin();
                return;
            }
            ss = new StackInstance { currentNum = x, previousMax = maxElement, previousMin = minElement };
            // If new number is less than maxEle  
            if (x > maxElement)
            {
                maxElement = x;
            }
            else if (x < minElement)
                minElement = x;

                s.Push(ss);

            Console.WriteLine($"Number Inserted: {x}");
            GetMax();
            GetMin();
        }
    }
}
