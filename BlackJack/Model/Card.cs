using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Model
{
    public class Card
    {

        public string Suit { get; set; }
        public int Number { get; set; }     
    
        public Card(int number, string suit)
        {
            Number = number;
            Suit = suit;
 
        }

        public override string ToString()
        {
            return Number + Suit;
        }

 
    }
}
