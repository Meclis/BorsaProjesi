using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    //Generic interface tanımı. T'ye sadece class türünden değişken veriyoruz. Veritabanından çekeceğimiz varlıkları IEntity içerisinde topluyoruz.
    //new() kodu T yerine yazacağımız sınıfın somut olması zorunluluğunu sağlıyor.
    interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Veri tabanında yapacağımız operasyonlarını yazdığımız Interface.Ortak olan operasyon metod imzalarını tekrarlanmaktan kaçınmamızı sağlamaktadır.
        List<T> GetList();

    }
}
