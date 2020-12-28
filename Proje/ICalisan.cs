using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proje
{
    public interface ICalisan
    {
        void CalisanEkle(Calisan calisan);
        void CalisanSil(Calisan calisan);
        void CalisanGuncelle(Calisan calisan);
        DataTable CalisanGetir();
    }
}
