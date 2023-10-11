using Migros.DAL.Abstract;
using Migros.DATA.Abstract;
using Migros.Service.Abstract;
using System.Linq.Expressions;

namespace Migros.Service.Concrete
{
    public class BaseService<T> : IBaseService<T> where T : class, IBaseEntity
    {
        private readonly IBaseRepo<T> _repo;

        public BaseService(IBaseRepo<T> repo)
        {
            _repo = repo;
        }

        public bool Add(T entity)
        {
            return _repo.Add(entity);
        }

        public bool Any(Expression<Func<T, bool>> filter)
        {
            return _repo.Any(filter);
        }

        public void Delete(T entity)
        {
            _repo.Delete(entity);
        }

        public IList<T> GetAll()
        {
            return _repo.GetAll();
        }

        public T GetById(int id)
        {
            return _repo.GetById(id);
        }

        public bool Update(T entity)
        {
            return _repo.Update(entity);
        }
    }
}
