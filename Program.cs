using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList<string> spreads = new RoverList<string>();

            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words

            Console.WriteLine("Hello! Here are your list of spreads for todays sandwhiches:");
            Console.WriteLine(" ");

            //element at doesn't work rn
            

            //1
            spreads.Starter("jelly");
            //2
            
            spreads.Add("peanut butter");
            //3
            spreads.Add("jam");
            //4
            spreads.Add("sun butter");
            //5
            spreads.Add("marmalade");
            //6
            spreads.Add("marshmallow fluff");
            //7
            spreads.Add("fig jam");
            //8
            spreads.Add("advacado");
            //9
            spreads.Add("cheese wiz");
            //10
            spreads.Add("nutella");
            //11
            spreads.Add("dulce de leche");
            //12
            spreads.Add("cretons");
            //13
            spreads.Add("honey");
            //14
            spreads.Add("hummus");
            //15
            spreads.Add("clotted cream");
            //16
            spreads.Add("kyopolou");

            // TODO:  Print out the list

            spreads.ListNodes();


            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("If you would like to request more spreads, please type them now. Type as many as you'd like! Type Done to finish.");

            Console.WriteLine("press enter to continue after each spread...");

            string input = Console.ReadLine();


            int bread = 0;

            while (bread == 0)
            {
                spreads.Add(input);

                if (input.Equals("done") || input.Equals("Done"))
                {
                    bread = 1;


                    spreads.RemoveLast();
                }

                if (bread == 0)
                {
                    Console.WriteLine("Type another spread now or done to continue!");
                    input = Console.ReadLine();
                }
            }

            // TODO:  Print out the list

            spreads.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"


            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Please enter more spreads that you would like to be added to high priority (fornt of the list)!");
            Console.WriteLine("Press enter after each spread, and press done when you are finished!");

            //same loop as above
            int baguette = 0;

            input = Console.ReadLine();

            while (baguette == 0)
            {
                
                if (input.Equals("done") || input.Equals("Done"))
                {
                    baguette = 1;
                }
                else
                {
                    spreads.Add(0, input);
                }

                if (baguette == 0)
                {
                    Console.WriteLine("Type another spread now or done to continue!");
                    input = Console.ReadLine();
                }
            }




            // TODO:  Print out the list

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            spreads.ListNodes();

            // TODO:  Remove every word with an odd length

            Console.WriteLine("Removing odd lengthed spreads: ");

            //spreads.OddCheck();

            // TODO:  Print out the list

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            spreads.ListNodes();

            // TODO:  Clear the list

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            spreads.Clear();

            // TODO:  Print out the list

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            spreads.ListNodes();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();

        }
    }
}
