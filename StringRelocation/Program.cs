using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelocation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a string: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Please Enter an index: ");
            int nInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{1}",userInput.Substring(userInput.Length - nInput),userInput.Substring(0,userInput.Length-nInput));
            Console.ReadLine();

        }
    }
}
