using System;
using System.Collections.Generic;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nThis is your Shopping List !\nYou can use following options to manage the list:\n\n[1] - add a new 'item and price' value\n[2] - view all items contained in the list\n[3] - remove an existing 'item and price' value from the list\n");

            //declaration block
            ShoppingCard ShopCard = new ShoppingCard();
            double aPrice = 0.0;
            string anItem = "";
            int userChoise = 0;

            do
            {
                Console.Write("\nSelect one of the options and confirm your choice by pressing 'Enter' key: ");
                //'user selects an option' conditional loop
                while (!Int32.TryParse(Console.ReadLine(), out userChoise) || (userChoise < 1 || userChoise > 3))
                {
                    Console.Write("\nNo such option exists. Please select any from available ones: ");
                }

                //prevention of displaying of an empty list
                if (ShopCard.listOfItems.Count == 0 && (userChoise == 2 || userChoise == 3))
                {
                    Console.Write("\nThe Shopping List is empty !\n");
                    continue;
                }

                //list's options execution
                switch (userChoise)
                {
                    case 1:
                        do
                        {
                            Console.Write("\nEnter a name for a new item\n(name must contain at least one character and can't be empty): ");
                            if (ShopCard.listOfItems.ContainsKey(anItem = Console.ReadLine()))
                            {
                                Console.Write("\nItem with such name already exists in the Shopping List !");
                            }
                        } while ((String.IsNullOrWhiteSpace(anItem) || ShopCard.listOfItems.ContainsKey(anItem)));

                        do
                        {
                            Console.Write("\nEnter a price for this item\n(price must contain only positive numbers above zero and can't be empty): ");
                        } while (!Double.TryParse(Console.ReadLine(), out aPrice) || aPrice != Math.Abs(aPrice));

                        ShopCard.listOfItems.Add(anItem, aPrice);
                        break;

                    case 2:
                        Console.Write("\nThe Shopping List comprises following items:\n\nNAME\tPRICE");
                        ShopCard.listView();
                        break;

                    case 3:
                        do
                        {
                            Console.Write("\nEnter an item's name to have one removed from the Shopping List: ");
                            if (ShopCard.listOfItems.ContainsKey(anItem = Console.ReadLine()))
                            {
                                ShopCard.listOfItems.Remove(anItem);
                                Console.Write("\nThe item \'{0}\' was successfully removed from the Shopping List !\n", anItem);
                                break;
                            }
                            else
                                Console.Write("\nThere's no item with such name in the Shopping List !");
                        } while ((!String.IsNullOrWhiteSpace(anItem)) || (!ShopCard.listOfItems.ContainsKey(anItem)));
                        break;

                    default:
                        Console.Write("\nYou've chosen incorrect option !");
                        break;
                }

            } while (true);
        }
    }
}




