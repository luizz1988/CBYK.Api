using CBYK.Api.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBYK.Api.Repository
{
    public class CBYKContext : DbContext
    {
        public CBYKContext() : base("name=DataContextBase")
        {
        }

        public DbSet<UserEntity> User { get; set; }


      

    }
}
