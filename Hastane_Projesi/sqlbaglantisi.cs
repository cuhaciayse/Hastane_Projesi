using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Projesi
{
    public class sqlbaglantisi
    {
        public SqlConnection connection()
        {
            SqlConnection connection = new SqlConnection("Data Source=ODA;Initial Catalog=Hastane_Projesi;Integrated Security=True");
            connection.Open();
            return connection;
            
        }   
        

    }
}
