using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IIzinService
    {
        List<Izins> GetAll(Expression<Func<Izins, bool>> filter = null);
        Izins Get(Expression<Func<Izins, bool>> filter);
        bool Add(string izinBas, string izinBit, int personelId);
        bool Update(Izins izin);
        bool Delete(string izinId);
    }
}
