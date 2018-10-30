using System;

namespace PiToNDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pi = Math.PI;
            string number;
            do
            {
                Console.WriteLine("Find Pi to Nth Digit");
                Console.WriteLine("Insert how many digits there should be: ");
                number = Console.ReadLine();
            } while (IsDigits(number) == false);

            Console.WriteLine(Math.Round(Pi, Convert.ToInt16(number)));
            Console.ReadKey(true);
            
        }
        public static bool IsDigits(string number)
        {
            for (var index = 0; index < number.Length; index++)
            {
                char a = number[index];
                if (a < '0' || a > '9')
                    return false;
            }

            return true;
        }
    }

}
