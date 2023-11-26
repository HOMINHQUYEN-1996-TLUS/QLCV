using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace QLCV
{
  public partial class Form_admin : Form
  {
    private GiaoViec giaoviec;
    public bool isExit = true;
    private DataTable dataTable;
    private MySqlDataAdapter dataAdapter;

    private static MySqlConnection? connection2;

    public Form_admin()
    {
      InitializeComponent();

      connection2 = Connect3.Connection();
    }

    private void tHoátToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void huyệnToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void Formmain_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (isExit)
      {
        Application.Exit();
      }

    }

    private void Formmain_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (isExit)
      {
        if (MessageBox.Show("Bạn muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
        {
          e.Cancel = true;
        }
      }

    }

    private void giaoViệcToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Hide();
      giaoviec = new GiaoViec(this);
      giaoviec.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string congvanId = txt_admin_idcongvan.Text;
      string ngaybatdau = datetime_admin_1.Value.ToString("yyyy-MM-dd");
      string ngayketthuc = datetime_admin_2.Value.ToString("yyyy-MM-dd");
      string trangthai = combobox_trangthai.Text;
      string idcanbo = combobox_canbo.Text;




      try
      {
        connection2.Open();
        string sqlQuery = sql.SelectTatCa(congvanId, idcanbo, ngaybatdau, ngayketthuc, trangthai);
        dataAdapter = new MySqlDataAdapter(sqlQuery, connection2);
        MySqlCommand command = new MySqlCommand(sqlQuery, connection2);

        dataAdapter.SelectCommand = command;

        dataTable = new DataTable();
        // Làm mới dữ liệu
        dataTable.Clear();

        // Đổ dữ liệu từ adapter vào DataTable
        dataAdapter.Fill(dataTable);

        // Hiển thị DataTable trên DataGridView
        datacongvan.DataSource = dataTable;
        UpdateRowCountLabel();
      }
      finally
      {
        connection2.Close();
      }
    }

    private void datacongvan_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void Form_admin_Load(object sender, EventArgs e)
    {
      LoadData();
      UpdateRowCountLabel();
      txt_admin_idcongvan.TextChanged += txt_admin_idcongvan_TextChanged;
    }
    private void LoadData()
    {
      try
      {
        connection2.Open();
        string sqlQuery = "SELECT * FROM managertasks";
        dataAdapter = new MySqlDataAdapter(sqlQuery, connection2);
        dataTable = new DataTable();
        // Làm mới dữ liệu
        dataTable.Clear();

        // Đổ dữ liệu từ adapter vào DataTable
        dataAdapter.Fill(dataTable);

        // Hiển thị DataTable trên DataGridView
        datacongvan.DataSource = dataTable;
        int displayedRowCount = datacongvan.DisplayedRowCount(true) - 1;
        label_soluong.Text = displayedRowCount.ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex.Message);
      }
      finally
      {
        connection2.Close();
      }
    }
    private void UpdateRowCountLabel()
    {
      int displayedRowCount = datacongvan.DisplayedRowCount(true) - 1;
      label_soluong.Text = displayedRowCount.ToString();
    }

    private void datacongvan_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      UpdateRowCountLabel();
    }

    private void txt_admin_idcongvan_TextChanged(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txt_admin_idcongvan.Text))
      {
        // Nếu có dữ liệu, làm cho các TextBox và ComboBox khác không thao tác được (bị mờ)
        combobox_trangthai.Enabled = false;
        combobox_canbo.Enabled = false;
      }
      else
      {
        // Nếu trống, làm cho các TextBox và ComboBox khác thao tác được (không mờ)
        combobox_trangthai.Enabled = true;
        combobox_canbo.Enabled = true;
      }
    }

    private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form_add_user form_Add_User = new Form_add_user();
      form_Add_User.Show();
      this.Hide();
    }
  }
}
