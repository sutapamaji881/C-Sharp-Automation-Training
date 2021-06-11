using System;

public class Program
{
    public static void Main(string[] args)
    {
        int a = 10;
        double b = 20.5;
        Console.WriteLine("Enter the operator");
        string sign = Console.ReadLine();


        Calculator cal = new Calculator();
        switch (sign)
        {
            case "+":
                Console.WriteLine("Result of Addition " + cal.Addition(a, b));
                break;
            case "-":
                Console.WriteLine("Result of Subtraction" + cal.Subtraction(a, b));
                break;
            case "*":
                Console.WriteLine("Result of Multiplication" + cal.Multiplication(a, b));
                break;
            case "/":
                double[] ans = cal.Division(a, b);
                Console.WriteLine("Result of Division" + ans[0]);
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }

}
internal class Calculator
{
    public double Addition(int a, double b)
    {
        return a + b;
    }
    public double Subtraction(int a, double b)
    {
        return a - b;
    }
    public double Multiplication(int a, double b)
    {
        return a * b;
    }
    public double[] Division(int a, double b)
    {
        return new double[] { a / b, a % b };
    }
}

