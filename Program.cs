using System;
using System.Collections.Generic;
using System.Threading;
namespace Assignment21
{
    class Program
    {
        static List<string> fruits = new List<string> { "Mango","WaterMelon","Guava","PineApple","Grapes","Apple","Cherri","JackFruit","Papaya","Orange","Banana","DragonFruit" };
        static List<string> days = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        static List<string> months = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        static Dictionary<string, string> words = new Dictionary<string, string>
            {
                { "McDonald's", "I'm Lovin' it" },
                { "KFC", "Finger lickin' good" },
                { "Coca Cola", "Taste the Feeling" },
                { "Kit Kat", "Have a break, Have a Kit Kat" },
                { "Parle-G", "G for Genius" }
            };
        public static void Days()
        {
            Console.WriteLine("Welcome to Learning---");
            Console.WriteLine("Displaying Days:");
            foreach (var day in days)
            {
                Console.WriteLine(day);
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
        public static void Months()
        {
            Thread.Sleep(5000); 
            Console.WriteLine("Displaying Months:");
            foreach (var month in months)
            {
                Console.WriteLine(month);
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
        public static void Fruits()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Displaying Fruits:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();
        }
        public static void Words()
        {
            Thread.Sleep(15000); 
            Console.WriteLine("Displaying Words and Meanings:");
            foreach (var dic in words)
            {
                Console.WriteLine($"{dic.Key}: {dic.Value}");
            }
            Console.WriteLine();
        }
    static void Main(string[] args)
        {
            Thread daysThread = new Thread(Days);
            Thread monthsThread = new Thread(Months);
            Thread fruitsThread = new Thread(Fruits);
            Thread wordsThread = new Thread(Words);

            daysThread.Start();
            monthsThread.Start();
            fruitsThread.Start();
            wordsThread.Start();

            daysThread.Join();
            monthsThread.Join();
            fruitsThread.Join();
            wordsThread.Join();

            Console.WriteLine("Program execution finished.");
        }
    }
}

