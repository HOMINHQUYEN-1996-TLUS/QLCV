namespace QLCV
{
  partial class Form_admin
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
      DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
      menuStrip1 = new MenuStrip();
      hệThốngToolStripMenuItem = new ToolStripMenuItem();
      quảnLýTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
      tHoátToolStripMenuItem = new ToolStripMenuItem();
      giaoViệcToolStripMenuItem = new ToolStripMenuItem();
      đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
      groupBox1 = new GroupBox();
      btn_capnhat = new Button();
      combobox_canbo = new ComboBox();
      combobox_trangthai = new ComboBox();
      label4 = new Label();
      label3 = new Label();
      btn_timkiem = new Button();
      datetime_admin_2 = new DateTimePicker();
      datetime_admin_1 = new DateTimePicker();
      label7 = new Label();
      label6 = new Label();
      txt_admin_idcongvan = new TextBox();
      label1 = new Label();
      datacongvan = new DataGridView();
      label5 = new Label();
      label2 = new Label();
      label_soluong = new Label();
      btn_admin_xoa = new Button();
      xuấtExcelToolStripMenuItem = new ToolStripMenuItem();
      menuStrip1.SuspendLayout();
      groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)datacongvan).BeginInit();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.ImageScalingSize = new Size(24, 24);
      menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, giaoViệcToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(1385, 33);
      menuStrip1.TabIndex = 0;
      menuStrip1.Text = "menuStrip1";
      // 
      // hệThốngToolStripMenuItem
      // 
      hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýTàiKhoảnToolStripMenuItem, tHoátToolStripMenuItem, xuấtExcelToolStripMenuItem });
      hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
      hệThốngToolStripMenuItem.Size = new Size(106, 29);
      hệThốngToolStripMenuItem.Text = "Hệ Thống";
      // 
      // quảnLýTàiKhoảnToolStripMenuItem
      // 
      quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
      quảnLýTàiKhoảnToolStripMenuItem.Size = new Size(270, 34);
      quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
      quảnLýTàiKhoảnToolStripMenuItem.Click += quảnLýTàiKhoảnToolStripMenuItem_Click;
      // 
      // tHoátToolStripMenuItem
      // 
      tHoátToolStripMenuItem.Name = "tHoátToolStripMenuItem";
      tHoátToolStripMenuItem.Size = new Size(270, 34);
      tHoátToolStripMenuItem.Text = "Đăng xuất";
      tHoátToolStripMenuItem.Click += tHoátToolStripMenuItem_Click;
      // 
      // giaoViệcToolStripMenuItem
      // 
      giaoViệcToolStripMenuItem.Name = "giaoViệcToolStripMenuItem";
      giaoViệcToolStripMenuItem.Size = new Size(101, 29);
      giaoViệcToolStripMenuItem.Text = "Giao Việc";
      giaoViệcToolStripMenuItem.Click += giaoViệcToolStripMenuItem_Click;
      // 
      // đổiMậtKhẩuToolStripMenuItem
      // 
      đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
      đổiMậtKhẩuToolStripMenuItem.Size = new Size(136, 29);
      đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
      đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
      // 
      // groupBox1
      // 
      groupBox1.Controls.Add(btn_capnhat);
      groupBox1.Controls.Add(combobox_canbo);
      groupBox1.Controls.Add(combobox_trangthai);
      groupBox1.Controls.Add(label4);
      groupBox1.Controls.Add(label3);
      groupBox1.Controls.Add(btn_timkiem);
      groupBox1.Controls.Add(datetime_admin_2);
      groupBox1.Controls.Add(datetime_admin_1);
      groupBox1.Controls.Add(label7);
      groupBox1.Controls.Add(label6);
      groupBox1.Controls.Add(txt_admin_idcongvan);
      groupBox1.Controls.Add(label1);
      groupBox1.Location = new Point(12, 47);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(654, 303);
      groupBox1.TabIndex = 1;
      groupBox1.TabStop = false;
      groupBox1.Text = "Tìm kiếm";
      // 
      // btn_capnhat
      // 
      btn_capnhat.Location = new Point(525, 203);
      btn_capnhat.Name = "btn_capnhat";
      btn_capnhat.Size = new Size(112, 34);
      btn_capnhat.TabIndex = 10;
      btn_capnhat.Text = "Cập Nhật";
      btn_capnhat.UseVisualStyleBackColor = true;
      btn_capnhat.Click += btn_capnhat_Click;
      // 
      // combobox_canbo
      // 
      combobox_canbo.FormattingEnabled = true;
      combobox_canbo.Items.AddRange(new object[] { "qkhanh_54", "ttrang_54", "qthai_54", "mhanh_54", "mle_54", "lanh_54", "vnhan_54", "dkhanh_54", "hgiang_54", "mquyen_54" });
      combobox_canbo.Location = new Point(170, 245);
      combobox_canbo.Name = "combobox_canbo";
      combobox_canbo.Size = new Size(300, 33);
      combobox_canbo.TabIndex = 9;
      // 
      // combobox_trangthai
      // 
      combobox_trangthai.FormattingEnabled = true;
      combobox_trangthai.Items.AddRange(new object[] { "đang giao", "đã nhận", "hoàn thành" });
      combobox_trangthai.Location = new Point(170, 195);
      combobox_trangthai.Name = "combobox_trangthai";
      combobox_trangthai.Size = new Size(300, 33);
      combobox_trangthai.TabIndex = 9;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(29, 253);
      label4.Name = "label4";
      label4.Size = new Size(69, 25);
      label4.TabIndex = 7;
      label4.Text = "Cán bộ";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(29, 203);
      label3.Name = "label3";
      label3.Size = new Size(89, 25);
      label3.TabIndex = 5;
      label3.Text = "Trạng thái";
      // 
      // btn_timkiem
      // 
      btn_timkiem.Location = new Point(525, 136);
      btn_timkiem.Name = "btn_timkiem";
      btn_timkiem.Size = new Size(112, 34);
      btn_timkiem.TabIndex = 4;
      btn_timkiem.Text = "Tìm Kiếm";
      btn_timkiem.UseVisualStyleBackColor = true;
      btn_timkiem.Click += button1_Click;
      // 
      // datetime_admin_2
      // 
      datetime_admin_2.Location = new Point(170, 139);
      datetime_admin_2.Name = "datetime_admin_2";
      datetime_admin_2.Size = new Size(300, 31);
      datetime_admin_2.TabIndex = 3;
      // 
      // datetime_admin_1
      // 
      datetime_admin_1.Location = new Point(170, 91);
      datetime_admin_1.Name = "datetime_admin_1";
      datetime_admin_1.Size = new Size(300, 31);
      datetime_admin_1.TabIndex = 3;
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.Location = new Point(29, 139);
      label7.Name = "label7";
      label7.Size = new Size(88, 25);
      label7.TabIndex = 2;
      label7.Text = "Đến ngày";
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new Point(29, 97);
      label6.Name = "label6";
      label6.Size = new Size(76, 25);
      label6.TabIndex = 2;
      label6.Text = "Từ ngày";
      // 
      // txt_admin_idcongvan
      // 
      txt_admin_idcongvan.Location = new Point(170, 46);
      txt_admin_idcongvan.Name = "txt_admin_idcongvan";
      txt_admin_idcongvan.Size = new Size(300, 31);
      txt_admin_idcongvan.TabIndex = 1;
      txt_admin_idcongvan.TextChanged += txt_admin_idcongvan_TextChanged;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(29, 52);
      label1.Name = "label1";
      label1.Size = new Size(115, 25);
      label1.TabIndex = 0;
      label1.Text = "Số Công Văn";
      // 
      // datacongvan
      // 
      datacongvan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
      datacongvan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
      dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
      dataGridViewCellStyle1.BackColor = SystemColors.Control;
      dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      datacongvan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      datacongvan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
      dataGridViewCellStyle2.BackColor = SystemColors.Window;
      dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      datacongvan.DefaultCellStyle = dataGridViewCellStyle2;
      datacongvan.Location = new Point(12, 394);
      datacongvan.Name = "datacongvan";
      datacongvan.RowHeadersWidth = 62;
      datacongvan.RowTemplate.Height = 33;
      datacongvan.Size = new Size(1353, 294);
      datacongvan.TabIndex = 2;
      datacongvan.CellClick += datacongvan_CellClick;
      datacongvan.CellContentClick += datacongvan_CellContentClick;
      datacongvan.DataBindingComplete += datacongvan_DataBindingComplete;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(210, 353);
      label5.Name = "label5";
      label5.Size = new Size(209, 25);
      label5.TabIndex = 3;
      label5.Text = "DANH SÁCH CÔNG VĂN";
      label5.TextAlign = ContentAlignment.TopCenter;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(12, 706);
      label2.Name = "label2";
      label2.Size = new Size(174, 25);
      label2.TabIndex = 4;
      label2.Text = "Số Lượng Công Việc";
      label2.Click += label2_Click;
      // 
      // label_soluong
      // 
      label_soluong.AutoSize = true;
      label_soluong.Location = new Point(192, 706);
      label_soluong.Name = "label_soluong";
      label_soluong.Size = new Size(0, 25);
      label_soluong.TabIndex = 4;
      // 
      // btn_admin_xoa
      // 
      btn_admin_xoa.Location = new Point(1253, 706);
      btn_admin_xoa.Name = "btn_admin_xoa";
      btn_admin_xoa.Size = new Size(112, 34);
      btn_admin_xoa.TabIndex = 5;
      btn_admin_xoa.Text = "Xoá";
      btn_admin_xoa.UseVisualStyleBackColor = true;
      btn_admin_xoa.Click += btn_admin_xoa_Click;
      // 
      // xuấtExcelToolStripMenuItem
      // 
      xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
      xuấtExcelToolStripMenuItem.Size = new Size(270, 34);
      xuấtExcelToolStripMenuItem.Text = "Xuất Excel";
      xuấtExcelToolStripMenuItem.Click += xuấtExcelToolStripMenuItem_Click;
      // 
      // Form_admin
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1385, 874);
      Controls.Add(btn_admin_xoa);
      Controls.Add(label_soluong);
      Controls.Add(label2);
      Controls.Add(label5);
      Controls.Add(datacongvan);
      Controls.Add(groupBox1);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      Name = "Form_admin";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Form2";
      FormClosing += Formmain_FormClosing;
      FormClosed += Formmain_FormClosed;
      Load += Form_admin_Load;
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)datacongvan).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem hệThốngToolStripMenuItem;
    private ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
    private ToolStripMenuItem tHoátToolStripMenuItem;
    private GroupBox groupBox1;
    private DateTimePicker datetime_admin_1;
    private TextBox txt_admin_idcongvan;
    private Label label1;
    private Label label4;
    private Label label3;
    private Button btn_timkiem;
    private DataGridView datacongvan;
    private Label label5;
    private ComboBox combobox_canbo;
    private ComboBox combobox_trangthai;
    private ToolStripMenuItem giaoViệcToolStripMenuItem;
    private DateTimePicker datetime_admin_2;
    private Label label7;
    private Label label6;
    private Label label2;
    private Label label_soluong;
    private Button btn_capnhat;
    private Button btn_admin_xoa;
    private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    private ToolStripMenuItem xuấtExcelToolStripMenuItem;
  }
}