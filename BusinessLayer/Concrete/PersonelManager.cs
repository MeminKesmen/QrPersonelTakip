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
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal = new EfPersonelDal();
        public bool Add(string ad, string soyAd, string tc, string tel, string adres, string maas, string dTarih, string mail, string qr, string resim, int meslekId)
        {

            if (ad != "" && soyAd != "" && tc.Length == 11 && tel.Length > 10
                && adres != "" && decimal.TryParse(maas, out decimal pMaas) && DateTime.TryParse(dTarih, out DateTime
                 pDTarih) && mail != ""
                && qr != "" && !resim.Contains("EmptyUser") && meslekId >0)
            {
                Personels personel = new Personels();
                personel.PersonelAd = ad;
                personel.PersonelSoyad = soyAd;
                personel.PersonelTC = tc;
                personel.PersonelTel = tel;
                personel.PersonelAdres = adres;
                personel.PersonelMaas = pMaas;
                personel.PersonelDogumTarih = pDTarih;
                personel.PersonelMail = mail;
                personel.PersonelQR = qr;
                personel.PersonelResim = resim;
                personel.Meslek_MeslekID = meslekId;
                _personelDal.Add(personel);
                return true;
            }
            return false;
        }

        public bool Delete(string personelId)
        {
            if (int.TryParse(personelId,out int id)&&id > 0)
            {
                var personel = _personelDal.Get(x => x.PersonelID == id);
                _personelDal.Delete(personel);
                return true;
            }
            return false;
        }

        public Personels Get(Expression<Func<Personels, bool>> filter)
        {
            return _personelDal.Get(filter);
        }

        public List<Personels> GetAll(Expression<Func<Personels, bool>> filter = null)
        {
            return filter == null ? _personelDal.GetAll() : _personelDal.GetAll(filter);
        }

        public bool QrYenile(string personelId, string qr)
        {
            if (int.TryParse(personelId,out int id)&&qr!="") {
                var bulPersonel = _personelDal.Get(x=>x.PersonelID==id);
                bulPersonel.PersonelQR = qr;
                _personelDal.Update(bulPersonel);
                return true;
            }
            return false;
        }

        public bool Update(string pId, string ad, string soyAd, string tc, string tel, string adres, string maas, string dTarih, string mail, string qr, string resim, int meslekId)
        {
            if (int.TryParse(pId, out int id) && ad != "" && soyAd != "" && tc.Length == 11 && tel.Length > 10
                && adres != "" && decimal.TryParse(maas, out decimal pMaas) && DateTime.TryParse(dTarih, out DateTime
                 pDTarih) && mail != ""
                && qr != "" && !resim.Contains("EmptyUser") && meslekId >0)
            {
                var bulPersonel = _personelDal.Get(x => x.PersonelID == id);
                bulPersonel.PersonelAd = ad;
                bulPersonel.PersonelSoyad = soyAd;
                bulPersonel.PersonelTC = tc;
                bulPersonel.PersonelTel = tel;
                bulPersonel.PersonelAdres = adres;
                bulPersonel.PersonelMaas = pMaas;
                bulPersonel.PersonelDogumTarih = pDTarih;
                bulPersonel.PersonelMail = mail;
                bulPersonel.PersonelQR = qr;
                bulPersonel.PersonelResim = resim;
                bulPersonel.Meslek_MeslekID = meslekId;
                _personelDal.Update(bulPersonel);
                return true;
            }
            return false;

        }
    }
}
