using System;

namespace UnitTestingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give one number!");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give another number!");
            int secondnum = Convert.ToInt32(Console.ReadLine());
            var coolmultipy = new UnitTestMethods();
            var answer = coolmultipy.Multiply(firstnum, secondnum);
            Console.WriteLine($"Here is your answer: {answer}");
            
        }
    }
}
