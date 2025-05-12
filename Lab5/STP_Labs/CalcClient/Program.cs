using System;
using System.Globalization;
using CalcInterfaces;
using System.ServiceModel;

namespace CalcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<ICalcService> channel = new ChannelFactory<ICalcService>("CalcServiceEndpoint");
            ICalcService proxy = channel.CreateChannel();

            // Тестування Sum
            int sumResult = proxy.Sum(5, 4);
            Console.WriteLine($"Sum: {sumResult}");

            // Введення дати
            DateTime birthDate;
            Console.WriteLine("\nEnter birthday in following format dd.MM.yyyy (for example, 15.03.2000):");

            while (true)
            {
                string input = Console.ReadLine();
                if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
                {
                    break;
                }
                Console.WriteLine("Wrong format! Try again:");
            }

            // Отримання знаку зодіаку
            string zodiac = proxy.GetZodiacSign(birthDate);
            Console.WriteLine($"Zodiac sign: {zodiac}");

            Console.ReadLine();
        }
    }
}