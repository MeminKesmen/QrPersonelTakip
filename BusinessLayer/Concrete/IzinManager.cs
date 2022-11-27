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
    public class IzinManager : IIzinService
    {
        IIzinDal _izinDal = new EfIzinDal();
        public bool Add(string izinBas,string izinBit,int personelId)
        {
            if (DateTime.TryParse(izinBas,out DateTime iBas)&& DateTime.TryParse(izinBit,out DateTime iBit) && personelId >0) {
                Izins izin = new Izins();
                izin.IzinBaslangic = iBas;
                izin.IzinBitis = iBit;
                izin.Personel_PersonelID = personelId;
                _izinDal.Add(izin);
                return true;
            }

            return false ;
        }

        public bool Delete(string izinId)
        {
            if (int.TryParse(izinId,out int id)&&id>0) 
            {
                var izin = _izinDal.Get(x=>x.IzinID==id);
                _izinDal.Delete(izin);
                return true;
            }
            return false;
        }

        public Izins Get(Expression<Func<Izins, bool>> filter)
        {
            return _izinDal.Get(filter);
        }

        public List<Izins> GetAll(Expression<Func<Izins, bool>> filter = null)
        {
            return filter == null ? _izinDal.GetAll() : _izinDal.GetAll(filter);
        }

        public bool Update (Izins izin)
        {
            _izinDal.Update(izin);
            return true;
        }
    }
}
