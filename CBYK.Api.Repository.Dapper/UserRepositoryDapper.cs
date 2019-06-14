using CBYK.Api.Entity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBYK.Api.Repository.Dapper
{
    public class UserRepositoryDapper
    {
       
        public UserEntity Get(string userName, string password)
        {
            try
            {

                string query = @"SELECT * FROM [DB_Teste].[dbo].[UserEntities] where UserName = @user and Password = @pwd";

                var result = CBYK.Api.Repository.Dapper.ConnectionHelper.Instance.Use(ConfigurationManager.ConnectionStrings["DataContextBase"].ConnectionString, conn =>
                {
                    var parameters = new { user = userName, pwd = password };

                    return conn.Query<UserEntity>(query, parameters);
                });

                return result.FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


    }
}
