using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCV
{
  public partial class Form_add_user : Form
  {
    private static MySqlConnection? connection;
    public Form_add_user()
    {
      InitializeComponent();
      connection = Connect3.Connection();
    }

    private void btn_adduser_lammoi_Click(object sender, EventArgs e)
    {
      txt_adduser_username.Text = "";
      txt_adduser_password.Text = "";
      combobox_adduser_usertype.SelectedIndex = 0;
    }

    private void btn_adduser_themtaikhoan_Click(object sender, EventArgs e)
    {
      
      string username = txt_adduser_username.Text;
      string password = txt_adduser_password.Text;
      string usertype = combobox_adduser_usertype.Text;
      try
      {
        connection.Open();
        if (usertype.Equals("admin"))
        {
          string query = sql.InsertUserQuery(username, password, 1);
          MySqlCommand cmd = new MySqlCommand(query, connection);
          int rowsAffected = cmd.ExecuteNonQuery();
          if (rowsAffected > 0)
          {
            MessageBox.Show("Thêm Mới Thành công", "Thông Báo");
          }
          else
          {
            MessageBox.Show("Thêm Mới Thất bại", "Thông Báo");
          }
        }
        else
        {
          string query = sql.InsertUserQuery(username, password, 0);
          MySqlCommand cmd = new MySqlCommand(query);
          int rowsAffected = cmd.ExecuteNonQuery();
          if (rowsAffected > 0)
          {
            MessageBox.Show("Thêm Mới Thành công", "Thông Báo");
          }
          else
          {
            MessageBox.Show("Thêm Mới Thất bại", "Thông Báo");
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "show");

      }
      finally
      {
        if (connection.State == ConnectionState.Open)
        {
          connection.Close();
        }
      }
    }
  }
}
