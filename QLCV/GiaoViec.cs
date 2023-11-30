using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using MySql.Data.MySqlClient;

namespace QLCV
{
  public partial class GiaoViec : Form
  {
    private Form_admin adminForm;
    public bool isExit = false;
    private static MySqlConnection? connectInsert;
    public GiaoViec(Form_admin adminForm)
    {
      InitializeComponent();
      connectInsert = Connect3.Connection();
      connectInsert.Open();
      this.adminForm = adminForm;
      this.FormClosing += GiaoViec_FormClosing;
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void btn_giaoviec_quaylai_Click(object sender, EventArgs e)
    {
      isExit = true;
      this.Close();
      adminForm.Show();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void txt_giaoviec_congvan_TextChanged(object sender, EventArgs e)
    {

    }

    private void btn_giaoviec_giaoviec_Click(object sender, EventArgs e)
    {
      DateTime currentDate = DateTime.Now;
      string ngayThangMoi = currentDate.ToString("yyyy-MM-dd");
      int id_congvan = int.Parse(txt_giaoviec_id_congvan.Text);
      string ten_congvan = txt_giaoviec_ten_congvan.Text;
      string id_canbo = combobox_giaoviec_canbo.Text;

      string query = sql.InsertTask(id_congvan, ten_congvan, id_canbo, ngayThangMoi);
      MySqlCommand cmd = new MySqlCommand(query, connectInsert);
      int roweffect = cmd.ExecuteNonQuery();
      if(roweffect != 0 )
      {
        MessageBox.Show("Giao Việc Thành Công", "Show");
      }
    }

    private void btn_giaoviec_lammoi_Click(object sender, EventArgs e)
    {
      txt_giaoviec_id_congvan.Text = "";
      txt_giaoviec_ten_congvan.Text = "";
      combobox_giaoviec_canbo.ResetText();
    }

    private void GiaoViec_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing && !isExit)
      {
        // Ngăn chặn đóng form và thay vào đó ẩn form
        Application.Exit();
      }
    }
  }
}
