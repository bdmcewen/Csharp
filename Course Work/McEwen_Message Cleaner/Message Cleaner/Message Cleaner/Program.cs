using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Message_Cleaner
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare an array to store Fibonacci numbers. 1 extra to handle case, n = 0 
            int[] fibo = new int[26];
            int i;

            // 0th and 1st number of the series are 0 and 1 
            fibo[0] = 0;
            fibo[1] = 1;
            

            for (i = 2; i <= 25; i++)
            {
                // Add the previous 2 numbers  in the sequence and store it 
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
            //Console.WriteLine("[{0}]", string.Join(", ", fibo));


            // Declare an array to store the letters in the alphabet
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            //Console.WriteLine("[{0}]", string.Join(", ", alpha));


            //Requests userdefined block of text
            Console.Write("Please enter your line of text to be cleaned: ");
            string dirtyText = Console.ReadLine();
            string[] dirtyWords = dirtyText.Split(' ');
            //Console.WriteLine(dirtyWords);

            
            //Requests user defined words to clean from block of text
            Console.Write("Please enter your list of unwanted words (separated by spaces): ");
            string badText = Console.ReadLine();
            string[] badWords = badText.Split(' ');
            //Console.WriteLine(badWords);


            //Clean the text
            string cleanText = Regex.Replace(dirtyText, "\\b" + string.Join("\\b|\\b", badWords) + "\\b", "");
            Console.WriteLine("Your cleaned text is: "+ cleanText);
            //Console.WriteLine(cleanText);
            string upperString = cleanText.ToUpper();
            

            //Remove all spaces 
            upperString = upperString.Replace(" ", "");
            //Console.WriteLine(upperString);
         

            int sum = 0;
            foreach (char word in upperString)
            {
                int x = Convert.ToInt32(word);
                //Console.WriteLine(x);

                //Console.WriteLine(fibo[x-65]);

                sum += (fibo[x - 65]);

            }
            Console.WriteLine("The sum of the Fibonacci values is: " + sum);

        }

    }
}
