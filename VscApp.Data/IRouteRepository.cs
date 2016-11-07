using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VscApp.Data;

namespace VscApp.Data
{
    public interface IRouteRepository
    {
        List<DriverInfo> GetAll();
        DriverInfo Get(int id);
        bool Update(DriverInfo item);
    }
}
