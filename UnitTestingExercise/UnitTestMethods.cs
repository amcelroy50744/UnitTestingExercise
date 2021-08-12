using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add(int one, int two, int three)
        {
            return one + two + three;
        }

        // Create a Subtract method that passes 2 integers
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        // Keep track of which number is getting passed as minuend and subtrahend

        // Create a Multiply method that passes 2 integers
        public int Multiply(int c, int d)
        {
            return c * d;
        }


        // Create a Divide method that passes 2 integers
        public int Divide(int e, int f)
        {
            return e / f;
        }



        // Create 2 methods that will utilize the [Fact] tests you
        public double Bmi(double g, double h)
        {
            return g / (h * h);
        }

        public int Sqr(int i)
        {
            return i * i;
        }

        public int Add10()
        {
            return 10; 
        }

        public string Message()
        {
            return "Good Morning";
        }

        
    }
}
