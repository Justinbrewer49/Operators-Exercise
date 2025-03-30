namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            int a = 17;
            int b = 4;
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($" {a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {difference}");
            Console.WriteLine($" {a} * {b} is {product}");
            Console.WriteLine($" {a} / {b} is {quotient}");
            Console.WriteLine($" {a} % {b} is {remainder};");

            AreaOfCircle();
        }

        static void AreaOfCircle()
        {
            double radius = 12;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");
        }
    }
}
