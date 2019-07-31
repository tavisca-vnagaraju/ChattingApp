using System;

namespace ChattingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ChatApp chatApp = new ChatApp();
            chatApp.Start();
            Console.ReadKey();
        }
    }
}
