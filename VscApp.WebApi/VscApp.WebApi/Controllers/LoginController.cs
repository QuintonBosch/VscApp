using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using VscApp.Data;

namespace VscApp.WebApi.Controllers
{
    /// <summary>
    /// Login controller used for authentication
    /// </summary>
    public class LoginController : ApiController
    {
        static readonly ILoginRepository repo = new LoginRepository();

        /// <summary>
        /// Returns if the user is authenticated against the database. Very simple, no encryption. 
        /// </summary>
        /// <param name="username">Users username</param>
        /// <param name="password">'Secure' Password :) </param>
        [HttpGet]
        [EnableCors(origins: "http://localhost:58306", headers: "*", methods: "get")]
        public bool Authenticate(string username, string password)
        {
            if(repo.IsAuthenticated(username, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
