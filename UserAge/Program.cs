using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun, sisesta oma vanus");
            int age = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2021 - age;

            Console.WriteLine($"Oled sündinud aastal {yearOfBirth} ");

        }
    }
}
