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
    public class DepartmanManager : IDepartmanService
    {
        IDepartmanDal _departmanDal = new EfDepartmanDal();
        public bool Add(string departmanAd)
        {
            if (departmanAd.Length > 2)

            {
                Departmen departmen = new Departmen();
                departmen.DepartmanAd = departmanAd;
                _departmanDal.Add(departmen);
                return true;
            }
            return false;

        }

        public bool Delete(string departmanId)
        {
            if (int.TryParse(departmanId, out int id) && id > 0)
            {
                var departman = _departmanDal.Get(x => x.DepartmanID == id);
                _departmanDal.Delete(departman);
                return true;
            }
            return false;
        }

        public Departmen Get(Expression<Func<Departmen, bool>> filter)
        {
            return _departmanDal.Get(filter);
        }

        public List<Departmen> GetAll(Expression<Func<Departmen, bool>> filter = null)
        {
            return filter == null ? _departmanDal.GetAll() : _departmanDal.GetAll(filter);
        }

        public bool Update(string departmanId, string departmanAd)
        {

            if (int.TryParse(departmanId, out int id) && departmanAd.Length > 2)
            {
                var bulDepartman = _departmanDal.Get(x => x.DepartmanID == id);
                bulDepartman.DepartmanAd = departmanAd;
                _departmanDal.Update(bulDepartman);
                return true;
            }
            return false;

        }
    }
}
