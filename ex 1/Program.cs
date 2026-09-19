using System;
class Student
{
    public string name;
    public int rollNo;
    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Roll Number: " + rollNo);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.name = "Febina";
        s.rollNo = 623;
        Console.WriteLine("Student Details");
        Console.WriteLine("----------------");
        s.Display();
        Console.ReadLine();
    }
}

