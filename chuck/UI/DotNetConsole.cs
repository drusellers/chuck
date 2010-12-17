namespace chuck.UI
{
    using System;

    public class DotNetConsole :
        Console
    {
        public void Write(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Write(string message, ConsoleColor color)
        {
            var currentColor = System.Console.ForegroundColor;

            System.Console.ForegroundColor = color;
            System.Console.WriteLine(message);

            System.Console.ForegroundColor = currentColor;
        }
    }
}