namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int a = 17;
            //int b = 4;

            //int sum = a + b;
            //int product = a * b;
            //int difference = a - b;
            //int quotient = a / b;
            //int remainder = a % b;

            //Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            //Console.WriteLine($"{a} + {b} is {sum}");
            //Console.WriteLine($"{a} - {b} is {difference}");
            //Console.WriteLine($"{a} x {b} is {product}");

            Console.WriteLine("Enter in the radius of a circle. We will calculate the area: ");
            string userInput = Console.ReadLine();
            double parsedNumber = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(parsedNumber));
        }


        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
