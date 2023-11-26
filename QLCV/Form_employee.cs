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
  public partial class Form_employee : Form
  {
    private bool isExit = false;
    private DataTable dataTable;
    private MySqlDataAdapter dataAdapter;

    private static MySqlConnection? connection2;
    private string username;
    public Form_employee(string username)
    {
      InitializeComponent();
      connection2 = Connect3.Connection();
      this.username = username;
    }

    private void Form_employee_Load(object sender, EventArgs e)
    {
      LoadData();
      UpdateRowCountLabel();
    }
    private void LoadData()
    {
      try
      {
        connection2.Open();
        string sqlQuery = $"SELECT * FROM managertasks WHERE username = '{username}'";
        dataAdapter = new MySqlDataAdapter(sqlQuery, connection2);
        dataTable = new DataTable();
        // Làm mới dữ liệu
        dataTable.Clear();

        // Đổ dữ liệu từ adapter vào DataTable
        dataAdapter.Fill(dataTable);

        // Hiển thị DataTable trên DataGridView
        dataGridView_employee.DataSource = dataTable;
        int displayedRowCount = dataGridView_employee.DisplayedRowCount(true) - 1;
        label_employee_soluong.Text = displayedRowCount.ToString();
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
      int displayedRowCount = dataGridView_employee.DisplayedRowCount(true) - 1;
      label_employee_soluong.Text = displayedRowCount.ToString();
    }

    private void Form_employee_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing && !isExit)
      {
        // Ngăn chặn đóng form và thay vào đó ẩn form
        Application.Exit();
      }
    }
  }
}
