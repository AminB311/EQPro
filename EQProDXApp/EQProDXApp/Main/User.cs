using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace EQProDXApp
{
    internal class User
    {
        Class_PublicDataAccessLayer objDALCls = new Class_PublicDataAccessLayer();
        SqlConnection SqlConn = new SqlConnection();

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
     
        public string EQRole { get; set; }
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
                command.Parameters.AddWithValue("@EQRole", user.EQRole);
                command.Parameters.AddWithValue("@email", user.Email);
                command.Parameters.AddWithValue("@IsDeleted", user.IsDeleted);

                int row = command.ExecuteNonQuery();

                if (row > 0)
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
