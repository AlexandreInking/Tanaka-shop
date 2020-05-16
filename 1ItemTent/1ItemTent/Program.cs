using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ItemTent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 'Anther world's shop'");
            Client client = new Client("", 0, 0);
            Seller seller = new Seller("Alexandre Inking", 25, 0, client);
            // Intro
            Console.Write("[Write your name] ");
            client.Name = Console.ReadLine();
            Console.Write("[Write your weapon mastery (1 - 40)] ");
            client.Mastery = int.Parse(Console.ReadLine());
            Console.Write("[Write your budget] ");
            client.Money = int.Parse(Console.ReadLine());
            // Custom chat
            if (client.Mastery.lvlMastery < 11 && client.Mastery.lvlMastery > 0)
            {
                Console.WriteLine("Hello, " + client.Name + ". So you're a Novice " + client.Mastery.Novice + " weapon master and your budget is " +
                    client.Money + " Tanaka Points.");
                Console.WriteLine("Oh! Little rookie awaits you a long way...");
            }
            else if (client.Mastery.lvlMastery < 21)
            {
                Console.WriteLine("Nice to meet you, " + client.Name + ". So you're a Apprentice " + client.Mastery.Apprentice + " weapon master and your " +
                    "budget is " + client.Money + " Tanaka Points.");
                Console.WriteLine("I remember when I became my master's apprentice... It was amazing.");
            }
            else if (client.Mastery.lvlMastery < 31)
            {
                Console.WriteLine("Congratulations on being a Graduate " + client.Mastery.Graduate + ", " + client.Name +
                    "! Now the hard part begins, pushing your limits. When we can, I hope we'll have a round of beers. Actually your budget is "
                    + client.Money + " Tanaka Points.");
            }
            else if (client.Mastery.lvlMastery < 41)
            {
                Console.WriteLine("It is an honor to have you in this humble tent, Master " + client.Name + ". I hope you find what you're looking" +
                    " for. So you're a Master " + client.Mastery.Master + " weapon master and your budget is " + client.Money + " Tanaka Points.");
            }
            else
            {
                Console.WriteLine("Gods or demons are not allowed in this shop.");
            }
            // Clear screen
            Console.ReadKey();
            Console.Clear();

            if (client.Mastery.lvlMastery < 41 && client.Mastery.lvlMastery > 0)
            {
                // List items in the shop
                Console.WriteLine("Actually I've got this items.");
                Item itemB = null;
                Console.WriteLine("1 - Long sword [TP 11.23]");
                Weapon sword = new Weapon(0, "Long sword", 11.23f, "fire", 7);
                Console.WriteLine("2 - Ark's platinum helmet [TP 5.8]");
                Armor helmet = new Armor(1, "Ark's platinum helmet", 5.8f, "all type of");
                Console.WriteLine("3 - High quality health potion [TP 13.21]");
                Potion health = new Potion(2, "High quality health potion", 13.21f, 100);
                Console.WriteLine("4 - [Are there another item?]");
                int option = int.Parse(Console.ReadLine());
                // Clear screen
                Console.ReadKey();
                Console.Clear();

                bool offer = false;

                switch (option)
                {
                    case 1:
                        itemB = sword;
                        Console.WriteLine("This sword is imbued with magic, dealing " + sword.DamageType + " damage to your enemies.");
                        if (sword.MasteryRestriction > client.Mastery.lvlMastery)
                        {
                            Console.WriteLine("You need a better mastery to equip it. Do you want to buy it? (Y/N)");
                        }
                        else if (sword.BuyCost > client.Money)
                        {
                            Console.Write("You don't have enough TP to buy it. ");

                            if (client.Mastery.lvlMastery > seller.Mastery.lvlMastery && client.Money >= 9 / 16 * sword.BuyCost)
                            {
                                Console.Write("I can sell this sword for you with a discount of 25% of its cost. Do you want to buy it? (Y/N)");
                                offer = true;
                            }
                            else
                            {
                                Console.Write("Do you want to buy it? (Y / N)");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Are you sure about to buy it? (Y / N)");
                        }
                        break;

                    case 2:
                        itemB = helmet;
                        Console.WriteLine("I found this helmet in the ruins of Ahr city. It resists  " + helmet.ResistanceType +
                            " damage. Do you want to buy it? (Y / N)");
                        break;

                    case 3:
                        itemB = health;
                        Console.WriteLine("It's the best health potion I found and I exchange it for all my other items. This bottle of potion has " +
                            health.Quantity + " ml. Do you want to buy it? (Y / N)");
                        break;

                    case 4:
                        Console.WriteLine("No, sorry about it. I sell the other items to buy a miraculous health potion. See you next time.");
                        break;

                    default:
                        Console.WriteLine("I don't understand what you want, sorry. See you next time.");
                        break;
                }

                if (option < 4 && option > 0)
                {
                    string buyIt = Console.ReadLine().ToUpper();
                    if (buyIt == "Y")
                    {
                        Console.WriteLine("Thanks for your buy. See you next time.");
                        if (offer)
                        {
                            client.Money -= seller.MakeOffer(itemB.BuyCost);
                        }
                        else
                        {
                            client.Money -= itemB.BuyCost;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        client.Store(itemB);
                        Console.WriteLine("Your budget: " + client.Money);
                    }
                    else if (buyIt == "N")
                    {
                        Console.WriteLine("Maybe you can find what you want next time. See you later.");
                    }
                    else
                    {
                        Console.WriteLine("I don't understand what you want, sorry. See you next time.");
                    }

                }
            }

            Console.ReadKey();
        }
    }
}
