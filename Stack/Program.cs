using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{

    public class stack
    {
        int[] stackArray;
        int top, max;
        public stack(int size)
        {
            this.stackArray = new int[size];
            this.top = -1;
            this.max = size;
        }
        public void push(int num)
        {
            if(this.top == this.max-1)
            {
                Console.WriteLine("Maximum Size reached");
            }
            else
            {
                top++;
                stackArray[top] = num;
            }
        }
        public void pop()
        {
            if(this.top == -1)
            {
                Console.WriteLine("No elements");

            }
            else
            {
                Console.WriteLine("{0} Popped from stack", this.stackArray[top]);
                top--;
            }
        }
        public void print()
        {
            int i ;
            for(i=0;i<=top;i++)
            {
                Console.WriteLine(this.stackArray[i]);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            stack One = new stack(3);
            One.push(1);
            One.push(2);
            One.push(3);
            One.push(4);
            One.print();
            One.pop();
            One.pop();
            One.pop();
            One.pop();
            One.print();

                
        }
    }
}
