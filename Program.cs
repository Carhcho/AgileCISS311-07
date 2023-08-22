using System;

namespace dropbox07
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Alice", 3.4);
            Student s2 = new Student("Bob", 3.4);
            Student s3 = new Student("Chuck", 3.4);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            s1.GPA = 3.5;
            s2.GPA = 3.4;
            s3.GPA = 3.3;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
