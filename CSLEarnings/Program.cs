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
            float Health;
            int armor;
            int damage;
            int precentConvert = 100;

            Console.Write("Введите количество здоровья: ");
            Health = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество брони: ");
            armor = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите количество урона: ");
            damage = Convert.ToInt32(Console.ReadLine());

            Health -= Convert.ToSingle(damage) / precentConvert * armor;

            Console.WriteLine($"Вам нанесли {damage} урона. У нас осталось {Health} здоровья.");
        }
    }
}
