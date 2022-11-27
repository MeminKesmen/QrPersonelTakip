using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IIslemService
    {
        List<Islems> GetAll(Expression<Func<Islems, bool>> filter = null);
        Islems Get(Expression<Func<Islems, bool>> filter);
        bool Add(bool islemAd, int personelId);
        bool Update(Islems islem);
        bool Delete(int islemId);
        bool IslemKontrol(int personelId);
    }
}
