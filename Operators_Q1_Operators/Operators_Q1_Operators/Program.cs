using System;

class Program
{
    static void Main(string[] args)
    {
        //---------------------------------------------------------------------
        // Part 1: Sum of two numbers
        int num1 = 10, num2 = 5;
        Console.WriteLine("Sum: " + (num1 + num2));

        //---------------------------------------------------------------------
        // Part 2: Difference between two numbers
        Console.WriteLine("Difference: " + (num1 - num2));

        //---------------------------------------------------------------------
        // Part 3: Product of two numbers
        Console.WriteLine("Product: " + (num1 * num2));

        //---------------------------------------------------------------------
        // Part 4: Division of two numbers
        Console.WriteLine("Division: " + (num1 / num2));

        //---------------------------------------------------------------------
        // Part 5: Remainder of two numbers
        Console.WriteLine("Remainder: " + (num1 % num2));

        //---------------------------------------------------------------------
        // Part 6: Square of a number
        int num = 5;
        Console.WriteLine("Square: " + (num * num));

        //---------------------------------------------------------------------
        // Part 7: Average of two numbers
        Console.WriteLine("Average of two numbers: " + ((num1 + num2) / 2.0));

        //---------------------------------------------------------------------
        // Part 8: Average of three numbers
        int num3 = 30;
        Console.WriteLine("Average of three numbers: " + ((num1 + num2 + num3) / 3.0));

        //---------------------------------------------------------------------
        // Part 9: Convert Celsius to Fahrenheit
        double celsius = 20;
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Fahrenheit: " + fahrenheit);

        //---------------------------------------------------------------------
        // Part 10: Area of a rectangle
        double length = 10, width = 5;
        double area = length * width;
        Console.WriteLine("Area of Rectangle: " + area);

        //---------------------------------------------------------------------
        // Part 11: Volume of a sphere
        double radius = 5;
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine("Volume of Sphere: " + volume);

        //---------------------------------------------------------------------
        // Part 12: Factorial of a number
        int factorialNum = 5;
        int factorial = 1;
        for (int i = 1; i <= factorialNum; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("Factorial: " + factorial);

        //---------------------------------------------------------------------
        // Part 13: Compound interest
        double principal = 1000, rate = 0.05;
        int time = 5;
        double amount = principal * Math.Pow((1 + rate), time);
        Console.WriteLine("Compound Interest: " + amount);

        //---------------------------------------------------------------------
        // Part 14: Solve quadratic equation
        double a = 1, b = 5, c = 6;
        double discriminant = b * b - 4 * a * c;
        if (discriminant >= 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Roots: " + root1 + " and " + root2);
        }
        else
        {
            Console.WriteLine("No real roots.");
        }

        //---------------------------------------------------------------------
        // Part 15: Fibonacci using recursion
        int fibNum = 8;
        Console.WriteLine("Fibonacci number: " + Fibonacci(fibNum));

        //---------------------------------------------------------------------
        // Part 16: Arithmetic sequence nth term
        int firstTerm = 3, commonDifference = 2, termNumber = 5;
        int nthTerm = firstTerm + (termNumber - 1) * commonDifference;
        Console.WriteLine("Nth Term: " + nthTerm);

        //---------------------------------------------------------------------
        // Part 17: Relational Operators (Greater than check)
        Console.WriteLine("Is num1 greater than num2? " + (num1 > num2));

        //---------------------------------------------------------------------
        // Part 18: Relational Operators (Less than or equal to 100)
        Console.Write("Enter a number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Is the number less than or equal to 100? " + (inputNumber <= 100));

        //---------------------------------------------------------------------
        // Part 19: Logical Operators (Even and greater than 10)
        Console.Write("Enter a number: ");
        inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Is the number even and greater than 10? " + (inputNumber % 2 == 0 && inputNumber > 10));

        //---------------------------------------------------------------------
        // Part 20: Logical Operators (Divisible by 3 or 5)
        Console.Write("Enter a number: ");
        inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Is the number divisible by 3 or 5? " + (inputNumber % 3 == 0 || inputNumber % 5 == 0));

        //---------------------------------------------------------------------
        // Part 21: Initialization and Assignment (Increment by 5)
        Console.Write("Enter a number: ");
        inputNumber = int.Parse(Console.ReadLine());
        inputNumber += 5;
        Console.WriteLine("After incrementing by 5: " + inputNumber);

        //---------------------------------------------------------------------
        // Part 22: Modulus and update using %= operator
        int number = 27;
        number %= 7;
        Console.WriteLine("Remainder after dividing by 7: " + number);
    }

    // Helper method for Fibonacci (Part 15)
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}