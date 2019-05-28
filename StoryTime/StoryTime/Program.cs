using System;

namespace StoryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THE END IS NEAR!");
            Console.WriteLine("WHAT WILL YOU DO NOW?");
            Console.WriteLine("ARE YOU FIT TO SURVIVE?");
            Console.ReadLine();
            Console.WriteLine("What is your name? Kim Possible or Ron Stoppable");
            Console.Write("Name: ");
           
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}", name);

            if (name == "Kim Possible")
            {
                Console.WriteLine("Wise choice, you are more likely to survive. Your enemies are no longer Shego and Dr.Drakken since they are already gone. Your adversaries are now the zombies surrounding you at this very moment, your only allies are your family, that you've kept safe for this long, and Ron Stoppable along with Rufus.");
            }
            else if (name == "Ron Stoppable")
            { 
                Console.WriteLine("You have no reason to fear, with the help of Kim you've been able to survive this long. You must now defeat the zombies around you and rely on each other to do so. Luckily Rufus is able to tell when there are zombies near by, unfortunately you are not sure if he is immune to the zombie infection or not...");
            }
            else
            {
                Console.WriteLine("You have died!");
                Console.WriteLine("Just Kidding, you are now the maker of your own destiny. Do you have allies? Do you have enemies beyond the zombies? Do you have to go to the bathroom but can't because it is occupied by zombies? Well we're about to find out...");
            }

            Console.WriteLine("You are currently in your old high school that has been a save haven, unfortunately you have run out of food because there's quite a number of people you have saved and brought in. Since food sources are limited, you must go out and seek nourishment");
            Console.WriteLine("Will you leave your save haven and risk your life to bring back food or will you let everyone slowly but surely starve to death?");
            Console.WriteLine("Choose one: 'Bring Food' or ''Ignore the needs of others");
            Console.Write("Choice:");
            string choice = Console.ReadLine();
             if ( choice == "Bring Food")
            {
                Console.WriteLine("You are a soul with a kind heart and full of bravery, Your allies have volunteered to come along with you. You have many assets that will make your adventure a success, Luckily Rufus can detect wether or not there are zombies near by. Just don't get him too close or he could be infected.");

            }else if ( choice == "Ignore the needs of others")
            {
                Console.WriteLine("It's quite the achievement you've made it this far in this zombie out break. Without food or water you will die and withouth the support of your allies (since you let them starve) you can not get food by yourself. It will only take a matter of time before you cease to exist");

            }
            else
            {
                Console.WriteLine("your lack of response shows your lack of will to live so you have DIED!");
            }
            Console.WriteLine("your task has been completed");
            Console.WriteLine("Unless you have died due to lack of better choices, you have made it this long along with those around you. You've heard news over the radio that there is now a cure to this zombie infection. You can now leave your save haven and start killing the zombies that cannot be brought back and vaccinate the humans to prevent a future outbreak. The time to re-start civilization has finally arrived!");
            Console.WriteLine("Did you make it this long? Where you brave enough to survive? Did you finally get to use the bathroom now that the zombies are gone?");
        }
    }
}
