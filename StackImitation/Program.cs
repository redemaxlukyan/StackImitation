using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImitation
{
    class StackImitation
    {
        private int[] stack;
        private int topIndex;

        public StackImitation(int size)
        {
            stack = new int[size];
            topIndex = 0;
        }

        public void SetNum(int num)
        {
            if (topIndex == stack.Length)
            {
                Console.WriteLine("Стек заповнено.");
                return;
            }

            stack[topIndex] = num;
            topIndex++;
        }

        public int GetNum()
        {
            if (topIndex == 0)
            {
                Console.WriteLine("Стек порожній.");
                return 0;
            }

            topIndex--;
            return stack[topIndex];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
