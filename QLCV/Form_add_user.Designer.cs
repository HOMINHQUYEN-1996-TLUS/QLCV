namespace QLCV
{
  partial class Form_add_user
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
      label2 = new Label();
      label3 = new Label();
      txt_adduser_username = new TextBox();
      txt_adduser_password = new TextBox();
      combobox_adduser_usertype = new ComboBox();
      btn_adduser_themtaikhoan = new Button();
      btn_adduser_lammoi = new Button();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(78, 47);
      label1.Name = "label1";
      label1.Size = new Size(129, 25);
      label1.TabIndex = 0;
      label1.Text = "Tên đăng nhập";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(78, 118);
      label2.Name = "label2";
      label2.Size = new Size(87, 25);
      label2.TabIndex = 0;
      label2.Text = "Mật Khẩu";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(78, 176);
      label3.Name = "label3";
      label3.Size = new Size(124, 25);
      label3.TabIndex = 0;
      label3.Text = "Loại Tài Khoản";
      // 
      // txt_adduser_username
      // 
      txt_adduser_username.Location = new Point(286, 47);
      txt_adduser_username.Name = "txt_adduser_username";
      txt_adduser_username.Size = new Size(150, 31);
      txt_adduser_username.TabIndex = 1;
      // 
      // txt_adduser_password
      // 
      txt_adduser_password.Location = new Point(286, 118);
      txt_adduser_password.Name = "txt_adduser_password";
      txt_adduser_password.Size = new Size(150, 31);
      txt_adduser_password.TabIndex = 1;
      // 
      // combobox_adduser_usertype
      // 
      combobox_adduser_usertype.FormattingEnabled = true;
      combobox_adduser_usertype.Items.AddRange(new object[] { "admin", "employee" });
      combobox_adduser_usertype.Location = new Point(286, 176);
      combobox_adduser_usertype.Name = "combobox_adduser_usertype";
      combobox_adduser_usertype.Size = new Size(150, 33);
      combobox_adduser_usertype.TabIndex = 2;
      combobox_adduser_usertype.Text = "admin";
      // 
      // btn_adduser_themtaikhoan
      // 
      btn_adduser_themtaikhoan.Location = new Point(134, 272);
      btn_adduser_themtaikhoan.Name = "btn_adduser_themtaikhoan";
      btn_adduser_themtaikhoan.Size = new Size(112, 34);
      btn_adduser_themtaikhoan.TabIndex = 3;
      btn_adduser_themtaikhoan.Text = "Thêm";
      btn_adduser_themtaikhoan.UseVisualStyleBackColor = true;
      btn_adduser_themtaikhoan.Click += btn_adduser_themtaikhoan_Click;
      // 
      // btn_adduser_lammoi
      // 
      btn_adduser_lammoi.Location = new Point(409, 272);
      btn_adduser_lammoi.Name = "btn_adduser_lammoi";
      btn_adduser_lammoi.Size = new Size(112, 34);
      btn_adduser_lammoi.TabIndex = 3;
      btn_adduser_lammoi.Text = "Làm Mới";
      btn_adduser_lammoi.UseVisualStyleBackColor = true;
      btn_adduser_lammoi.Click += btn_adduser_lammoi_Click;
      // 
      // Form_add_user
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(btn_adduser_lammoi);
      Controls.Add(btn_adduser_themtaikhoan);
      Controls.Add(combobox_adduser_usertype);
      Controls.Add(txt_adduser_password);
      Controls.Add(txt_adduser_username);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "Form_add_user";
      Text = "Formuser";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox txt_adduser_username;
    private TextBox txt_adduser_password;
    private ComboBox combobox_adduser_usertype;
    private Button btn_adduser_themtaikhoan;
    private Button btn_adduser_lammoi;
  }
}