using Migros.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Migros.DAL.Abstract
{
    public interface IBaseRepo<T> where T : class, IBaseEntity
    {
        bool Add(T entity);
        void Delete(T entity);
        bool Update(T entity);
        IList<T> GetAll();
        T GetById(int id);
        bool Any(Expression<Func<T, bool>> filter);
    }
}
