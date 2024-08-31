//    What is your name?
//    What are three things you can’t live without? (Save in a list)
//    Have you ever tried running at 2 AM? (Yes/No)
//    What is your height in meters? (e.g., 1.75)
//    What is your spirit animal? (It could be anything, from a lion to a toaster.)
//    If you could have any superpower, what would it be?
//    How many hours of sleep do you usually get per night?
//    On a scale of 1 to 10, how would you rate your dancing skills? (Use decimals if needed)
//    What is the strangest food you've ever eaten?
//    If you were a fruit, which one would you be and why?
//    How many cups of coffee (or tea) do you drink in a day? (Enter a number)
//    What is your favorite meme or funny saying?
//    What is one thing you are ridiculously good at that nobody knows about?
//    If you could time travel, which period of history would you visit and why?
//    What's your go-to dance move at a party?
//    If you could swap lives with a fictional character for a day, who would it be?
//    What is your favorite movie or TV show to rewatch over and over again?
//    If you could live in any fictional universe, which one would you choose?
//    What’s your guilty pleasure snack?
//    If you were a superhero, what would your theme song be?
//    What is the weirdest dream you’ve ever had?
//    What’s a fun fact about you that most people don’t know?
//    If you could talk to animals, what would be the first question you’d ask them?
//    What is your favorite childhood memory?
//    If you could only eat one food for the rest of your life, what would it be?

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
            
            p.HeightGenerator();
            
            p.AnimalSpirit();
            
            p.SleepHours();
            
            p.DancingSkill();
            
            p.StrongestFood();
            
            p.typeFruit();
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
            Console.WriteLine("Have you tried running at 2am yes or no?");

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
        private void HeightGenerator()
        {
            double[] heights = new double[] { 1.98, 1.7, 1.6, 1.5, 1.4, 1.3, 1.2, 1.1 };
    
            int randomIndex = random.Next(heights.Length);
    
            double randomHeight = heights[randomIndex];
    
            Console.WriteLine("My height is " + randomHeight + " meters");
        }
        
        private void AnimalSpirit()
        {
            string[] listofAnimalsSpirits = { "Dog", "Cat", "Fish" };
    
            int randomIndex = random.Next(listofAnimalsSpirits.Length);
    
            string animalSpirit = listofAnimalsSpirits[randomIndex];
    
            Console.WriteLine("This is your spirit animal: " + animalSpirit);
        }

        private void SleepHours()
        {
            int randomIndex = random.Next(minValue:5, maxValue:10);
            
            Console.WriteLine("I am sleeping " + randomIndex + "hours per day");
        }

        private void DancingSkill()
        {
            int randomindex = random.Next(minValue:0, maxValue:10);
            
            Console.WriteLine("My dancing skill is " + randomindex + "/10");
        }

        private void StrongestFood()
        {
            string[] listStrongestFood = { "Vindaloo", "Cau Cau", "Phaal Curry" };
            
            Console.WriteLine("the spiciest food is" + listStrongestFood);
        }

        private void typeFruit()
        {
            string[] listFruit = { "Apple", "Orange", "Banana", "Pineapple" };
            
            Console.WriteLine("This is what type of Fruit i would be" + listFruit);
        }
    }
}