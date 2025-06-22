using System;

class Program
{
    static void Main()
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("First log message");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("Second log message");

        Console.WriteLine(object.ReferenceEquals(logger1, logger2)
            ? "Both logger instances are the same (Singleton working)"
            : "Different instances (Singleton failed)");
    }
}
