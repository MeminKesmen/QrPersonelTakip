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
    public class YetkiManager : IYetkiService
    {
        IYetkiDal _yetkiDal = new EfYetkiDal();
        public bool Add(string yetkiAd)
        {
            if (yetkiAd!="") 
            {
                Yetkis yetki = new Yetkis();
                yetki.YetkiAd = yetkiAd;
                _yetkiDal.Add(yetki);
                return true;
            }
            return false;
        }

        public bool Delete(string yetkiId)
        {
            if (int.TryParse(yetkiId,out int id)&&id>0) 
            {
                var yetki = _yetkiDal.Get(x=>x.YetkiID==id);
                _yetkiDal.Delete(yetki);
                return true;
            }
            return false;
        }

        public Yetkis Get(Expression<Func<Yetkis, bool>> filter)
        {
            return _yetkiDal.Get(filter);
        }

        public List<Yetkis> GetAll(Expression<Func<Yetkis, bool>> filter = null)
        {
            return filter == null ? _yetkiDal.GetAll() : _yetkiDal.GetAll(filter);
        }

        public bool Update(string yetkiId, string yetkiAd)
        {
            if (int.TryParse(yetkiId,out int id)&&yetkiAd != "")
            {
                var bulYetki = _yetkiDal.Get(x=>x.YetkiID==id);
                bulYetki.YetkiAd = yetkiAd;
                _yetkiDal.Update(bulYetki);
                return true;
            }
            return false;
            
        }
    }
}
