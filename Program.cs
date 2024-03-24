using System;

class Counter
{
    public static int Count { get; set; }

    public static void Increment()
    {
        Count++;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Initial count: " + Counter.Count); // Output: Initial count: 0

        Counter.Increment();
        Console.WriteLine("Count after increment: " + Counter.Count); // Output: Count after increment: 1

        Counter.Increment();
        Console.WriteLine("Count after second increment: " + Counter.Count); // Output: Count after second increment: 2
    }
}