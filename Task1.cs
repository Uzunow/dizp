
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Изберете опция:");
        Console.WriteLine("1 - От десетична в друга бройна система");
        Console.WriteLine("2 - От друга бройна система в десетична");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Въведете десетично число: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            Console.Write("Въведете основа на новата бройна система (2 до 16): ");
            int baseTo = int.Parse(Console.ReadLine());

            string result = Convert.ToString(decimalNumber, baseTo).ToUpper();
            Console.WriteLine($"Резултат: {result}");
        }
        else if (choice == 2)
        {
            Console.Write("Въведете число: ");
            string number = Console.ReadLine();

            Console.Write("Въведете основа на бройната система (2 до 16): ");
            int baseFrom = int.Parse(Console.ReadLine());

            int result = Convert.ToInt32(number, baseFrom);
            Console.WriteLine($"Резултат в десетична: {result}");
        }
        else
        {
            Console.WriteLine("Невалиден избор.");
        }

        Console.WriteLine("Натиснете Enter за изход...");
        Console.ReadLine();
    }
}
