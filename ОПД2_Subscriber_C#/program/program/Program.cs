using program;
using System.Globalization;
using System.Text.RegularExpressions;


class Program
{
    public static void Main()
    {
        int ms;
        var Timer = new CountDown();
        //Console.WriteLine("Введите имя");
        //string NameSub = Console.ReadLine();
        var firstSubscriber = new Subscriber1(Timer, "Ivan");
        var secondSubscriber = new Subscriber2(Timer, "Kate");

        Console.WriteLine("Enter delay in milliseconds:");
        while (!int.TryParse(Console.ReadLine(), out ms))
        {
        }

        Timer.Timer(ms, "Hello!");
        Timer.Timer(1000, "3 seconds left");
        Timer.Timer(1000, "2 seconds left");
        Timer.Timer(1000, "1 seconds left");
        Timer.Timer(1000, "Cabooom");

    }
}