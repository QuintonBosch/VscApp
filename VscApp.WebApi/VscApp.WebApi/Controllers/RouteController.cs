using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VscApp.Data;

namespace VscApp.WebApi.Controllers
{
    /// <summary>
    /// Route controller to return the driver route details
    /// </summary>
    public class RouteController : ApiController
    {
        static readonly IRouteRepository repository = new RouteRepository();

        /// <summary>
        /// Return the full list of drive information 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<DriverInfo> GetAllDriverInfo()
        {
            return repository.GetAll();
        }

        /// <summary>
        /// Return the driver with the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DriverInfo GetDriverById(int id)
        {
            return repository.Get(id);
        }
    }
}
