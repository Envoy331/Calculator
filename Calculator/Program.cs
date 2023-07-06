internal class Program
{
    private static void Main(string[] args)
    {
        // initializing two ints
        double num1 = 0;
        double num2 = 0;
        Console.WriteLine("Console calculator in C#\n");
        Console.WriteLine("------------------------");
        Console.WriteLine("Input your number");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input your second number");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input the operation that you want to do\n");
        Console.WriteLine("\ta -> Add");
        Console.WriteLine("\ts -> Substract");
        Console.WriteLine("\tm -> Multiply");
        Console.WriteLine("\td -> Divide");
        Console.Write("Your option ");
        switch (Console.ReadLine())
        {
            case "a":
                Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                break;
            case "s":
                Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                break;
            case "m":
                Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                break;
            case "d":
                while (num1 == 0)
                {
                    Console.WriteLine("Please input a non zero number: ");
                    num1 = Convert.ToInt32(Console.ReadLine()); 
                }
                while (num2 == 0)
                {
                    Console.WriteLine("Please input a non zero divisor: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                break;
    }
    }
}