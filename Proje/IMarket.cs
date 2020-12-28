using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public interface IMarket
    {
        void MarketEkle(Market market);
        void MarketSil(Market market);
        void MarketGuncelle(Market market);
        void MarketGetir();
    }
}
