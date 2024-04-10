//Console.WriteLine("Task 1");
//string s1 = Console.ReadLine();
//string s2 = Console.ReadLine();
//Stack<char> stack = new Stack<char>(s1.ToCharArray());
//bool f = false;
//foreach (char c in s2)
//{
//    if (c != stack.Pop())
//    {
//        Console.WriteLine("String is not reversed");
//        f = true;
//        break;
//    }
//}
//if (!f)
//{
//    Console.WriteLine("String is reversed");
//}



//Console.WriteLine("Task 2");
//Queue<int> q1 = new Queue<int>();
//Queue<int> q2 = new Queue<int>();

//using (FileStream fs = new FileStream("task2read.txt", FileMode.Open))
//{
//    using (StreamReader sr = new StreamReader(fs))
//    {
//        string line;
//        while ((line = sr.ReadLine()) != null)
//        {
//            int number = int.Parse(line);
//            if (number >= 0)
//                q1.Enqueue(number);
//            else
//                q2.Enqueue(number);
//        }
//    }
//}
//Console.WriteLine(" >= 0");
//foreach (int num in q1)
//{
//    Console.Write(num + " ");
//}

//Console.WriteLine();
//Console.WriteLine(" < 0");
//foreach (int num in q2)
//{
//    Console.Write(num + " ");
//}

Console.WriteLine("Task 3");
string s1 = Console.ReadLine();
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