using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luhns_Algorithm
{
    class Test
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your card number with no punctuation: ");
                string cardNumber;
                cardNumber = Console.ReadLine();
                if (Program.ValidateCard(cardNumber))
                {
                    Console.WriteLine(cardNumber + " appears to be a valid format.");
                }
                else
                {
                    Console.WriteLine(cardNumber + " appears to not be a valid format.");
                }
            }
        }
    }
}
