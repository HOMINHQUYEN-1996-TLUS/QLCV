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
      dataGridView_employee = new DataGridView();
      comboBox_employee = new ComboBox();
      btn_employee_timkiem = new Button();
      label1 = new Label();
      btn_employee_capnhat = new Button();
      label2 = new Label();
      label_employee_soluong = new Label();
      ((System.ComponentModel.ISupportInitialize)dataGridView_employee).BeginInit();
      SuspendLayout();
      // 
      // dataGridView_employee
      // 
      dataGridView_employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView_employee.Location = new Point(23, 12);
      dataGridView_employee.Name = "dataGridView_employee";
      dataGridView_employee.RowHeadersWidth = 62;
      dataGridView_employee.RowTemplate.Height = 33;
      dataGridView_employee.Size = new Size(737, 225);
      dataGridView_employee.TabIndex = 0;
      // 
      // comboBox_employee
      // 
      comboBox_employee.FormattingEnabled = true;
      comboBox_employee.Items.AddRange(new object[] { "đang giao", "đã nhận", "hoàn thành" });
      comboBox_employee.Location = new Point(162, 353);
      comboBox_employee.Name = "comboBox_employee";
      comboBox_employee.Size = new Size(182, 33);
      comboBox_employee.TabIndex = 1;
      // 
      // btn_employee_timkiem
      // 
      btn_employee_timkiem.Location = new Point(403, 351);
      btn_employee_timkiem.Name = "btn_employee_timkiem";
      btn_employee_timkiem.Size = new Size(112, 34);
      btn_employee_timkiem.TabIndex = 2;
      btn_employee_timkiem.Text = "Tìm kiếm";
      btn_employee_timkiem.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(23, 356);
      label1.Name = "label1";
      label1.Size = new Size(92, 25);
      label1.TabIndex = 3;
      label1.Text = "Trạng Thái";
      // 
      // btn_employee_capnhat
      // 
      btn_employee_capnhat.Location = new Point(77, 254);
      btn_employee_capnhat.Name = "btn_employee_capnhat";
      btn_employee_capnhat.Size = new Size(238, 34);
      btn_employee_capnhat.TabIndex = 2;
      btn_employee_capnhat.Text = "Cập Nhật Trạng Thái";
      btn_employee_capnhat.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(517, 254);
      label2.Name = "label2";
      label2.Size = new Size(188, 25);
      label2.TabIndex = 4;
      label2.Text = "Số Lượng Công Việc : ";
      // 
      // label_employee_soluong
      // 
      label_employee_soluong.AutoSize = true;
      label_employee_soluong.Location = new Point(724, 254);
      label_employee_soluong.Name = "label_employee_soluong";
      label_employee_soluong.Size = new Size(22, 25);
      label_employee_soluong.TabIndex = 4;
      label_employee_soluong.Text = "0";
      // 
      // Form_employee
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(789, 450);
      Controls.Add(label_employee_soluong);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(btn_employee_capnhat);
      Controls.Add(btn_employee_timkiem);
      Controls.Add(comboBox_employee);
      Controls.Add(dataGridView_employee);
      Name = "Form_employee";
      Text = "Form_employee";
      FormClosing += Form_employee_FormClosing;
      Load += Form_employee_Load;
      ((System.ComponentModel.ISupportInitialize)dataGridView_employee).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private DataGridView dataGridView_employee;
    private ComboBox comboBox_employee;
    private Button btn_employee_timkiem;
    private Label label1;
    private Button btn_employee_capnhat;
    private Label label2;
    private Label label_employee_soluong;
  }
}