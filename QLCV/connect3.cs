using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QLCV
{
  public class Connect3
  {
    private static MySqlConnection? connection;
    private static string connectionString = "Server=localhost;Database=qlcv;User ID=root;Password='';";
    public static MySqlConnection Connection()
    {
      connection = new MySqlConnection(connectionString);
      return connection;
    }
  }
}
