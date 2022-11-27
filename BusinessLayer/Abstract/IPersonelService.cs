using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPersonelService
    {
        List<Personels> GetAll(Expression<Func<Personels, bool>> filter = null);
        Personels Get(Expression<Func<Personels, bool>> filter);
        bool Add(string ad, string soyAd, string tc, string tel, string adres, string maas, string dTarih, string mail, string qr, string resim, int meslekId);
        bool Update(string pId, string ad, string soyAd, string tc, string tel, string adres, string maas, string dTarih, string mail, string qr, string resim, int meslekId);
        bool Delete(string personelId);
        bool QrYenile(string personelId,string qr);
        void QrGonder(Personels personel);
    }
}
