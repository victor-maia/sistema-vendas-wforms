using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SistemaDeVenda.DAL_Classes
{

    public class userDAL_Class
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;


        #region Selecionar dados do Banco de Dados
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select * from tbl_usuarios";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex) {
                throw ex;
            }

            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
    }
}
