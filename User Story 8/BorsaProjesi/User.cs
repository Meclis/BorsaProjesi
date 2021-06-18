using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesi
{
    public class User:IEntity
    {
        public string userId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string TcNo { get; set; }
        public string TelefonNo { get; set; }
        public string Adres { get; set; }
        public string MailAdresi { get; set; }
        public decimal GuncelBakiye { get; set; }
        public decimal YeniBakiye { get; set; }
        public bool AliciYetki { get; set; }
        public bool SaticiYetki { get; set; }

    }
}
