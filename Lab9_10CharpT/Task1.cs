using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    public class Task1
    {
        public async Task Run()
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter string 1");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter string 2");
            string s2 = Console.ReadLine();
            Stack<char> stack = new Stack<char>(s1.ToCharArray());
            bool f = false;
            foreach (char c in s2)
            {
                if (c != stack.Pop())
                {
                    Console.WriteLine("String is not reversed");
                    f = true;
                    break;
                }
            }
            if (!f)
            {
                Console.WriteLine("String is reversed");
            }
        }
    }
}
