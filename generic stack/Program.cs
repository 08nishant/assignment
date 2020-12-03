using System;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        Stack<string> days = new Stack<string>();
        days.Push("mon");
        days.Push("tue");
        days.Push("thu");
        days.Push("fri");
        days.Push("sat");

        
        foreach (string day in days)
        {
            Console.WriteLine(day);
        }

        Console.WriteLine("\nPopping '{0}'", days.Pop());
        Console.WriteLine("Peek at next item to destack: {0}",
            days.Peek());
        Console.WriteLine("Popping '{0}'", days.Pop());

        
        Stack<string> stack2 = new Stack<string>(days.ToArray());

        Console.WriteLine("\nContents of the first copy:");
        foreach (string day in stack2)
        {
            Console.WriteLine(day);
        }

       
        string[] array2 = new string[days.Count * 2];
        days.CopyTo(array2, days.Count);

      
        Stack<string> stack3 = new Stack<string>(array2);

        Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
        foreach (string number in stack3)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
            stack2.Contains("four"));

        Console.WriteLine("\nstack2.Clear()");
        stack2.Clear();
        Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
        Console.ReadLine();
    }
}
