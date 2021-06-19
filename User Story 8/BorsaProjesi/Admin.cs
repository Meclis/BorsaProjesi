using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesi
{
    public class Admin:IEntity
    {
        public string AdminTcNo { get; set; }
        public string AdminSifre { get; set; }

    }
}
