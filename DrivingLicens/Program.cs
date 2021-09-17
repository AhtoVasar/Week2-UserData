using System;

namespace DrivingLicens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluba saada");

            }
            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhiluba saada");
            }
            else
            {
                Console.WriteLine("Palju õnne!!! Nüüd saad juhiluba taodelda");
            }
            Console.WriteLine("Kena päeva!");

        }
    }
}

