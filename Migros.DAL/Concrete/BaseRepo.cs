using Migros.DAL.Abstract;
using Migros.DAL.Contexts;
using Migros.DATA.Abstract;
using Migros.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Migros.DAL.Concrete
{
    public class BaseRepo<T> : IBaseRepo<T> where T :class, IBaseEntity
    {
        private readonly AppDbContext dbContext;

        public BaseRepo(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool Add(T entity)
        {
            dbContext.Add(entity);
            if (dbContext.SaveChanges() > 0)
                return true;
            else
                return false;
        }

        public bool Any(Expression<Func<T, bool>> filter)
        {
            return dbContext.Set<T>().Any(filter);
        }

        public void Delete(T entity)
        {
            entity.DeleteDate = DateTime.Now;
            entity.Status = Status.Passive;
            dbContext.Set<T>().Update(entity);
            dbContext.SaveChanges();
        }

        public bool Update(T entity)
        {
            entity.UpdateDate= DateTime.Now;
            entity.Status = Status.Modified;
            dbContext.Set<T>().Update(entity);
            if (dbContext.SaveChanges() > 0)
                return true;
            else
                return false; 
        }

        IList<T> IBaseRepo<T>.GetAll()
        {
            var list=dbContext.Set<T>().ToList();
            return list;
        }
    }
}
