using Microsoft.EntityFrameworkCore;
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
        private readonly DbSet<T> table;
        public BaseRepo(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.table = dbContext.Set<T>();
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
            return table.Any(filter);
        }

        public void Delete(T entity)
        {
            entity.DeleteDate = DateTime.Now;
            entity.Status = Status.Passive;
            table.Update(entity);
            dbContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public bool Update(T entity)
        {
            entity.UpdateDate= DateTime.Now;
            entity.Status = Status.Modified;
            table.Update(entity);
            if (dbContext.SaveChanges() > 0)
                return true;
            else
                return false; 
        }

        IList<T> IBaseRepo<T>.GetAll()
        {
            var list=table.ToList();
            return list;
        }
    }
}
