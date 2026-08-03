using System;

public class Solution
{
    public string EvaluateExpression(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
            return "Error:InvalidExpression";

        string[] parts = expression.Split(' ');

        if (parts.Length != 3)
            return "Error:InvalidExpression";

        int a, b;

        if (!int.TryParse(parts[0], out a) || !int.TryParse(parts[2], out b))
            return "Error:InvalidNumber";

        string op = parts[1];

        switch (op)
        {
            case "+":
                return (a + b).ToString();

            case "-":
                return (a - b).ToString();

            case "*":
                return (a * b).ToString();

            case "/":
                if (b == 0)
                    return "Error:DivideByZero";

                return (a / b).ToString();

            default:
                return "Error:UnknownOperator";
        }
    }

    public static void Main()
    {
        Solution obj = new Solution();

        string expression = Console.ReadLine();

        Console.WriteLine(obj.EvaluateExpression(expression));
    }
}