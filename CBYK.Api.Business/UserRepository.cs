using CBYK.Api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBYK.Api.Repository
{
    public class UserRepository
    {
        private CBYKContext db = new CBYKContext();

        #region Methods

        public UserEntity Get(string userName,string password)
        {
            try
            {
                var ret = db.User.FirstOrDefault(c => c.UserName == userName && c.Password == password);
                return ret;
            }
            catch (Exception)
            {
                throw;
            }
           

        }

        #endregion


    }
}
