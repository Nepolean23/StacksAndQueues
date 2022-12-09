using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class UC_1_AbilityToCreateAStack
    {
        private Node Top;

        public  UC_1_AbilityToCreateAStack()
        {
            this.Top = null;
        }
        
        internal void Push(int value)
        {
            Node Node = new Node(value);
            if (this.Top == null)
                Node.next = null;
            else
                Node.next = this.Top;
                this.Top=Node;
            Console.WriteLine("{0} pushed to stack" +value);
        }
        internal void display()
        {
            Node temp = this.Top;
            while(temp!= null ) 
            {
                Console.WriteLine(temp.data+ "");
                temp = temp.next;
            }
        }
        
            
        
    }
}
