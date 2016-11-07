using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VscApp.Data;
using System.Collections.Generic;

namespace VscApp.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private static IRouteRepository repo = new RouteRepository();

        [TestMethod]
        public IEnumerable<DriverInfo> GetAllDrivers()
        {
            return repo.GetAll();
        }
    }
}
