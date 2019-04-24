using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string rollAgain = "y";
            while (rollAgain == "y")
            {
                Console.WriteLine("How many sides on your dice?");
                int sides = int.Parse(Console.ReadLine());

                Console.WriteLine("Would you like to roll your dice?  y or n");
                string response = Console.ReadLine();

                Random rand = new Random();
                int rand1 = rand.Next(2, sides + 1);
                int rand2 = rand.Next(2, sides + 1);



                if (response == "y")
                {
                    Console.WriteLine("Here we go!");
                    Console.WriteLine("Your first die roll is " + rand1);
                    Console.WriteLine("Your second die roll is " + rand2);

                }
                else
                {
                    Console.WriteLine("Sorry we couldn't play");

                }

                rollAgain = Methods.ContinueLoop();

                int die1 = Methods.GetRandomNumber(sides);
                int die2 = Methods.GetRandomNumber(sides);
            }



































        }


    }





    }

