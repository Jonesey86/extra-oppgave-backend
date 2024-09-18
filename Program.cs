using System.ComponentModel;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        SomeName calculator = new SomeName();
        Console.WriteLine(calculator.Add(5, 5));
        Console.WriteLine(calculator.Subtract(5, 3));

        Console.WriteLine("enter the first number");
        int addA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter the second number");
        int addB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(calculator.Add(addA, addB));

        // extra oppgave


        Console.WriteLine("enter a value(number)");
        int numA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter a symbol)");
        string? symbol = Console.ReadLine();
        Console.WriteLine("enter a value(number)");
        int numB = Convert.ToInt32(Console.ReadLine());

        switch (symbol)
        {
            case "+":
                Console.WriteLine(calculator.Add(numA, numB));
                break;
            case "-":
                Console.WriteLine(calculator.Subtract(numA, numB));
                break;
            case "/":    
                Console.WriteLine(calculator.Divide(numA, numB));
                break;
            case "*":   
                Console.WriteLine(calculator.Multiply(numA, numB));
                break;

        }
    }
}









    

    
