using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsManager.Services;
using ContactsManager.Interfaces;
using ContactsManager.Models;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactsManager.Repos
{
    public class CategoriesRepo : DbConnector, ICategories
    {
        public void AddCategory(Category newCategory, int userId)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int categoryId, int userId)
        {
            throw new NotImplementedException();
        }

        public void EditCategory(Category changedCategory, int userId)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories(int userId)
        {
            var resultList = new List<Category>();

            try
            {
                string sqlQuery = "select * from Categories where UserId = @userId";
                _connection.Open();
                _command = new SqlCommand(sqlQuery, _connection);
                _command.Parameters.AddWithValue("@userId", userId);
                _reader = _command.ExecuteReader();
                while (_reader.Read())
                {
                    resultList.Add(new Category()
                    {
                        Id = (int)_reader["Id"],
                        CategoryName = _reader["CategoryName"].ToString(),
                        UserId = (int)_reader["UserId"],
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Category Download Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _connection.Close();
                _command = null;
                _reader.Close();
            }

            return resultList;
        }
    }
}
