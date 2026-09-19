using System;

class Number
{
    int x, y;

    public Number(int a, int b) { x = a; y = b; }

    public static Number operator +(Number a, Number b)
    {
        return new Number(a.x + b.x, a.y + b.y);
    }

    public void Show()
    {
        Console.WriteLine("X Value : " + x);

        Console.WriteLine("Y Value : " + y);
    }

    static void Main()
    {
        Number n1 = new Number(10, 20);

        Number n2 = new Number(30, 40);

        Number n3 = n1 + n2;

        Console.WriteLine("First Object");

        n1.Show();

        Console.WriteLine("\nSecond Object");

        n2.Show();

        Console.WriteLine("\nResult After Operator Overloading");

        n3.Show();

        Console.ReadLine();
    }
}





