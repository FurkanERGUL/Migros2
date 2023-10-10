

using Microsoft.AspNetCore.Identity;
using Migros.DATA.Abstract;
using Migros.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Migros.DATA.Concrete
{
    public class AppUser : IdentityUser, IBaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public Status Status { get; set; }
    }
}
