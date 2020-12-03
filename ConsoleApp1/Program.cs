using System;

namespace ConsoleApp1
{
    class Program
    {
        public Program(string nam, int age)
        {
            this.nam = nam;
            this.age = age;
        }

        public string nam { get; set; }
        public int age { get; set; }
        public virtual void work()
        {
            Console.WriteLine("Hello World....");
        }
    }

    internal class Employee : Program
    {
        public double salary { get; set; }
        public string designation { get; set; }
        public override void work()
        {
            Console.WriteLine("earns");
        }
    }
    class Person
    {
        static void main(string[] args)
        {
            Program p1 = new Employee();
            p1.work();
            p1 = new Employee();
            p1.work();
        }
    }
}
