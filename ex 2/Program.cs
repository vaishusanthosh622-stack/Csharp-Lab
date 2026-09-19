using System;
class Person
{
    public string name;
    public int age;
    public void GetPersonDetails(string n, int a)
    {
        name = n;
        age = a;
    }
    public void DisplayPersonDetails()
    {
        Console.WriteLine("Person Details");
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age  : " + age);
    } }
class Student : Person
{
    public int rollNo;
    public string department;
    public void GetStudentDetails(int r, string d)
    {
        rollNo = r;
        department = d;
    }
    public void DisplayStudentDetails()
    {
        Console.WriteLine("Roll Number : " + rollNo);
        Console.WriteLine("Department  : " + department);
    } }
class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.GetPersonDetails("Vaishu", 20);
        s.GetStudentDetails(101, "Information Technology");
        s.DisplayPersonDetails();
        s.DisplayStudentDetails();
        Console.ReadLine();
    }
} 



