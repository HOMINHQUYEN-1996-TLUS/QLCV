namespace QLCV
{
  partial class Formlogin
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      label1 = new Label();
      txt_username = new TextBox();
      label2 = new Label();
      txt_password = new TextBox();
      btn_login = new Button();
      btn_exit = new Button();
      checkBox1 = new CheckBox();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(44, 50);
      label1.Name = "label1";
      label1.Size = new Size(86, 25);
      label1.TabIndex = 0;
      label1.Text = "Tài khoản";
      // 
      // txt_username
      // 
      txt_username.Location = new Point(166, 47);
      txt_username.Name = "txt_username";
      txt_username.Size = new Size(338, 31);
      txt_username.TabIndex = 1;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(44, 104);
      label2.Name = "label2";
      label2.Size = new Size(86, 25);
      label2.TabIndex = 2;
      label2.Text = "Mật khẩu";
      label2.Click += label2_Click;
      // 
      // txt_password
      // 
      txt_password.Location = new Point(166, 98);
      txt_password.Name = "txt_password";
      txt_password.Size = new Size(338, 31);
      txt_password.TabIndex = 3;
      // 
      // btn_login
      // 
      btn_login.Location = new Point(166, 211);
      btn_login.Name = "btn_login";
      btn_login.Size = new Size(112, 34);
      btn_login.TabIndex = 4;
      btn_login.Text = "Đăng Nhập";
      btn_login.UseVisualStyleBackColor = true;
      btn_login.Click += btn_login_Click;
      // 
      // btn_exit
      // 
      btn_exit.Location = new Point(392, 211);
      btn_exit.Name = "btn_exit";
      btn_exit.Size = new Size(112, 34);
      btn_exit.TabIndex = 5;
      btn_exit.Text = "Thoát";
      btn_exit.UseVisualStyleBackColor = true;
      btn_exit.Click += btn_exit_Click;
      // 
      // checkBox1
      // 
      checkBox1.AutoSize = true;
      checkBox1.Location = new Point(166, 152);
      checkBox1.Name = "checkBox1";
      checkBox1.Size = new Size(147, 29);
      checkBox1.TabIndex = 6;
      checkBox1.Text = "Lưu Tài Khoản";
      checkBox1.UseVisualStyleBackColor = true;
      checkBox1.CheckedChanged += checkBox1_CheckedChanged;
      // 
      // Formlogin
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(639, 334);
      Controls.Add(checkBox1);
      Controls.Add(btn_exit);
      Controls.Add(btn_login);
      Controls.Add(txt_password);
      Controls.Add(label2);
      Controls.Add(txt_username);
      Controls.Add(label1);
      Name = "Formlogin";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "FormLogin";
      FormClosed += Formlogin_FormClosed;
      Load += Form1_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txt_username;
    private Label label2;
    private TextBox txt_password;
    private Button btn_login;
    private Button btn_exit;
    private CheckBox checkBox1;
  }
}