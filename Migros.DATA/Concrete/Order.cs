using Migros.DATA.Abstract;
using Migros.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migros.DATA.Concrete
{
    public class Order : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public Status Status { get; set; }

        //Navigation Property

        public string UserID { get; set; }
        public AppUser Musteri { get; set; }

        public List<Product> Products { get; set; }


    }
}
