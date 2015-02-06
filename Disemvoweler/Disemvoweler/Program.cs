using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            Disemvoweler("Nickelback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");

            // keep the console open
            Console.ReadKey();
        }
        /// <summary>
        /// Removing all vowels from the string and printing out string without vowels and string with removed vowels 
        /// </summary>
        /// <param name="input">String to be processed</param>
        /// <returns>String without vowels</returns>
        public static string Disemvoweler(string input)
        {
            //creating string for storing text without vowels and all removed vowels 
            string disemvoweledString = String.Empty;
            string vowelsRemoved = String.Empty;

            //looping through original string
            for (int i = 0; i < input.Length; i++)
            {
                //checking if a letter is a vowel
                if ("aeiouAEIOU".Contains(input[i].ToString()))
                    //or
                    //string letter = input[i].ToString();
                    //(if ("aeiou".Contains(letter.ToLower())))
                {
                    vowelsRemoved += input[i];
                }
                //checking if a letter is consonant and not a special character
                else if ((input[i] >= 'a' && input[i] <= 'z' || input[i] >= 'A' && input[i] <= 'Z') && (!"aeiouAEIOU".Contains(input[i].ToString())))
                {
                    disemvoweledString += input[i];
                }
            }

            // Write out the various string results
            Console.WriteLine("Original: {0}", input);
            Console.WriteLine("Disemvoweled: {0}", disemvoweledString);
            Console.WriteLine("Vowels Removed: {0}", vowelsRemoved); 
            // Return the Disemvoweled string as well for testing
            
            Console.WriteLine(@"Original: {0}
Disemvoweld: {1}
Vowels Remover: {2}
Have a nice day!", input, disemvoweledString, vowelsRemoved);

            return disemvoweledString;
        }
    }
}
