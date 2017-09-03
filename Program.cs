using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            stack test = new stack(10);
            test.push(5);
            test.push(6);
            test.pop();
            test.peek();
            stack other = new Stack.stack(5);
            other.push(1);
            other.push(2);
            other.push(500);
            Console.WriteLine(other.pop()+" has been popped");
            other.push(3);
            other.push(4);
            other.push(5);
            other.push(6);
            other.peek();
            Console.ReadLine();
        }
    }
    class stack
    {
        private int[] array;
        private int pointer;

        public stack(int size)
        {
            this.array = new int[size];
            this.pointer = -1;
        }
        public void push(int n)
        {
            if (pointer == array.Length-1)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                array[pointer+1] = n;
                pointer += 1;
            }
        }
        public void peek()
        {
            for (int i = 0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public int pop()
        {
            if (pointer == -1)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                int temp = array[pointer];
                array[pointer] = 0;
                pointer -= 1;
                return temp;
            }
        }
    }
}