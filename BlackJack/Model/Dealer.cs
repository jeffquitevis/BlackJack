using System.Collections.Generic;

namespace BlackJack.Model
{
    class Dealer : IPlayer
    {

        private List<Card> playerHand = new List<Card>();
      

        public Card AddCard(Card card)
        {
            playerHand.Add(card);
            return card;
        }

     
        public void Stay()
        {
           
        }


        public List<Card> PlayerHand
        {
            get { return playerHand; }
        }  

     
    }
}
