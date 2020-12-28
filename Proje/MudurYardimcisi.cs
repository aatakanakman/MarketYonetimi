using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class MudurYardimcisi: Calisan
    {
        public MudurYardimcisi()
        {

        }
        public override void MaasHesapla()
        {
            base.MaasHesapla();
            maas *= 3M;
        }
    }
}
