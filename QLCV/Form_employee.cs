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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLCV
{
  public partial class Form_employee : Form
  {
    private bool isExit = false;
    private DataTable dataTable;
    private MySqlDataAdapter dataAdapter;
    private int taskid;


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

    private void btn_employee_timkiem_Click(object sender, EventArgs e)
    {
      string trangthai = comboBox_employee.Text;

      try
      {
        connection2.Open();
        string sqlQuery = sql.select_employee(username, trangthai);
        dataAdapter = new MySqlDataAdapter(sqlQuery, connection2);
        MySqlCommand command = new MySqlCommand(sqlQuery, connection2);

        dataAdapter.SelectCommand = command;

        dataTable = new DataTable();
        // Làm mới dữ liệu
        dataTable.Clear();

        // Đổ dữ liệu từ adapter vào DataTable
        dataAdapter.Fill(dataTable);

        // Hiển thị DataTable trên DataGridView
        dataGridView_employee.DataSource = dataTable;
        UpdateRowCountLabel();
      }
      finally
      {
        connection2.Close();
      }
    }

    private void btn_employee_capnhat_Click(object sender, EventArgs e)
    {
      connection2.Open();
      string query = sql.updateStatus(this.taskid.ToString());
      MySqlCommand cmd = new MySqlCommand(query, connection2);
      int roweffect = cmd.ExecuteNonQuery();
      if (roweffect != 0)
      {
        connection2.Close();
        MessageBox.Show("Cập nhật thành công", "Show");
        LoadData();
      }
      
    }

    private void dataGridView_employee_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView_employee.Columns["Column1"].Index)
      {
        DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGridView_employee.Rows[e.RowIndex].Cells["Column1"];

        if (Convert.ToBoolean(cell.Value))
        {
          // Lấy giá trị của cột "taskid" của dòng được chọn
          int taskId = Convert.ToInt32(dataGridView_employee.Rows[e.RowIndex].Cells["taskid"].Value);

          MessageBox.Show($"TaskID của dòng được chọn: {taskId}");
        }
      }
    }

    private void dataGridView_employee_DataSourceChanged(object sender, EventArgs e)
    {

    }

    private void label_employee_soluong_Click(object sender, EventArgs e)
    {

    }

    private void dataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dataGridView_employee_EditModeChanged(object sender, EventArgs e)
    {

    }

    private void dataGridView_employee_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        DataGridViewRow selectedRow = dataGridView_employee.Rows[e.RowIndex];
        this.taskid = Int32.Parse(selectedRow.Cells["taskid"].Value.ToString());
      }
    }
  }
}
