using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{   
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string sqlcon = @"Data Source=LAPTOP-OUJP2SVF\TUAN;Initial Catalog=QLDLC1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlcon);
            return conn;
        }

    }
    public class DatabaseAccess
    {
      public static int CheckLoginDTO(Account Acc1)
        {
            try
            {
                SqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                SqlCommand command = new SqlCommand("proc_login", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@user", Acc1.TaiKhoan);
                command.Parameters.AddWithValue("@pass", Acc1.MatKhau);
                command.Connection = conn;
                object kq = command.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                conn.Close();
                return code;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 10;
            }

        }
    }
}
