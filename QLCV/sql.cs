using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLCV
{
  public class sql
  {
    public static string InsertTask(int taskId, string taskName, string username, string dateCreate )
    {
      return $"INSERT INTO managertasks (taskid, taskname, status,username, createddate) " +
             $"VALUES ({taskId}, '{taskName}','đang giao','{username}', '{dateCreate}' )";
    }
    public static string InsertUserQuery(string username, string password, int usertype)
    {
      return $"INSERT INTO user (username, password, isadmin) " +
             $"VALUES ({username}, '{password}', '{usertype}')";
    }
    public static string updateStatus(string taskid)
    {
      return $"UPDATE managertasks\r\nSET status = \r\n    CASE \r\n        WHEN status = 'đang giao' THEN 'đã nhận'\r\n        WHEN status = 'đã nhận' THEN 'hoàn thành'\r\n       \r\n        ELSE status\r\n    END\r\nWHERE taskid = '{taskid}'";
    }
    public static string SelectTatCa(string taskid, string username, string dateCreate1, string dateCreate2, string status)
    {
      string sqlQuery = $"SELECT * FROM managertasks WHERE 1 = 1 AND createddate BETWEEN '{dateCreate1}' AND '{dateCreate2}'";

      // Kiểm tra và thêm điều kiện vào truy vấn nếu giá trị không rỗng
      if (!string.IsNullOrEmpty(taskid))
      {
        return sqlQuery += $" AND taskid = {taskid}";
      }

      if (!string.IsNullOrEmpty(status) && string.IsNullOrEmpty(username))
      {
        // Nếu có dữ liệu trong status và không có dữ liệu trong username
        sqlQuery += $" AND status = '{status}'";
      }
      else if (!string.IsNullOrEmpty(username) && string.IsNullOrEmpty(status))
      {
        // Nếu có dữ liệu trong username và không có dữ liệu trong status
        sqlQuery += $" AND username = '{username}'";
      }
      else if (!string.IsNullOrEmpty(status) && !string.IsNullOrEmpty(username))
      {
        // Nếu cả status và username đều có dữ liệu, sử dụng OR để chọn một trong hai điều kiện
        sqlQuery += $" AND (status = '{status}' AND username = '{username}')";
      }

      // Thêm điều kiện với createddate cho trường hợp cả status và username đều trống
      return sqlQuery;
    }
    public static string select_employee(string username,string status)
    {
      string query =  "SELECT * FROM managertasks where 1 = 1 ";
      if (!string.IsNullOrEmpty(status) && !string.IsNullOrEmpty(username))
      {
        // Nếu cả status và username đều có dữ liệu, sử dụng OR để chọn một trong hai điều kiện
        query += $" AND (status = '{status}' AND username = '{username}')";
      }
      else if (status.Equals(""))
      {
        query += $"AND username = '{username}'";
      }

      return query;
    }
    public static string delete_task(string taskid)
    {
      return $"DELETE from managertasks where taskid = '{taskid}'";
    }
    public static string update_matkhau(string username,string password)
    {
      return $"UPDATE user SET password = '{password}' where username = '{username}'";
    }
  }
}
