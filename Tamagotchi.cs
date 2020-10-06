using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private int hunger = 0;
        private int boredom = 0;
        private List<string> words = new List<string>();
        private bool isAlive = true;
        private Random random = new Random();

        public string name;

        private int playerChoose = 0;

        public Tamagotchi()
        {
            System.Console.WriteLine("Hello!\nWhat should I be called?");
            string tamagotchiname = Console.ReadLine().Trim();
            while (tamagotchiname == "")
            {
                System.Console.WriteLine("Please give me name!");
                tamagotchiname = Console.ReadLine().Trim();
            }
            Console.Clear();
            System.Console.WriteLine("Thank you, my name is now: " + tamagotchiname + "\n\n");

            while (isAlive == true)
            {
                if (true)
                {
                    
                }
                System.Console.WriteLine("What do you want to do?");
                System.Console.WriteLine("1: Teach word\n2: Say hello\n3: Feed\n4: Do nothing");
                int.TryParse(Console.ReadLine(), out playerChoose);
                while (playerChoose != 1 && playerChoose != 2 && playerChoose != 3 && playerChoose != 4)
                {
                    System.Console.WriteLine("works");
                    System.Console.WriteLine("What do you want to do?");
                    System.Console.WriteLine("1: Teach word\n2: Say hello\n3: Feed\n4: Do nothing");
                    int.TryParse(Console.ReadLine(), out playerChoose);
                }

                if (playerChoose == 1)
                {

                }

                if (playerChoose == 2)
                {
                    Hi();
                }

                if (playerChoose == 3)
                {
                    Feed();
                }

                else
                {

                }
            }

            System.Console.WriteLine("Your Tamagotchi died\n\n\nRIP");
        }

        public void Feed()
        {
            hunger -= 3;
        }

        public void Hi()
        {
            
        }

        public void Teach(string words)
        {

        }

        public void Tick()
        {
            hunger++;
            boredom++;

            if (hunger >= 10 && boredom >= 10)
            {
                isAlive = false;
            }
        }

        public void PrintStats()
        {

        }

        public void GetAlive()
        {

        }

        private void ReduceBoredom()
        {
            boredom -= 3;
        }
    }
}
