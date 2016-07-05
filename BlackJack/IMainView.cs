using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public interface IMainView
    {
        Label DealerLabel { get; }
        Label DealerTotal { get; }
        Label PlayerLabel { get; }
        Label PlayerTotal { get; }
        ListView PlayerListView { get; }
        ListView DealerListView { get; }


    }
}
