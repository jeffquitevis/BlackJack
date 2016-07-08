using System.Collections.Generic;

namespace BlackJack.Model
{
    class Dealer : IPlayer
    {

        private List<Card> playerHand = new List<Card>();
      

        public List<Card> PlayerHand
        {
            get { return playerHand; }
        }  

     
    }
}
