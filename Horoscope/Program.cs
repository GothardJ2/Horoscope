using System;
using System.Security.Cryptography;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            string repeat = "Y";

            while (repeat == "Y")
            {
                Console.WriteLine("Select your sign by entering the number found in the \"[]\"");
                Console.WriteLine("[1] Aries");
                Console.WriteLine("[2] Taurus");
                Console.WriteLine("[3] Gemini");
                Console.WriteLine("[4] Cancer");
                Console.WriteLine("[5] Leo");
                Console.WriteLine("[6] Virgo");

                selection = int.Parse(Console.ReadLine());

                DisplayHoroscope(selection);
                Console.WriteLine();
                Console.WriteLine("Would you like to check another horoscope? Y/N");
                repeat = Console.ReadLine();
                repeat = repeat.ToUpper();
            }

            Console.WriteLine("You can now exit the program.");
         }

        static void  DisplayHoroscope(int choice)
        {
        switch (choice)
            {
                case 1 :
                    Console.WriteLine("Aries: ");
                    Console.Write("Today you should work to tune into the larger, slower-moving trends in your life, Aries.");
                    break;
                case 2 :
                    Console.WriteLine("Taurus: ");
                    Console.Write("Let your artistic nature loose today, Taurus");
                    break;
                case 3 :
                    Console.WriteLine("Gemini: ");
                    Console.Write("Don't gamble away your resources, Gemini.");
                    break;
                case 4 :
                    Console.WriteLine("Cancer: ");
                    Console.Write("Get things out in the open today, Cancer.");
                    break;
                case 5 :
                    Console.WriteLine("Leo: ");
                    Console.Write("Stick to the tried and true today, Leo.");
                    break;
                case 6:
                    Console.WriteLine("Virgo: ");
                    Console.Write("Reap all the riches that a new day has to offer, Virgo.");
                    break;
                default :
                    Console.WriteLine("Unknown entry.");
                    break;
            }
            return;
        }
    }
}
