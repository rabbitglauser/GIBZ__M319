using System;
using System.ComponentModel.Design;

namespace learning_c
{
    class Program
    {
        private int i = 9;
        
        private Random random = new Random();

        static void Main(string[] args)
        {
            var p = new Program();
            
            p.DoIt();
            
            p.ShowRandomEssentialItem();
            
            p.Running2Am();
        }

        private void DoIt()
        {
            i++;
            string[] names = { "Dave", "Andre", "Jason", "Samuel" };
            
            int randomIndex = random.Next(names.Length);
            
            string randomName = names[randomIndex];
            
            Console.WriteLine("My name is " + randomName);
        }

        private void ShowRandomEssentialItem()
        {
            string[] essentialItems = { "phone", "water", "friends", "food" };
            
            int randomIndex = random.Next(essentialItems.Length);
            
            string essentialItem = essentialItems[randomIndex];
            
            Console.WriteLine("The thing I can't live without is " + essentialItem);
        }

        private void Running2Am()
        {
            Console.WriteLine("Have you tried running 2am yes or no?");

            string userInput = Console.ReadLine();

            if (string.Compare(userInput, "yes", true) == 0)
            {
                Console.WriteLine("its cool that you run at 2 Am");
            }
            else if(string.Compare(userInput, "no", true) == 0)
            {
                Console.WriteLine("maybe try to start running at 2 Am");
            }
            else
            {
                Console.WriteLine("Pls answer with a yes or a no");
            }
        }
    }
}