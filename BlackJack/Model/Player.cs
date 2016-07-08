using System.Collections.Generic;

namespace BlackJack.Model
{
    public class Player : IPlayer
    {


        private List<Card> playerHand = new List<Card>();
              

        public List<Card> PlayerHand
        {
            get { return playerHand; }
        }


    }
}
