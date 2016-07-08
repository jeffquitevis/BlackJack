using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Model;

namespace BlackJack.Util
{
    class CardUtil
    {

        public static Stack<Card> ShuffleCard()
        {
            int numberSuit = 14;

            List<string> suit = new List<string>() {"h","d","c","s"};
            List<Card> deckList = new List<Card>();
            Stack<Card> deck = new Stack<Card>();
            Random random = new Random();

            for (int x1 = 0; x1 < suit.Count; x1++)
            {
                for (int x2 = 1; x2 < numberSuit; x2++)
                {
                    deckList.Add(new Card(x2, suit[x1]));
                }
            }



          
            for (int x = 0; x < deckList.Count; x++)
            {
                deck.Push(deckList[random.Next(deckList.Count)]);
            }

            
            return deck;
        }
      
    }
}
