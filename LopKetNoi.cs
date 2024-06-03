using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace ktracuoiki

{
    public class LopKetNoi
    {
        SqlConnection con;
        private void MoKetNoi()
        {
            string sqlcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C++\\ktracuoiki\\ktracuoiki\\App_Data\\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(sqlcon);
            con.Open();

        }
        private void DongKetNoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public DataTable DocDuLieu(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                MoKetNoi();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch
            {
                dt = null;
            }
            finally
            {
                DongKetNoi();
            }
            return dt;
        }
       
    }
}