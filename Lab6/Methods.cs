using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Methods
    {
        public static int GetRandomNumber(int sides)
        {
            Random random = new Random();
            return random.Next(2, sides);

            

        }
        public static string ContinueLoop()
        {
            Console.WriteLine("Would you like to roll again? y or n");
            return Console.ReadLine().ToLower();

        }

        
        
            
            




        }
        




    }

