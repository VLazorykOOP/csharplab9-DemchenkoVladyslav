using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    public class Task3
    {
        public async Task Run()
        {
            Console.WriteLine("Task 3");
            Console.WriteLine("Enter string 1");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter string 2");
            string s2 = Console.ReadLine();
            ArrayList al1 = new ArrayList(s1.ToCharArray());
            ArrayList al2 = new ArrayList(s2.ToCharArray());
            al1.Reverse();
            bool f = false;
            for (int i = 0; i < al1.Count && i < al2.Count; i++)
            {
                if (!(al1[i] == al2[i]))
                {
                    f = true;
                    break;
                }
            }
            if (!f)
            {
                Console.WriteLine("String is reversed");
            }
            else
                Console.WriteLine("String is not reversed");

            ArrayList q1 = new ArrayList();
            ArrayList q2 = new ArrayList();

            using (FileStream fs = new FileStream("task3read.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        int number = int.Parse(line);
                        if (number >= 0)
                            q1.Add(number);
                        else
                            q2.Add(number);
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
