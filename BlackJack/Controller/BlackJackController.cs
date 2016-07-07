using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack.Exceptions;
using BlackJack.Model;

namespace BlackJack.Controller
{
    public class BlackJackController
    {

        private IMainView view;
        private Stack<Card> deckCards;
        private IPlayer player = new Player();
        private IPlayer dealer = new Dealer();
        private  ImageGenerator image = new ImageGenerator();
            
        private int pHandTotal = 0;
        private int dHandTotal = 0;
       

        public BlackJackController(Stack<Card> deckCards,IMainView view)
        {
            this.deckCards = deckCards;
            this.view = view;
            InitialDeal();

        }
        
        public void HitPlayer(Card card)
        {
            
            PlayerManager manageHand = new PlayerManager();

            manageHand.AddCard(card, player);
            //player.AddCard(card);
            pHandTotal =  manageHand.CalculateHand(player);

            view.PlayerTotal.Text = Convert.ToString(pHandTotal);
            image.GenerateImage(card.ToString(),view.PlayerListView);    
                                        
            if (pHandTotal > 21)
            {
                MessageBox.Show(@"Dealer Wins!");
            }

        }


        public void HitDealer()
        {

            PlayerManager manageHand = new PlayerManager();

          
                while (dHandTotal < 16)
                {
                    Card tempCard = manageHand.AddCard(deckCards.Pop(), dealer);
                    dHandTotal += manageHand.CalculateHand(dealer);
                    image.GenerateImage(tempCard.ToString(), view.DealerListView);
                }
             
            view.DealerTotal.Text = Convert.ToString(dHandTotal);


            if (dHandTotal > 21)
            {
                MessageBox.Show(@"Player Wins!");
            }

        }






        public void InitialDeal()
        {

            List<IPlayer> dealPlayers = new List<IPlayer>() { player, dealer, player };         

            for (int x = 0; x < dealPlayers.Count; x++)
            {
                PlayerManager manageHand = new PlayerManager();
                manageHand.AddCard(deckCards.Pop(), dealPlayers[x]);


                if (dealPlayers[x] == player)
                {
                    pHandTotal = manageHand.CalculateHand(dealPlayers[x]);
                }
                else
                {
                    dHandTotal = manageHand.CalculateHand(dealPlayers[x]);
                }
            }
          
            

            for (int x = 0; x < dealer.PlayerHand.Count; x++)
            {
                image.GenerateImage(dealer.PlayerHand[x].ToString(), view.DealerListView);
            }

            for (int x = 0; x < player.PlayerHand.Count; x++)
            {
                image.GenerateImage(player.PlayerHand[x].ToString(), view.PlayerListView);
            }

            view.PlayerTotal.Text = Convert.ToString(pHandTotal);
            view.DealerTotal.Text = Convert.ToString(dHandTotal);
        }

    }
}
