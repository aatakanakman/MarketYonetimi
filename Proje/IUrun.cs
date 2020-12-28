using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public interface IUrun
    {
        void UrunEkle(Urun urun);
        void UrunSil(Urun urun);
        void UrunGuncelle(Urun urun);
        DataTable UrunGetir();
    }
}
