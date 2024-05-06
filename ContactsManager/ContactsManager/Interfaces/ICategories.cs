using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsManager.Models;

namespace ContactsManager.Interfaces
{
    public interface ICategories
    {
        List<Category> GetAllCategories(int userId);
        void AddCategory(Category newCategory, int userId);
        void DeleteCategory(int categoryId, int userId);
        void EditCategory(Category changedCategory, int userId);

    }
}
