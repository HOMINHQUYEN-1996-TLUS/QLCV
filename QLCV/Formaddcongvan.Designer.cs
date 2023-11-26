namespace QLCV
{
  partial class Formaddcongvan
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
      label1 = new Label();
      txt_them_socongvan = new TextBox();
      label2 = new Label();
      label3 = new Label();
      listBox1 = new ListBox();
      btn_them = new Button();
      btn_lammoi = new Button();
      listBox2 = new ListBox();
      label4 = new Label();
      txt_them_tencongvan = new TextBox();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(44, 63);
      label1.Name = "label1";
      label1.Size = new Size(115, 25);
      label1.TabIndex = 0;
      label1.Text = "Số Công Văn";
      // 
      // txt_them_socongvan
      // 
      txt_them_socongvan.Location = new Point(184, 60);
      txt_them_socongvan.Name = "txt_them_socongvan";
      txt_them_socongvan.Size = new Size(256, 31);
      txt_them_socongvan.TabIndex = 1;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(44, 104);
      label2.Name = "label2";
      label2.Size = new Size(125, 25);
      label2.TabIndex = 2;
      label2.Text = "Huyện / Thị xã";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(44, 144);
      label3.Name = "label3";
      label3.Size = new Size(72, 25);
      label3.TabIndex = 3;
      label3.Text = "Độ Mật";
      // 
      // listBox1
      // 
      listBox1.FormattingEnabled = true;
      listBox1.ItemHeight = 25;
      listBox1.Items.AddRange(new object[] { "Bình Thường", "Mật", "Tuyệt Mật" });
      listBox1.Location = new Point(184, 144);
      listBox1.Name = "listBox1";
      listBox1.Size = new Size(256, 29);
      listBox1.TabIndex = 4;
      // 
      // btn_them
      // 
      btn_them.Location = new Point(78, 215);
      btn_them.Name = "btn_them";
      btn_them.Size = new Size(112, 34);
      btn_them.TabIndex = 5;
      btn_them.Text = "Thêm";
      btn_them.UseVisualStyleBackColor = true;
      // 
      // btn_lammoi
      // 
      btn_lammoi.Location = new Point(305, 215);
      btn_lammoi.Name = "btn_lammoi";
      btn_lammoi.Size = new Size(112, 34);
      btn_lammoi.TabIndex = 6;
      btn_lammoi.Text = "Làm Mới";
      btn_lammoi.UseVisualStyleBackColor = true;
      // 
      // listBox2
      // 
      listBox2.FormattingEnabled = true;
      listBox2.ItemHeight = 25;
      listBox2.Items.AddRange(new object[] { "Tuy Hoà", "Đồng Xuân", "Sông Cầu", "Tuy An", "Sơn Hoà", "Phú Hoà", "Tây Hoà", "Sông Hinh", "Đông Hoà" });
      listBox2.Location = new Point(184, 104);
      listBox2.Name = "listBox2";
      listBox2.Size = new Size(180, 29);
      listBox2.TabIndex = 7;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(44, 21);
      label4.Name = "label4";
      label4.Size = new Size(120, 25);
      label4.TabIndex = 0;
      label4.Text = "Tên Công Văn";
      // 
      // txt_them_tencongvan
      // 
      txt_them_tencongvan.Location = new Point(184, 23);
      txt_them_tencongvan.Name = "txt_them_tencongvan";
      txt_them_tencongvan.Size = new Size(256, 31);
      txt_them_tencongvan.TabIndex = 1;
      // 
      // Form3
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(583, 347);
      Controls.Add(listBox2);
      Controls.Add(btn_lammoi);
      Controls.Add(btn_them);
      Controls.Add(listBox1);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(txt_them_tencongvan);
      Controls.Add(txt_them_socongvan);
      Controls.Add(label4);
      Controls.Add(label1);
      Name = "Form3";
      Text = "Gửi Công Văn";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txt_them_socongvan;
    private Label label2;
    private Label label3;
    private ListBox listBox1;
    private Button btn_them;
    private Button btn_lammoi;
    private ListBox listBox2;
    private Label label4;
    private TextBox txt_them_tencongvan;
  }
}