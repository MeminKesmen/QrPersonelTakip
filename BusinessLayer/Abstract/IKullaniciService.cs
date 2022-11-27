using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IKullaniciService
    {
        List<Kullanicis> GetAll(Expression<Func<Kullanicis, bool>> filter = null);
        Kullanicis Get(Expression<Func<Kullanicis, bool>> filter);
        bool Add(string kulAd, string kulSifre, int personelId, int yetkiId);
        bool Update(string kulId, string kulAd, string kulSifre, int personelId, int yetkiId);
        bool Delete(string kullaniciId);
    }
}
