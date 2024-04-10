using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    public class Task2
    {
        public async Task Run()
        {
            Console.WriteLine("Task 2");
            Queue<int> q1 = new Queue<int>();
            Queue<int> q2 = new Queue<int>();

            using (FileStream fs = new FileStream("task2read.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        int number = int.Parse(line);
                        if (number >= 0)
                            q1.Enqueue(number);
                        else
                            q2.Enqueue(number);
                    }
                }
            }
            Console.WriteLine(" >= 0");
            foreach (int num in q1)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.WriteLine(" < 0");
            foreach (int num in q2)
            {
                Console.Write(num + " ");
            }
        }
    }
}
