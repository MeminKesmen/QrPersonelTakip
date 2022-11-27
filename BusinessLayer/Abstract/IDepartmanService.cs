using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDepartmanService
    {
        List<Departmen> GetAll(Expression<Func<Departmen, bool>> filter = null);
        Departmen Get(Expression<Func<Departmen, bool>> filter);
        bool Add(string departmanAd);
        bool Update(string departmanId, string departmanAd);
        bool Delete(string departmanId);
    }
}
