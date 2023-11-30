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
  public partial class doimatkhau : Form
  {
    Form_employee fEmployee;
    public bool isExit = false;
    private MySqlConnection connect;
    private string username;
    private string password;
    public doimatkhau(string username,string password)
    {
      InitializeComponent();
      this.username = username;
      this.password = password;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void btn_doimatkhau_quaylai_Click(object sender, EventArgs e)
    {
      isExit = true;
      this.Close();
      fEmployee = new Form_employee(username,password);
      fEmployee.Show();
    }

    private void doimatkhau_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing && !isExit)
      {
        // Ngăn chặn đóng form và thay vào đó ẩn form
        Application.Exit();
      }
    }

    private void btn_doimatkhau_capnhat_Click(object sender, EventArgs e)
    {
      string username = this.username;
      string password = this.password;  

      string oldpass = txt_oldpassword.Text;
      string newpass = txt_newpassword.Text;
      string replacepass = txt_newpassword_replace.Text;
      connect.Open();
      if(password.Equals(oldpass) && newpass.Equals(replacepass))
      {
        string query = sql.update_matkhau(username, newpass);
        MySqlCommand cmd = new MySqlCommand(query,connect);
        int roweffect = cmd.ExecuteNonQuery();
        if(roweffect > 0)
        {
          MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo");
        }
        else
        {
          MessageBox.Show("Thay đổi mật khẩu thất bại", "Thông báo");
        }
        connect.Close();
      }
    }

    private void doimatkhau_Load(object sender, EventArgs e)
    {
      connect = Connect3.Connection();
    }
  }
}
