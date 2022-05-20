using System;

namespace Deliverable2
{
    class Buffet
    {
        static void Main(string[] args)
        {
            //initialise values
            const double BUFFET_PRICE = 9.99;
            const double SODA_PRICE = 1.50;
            double buffetTotal;
            double sodaTotal;
            double totalPrice;
            string multipleWater = "";
            string multipleSoda = "";
            string multipleBuffet = "";
            int water = 0;
            int soda = 0;
            //ask for number of people
            Console.WriteLine("Hi! Welcome to our buffet. Our all you can eat price is $9.99. Waters are free. There is an extra charge of $1.50 for sodas. We can only seat tables of 6 or less. How many are in your group?");
            int people = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (people > 1)
            {
                multipleBuffet = "s";
            }
            if (people > 6)
            {
                Console.WriteLine("I'm sorry. We can only seat tables of 6 or less.");
            }
            else
            {
                //loop through drink choices
                Console.WriteLine($"A party of {people}! Right this way. I'll take you to your table.");
                Console.WriteLine("What drinks can I get for you? Waters are free, and sodas cost an extra $1.50.");
                Console.WriteLine();
                for (int i = 1; i <= people; i++)
                {
                    Console.WriteLine("Ok, guest " + i + ", water or soda?");
                    string drinkChoice = Console.ReadLine();
                    if (drinkChoice == "water")
                    {
                        water++;
                        Console.WriteLine("Water, excellent!");
                        Console.WriteLine();
                    }
                    else if (drinkChoice == "soda")
                    {
                        soda++;
                        Console.WriteLine("Soda, great choice!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, we don't have that. No drink for you.");
                        Console.WriteLine();
                    }
                }
                if (soda > 1 && water > 1)
                {
                    multipleSoda = "s";
                    multipleWater = "s";
                }
                else if (soda > 1)
                {
                    multipleSoda = "s";
                }
                else if (water > 1)
                {
                    multipleWater = "s";
                }
                if (soda > 0 && water > 0)
                {
                    Console.WriteLine($"Ok, that's {water} water{multipleWater} and {soda} soda{multipleSoda}. Feel free to start grabbing your food, and I'll be right back with your drinks.");
                    Console.WriteLine();
                }
                else if (soda > 0)
                {
                    Console.WriteLine($"Ok, that's {soda} soda{multipleSoda}. Feel free to start grabbing your food, and I'll be right back with your drinks.");
                    Console.WriteLine();
                }
                else if (water > 0)
                {
                    Console.WriteLine($"Ok, that's {water} water{multipleWater}. Feel free to start grabbing your food, and I'll be right back with your drinks.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Ok, no drinks. Feel free to start grabbing your food.");
                    Console.WriteLine();
                }
                //calculate totals
                buffetTotal = people * BUFFET_PRICE;
                sodaTotal = soda * SODA_PRICE;
                totalPrice = buffetTotal + sodaTotal;
                //display bill
                Console.WriteLine("Here is your bill. Total Price: $" + String.Format("{0:0.00}", (totalPrice)));
                Console.WriteLine();
                Console.WriteLine($"{people} buffet{multipleBuffet} = {people} X 9.99 = {String.Format("{0:0.00}", (buffetTotal))}");
                if (soda > 0)
                {
                    Console.WriteLine($"{soda} soda{multipleSoda} = {soda} X 1.50 = {String.Format("{0:0.00}", (sodaTotal))} ");
                }
                if (water > 0)
                {
                    Console.WriteLine($"{water} water{multipleWater} = free");
                }
                Console.WriteLine("total = " + totalPrice);
            }
        }
    }
}