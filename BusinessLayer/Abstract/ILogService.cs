using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILogService
    {
        List<Logs> GetAll(Expression<Func<Logs, bool>> filter = null);
        Logs Get(Expression<Func<Logs, bool>> filter);
        bool Add(Logs log);
        bool Update(Logs log);
        bool Delete(int logId);
    }
}
