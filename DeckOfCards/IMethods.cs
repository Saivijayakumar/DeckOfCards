using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    interface IMethods
    {
        void AllInOne();
        void SortCards(LinkedList<string> playarray);
        void DisplayCards(LinkedList<string> gen);
    }
}
