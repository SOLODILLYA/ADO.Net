using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.Interfaces
{
    public interface IUsers
    {
        bool SignUp(string userLogin, string UserPassword);
        bool SignIn(string userLogin, string UserPassword);
        string GetMd5Hash(string text);
    }
}
