using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQProDXApp.Entities
{
    internal class User
    {
        public string EQProUserID { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string ESignature { get; set; }
        public DateTime DateChange { get; set; } = DateTime.Now;
        public DateTime DateCurrent { get; set; } = DateTime.Now;
        public bool CanCreateEQProID { get; set; }
        public bool CanCreateUserID { get; set; }
        public string EQRole { get; set; }
        public string UserRole { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }

        public void InsertOrUpdateUser(String query, User user, string message)
        {            
            SqlConnection conn = new Class_PublicDataAccessLayer().getSqlConn();
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@EQProUserID", user.EQProUserID);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@MiddleName", user.MiddleName);
                command.Parameters.AddWithValue("@Prefix", user.Prefix);
                command.Parameters.AddWithValue("@Suffix", user.Suffix);
                command.Parameters.AddWithValue("@ESignature", user.ESignature);
                command.Parameters.AddWithValue("@DateChange", DateChange);
                command.Parameters.AddWithValue("@DateCurrent", DateCurrent);
                command.Parameters.AddWithValue("@CanCreateEQProID", user.CanCreateEQProID);
                command.Parameters.AddWithValue("@CanCreateUserID", user.CanCreateUserID);
                command.Parameters.AddWithValue("@EQRole", user.EQRole);
                command.Parameters.AddWithValue("@UserRole", user.UserRole);
                command.Parameters.AddWithValue("@email", user.Email);
                command.Parameters.AddWithValue("@IsDeleted", user.IsDeleted);

                int row = command.ExecuteNonQuery();

                if(row > 0)
                {
                    MessageBox.Show(message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Some Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            finally
            {
                conn.Close();
            }
            
            
            //if(row > 0)
            //{
            //    MessageBox.Show("")
            //}
        } 
    }
}
