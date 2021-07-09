using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class AllMethods:IMethods
    {
        public void AllInOne()
        {
            var suit = new List<string> { "Club", "Diamond", "Heart", "Spade" };
            var rank = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "J", "Q", "K" };
            LinkedList<string> cards = new LinkedList<string>();
            LinkedList<string> players = new LinkedList<string>();
            Console.WriteLine("\n\t\t\tPrinting the entire deck\n");
            //combining both list into a cards linked list
            for (int i = 0; i < suit.Count; i++)
            {
                foreach (var mem in rank)
                {
                    cards.AddLast(suit[i] + mem);
                    Console.Write(suit[i] + mem + " , ");
                }
                Console.WriteLine("\n");
            }
            //For storing player and his cards at one place
            Dictionary<string, LinkedList<string>> playersWithCards = new Dictionary<string, LinkedList<string>>();
            int player = 1;
            Random random = new Random();
            while (player != 5)
            {
                LinkedList<string> card = new LinkedList<string>();
                while (card.Count < 9)
                {
                    int ransuit = random.Next(0, suit.Count);
                    int ranrank = random.Next(0, rank.Count);
                    card.AddLast(rank[ranrank] + suit[ransuit]);
                }
                playersWithCards.Add(("player" + player), card);
                player++;

            }
            foreach (var member in playersWithCards)
            {
                Console.WriteLine("---------->" + member.Key + "<------------");
                Console.WriteLine("----------->Before Sort<-------------");
                DisplayCards(member.Value);
                SortCards(member.Value);
            }
        }
        public void SortCards(LinkedList<string> playarray)
        {
            string[] arry = new string[9];
            int count = 0;
            foreach (var i in playarray)
            {
                if (count < 9)
                {
                    arry[count] = i;
                }
                count++;
            }
            Array.Sort(arry);
            Console.WriteLine("--------->After Sort<---------------");
            foreach (string i in arry)
            {
                Console.WriteLine(i);
            }
        }
        public void DisplayCards(LinkedList<string> gen)
        {
            foreach (var i in gen)
            {
                Console.WriteLine(i);
            }
        }
    }
}

