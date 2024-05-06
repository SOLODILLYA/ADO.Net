using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsManager.Interfaces;
using ContactsManager.Services;

namespace ContactsManager.Repos
{
    public class UsersRepo : DbConnector, IUsers
    {
        public string GetMd5Hash(string text)
        {
                var md5 = MD5.Create();
                byte[] data = Encoding.UTF8.GetBytes(text);
                byte[] hash = md5.ComputeHash(data);

                var builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("X2"));
                }
                return builder.ToString();
        }

        public bool SignIn(string userLogin, string UserPassword)
        {
            bool success = false;
            try
            {
                string sqlQuery = "select * from Users where UserLogin = @login and UserPassword = @password";
                _connection.Open();
                _command = new SqlCommand(sqlQuery, _connection);
                _command.Parameters.AddWithValue("@login", userLogin);
                _command.Parameters.AddWithValue("@password", UserPassword);
                _reader = _command.ExecuteReader();
                if(_reader.Read())
                {
                    MessageBox.Show("Registration-OK", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    success = true;
                }
                else
                {
                    MessageBox.Show("User Not Found", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration-Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            finally
            {
                _connection.Close();
                _command = null;
                _reader.Close();
            }
            return success;
        }

        public bool SignUp(string userLogin, string UserPassword)
        {
            bool success = false;
            try
            { 
                string sqlQuery = "insert into Users values (@login, @password)";
                _connection.Open();
                _command = new SqlCommand(sqlQuery, _connection);
                _command.Parameters.AddWithValue("@login", userLogin);
                _command.Parameters.AddWithValue("@password", UserPassword);
                _command.ExecuteNonQuery();
                MessageBox.Show("Registration-OK", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration-Error: {ex.Message}", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                success = false;
            }
            finally
            {
                _connection.Close();
                _command = null;
            }
            return success;
        }
    }
}
