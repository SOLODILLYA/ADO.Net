using ContactsManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.Interfaces
{
    public interface IContacts
    {
        List<Contact> GetAllContactsOfCategory(int categoryId);
    }
}
