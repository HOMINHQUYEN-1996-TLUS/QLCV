namespace QLCV
{
  partial class doimatkhau
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
      txt_oldpassword = new TextBox();
      label2 = new Label();
      label3 = new Label();
      txt_newpassword = new TextBox();
      txt_newpassword_replace = new TextBox();
      btn_doimatkhau_capnhat = new Button();
      button2 = new Button();
      btn_doimatkhau_quaylai = new Button();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(145, 78);
      label1.Name = "label1";
      label1.Size = new Size(117, 25);
      label1.TabIndex = 0;
      label1.Text = "Mật Khẩu Cũ.";
      // 
      // txt_oldpassword
      // 
      txt_oldpassword.Location = new Point(403, 78);
      txt_oldpassword.Name = "txt_oldpassword";
      txt_oldpassword.Size = new Size(174, 31);
      txt_oldpassword.TabIndex = 1;
      txt_oldpassword.TextChanged += textBox1_TextChanged;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(145, 133);
      label2.Name = "label2";
      label2.Size = new Size(123, 25);
      label2.TabIndex = 0;
      label2.Text = "Mật Khẩu Mới";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(145, 186);
      label3.Name = "label3";
      label3.Size = new Size(197, 25);
      label3.TabIndex = 0;
      label3.Text = "Nhập Lại Mật Khẩu Mới";
      // 
      // txt_newpassword
      // 
      txt_newpassword.Location = new Point(403, 133);
      txt_newpassword.Name = "txt_newpassword";
      txt_newpassword.Size = new Size(174, 31);
      txt_newpassword.TabIndex = 1;
      txt_newpassword.TextChanged += textBox1_TextChanged;
      // 
      // txt_newpassword_replace
      // 
      txt_newpassword_replace.Location = new Point(403, 186);
      txt_newpassword_replace.Name = "txt_newpassword_replace";
      txt_newpassword_replace.Size = new Size(174, 31);
      txt_newpassword_replace.TabIndex = 1;
      txt_newpassword_replace.TextChanged += textBox1_TextChanged;
      // 
      // btn_doimatkhau_capnhat
      // 
      btn_doimatkhau_capnhat.Location = new Point(150, 264);
      btn_doimatkhau_capnhat.Name = "btn_doimatkhau_capnhat";
      btn_doimatkhau_capnhat.Size = new Size(112, 34);
      btn_doimatkhau_capnhat.TabIndex = 2;
      btn_doimatkhau_capnhat.Text = "Cập Nhật";
      btn_doimatkhau_capnhat.UseVisualStyleBackColor = true;
      btn_doimatkhau_capnhat.Click += btn_doimatkhau_capnhat_Click;
      // 
      // button2
      // 
      button2.Location = new Point(465, 264);
      button2.Name = "button2";
      button2.Size = new Size(112, 34);
      button2.TabIndex = 2;
      button2.Text = "Cập Nhật";
      button2.UseVisualStyleBackColor = true;
      // 
      // btn_doimatkhau_quaylai
      // 
      btn_doimatkhau_quaylai.Location = new Point(465, 264);
      btn_doimatkhau_quaylai.Name = "btn_doimatkhau_quaylai";
      btn_doimatkhau_quaylai.Size = new Size(112, 34);
      btn_doimatkhau_quaylai.TabIndex = 2;
      btn_doimatkhau_quaylai.Text = "Quay Lại";
      btn_doimatkhau_quaylai.UseVisualStyleBackColor = true;
      btn_doimatkhau_quaylai.Click += btn_doimatkhau_quaylai_Click;
      // 
      // doimatkhau
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(btn_doimatkhau_quaylai);
      Controls.Add(button2);
      Controls.Add(btn_doimatkhau_capnhat);
      Controls.Add(txt_newpassword_replace);
      Controls.Add(txt_newpassword);
      Controls.Add(txt_oldpassword);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "doimatkhau";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "doimatkhau";
      FormClosing += doimatkhau_FormClosing;
      Load += doimatkhau_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txt_oldpassword;
    private Label label2;
    private Label label3;
    private TextBox txt_newpassword;
    private TextBox txt_newpassword_replace;
    private Button btn_doimatkhau_capnhat;
    private Button button2;
    private Button btn_doimatkhau_quaylai;
  }
}