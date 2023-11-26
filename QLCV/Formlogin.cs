
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace QLCV
{

  public partial class Formlogin : Form
  {
    private static MySqlConnection? mySqlConnection;
    public Formlogin()
    {
      InitializeComponent();
      mySqlConnection = Connect3.Connection();
      mySqlConnection.Open();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      txt_username.Text = Properties.Settings.Default.Username;
      txt_password.Text = Properties.Settings.Default.Password;
      if (Properties.Settings.Default.Username != "")
      {
        checkBox1.Checked = true;
      }
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void btn_login_Click(object sender, EventArgs e)
    {
      bool shouldSaveCredentials = checkBox1.Checked;

      string username = txt_username.Text;
      string password = txt_password.Text;
      if (username.Equals(""))
      {
        MessageBox.Show("Tài khoản không được để trống", "Cảnh Báo");
        txt_username.Focus();
      }
      else if (password.Equals(""))
      {
        MessageBox.Show("Mật khẩu không được để trống", "Cảnh Báo");
        txt_password.Focus();
      }
      else
      {
        string query = $"SELECT * FROM user WHERE username='{username}' AND password='{password}';";
        MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
        MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
          if (reader.HasRows)
          {
            if (reader.GetBoolean(2))
            {
              Form_admin form_Admin = new Form_admin();
              form_Admin.Show();
              this.Hide();
            }
            else
            {
              Form_employee form_Employee = new Form_employee(username);
              form_Employee.Show();
              this.Hide();
            }

          }
        }
      }
    }

    private void F_logout(object? sender, EventArgs e)
    {
      (sender as Form_admin).isExit = false;
      (sender as Form_admin).Close();
      this.Show();
    }

    private void btn_exit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void Formlogin_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (txt_username.Text != "" && txt_password.Text != "")
      {
        if (checkBox1.Checked)
        {
          string username = txt_username.Text;
          string password = txt_password.Text;
          Properties.Settings.Default.Username = username;
          Properties.Settings.Default.Password = password;
          Properties.Settings.Default.Save();
        }
        else
        {
          Properties.Settings.Default.Reset();
        }
      }
    }

    private void Button1_ClickAsync(object sender, EventArgs e)
    {
      //FirebaShowData()seResponse resp2 = await client.GetTaskAsync(@"users/");
      //string[] product = { textBox, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text };

    }
  }
}