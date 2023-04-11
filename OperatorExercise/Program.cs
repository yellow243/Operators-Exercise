using System.ComponentModel.DataAnnotations;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = 16;
           
             Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 % num2);
          
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }
            
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            
            var answer = AreaOfCircle(radius);
            Console.WriteLine(answer);

        }
        public static double AreaOfCircle(double radius)
        {
           return Math.PI* radius *radius;
        }
    }

    


}
