using CalcInterfaces;
using System;

namespace CalcServer
{
    public class CalcService : ICalcService
    {
        public int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public string GetZodiacSign(DateTime birthDate)
        {
            int month = birthDate.Month;
            int day = birthDate.Day;

            switch (month)
            {
                case 1:  // Січень
                    return (day <= 19) ? "Capricorn" : "Aquarius";
                case 2:  // Лютий
                    return (day <= 18) ? "Aquarius" : "Pisces";
                case 3:  // Березень
                    return (day <= 20) ? "Pisces" : "Aries";
                case 4:  // Квітень
                    return (day <= 19) ? "Aries" : "Taurus";
                case 5:  // Травень
                    return (day <= 20) ? "Taurus" : "Gemini";
                case 6:  // Червень
                    return (day <= 20) ? "Gemini" : "Cancer";
                case 7:  // Липень
                    return (day <= 22) ? "Cancer" : "Leo";
                case 8:  // Серпень
                    return (day <= 22) ? "Leo" : "Virgo";
                case 9:  // Вересень
                    return (day <= 22) ? "Virgo" : "Libra";
                case 10: // Жовтень
                    return (day <= 22) ? "Libra" : "Scorpio";
                case 11: // Листопад
                    return (day <= 21) ? "Scorpio" : "Sagittarius";
                case 12: // Грудень
                    return (day <= 21) ? "Sagittarius" : "Capricorn";
                default:
                    return "Unknown sign"; // Невідомий знак
            }
        }
    }
}