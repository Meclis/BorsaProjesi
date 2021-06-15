using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesi
{
    public class DemandedProduct:IEntity
    {
        public string TalepEdenId { get; set; }
        public string UrunAdi { get; set; }
        public string UrunFiyati { get; set; }
        public string UrunBirimi { get; set; }
        public string TalepEdilenUrunId { get; set; }


    }
}
