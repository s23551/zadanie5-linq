using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task7();
            foreach (var item in t)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
