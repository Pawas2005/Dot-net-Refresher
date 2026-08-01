using System;

public class program
{
    public static void SwapUsingRef(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a- b;
    }

    public static void SwapUsingOut(int a, int b, out int x, out int y)
    {
        a = a + b;
        b = a - b;
        a = a - b;

        x = a;
        y = b;
    }

     public static void Main()
    {
        int num1 = 10;
        int num2 = 20;

        Console.WriteLine("=====================================");

        Console.WriteLine("Before Swap (ref)");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        SwapUsingRef(ref num1, ref num2);

        Console.WriteLine("\nAfter Swap (ref)");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        Console.WriteLine("--------------------------------------");

        int a = 30;
        int b = 40;
        int x, y;

        Console.WriteLine("Before Swap (out)");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        SwapUsingOut(a, b, out x, out y);

        Console.WriteLine("\nAfter Swap (out)");
        Console.WriteLine("a = " + x);
        Console.WriteLine("b = " + y);
    }
}