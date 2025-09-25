using System;
namespace Tumakov2
{
    enum Bank
    {
        Saving,
        Current
    }
    internal class Program
    {
        static void Main()
        {
            //Упр 3.1
            Bank now = Bank.Saving;
            Console.WriteLine(now);
        }
    }
}
