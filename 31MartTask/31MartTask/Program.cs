using System;

namespace _31MartTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Group group = new Group((Type)0);
            Group group1 = new Group((Type)1);
            Group group2 = new Group((Type)1);
            Console.WriteLine(group1.No);
            Console.WriteLine(group2.No);
            Console.WriteLine(group.No);


        }
    }
}
