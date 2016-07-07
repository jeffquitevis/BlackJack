using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BlackJack.Controller;
using BlackJack.Model;
using BlackJack.Util;

namespace BlackJack.View
{
    public partial class BlackJackTableView : Form,IMainView
    {

        private BlackJackController bjc;
        private Stack<Card> deckCards = CardUtil.ShuffleCard();

        public BlackJackTableView()
        {
            InitializeComponent();
            
            bjc = new BlackJackController(deckCards,this);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
             

        }

        private void bHit_Click(object sender, System.EventArgs e)
        {
            bjc.HitPlayer(deckCards.Pop());
        }

        private void bStay_Click(object sender, System.EventArgs e)
        {

            bjc.HitDealer();
           
        }

        public Label DealerLabel
        {
            get { return lblDealer; }
        }

        public Label DealerTotal
        {
            get { return lblDealerTotal; }
        }

        public Label PlayerLabel
        {
            get { return lblPlayer; }
        }

        public Label PlayerTotal
        {
            get { return lblPlayerTotal; }
        }

        public ListView PlayerListView
        {
            get { return lvPlayer; }
        }

        public ListView DealerListView
        {
            get { return lvDealer; }
        }
    }
}
