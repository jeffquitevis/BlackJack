using System.Collections.Generic;

namespace BlackJack.Model
{
    public class Player : IPlayer
    {


        private List<Card> playerHand = new List<Card>();
       
        
        public Card AddCard(Card card)
        {            
            playerHand.Add(card);

            return card;
        }


        public List<Card> PlayerHand
        {
            get { return playerHand; }
        }



    }
}
