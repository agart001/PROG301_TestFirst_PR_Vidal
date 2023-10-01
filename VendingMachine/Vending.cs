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
        public string CurrentOutputText { get; protected set; }

        public string CurrentInputText { get; set; }

        private bool UTesting { get; set; }
        private int TestsRan { get; set; }

        public Vending() 
        {
            TestsRan= 0;
            UTesting = false;
        }

        public Vending(bool testing)
        {
            TestsRan = 0;
            UTesting = testing;
        }

        public string UTestInput()
        {
            string input = "";

            if (UTesting)
            {
                input = CurrentInputText;
                TestsRan++;
            }
            else { input = ReadLine().ToLower(); }

            return input;
        }


        public void Vend()
        {
            string choice;

            CurrentOutputText = "What would you like? Drinks or Snacks?";
            WriteLine(CurrentOutputText);

            WriteLine("");

            choice = UTestInput();

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

            CurrentOutputText = "Choose your snack:";
            WriteLine(CurrentOutputText + "\n1) Potato Chips\n2) Chocolate\n3) Taffy\n4) Gum\n5) Mints");

            if (UTesting && TestsRan > 0) return;

            string[] snacky = new string[5];
            snacky[0] = "Potato Chips";
            snacky[1] = "Chocolate";
            snacky[2] = "Taffy";
            snacky[3] = "Gum";
            snacky[4] = "Mints";
           
            WriteLine("");

            choose = UTestInput();

            if (choose == snacky[0])
            {
                WriteLine("");
                CurrentOutputText = "You got potato chips!";
                WriteLine(CurrentOutputText);
            }
            if (choose == snacky[1])
            {
                WriteLine("");
                CurrentOutputText = "You got chocolate!";
                WriteLine(CurrentOutputText);
            }
            if (choose == snacky[2])
            {
                WriteLine("");
                CurrentOutputText = "You got taffy!";
                WriteLine();
            }
            if (choose == snacky[3])
            {
                WriteLine("");
                CurrentOutputText = "You got gum!";
                WriteLine(CurrentOutputText);
            }
            if (choose == snacky[4])
            {
                WriteLine("");
                CurrentOutputText = "You got mints!";
                WriteLine(CurrentOutputText);
            }
        }

        public void Drink()
        {
            string choice;

            WriteLine("");

            CurrentOutputText = "Would you like a cold drink or a hot drink?";
            WriteLine(CurrentOutputText);

            if (UTesting && TestsRan > 0) return;

            WriteLine("");

            choice = UTestInput();

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
        }

        public void ColdDrink()
        {

            string choose;

            WriteLine("");

            CurrentOutputText = "Choose your cold drink:";
            WriteLine(CurrentOutputText + "\n1) Cola\n2) Sweet Tea\n3) Water\n4) Sparkling Water\n5) Vitamin Water");

            if (UTesting && TestsRan > 0) return;

            string[] cold = new string[5];
            cold[0] = "Cola";
            cold[1] = "Sweet Tea";
            cold[2] = "Water";
            cold[3] = "Sparkling Water";
            cold[4] = "Vitamin Water";

            WriteLine("");

            choose = UTestInput();

            if (choose == cold[0])
            {
                WriteLine("");
                CurrentOutputText = "You got cola!";
                WriteLine(CurrentOutputText);
            }
            if (choose == cold[1])
            {
                WriteLine("");
                CurrentOutputText = "You got sweet tea!";
                WriteLine(CurrentOutputText);
            }
            if (choose == cold[2])
            {
                WriteLine("");
                CurrentOutputText = "You got water!";
                WriteLine(CurrentOutputText);
            }
            if (choose == cold[3])
            {
                WriteLine("");
                CurrentOutputText = "You got sparkling water!";
                WriteLine(CurrentOutputText);
            }
            if (choose == cold[4])
            {
                WriteLine("");
                CurrentOutputText = "You got vitamin water!";
                WriteLine(CurrentOutputText);
            }
        }

        public void HotDrink()
        {

            string choose;


            WriteLine("");

            CurrentOutputText = "Choose your snack:";
            WriteLine(CurrentOutputText + "\n1) Kool-Aid\n2) Tea\n3) Hot Water\n4) Coffee\n5) Espresso");

            if (UTesting && TestsRan > 0) return;

            string[] hot = new string[5];
            hot[0] = "Kool-Aid";
            hot[1] = "Tea";
            hot[2] = "Hot Water";
            hot[3] = "Coffee";
            hot[4] = "Espresso";

            WriteLine("");

            choose = UTestInput();

            if (choose == hot[0])
            {
                WriteLine("");
                CurrentOutputText = "You got Kool-Aid!";
                WriteLine(CurrentOutputText);
            }
            if (choose == hot[1])
            {
                WriteLine("");
                CurrentOutputText = "You got tea!";
                WriteLine(CurrentOutputText);
            }
            if (choose == hot[2])
            {
                WriteLine("");
                CurrentOutputText = "You got hot water!";
                WriteLine(CurrentOutputText);
            }
            if (choose == hot[3])
            {
                WriteLine("");
                CurrentOutputText = "You got coffee!";
                WriteLine(CurrentOutputText);
            }
            if (choose == hot[4])
            {
                WriteLine("");
                CurrentOutputText = "You got espresso!";
                WriteLine(CurrentOutputText);
            }
        }
    }
}
