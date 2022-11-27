using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IYetkiService
    {
        List<Yetkis> GetAll(Expression<Func<Yetkis, bool>> filter = null);
        Yetkis Get(Expression<Func<Yetkis, bool>> filter);
        bool Add(string yetkiAd); 
        bool Update(string yetkiId, string yetkiAd);
        bool Delete(string yetkiId);
    }
}
