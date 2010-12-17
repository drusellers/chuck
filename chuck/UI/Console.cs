namespace chuck.UI
{
    using System;

    public interface Console
    {
        void Write(string message);
        void Write(string message, ConsoleColor color);
    }
}