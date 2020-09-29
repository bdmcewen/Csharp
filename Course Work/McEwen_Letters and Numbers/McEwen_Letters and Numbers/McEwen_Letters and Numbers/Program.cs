using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McEwen_Letters_and_Numbers
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

            Console.WriteLine("[{0}]", string.Join(", ", fibo));


            // Declare an array to store the letters in the alphabet
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.WriteLine("[{0}]", string.Join(", ", alpha));


            //Requests a word from user
            Console.Write("Please Enter a Word:");
            string input = Console.ReadLine();
            string upperString = input.ToUpper();


            int sum = 0;
            string[] newValues;

            foreach (char letter in upperString)
            {
                int x = Convert.ToInt32(letter);
                Console.WriteLine(x);

                Console.WriteLine(fibo[x - 65]);

                sum += (fibo[x - 65]);

            }
            Console.WriteLine("The sum of the Fibonacci values is: " + sum);

        }
    }
}
