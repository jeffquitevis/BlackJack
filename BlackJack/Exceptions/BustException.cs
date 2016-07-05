using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Exceptions
{
    public class BustException : Exception
    {

        public BustException()
        {
            
        }


        public BustException(string message)
            :base(message)
        {
            
        }
    }
}
