using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using CBYK.Api.Repository;
using CBYK.Api.Entity;
using CBYK.Api.Repository.Dapper;

namespace CBYK.Api.Services.Controllers
{
    public class UserController : ApiController
    {


        /// <summary>
        /// Get User 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IHttpActionResult Get([FromUri]string userName, [FromUri]string password)
        {
            try
            {
                if (userName == null || password == null)
                {
                    return NotFound();
                }

                ///// Caso queira usar com Entity
                //UserRepository rep = new UserRepository();
                //rep.Dispose();
                //var user = rep.Get(userName, password);
                //return Ok(user);

                // Caso queira usar com Dapper
                UserRepositoryDapper repDapper = new UserRepositoryDapper();
                var userDapper = repDapper.Get(userName, password);
                return Ok(userDapper);
            }
            catch (Exception ex)
            {

                return InternalServerError(new Exception("Erro na busca do usuario!", ex.InnerException));
            }
        }

        #region  Private Methods
        #endregion

    }
}