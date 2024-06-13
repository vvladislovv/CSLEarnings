using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLEarnings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Введите свой возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Добро пожайловать в нащ бар!");
                Console.WriteLine("Что будете пить?");
            }
            else
            {
                Console.WriteLine("Вы слишком малы");
                Console.WriteLine($"Приходите к нам через: {18 - age} лет!");
            }

        }
    }
}
