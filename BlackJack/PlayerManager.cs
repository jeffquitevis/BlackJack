using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Model;

namespace BlackJack
{
    public class PlayerManager
    {
        private int sum = 0;
     
        public int CalculateHand(IPlayer player)
        {
            for (int x = 0; x < player.PlayerHand.Count; x++)
            {
                sum += player.PlayerHand[x].Number;
            }

            return sum;
        }

        public Card AddCard(Card card, IPlayer player)
        {
            Card tempCard = null;

            player.PlayerHand.Add(card);

            return tempCard;
        }

    }
}
