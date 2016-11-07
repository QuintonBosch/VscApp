using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VscApp.Data
{
    public interface ILoginRepository
    {
        bool IsAuthenticated(string Username, string password);
    }
}
