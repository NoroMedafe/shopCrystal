﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopCrystal
{
    class Program
    {
        static void Main(string[] args)
        {
            int userGold = 0;
            int userCrystal= 0;
            int costCrystal = 2;
            int purchasedСrystals;
           
            Console.Write("Сколько у вас золота? "); userGold = Convert.ToInt32(Console.ReadLine());
            while (userGold > 0)
            {
                Console.Write("Сколько кристаллов хотите купить? Цена кристала " + costCrystal + " золотых: "); purchasedСrystals = Convert.ToInt32(Console.ReadLine());

                userGold -= purchasedСrystals * costCrystal;
                userCrystal += purchasedСrystals;

                Console.WriteLine("Ваш баланс:" + "\n" + "Осталось золота:" + userGold + " Имеется кристалов:" + userCrystal);
            }
            Console.WriteLine("Торги прекращены. У вас закончилось золото или у вас появился долг");
            Console.ReadKey();
        }
    }
}
