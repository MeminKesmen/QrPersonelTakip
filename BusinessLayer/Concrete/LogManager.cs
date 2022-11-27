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
    public class LogManager : ILogService
    {
        ILogDal _logDal = new EfLogDal();
        public bool Add(Logs log)
        {
            if (log.LogIslem!="") 
            {
                _logDal.Add(log);
                return true;    
            }
            return false;
            
        }

        public bool Delete(int logId)
        {
            if (logId>0) 
            {
                var log = _logDal.Get(x=>x.LogID==logId);
                _logDal.Delete(log);
                return true;
            }
            return false;
        }

        public Logs Get(Expression<Func<Logs, bool>> filter)
        {
            return _logDal.Get(filter);
        }

        public List<Logs> GetAll(Expression<Func<Logs, bool>> filter = null)
        {
            return filter == null ? _logDal.GetAll() : _logDal.GetAll(filter);
        }

        public bool Update(Logs log)
        {
            if (log.LogIslem != "")
            {
                _logDal.Update(log);
                return true;
            }
            return false;
        }
    }
}
