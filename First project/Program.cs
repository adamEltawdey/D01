
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your favotite number");
        int yourNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("really  " + yourNum + "is my favorite number");

    }
}