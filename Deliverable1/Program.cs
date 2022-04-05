using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables for counting ingredients
            int people, slice, tablespoon, teaspoon, loaf, jelly, peanutbutter, loafRemainder, jellyRemainder, pbRemainder;
            string answer;

            do
            {
                //Asking input for number of people 
                Console.WriteLine("How may people are we making PB and J sandwiches for?");
                people = int.Parse(Console.ReadLine());

                //Calculatoins
                slice = people * 2;
                tablespoon = people * 2;
                teaspoon = people * 4;
                loaf = slice / 28;
                jelly = teaspoon / 48;
                peanutbutter = tablespoon / 32;

                loafRemainder = slice % 28;
                jellyRemainder = teaspoon % 48;
                pbRemainder = tablespoon % 32;

                //Calculation for rounding up
                if (loafRemainder >= 0)
                {
                    loaf = loaf + 1;
                }

                if (jellyRemainder >= 0)
                {
                    jelly = jelly + 1;
                }

                if (pbRemainder >= 0)
                {
                    peanutbutter = peanutbutter + 1;
                }

                //Outputting calculatoins
                Console.WriteLine("You need: ");
                Console.WriteLine(slice + " slices of bread");
                Console.WriteLine(tablespoon + " tablespoons of peanut butter");
                Console.WriteLine(teaspoon + " teaspoons of jelly");
                Console.WriteLine("which is...");
                Console.WriteLine(loaf + " loaves of bread");
                Console.WriteLine(peanutbutter + " jars of peanutbutter");
                Console.WriteLine(jelly + " jars of jelly");
                Console.WriteLine();
                Console.Write("Would you like to restart? Enter yes or y to continue, or enter any other key to exit: ");

                answer = Console.ReadLine();

            } while (answer == "y" || answer == "yes");

            //After user exits the program
            Console.WriteLine("Goodbye!");
        }
    }
}
