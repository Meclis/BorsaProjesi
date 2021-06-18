using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesi
{
    public class PurchaseHistory:IEntity
    {
        public DateTime Tarih { get; set; }
        public string UrunAdi { get; set; }
        public string UrunAliciId { get; set; }

        public string UrunFiyati { get; set; }
        public string UrunBirimi { get; set; }
        public string UrunId { get; set; }
        public string UrunSatanId { get; set; }
    }
}
