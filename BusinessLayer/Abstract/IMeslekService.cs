using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMeslekService
    {
        List<Mesleks> GetAll(Expression<Func<Mesleks, bool>> filter = null);
        Mesleks Get(Expression<Func<Mesleks, bool>> filter);
        bool Add(string meslekAd, int departmanId); 
        bool Update(string meslekId, string meslekAd, int departmanId);
        bool Delete(string meslekId);
    }
}
