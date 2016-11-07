using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VscApp.Data
{
    public class LoginRepository : ILoginRepository
    {
        VscEntities db = new VscEntities();

        public bool IsAuthenticated(string username, string password)
        {
            try
            {
                AppUser user = db.AppUsers.FirstOrDefault(p => p.UserName == username && p.Password == password);

                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
