namespace QLCV
{
  partial class GiaoViec
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
      txt_giaoviec_id_congvan = new TextBox();
      label5 = new Label();
      combobox_giaoviec_canbo = new ComboBox();
      btn_giaoviec_giaoviec = new Button();
      btn_giaoviec_lammoi = new Button();
      btn_giaoviec_quaylai = new Button();
      label2 = new Label();
      txt_giaoviec_ten_congvan = new TextBox();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(62, 41);
      label1.Name = "label1";
      label1.Size = new Size(112, 25);
      label1.TabIndex = 0;
      label1.Text = "ID Công Văn";
      label1.Click += label1_Click;
      // 
      // txt_giaoviec_id_congvan
      // 
      txt_giaoviec_id_congvan.Location = new Point(198, 35);
      txt_giaoviec_id_congvan.Name = "txt_giaoviec_id_congvan";
      txt_giaoviec_id_congvan.Size = new Size(150, 31);
      txt_giaoviec_id_congvan.TabIndex = 1;
      txt_giaoviec_id_congvan.TextChanged += txt_giaoviec_congvan_TextChanged;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(62, 175);
      label5.Name = "label5";
      label5.Size = new Size(92, 25);
      label5.TabIndex = 0;
      label5.Text = "ID Cán bộ";
      label5.Click += label2_Click;
      // 
      // combobox_giaoviec_canbo
      // 
      combobox_giaoviec_canbo.FormattingEnabled = true;
      combobox_giaoviec_canbo.Items.AddRange(new object[] { "qkhanh_54", "ttrang_54", "qthai_54", "mhanh_54", "mle_54", "lanh_54", "vnhan_54", "dkhanh_54", "hgiang_54", "mquyen_54" });
      combobox_giaoviec_canbo.Location = new Point(198, 175);
      combobox_giaoviec_canbo.Name = "combobox_giaoviec_canbo";
      combobox_giaoviec_canbo.Size = new Size(182, 33);
      combobox_giaoviec_canbo.TabIndex = 3;
      combobox_giaoviec_canbo.Text = "qkhanh_54";
      // 
      // btn_giaoviec_giaoviec
      // 
      btn_giaoviec_giaoviec.Location = new Point(49, 290);
      btn_giaoviec_giaoviec.Name = "btn_giaoviec_giaoviec";
      btn_giaoviec_giaoviec.Size = new Size(112, 34);
      btn_giaoviec_giaoviec.TabIndex = 4;
      btn_giaoviec_giaoviec.Text = "Giao Việc";
      btn_giaoviec_giaoviec.UseVisualStyleBackColor = true;
      btn_giaoviec_giaoviec.Click += btn_giaoviec_giaoviec_Click;
      // 
      // btn_giaoviec_lammoi
      // 
      btn_giaoviec_lammoi.Location = new Point(268, 290);
      btn_giaoviec_lammoi.Name = "btn_giaoviec_lammoi";
      btn_giaoviec_lammoi.Size = new Size(112, 34);
      btn_giaoviec_lammoi.TabIndex = 5;
      btn_giaoviec_lammoi.Text = "Làm Mới";
      btn_giaoviec_lammoi.UseVisualStyleBackColor = true;
      btn_giaoviec_lammoi.Click += btn_giaoviec_lammoi_Click;
      // 
      // btn_giaoviec_quaylai
      // 
      btn_giaoviec_quaylai.Location = new Point(493, 290);
      btn_giaoviec_quaylai.Name = "btn_giaoviec_quaylai";
      btn_giaoviec_quaylai.Size = new Size(112, 34);
      btn_giaoviec_quaylai.TabIndex = 5;
      btn_giaoviec_quaylai.Text = "Quay Lại";
      btn_giaoviec_quaylai.UseVisualStyleBackColor = true;
      btn_giaoviec_quaylai.Click += btn_giaoviec_quaylai_Click;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(62, 111);
      label2.Name = "label2";
      label2.Size = new Size(120, 25);
      label2.TabIndex = 0;
      label2.Text = "Tên Công Văn";
      label2.Click += label1_Click;
      // 
      // txt_giaoviec_ten_congvan
      // 
      txt_giaoviec_ten_congvan.Location = new Point(198, 108);
      txt_giaoviec_ten_congvan.Name = "txt_giaoviec_ten_congvan";
      txt_giaoviec_ten_congvan.Size = new Size(388, 31);
      txt_giaoviec_ten_congvan.TabIndex = 1;
      txt_giaoviec_ten_congvan.TextChanged += txt_giaoviec_congvan_TextChanged;
      // 
      // GiaoViec
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(btn_giaoviec_quaylai);
      Controls.Add(btn_giaoviec_lammoi);
      Controls.Add(btn_giaoviec_giaoviec);
      Controls.Add(combobox_giaoviec_canbo);
      Controls.Add(txt_giaoviec_ten_congvan);
      Controls.Add(txt_giaoviec_id_congvan);
      Controls.Add(label5);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "GiaoViec";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "GiaoViec";
      FormClosing += GiaoViec_FormClosing;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txt_giaoviec_id_congvan;
    private Label label5;
    private ComboBox combobox_giaoviec_canbo;
    private Button btn_giaoviec_giaoviec;
    private Button btn_giaoviec_lammoi;
    private Button btn_giaoviec_quaylai;
    private Label label2;
    private TextBox txt_giaoviec_ten_congvan;
  }
}