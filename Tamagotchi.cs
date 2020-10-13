using System;
using System.Collections.Generic;
using System.Threading;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private int hunger = 0;
        private int boredom = 0;
        private List<string> words = new List<string>();
        private bool isAlive = true;
        private static Random random = new Random();

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
            Thread.Sleep(1000);

            while (isAlive == true)
            {
                System.Console.WriteLine("What do you want to do?");
                System.Console.WriteLine("1: Teach word\n2: Say hello\n3: Feed\n4: Do nothing");
                int.TryParse(Console.ReadLine(), out playerChoose);
                while (playerChoose != 1 && playerChoose != 2 && playerChoose != 3 && playerChoose != 4)
                {
                    System.Console.WriteLine("What do you want to do?");
                    System.Console.WriteLine("1: Teach word\n2: Say hello\n3: Feed\n4: Do nothing");
                    int.TryParse(Console.ReadLine(), out playerChoose);
                }

                if (playerChoose == 1)
                {
                    string[] wordList = {"word1", "word2", "word3", "word4", "word5"};
                    Teach(wordList[random.Next(4)]);
                }

                else if (playerChoose == 2)
                {
                    Hi();
                }

                else if (playerChoose == 3)
                {
                    Feed();
                }

                else if (playerChoose == 4)
                {
                    System.Console.WriteLine("You decided to do nothing...");
                }

                GetAlive();
                Tick();

                PrintStats();
                Console.Clear();
            }
        }

        public void Feed()
        {
            System.Console.WriteLine("Hunger decreases...");
            hunger -= 3;
            if (hunger < 0)
            {
                hunger = 0;
            }
        }

        public void Hi()
        {
            if (words.Count != 0)
            {
                System.Console.WriteLine(words[random.Next(words.Count)]);
                ReduceBoredom();
            }

            else
            {
                System.Console.WriteLine("The Tamagotchi doesn't know any words...\nLearn atleast 1 word before trying again");
            }
        }

        public void Teach(string word)
        {
            System.Console.WriteLine("You will now learn the word: " + word);

            words.Add(word);

            System.Console.WriteLine("\nThese are tha words that I now know:\n");
            //Kunde använt en for-loop, men hittade denna på Stack Overflow och kände "varför inte?"
            words.ForEach(i => Console.Write("{0}\n", i));

            Thread.Sleep(1500);
        }

        public void Tick()
        {
            System.Console.WriteLine("Hunger and boredom increases...");
            hunger++;
            boredom++;

            if (hunger >= 10 || boredom >= 10)
            {
                isAlive = false;
            }

            Thread.Sleep(2000);
        }

        public void PrintStats()
        {
            Console.Clear();
            System.Console.WriteLine("Current hunger: " + hunger);
            System.Console.WriteLine("Current boredom: " + boredom);

            if (isAlive == true)
            {
                System.Console.WriteLine("Tamagotchi is still alive...");
            }

            else
            {
                System.Console.WriteLine("Your Tamagotchi died\n\n\nRIP");
            }

            Thread.Sleep(1000);
        }

        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {
            System.Console.WriteLine("Boredom decreases...");
            boredom -= 3;
            if (boredom < 0)
            {
                boredom = 0;
            }
        }
    }
}
