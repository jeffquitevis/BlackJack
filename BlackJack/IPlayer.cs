using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Model;

namespace BlackJack
{
    public interface IPlayer
    {

        Card AddCard(Card card);
        List<Card> PlayerHand { get; }    
       

    }
}
