using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    interface IUserService:IEntityRepository<User>
    {
        string kullaniciKontrol(int index);
        string sifreKontrol(int index);
        string IdKontrol(int index);

    }
}
