using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal = new EfKullaniciDal();
        public bool Add(string kulAd, string kulSifre, int personelId, int yetkiId)
        {
            if (kulAd != "" && kulSifre != "" && personelId > 0 && yetkiId > 0)
            {
                Kullanicis kullanici = new Kullanicis();
                kullanici.KullaniciAd = kulAd;
                kullanici.KullaniciSifre = kulSifre;
                kullanici.Yetki_YetkiID = yetkiId;
                kullanici.Personel_PersonelID = personelId;
                _kullaniciDal.Add(kullanici);
                return true;
            }
            return false;
        }

        public bool Delete(string kullaniciId)
        {
            if (int.TryParse(kullaniciId, out int id) && id > 0)
            {
                var kullanici = _kullaniciDal.Get(x => x.KullaniciID == id);
                _kullaniciDal.Delete(kullanici);
                return true;
            }
            return false;
        }

        public Kullanicis Get(Expression<Func<Kullanicis, bool>> filter)
        {
            return _kullaniciDal.Get(filter);
        }

        public List<Kullanicis> GetAll(Expression<Func<Kullanicis, bool>> filter = null)
        {
            return filter == null ? _kullaniciDal.GetAll() : _kullaniciDal.GetAll(filter);
        }

        public bool Update(string kulId, string kulAd, string kulSifre, int personelId, int yetkiId)
        {
            if (int.TryParse(kulId, out int id) && kulAd != "" && kulSifre != "" && personelId > 0 && yetkiId > 0)
            {
                var bulKullanici = _kullaniciDal.Get(x => x.KullaniciID == id);
                bulKullanici.KullaniciAd = kulAd;
                bulKullanici.KullaniciSifre = kulSifre;
                bulKullanici.Yetki_YetkiID = yetkiId;
                bulKullanici.Personel_PersonelID = personelId;
                _kullaniciDal.Update(bulKullanici);
                return true;
            }
            return false;
        }
    }
}
