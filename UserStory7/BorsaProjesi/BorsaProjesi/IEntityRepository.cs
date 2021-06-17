using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesi
{
 
    interface IEntityRepository<T> where T:class,IEntity,new()
    {
     
        List<T> GetList();

    }
}
