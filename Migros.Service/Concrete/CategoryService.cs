using Migros.DAL.Abstract;
using Migros.DATA.Concrete;
using Migros.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migros.Service.Concrete
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        public CategoryService(IBaseRepo<Category> repo) : base(repo)
        {
        }
    }
}
