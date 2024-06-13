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
            int money;
            int food;
            int foodCostPrice = 10;
            bool isAbleToPay;

            Console.WriteLine($"Welcome in pecarnia! Today eat by {foodCostPrice} money.");
            Console.Write("How many money do you have?");
            money = Convert.ToInt32(Console.ReadLine());

            Console.Write("How much food do you need?");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= food * foodCostPrice;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food * foodCostPrice;
            Console.WriteLine($"In your bag {food} food units, and {money} money.");


        }
    }
}
