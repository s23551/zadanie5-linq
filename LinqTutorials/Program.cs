using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task2();
            foreach (var emp in t)
            {
                Console.WriteLine(emp.Ename + " " + emp.Job + " " + emp.Salary);
            }

        }
    }
}
