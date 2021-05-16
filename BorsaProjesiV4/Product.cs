using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Product:IEntity
    {
        public string UrunSahibiId { get; set; }
        public string UrunAdi { get; set; }
        public string UrunBirimi { get; set; }
        public string UrunFiyati { get; set; }
        public string UrunId { get; set; }
        public bool UrunOnay { get; set; }

    }
}
