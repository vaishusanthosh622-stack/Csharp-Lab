using System;

class DataValidation
{
    static void Main()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        if (name == "")
            Console.WriteLine("Name is required.");
        else if (age < 18 || age > 60)
            Console.WriteLine("Age must be between 18 and 60.");
        else if (!email.Contains("@"))
            Console.WriteLine("Enter a valid email.");
        else
            Console.WriteLine("Data validation successful!");
    }
}
