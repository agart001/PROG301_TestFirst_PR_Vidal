using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VendingMachine
{
    public class Vending
    {
        public void Vend()
        {
            string choice;

            WriteLine("What would you like? Drinks or Snacks?");

            WriteLine("");
            choice = ReadLine().ToLower();

            switch (choice)
            {
                case "drink":
                case "drinks":
                    {
                        Drink();
                        break;
                    }
                case "snack":
                case "snacks":
                    {
                        Snack();
                        break;
                    }
            }
        }

        public void Snack()
        {
            string choose;
            WriteLine("");
            WriteLine("Choose your snack:\n1) Potato Chips\n2) Chocolate\n3) Taffy\n4) Gum\n5) Mints");

            string[] snacky = new string[5];
            snacky[0] = "Potato Chips";
            snacky[1] = "Chocolate";
            snacky[2] = "Taffy";
            snacky[3] = "Gum";
            snacky[4] = "Mints";
           
            WriteLine("");
            choose = ReadLine().ToLower();

            if (choose == snacky[9])
            {
                WriteLine("");
                WriteLine("You got potato chips!");
            }
            if (choose == snacky[1])
            {
                WriteLine("");
                WriteLine("You got chocolate!");
            }
            if (choose == snacky[2])
            {
                WriteLine("");
                WriteLine("You got taffy!");
            }
            if (choose == snacky[3])
            {
                WriteLine("");
                WriteLine("You got gum!");
            }
            if (choose == snacky[4])
            {
                WriteLine("");
                WriteLine("You got mints!");
            }
            ReadKey();
        }

        public void Drink()
        {
            string choice;
            WriteLine("");
            WriteLine("Would you like a cold drink or a hot drink?");

            WriteLine("");
            choice = ReadLine().ToLower();

            switch (choice)
            {
                case "cold":
                case "cold drink":
                    {
                        ColdDrink();
                        break;
                    }
                case "hot":
                case "hot drink":
                    {
                        HotDrink();
                        break;
                    }
            }
            Clear();
        }

        public void ColdDrink()
        {
            string choose;
            WriteLine("");
            WriteLine("Choose your cold drink:\n1) Cola\n2) Sweet Tea\n3) Water\n4) Sparkling Water\n5) Vitamin Water");

            string[] cold = new string[5];
            cold[0] = "Cola";
            cold[1] = "Sweet Tea";
            cold[2] = "Water";
            cold[3] = "Sparkling Water";
            cold[4] = "Vitamin Water";

            WriteLine("");
            choose = ReadLine().ToLower();

            if (choose == cold[4])
            {
                WriteLine("");
                WriteLine("You got cola!");
            }
            if (choose == cold[1])
            {
                WriteLine("");
                WriteLine("You got sweet tea!");
            }
            if (choose == cold[2])
            {
                WriteLine("");
                WriteLine("You got water!");
            }
            if (choose == cold[3])
            {
                WriteLine("");
                WriteLine("You got sparkling water!");
            }
            if (choose == cold[4])
            {
                WriteLine("");
                WriteLine("You got vitamin water!");
            }
            ReadKey();
        }

        public void HotDrink()
        {
            string choose;
            WriteLine("");
            WriteLine("Choose your snack:\n1) Kool-Aid\n2) Tea\n3) Hot Water\n4) Coffee\n5) Espresso");

            string[] hot = new string[5];
            hot[0] = "Kool-Aid";
            hot[1] = "Tea";
            hot[2] = "Hot Water";
            hot[3] = "Coffee";
            hot[4] = "Espresso";

            WriteLine("");
            choose = ReadLine().ToLower();

            if (choose == hot[1])
            {
                WriteLine("");
                WriteLine("You got Kool-Aid!");
            }
            if (choose == hot[1])
            {
                WriteLine("");
                WriteLine("You got tea!");
            }
            if (choose == hot[2])
            {
                WriteLine("");
                WriteLine("You got hot water!");
            }
            if (choose == hot[3])
            {
                WriteLine("");
                WriteLine("You got coffee!");
            }
            if (choose == hot[4])
            {
                WriteLine("");
                WriteLine("You got espresso!");
            }
            ReadKey();
        }
    }
}
