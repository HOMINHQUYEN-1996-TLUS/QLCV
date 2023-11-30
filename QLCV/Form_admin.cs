using MySql.Data.MySqlClient;
using Npgsql;
using OfficeOpenXml;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace QLCV
{
  public partial class Form_admin : Form
  {
    private doimatkhau fdoimatkhau;
    private GiaoViec giaoviec;
    public bool isExit = true;
    private DataTable dataTable;
    private MySqlDataAdapter dataAdapter;
    private int taskid;
    private string username_task;
    private string username;
    private string password;

    private static MySqlConnection? connection2;

    public Form_admin(string username, string password)
    {
      InitializeComponent();

      connection2 = Connect3.Connection();
      LoadData();
      this.username = username;
      this.password = password;
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

        foreach (DataGridViewColumn column in datacongvan.Columns)
        {
          column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
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
      //LoadData();
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

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void btn_capnhat_Click(object sender, EventArgs e)
    {
      LoadData();
    }

    private void btn_admin_xoa_Click(object sender, EventArgs e)
    {

      connection2.Open();
      string query = sql.delete_task(this.taskid.ToString());
      MySqlCommand cmd = new MySqlCommand(query, connection2);
      DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá Công Văn với số công văn là {this.taskid} giao cho cán bộ : {this.username_task} không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

      // Kiểm tra xem người dùng đã nhấn OK hay không
      if (result == DialogResult.OK)
      {
        // Thực hiện công việc xoá ở đây
        int roweffect = cmd.ExecuteNonQuery();
        if (roweffect != 0)
        {
          connection2.Close();
          MessageBox.Show("Xoá Thành Công", "Show");
          LoadData();
        }
      }

    }

    private void datacongvan_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        DataGridViewRow selectedRow = datacongvan.Rows[e.RowIndex];
        this.taskid = Int32.Parse(selectedRow.Cells["taskid"].Value.ToString());
        this.username_task = selectedRow.Cells["username"].Value.ToString();
      }
    }

    private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Hide();
      fdoimatkhau = new doimatkhau(username, password);
      fdoimatkhau.Show();
    }

    private void xuấtExcelToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
        ToExcel(datacongvan, saveFileDialog1.FileName);
      }
    }
    private void ToExcel(DataGridView dataGridView1, string fileName)
    {
      //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
      Microsoft.Office.Interop.Excel.Application excel;
      Microsoft.Office.Interop.Excel.Workbook workbook;
      Microsoft.Office.Interop.Excel.Worksheet worksheet;
      try
      {
        //Tạo đối tượng COM.
        excel = new Microsoft.Office.Interop.Excel.Application();
        excel.Visible = false;
        excel.DisplayAlerts = false;
        //tạo mới một Workbooks bằng phương thức add()
        workbook = excel.Workbooks.Add(Type.Missing);
        worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
        //đặt tên cho sheet
        worksheet.Name = "QLCV";

        // export header trong DataGridView
        for (int i = 0; i < dataGridView1.ColumnCount; i++)
        {
          worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
        }
        // export nội dung trong DataGridView
        for (int i = 0; i < dataGridView1.RowCount-1; i++)
        {
          for (int j = 0; j < dataGridView1.ColumnCount; j++)
          {
            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
            //MessageBox.Show(dataGridView1.Rows[i].Cells[j].Value.ToString(), "show");
          }
        }
        // sử dụng phương thức SaveAs() để lưu workbook với filename
        workbook.SaveAs(fileName);
        //đóng workbook
        workbook.Close();
        excel.Quit();
        MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        workbook = null;
        worksheet = null;
      }
    }
  }
}
