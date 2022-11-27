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
    public class IslemManager : IIslemService
    {
        IIslemDal _islemDal = new EfIslemDal();
        public bool Add(bool islemAd, int personelId)
        {
            if (personelId > 0)
            {
                Islems islem = new Islems();
                islem.IslemAd = islemAd;
                islem.Personel_PersonelID = personelId;
                _islemDal.Add(islem);
            }

            return true;
        }
        public bool IslemKontrol(int personelId)
        {
            var islem = _islemDal.GetAll(x => x.Personel_PersonelID == personelId);
            if (islem.Count > 0)
            {
                return !islem.Last().IslemAd;
            }

            return true;

        }

        public bool Delete(int islemId)
        {
            if (islemId > 0)
            {
                var islem = _islemDal.Get(x => x.IslemID == islemId);
                _islemDal.Delete(islem);
                return true;
            }
            return false;
        }

        public Islems Get(Expression<Func<Islems, bool>> filter)
        {
            return _islemDal.Get(filter);
        }

        public List<Islems> GetAll(Expression<Func<Islems, bool>> filter = null)
        {
            return filter == null ? _islemDal.GetAll().OrderByDescending(x => x.IslemTarih).ToList() : _islemDal.GetAll(filter).OrderByDescending(x => x.IslemTarih).ToList();
        }

        public bool Update(Islems islem)
        {
            _islemDal.Update(islem);
            return true;
        }
    }
}
