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
            player.AddCard(card);
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
                    Card tempCard = dealer.AddCard(deckCards.Pop());
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

        

            List<IPlayer> dealPlayers = new List<IPlayer>() { dealer, player,dealer };
           

            for (int x = 0; x < dealPlayers.Count; x++)
            {
               dealPlayers[x].AddCard(deckCards.Pop());                              
                
            }
            for (int x = 0; x < player.PlayerHand.Count; x++)
            {
                PlayerManager playerHand = new PlayerManager();
                pHandTotal = playerHand.CalculateHand(player);

            }

            for (int x = 0; x < dealer.PlayerHand.Count; x++)
            {
                image.GenerateImage(dealer.PlayerHand[x].ToString(), view.DealerListView);
            }

            for (int x = 0; x < player.PlayerHand.Count; x++)
            {
                image.GenerateImage(dealer.PlayerHand[x].ToString(), view.PlayerListView);
            }

            for (int x = 0; x < dealer.PlayerHand.Count; x++)
            {
                PlayerManager playerHand = new PlayerManager();
                dHandTotal = playerHand.CalculateHand(dealer);
            }

          

            view.PlayerTotal.Text = Convert.ToString(pHandTotal);
            view.DealerTotal.Text = Convert.ToString(dHandTotal);




        }


 

    }
}
