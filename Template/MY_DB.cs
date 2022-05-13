using System.Data;
using System.Data.SqlClient;

namespace Template
{
    internal class MY_DB
    {
        private SqlConnection con =
            new SqlConnection(@"Data Source=DESKTOP-PH7VFOH;Initial Catalog=QL_THU_VIEN_20222;Integrated Security =True;");

        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        public void closeConnection(){
            if ((con.State == ConnectionState.Closed))
            {
                con.Close();
            }
        }
    }
}