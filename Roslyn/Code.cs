using System;

public class Greeter
{
    public void SayHellp()
    {
        var message = "Hello, World!";
        PrintMessage(message);
    }

    private void PrintMessage(string message)
    {
        var length = message.Length;
        Console.WriteLine($"{message} {length}");
    }
}
