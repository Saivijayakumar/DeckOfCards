using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
        /// <summary>
        /// -------------->Welcome to DeckOfCards<-------------
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("-------------->Welcome to DeckOfCards<-------------");
            AllMethods allMethods = new AllMethods();
            allMethods.AllInOne();
            Console.ReadLine();
        }
    }
}
