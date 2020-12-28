using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    interface IKasiyer
    {
        void KasiyerEkle(Kasiyer kasiyer);
        void KasiyerSil(Kasiyer kasiyer);
        void KasiyerGüncelle(Kasiyer kasiyer);
        DataTable CalisanGetir();
    }
}
