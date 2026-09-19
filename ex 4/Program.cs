using System;
public delegate void Notify();
class Publisher
{
 public event Notify OnMessage;
    public void SendMessage()
    {
        Console.WriteLine("Publisher: Event is raised.");
        if (OnMessage != null)
        {
            OnMessage();
        } } }
class Subscriber
{
    public void ShowMessage()
    {
        Console.WriteLine("Subscriber: Event received successfully.");
    } }
class Program
{
    static void Main(string[] args)
    {
 Publisher p = new Publisher();
        Subscriber s = new Subscriber();
        p.OnMessage += s.ShowMessage;
        p.SendMessage();
        Console.ReadLine();
  } }


