using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetList();

    }
}
