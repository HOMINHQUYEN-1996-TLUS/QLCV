namespace QLCV
{
  partial class Form_employee
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      comboBox_employee = new ComboBox();
      btn_employee_timkiem = new Button();
      label1 = new Label();
      btn_employee_capnhat = new Button();
      label2 = new Label();
      label_employee_soluong = new Label();
      dataGridView_employee = new DataGridView();
      menuStrip1 = new MenuStrip();
      đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
      đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)dataGridView_employee).BeginInit();
      menuStrip1.SuspendLayout();
      SuspendLayout();
      // 
      // comboBox_employee
      // 
      comboBox_employee.FormattingEnabled = true;
      comboBox_employee.Items.AddRange(new object[] { "đang giao", "đã nhận", "hoàn thành" });
      comboBox_employee.Location = new Point(159, 377);
      comboBox_employee.Name = "comboBox_employee";
      comboBox_employee.Size = new Size(182, 33);
      comboBox_employee.TabIndex = 1;
      // 
      // btn_employee_timkiem
      // 
      btn_employee_timkiem.Location = new Point(389, 375);
      btn_employee_timkiem.Name = "btn_employee_timkiem";
      btn_employee_timkiem.Size = new Size(112, 34);
      btn_employee_timkiem.TabIndex = 2;
      btn_employee_timkiem.Text = "Tìm kiếm Công Văn";
      btn_employee_timkiem.UseVisualStyleBackColor = true;
      btn_employee_timkiem.Click += btn_employee_timkiem_Click;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(23, 385);
      label1.Name = "label1";
      label1.Size = new Size(92, 25);
      label1.TabIndex = 3;
      label1.Text = "Trạng Thái";
      // 
      // btn_employee_capnhat
      // 
      btn_employee_capnhat.Location = new Point(23, 302);
      btn_employee_capnhat.Name = "btn_employee_capnhat";
      btn_employee_capnhat.Size = new Size(238, 34);
      btn_employee_capnhat.TabIndex = 2;
      btn_employee_capnhat.Text = "Cập Nhật Trạng Thái";
      btn_employee_capnhat.UseVisualStyleBackColor = true;
      btn_employee_capnhat.Click += btn_employee_capnhat_Click;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(515, 302);
      label2.Name = "label2";
      label2.Size = new Size(188, 25);
      label2.TabIndex = 4;
      label2.Text = "Số Lượng Công Việc : ";
      // 
      // label_employee_soluong
      // 
      label_employee_soluong.AutoSize = true;
      label_employee_soluong.Location = new Point(721, 307);
      label_employee_soluong.Name = "label_employee_soluong";
      label_employee_soluong.Size = new Size(22, 25);
      label_employee_soluong.TabIndex = 4;
      label_employee_soluong.Text = "0";
      label_employee_soluong.Click += label_employee_soluong_Click;
      // 
      // dataGridView_employee
      // 
      dataGridView_employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView_employee.Location = new Point(12, 37);
      dataGridView_employee.Name = "dataGridView_employee";
      dataGridView_employee.RowHeadersWidth = 62;
      dataGridView_employee.RowTemplate.Height = 33;
      dataGridView_employee.Size = new Size(1025, 225);
      dataGridView_employee.TabIndex = 0;
      dataGridView_employee.DataSourceChanged += dataGridView_employee_DataSourceChanged;
      dataGridView_employee.EditModeChanged += dataGridView_employee_EditModeChanged;
      dataGridView_employee.CellClick += dataGridView_employee_CellClick;
      dataGridView_employee.CellContentClick += dataGridView_employee_CellContentClick;
      dataGridView_employee.CellValueChanged += dataGridView_employee_CellValueChanged;
      // 
      // menuStrip1
      // 
      menuStrip1.ImageScalingSize = new Size(24, 24);
      menuStrip1.Items.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(1060, 33);
      menuStrip1.TabIndex = 5;
      menuStrip1.Text = "menuStrip1";
      // 
      // đổiMậtKhẩuToolStripMenuItem
      // 
      đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
      đổiMậtKhẩuToolStripMenuItem.Size = new Size(136, 29);
      đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
      đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
      // 
      // đăngXuấtToolStripMenuItem
      // 
      đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
      đăngXuấtToolStripMenuItem.Size = new Size(112, 29);
      đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
      đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
      // 
      // Form_employee
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1060, 450);
      Controls.Add(label_employee_soluong);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(btn_employee_capnhat);
      Controls.Add(btn_employee_timkiem);
      Controls.Add(comboBox_employee);
      Controls.Add(dataGridView_employee);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      Name = "Form_employee";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Form_employee";
      FormClosing += Form_employee_FormClosing;
      Load += Form_employee_Load;
      ((System.ComponentModel.ISupportInitialize)dataGridView_employee).EndInit();
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private ComboBox comboBox_employee;
    private Button btn_employee_timkiem;
    private Label label1;
    private Button btn_employee_capnhat;
    private Label label2;
    private Label label_employee_soluong;
    private DataGridView dataGridView_employee;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    private ToolStripMenuItem đăngXuấtToolStripMenuItem;
  }
}