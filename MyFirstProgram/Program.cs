using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Semi colon tells the computer that this line of code has ended;
            Console.Write("Yo, who you be?");
            int playerScore = 0;
            string playerName = "";

            playerName = Console.ReadLine();

            int add = 0;

            while (playerScore < 10)
            {
                //request input;
                Console.Write("Increment score: ");
                add = Convert.ToInt32(Console.ReadLine());
                //add score;
                playerScore += add;
                Console.Write("Current score: ");
                Console.WriteLine(playerScore);
            }           

            Console.WriteLine("Hello " + playerName);
            Console.WriteLine("Score of " + playerScore);
            
            //quotation marks in C# code are used to define a string;
            //A string is used to display text to the user/player;
            // \n is a character in a string that attatches a return character;
            Console.Write(" This is my first program. Neat!");
            
            //Window closes when user presses enter;
            Console.ReadLine();

            /*C# data types
             string - stores text for the user;
             int - numbers with no decimal places;
             char - a single letter;
             float - numbers with decimal values;
             double - similar to float but has a higher number of decimal values;
             */

            /*initializing variables
            dataTypeVariable variableName = value of data;
             */

            /* Logical Operators
             * && = true if [true && true]/ false if [false && true];
             * || = true if either one of the sides are true;
             * ! = the opposite of;
             * == asks "is this equal to or the same as that?";
             * = assigns a value to a variable;
             * += does A = A + B. same as A += B;
             * -= subtracts like how above adds;
             * *= Multiply and assignment operator;
             * /= Divide and assignment operator;
             * %= Modulus and assignment operator;
             */
        }
    }
}
