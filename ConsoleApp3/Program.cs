using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int pplNum;
            Console.WriteLine("Yo! What kind of activity are you feeling today? Make a selection below. \n");
            Console.WriteLine("Choose: \n" + "1.Action \n" + "2.Chilln \n" + "3.Danger \n" + "4.Good Food \n");

            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Action huh? How many people are going?\n");
                    break;
                case 2:
                    Console.WriteLine("Nice & chill. How many people?\n");
                    break;
                case 3:
                    Console.WriteLine("Danger? Uh-oh. How many helmets will you need?\n");
                    break;
                case 4:
                    Console.WriteLine("Did someone say food? How many mouths we feedin'?\n");
                    break;
                default:
                    Console.WriteLine("Sorry, your choice was not understood. ");
                    break;

            }
            pplNum = Convert.ToInt32(Console.ReadLine());

            // action choices
            while (choice == 1)
            {
                if (pplNum == 0)
                {
                    Console.WriteLine("Lace up your best sneakers and put the pedal to the metal in a stock car!");

                }
                else if (pplNum >= 1 && pplNum <= 4)
                {
                    Console.WriteLine("Ask to borrow your neighbors sedan, grab a few friends, and play tag in WalMart!");
                }
                else if (pplNum >= 5 && pplNum <= 10)
                {
                    Console.WriteLine("Action with a large group? Take a Volkswagen Bus with no doors on a slow roll Safari. ");
                }
                else
                {
                    Console.WriteLine("You. Your closest 11 or so friends. An airplane. Take a Flight on Spirit! ");
                }
                break;
            }

            //chilln choices
            while (choice == 2)
            {
                if (pplNum == 0)
                {
                    Console.WriteLine("Just you and some good boots. Go hiking and get some fresh air. ");

                }
                else if (pplNum >= 1 && pplNum <= 4)
                {
                    Console.WriteLine("Doesn't that one van have a DVD player? Grab some popcorn, movie night in the driveway. ");
                }
                else if (pplNum >= 5 && pplNum <= 10)
                {
                    Console.WriteLine("Take the VW Bus to a field. Drum circle. ");
                }
                else
                {
                    Console.WriteLine("Huddle around the computer and look at trips everyone wants to take. ");
                }
                break;
            }

            //danger choices
            while (choice == 3)
            {
                if (pplNum == 0)
                {
                    Console.WriteLine("Up for a thrill? Go skydiving in a pair of Yeezy's. ");

                }
                else if (pplNum >= 1 && pplNum <= 4)
                {
                    Console.WriteLine("Know how to drive a stick? Doesn't matter in a demolition derby. ");
                }
                else if (pplNum >= 5 && pplNum <= 10)
                {
                    Console.WriteLine("Put some thin tires on that Volkswagen and go drifting around Belle Isle. ");
                }
                else
                {
                    Console.WriteLine("Just a game of musical chairs with your friends...on the wing of a moving plane! ");
                }
                break;
            }

            //food choices
            while (choice == 4)
            {
                if (pplNum == 0)
                {
                    Console.WriteLine("You want some good food? You gotta hit up Taco Beez!");

                }
                else if (pplNum >= 1 && pplNum <= 4)
                {
                    Console.WriteLine("Take you and your carload to Sonic. Have you had the slushes?!");
                }
                else if (pplNum >= 5 && pplNum <= 10)
                {
                    Console.WriteLine("It's 2AM. You've got a busload of folks. You gotta go to White Castle, fam. ");
                }
                else
                {
                    Console.WriteLine("Wild night with the entourage? Gotta land the private jet in front of your favorite coney. ");
                }
                break;
            }
            Console.WriteLine("\nWhatever you do, just be safe. Later!");
        }
    }
}
