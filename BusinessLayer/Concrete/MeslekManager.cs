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
    public class MeslekManager : IMeslekService
    {
        IMeslekDal _meslekDal = new EfMeslekDal();
        public bool Add(string meslekAd,int departmanId)
        {
            if (meslekAd != ""&& departmanId >0) 
            {
                Mesleks meslek = new Mesleks();
                meslek.MeslekAd = meslekAd;
                meslek.Departman_DepartmanID = departmanId;
                _meslekDal.Add(meslek);
                return true;
            }
            return false;   
        }

        public bool Delete(string meslekId)
        {
            if (int.TryParse(meslekId,out int id)&&id>0) 
            {
                var meslek = _meslekDal.Get(x=>x.MeslekID==id);
                _meslekDal.Delete(meslek);
                return true;
            }
            return false;
        }

        public Mesleks Get(Expression<Func<Mesleks, bool>> filter)
        {
            return _meslekDal.Get(filter);
        }

        public List<Mesleks> GetAll(Expression<Func<Mesleks, bool>> filter = null)
        {
            return filter == null ? _meslekDal.GetAll() : _meslekDal.GetAll(filter);
        }

        public bool Update(string meslekId,string meslekAd, int departmanId)
        {
            if (int.TryParse(meslekId,out int id)&&meslekAd != ""&& departmanId>0)
            {
                var bulMeslek = _meslekDal.Get(x=>x.MeslekID==id);
                bulMeslek.MeslekAd = meslekAd;
                bulMeslek.Departman_DepartmanID = departmanId;
                _meslekDal.Update(bulMeslek);
                return true;
            }
            return false;
        }
    }
}
