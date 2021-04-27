using System.Security;
using System;
using System.Collections.Generic;

namespace Slutprojekt_Prog2
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player();
            
            //Lista för att skapa motståndare
            List<Character> EnemyList = new List<Character>();
            //Lägger till instans av motståndare i listan.
            EnemyList.Add(new Opponent());



            ShowStats(player);
            Console.ReadLine();
        }

        //metod för att visa spelaren stats
        public static void ShowStats(Player spelare)
        {
            spelare.ShowStats();

        }
    }
}
