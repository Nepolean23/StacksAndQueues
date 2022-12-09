using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class UC_2_AbilityToPeakAndPopOperation
    {
        private Node Top;
        internal void peek()
        {
            if(this.Top==null)
            {
                Console.WriteLine("The Stack is Empty");
                return;

            }
            Console.WriteLine("{0} is in the top of the stack", this.Top.next);
        }

        internal void pop() 
        {
            if(Top==null)
            {
                Console.WriteLine("Stack is empty,Deletion is not possible");
                return;

            }
            Console.WriteLine("Value popped is {0}", this.Top.data);
            this.Top=this.Top.next
        }
        
        internal void IsEmpty()
        {
            while(this.Top!=null) 
            {
                peek();
                pop();
            }
        }
    }
}
