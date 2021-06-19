using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesi
{
    public class Accounting:IEntity
    {
        public int MuhasebeId { get; set; }
        public string MuhasebeAdi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public decimal MuhasebeBakiye { get; set; }
    }
}
