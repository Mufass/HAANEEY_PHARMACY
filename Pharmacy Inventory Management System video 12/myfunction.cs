using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy_Inventory_Management_System_video_12
{
    public class myfunction
    {
        public static String connection = @"Data Source=MUFAS\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True";

        public static SqlConnection Databaseconnection()

        {
            return new SqlConnection(connection);

        }


        public  DataSet getData(String query)
        {

            SqlConnection con = Databaseconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public void setData(String query, String msg)
        { 
        SqlConnection con = Databaseconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        con.Open();
        cmd.CommandText = query;
        cmd.ExecuteNonQuery();
        con.Close();
        MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public static bool ValidateUsernameAndPassword(string username, string password, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Username cannot be empty.";
                return false;
            }

            if (username.Length < 4 )
            {
                errorMessage = "Username must be at least 4 characters long.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Password cannot be empty.";
                return false;
            }

            if (password.Length < 8)
            {
                errorMessage = "Password must be at least 8 characters long.";
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                errorMessage = "Password must contain at least one uppercase letter.";
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                errorMessage = "Password must contain at least one number.";
                return false;
            }

            return true;
        }



    }
}
