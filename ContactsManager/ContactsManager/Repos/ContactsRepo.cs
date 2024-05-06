using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsManager.Interfaces;
using ContactsManager.Models;
using ContactsManager.Services;
namespace ContactsManager.Repos
{
    public class ContactsRepo : DbConnector, IContacts
    {
        public List<Contact> GetAllContactsOfCategory(int categoryId)
        {
            var resultList = new List<Contact>();

            try
            {
                string sqlQuery = "select * from Contacts where CategoryId = @categoryId";
                _connection.Open();
                _command = new SqlCommand(sqlQuery, _connection);
                _command.Parameters.AddWithValue("@categoryId", categoryId);
                _reader = _command.ExecuteReader();
                while (_reader.Read())
                {
                    resultList.Add(new Contact()
                    {
                        Id = (int)_reader["Id"],
                        ContactName = _reader["ContactName"].ToString(),
                        City = _reader["City"].ToString(),
                        Field = _reader["Field"].ToString(),
                        Phone = _reader["Phone"].ToString(),
                        Email = _reader["Email"].ToString(),
                        Telegram = _reader["Telegram"].ToString(),
                        Notes = _reader["Notes"].ToString(),
                        Photo = _reader["Photo"].ToString(),
                        CategoryId = (int)_reader["CategoryId"]
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Contacts Download Error: {ex.Message}", "Error",
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
