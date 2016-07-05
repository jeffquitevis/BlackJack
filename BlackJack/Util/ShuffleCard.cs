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
            List<string> suit = new List<string>();
            List<int> number = new List<int>();
            List<Card> deckList = new List<Card>();
            Stack<Card> deck = new Stack<Card>();
            Random random = new Random();

            suit.Add("h");
            suit.Add("d");
            suit.Add("c");
            suit.Add("s");

            number.Add(1);
            number.Add(2);
            number.Add(3);
            number.Add(4);
            number.Add(5);
            number.Add(6);
            number.Add(7);
            number.Add(8);
            number.Add(9);
            number.Add(10);
            number.Add(11);
            number.Add(12);
            number.Add(13);



            for (int x1 = 0; x1 < suit.Count; x1++)
            {
                for (int x2 = 0; x2 < number.Count; x2++)
                {
                    deckList.Add(new Card(number[x2], suit[x1]));
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
