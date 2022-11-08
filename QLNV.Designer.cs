
namespace QLTV
{
    partial class QLNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt__sua = new System.Windows.Forms.Button();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.cb_chucvu = new System.Windows.Forms.ComboBox();
            this.tb_socmnd = new System.Windows.Forms.TextBox();
            this.tb_hktt = new System.Windows.Forms.TextBox();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.tb_dienthoai = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.tb_ns = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ngày sinh:";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(45, 350);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(857, 244);
            this.dgv.TabIndex = 56;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(827, 215);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 35);
            this.bt_xoa.TabIndex = 55;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt__sua
            // 
            this.bt__sua.Location = new System.Drawing.Point(827, 158);
            this.bt__sua.Name = "bt__sua";
            this.bt__sua.Size = new System.Drawing.Size(75, 35);
            this.bt__sua.TabIndex = 54;
            this.bt__sua.Text = "Sửa";
            this.bt__sua.UseVisualStyleBackColor = true;
            this.bt__sua.Click += new System.EventHandler(this.bt__sua_Click);
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "nam ",
            "nữ"});
            this.cb_gioitinh.Location = new System.Drawing.Point(491, 209);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(188, 24);
            this.cb_gioitinh.TabIndex = 67;
            // 
            // cb_chucvu
            // 
            this.cb_chucvu.FormattingEnabled = true;
            this.cb_chucvu.Items.AddRange(new object[] {
            "thủ thư ",
            "quản đốc"});
            this.cb_chucvu.Location = new System.Drawing.Point(491, 121);
            this.cb_chucvu.Name = "cb_chucvu";
            this.cb_chucvu.Size = new System.Drawing.Size(188, 24);
            this.cb_chucvu.TabIndex = 66;
            // 
            // tb_socmnd
            // 
            this.tb_socmnd.Location = new System.Drawing.Point(148, 176);
            this.tb_socmnd.Multiline = true;
            this.tb_socmnd.Name = "tb_socmnd";
            this.tb_socmnd.Size = new System.Drawing.Size(188, 29);
            this.tb_socmnd.TabIndex = 65;
            // 
            // tb_hktt
            // 
            this.tb_hktt.Location = new System.Drawing.Point(148, 218);
            this.tb_hktt.Multiline = true;
            this.tb_hktt.Name = "tb_hktt";
            this.tb_hktt.Size = new System.Drawing.Size(188, 29);
            this.tb_hktt.TabIndex = 63;
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(148, 83);
            this.tb_hoten.Multiline = true;
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(188, 29);
            this.tb_hoten.TabIndex = 62;
            // 
            // tb_dienthoai
            // 
            this.tb_dienthoai.Location = new System.Drawing.Point(491, 167);
            this.tb_dienthoai.Multiline = true;
            this.tb_dienthoai.Name = "tb_dienthoai";
            this.tb_dienthoai.Size = new System.Drawing.Size(188, 26);
            this.tb_dienthoai.TabIndex = 56;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(491, 74);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(188, 29);
            this.tb_email.TabIndex = 54;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(148, 128);
            this.tb_diachi.Multiline = true;
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(188, 29);
            this.tb_diachi.TabIndex = 53;
            // 
            // tb_manv
            // 
            this.tb_manv.Location = new System.Drawing.Point(148, 36);
            this.tb_manv.Multiline = true;
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(188, 29);
            this.tb_manv.TabIndex = 52;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(827, 104);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 35);
            this.bt_them.TabIndex = 53;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // tb_ns
            // 
            this.tb_ns.Location = new System.Drawing.Point(491, 29);
            this.tb_ns.Multiline = true;
            this.tb_ns.Name = "tb_ns";
            this.tb_ns.Size = new System.Drawing.Size(188, 29);
            this.tb_ns.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "HKTT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Số CMND:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Mã nhân viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Chức vụ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_ns);
            this.groupBox1.Controls.Add(this.cb_gioitinh);
            this.groupBox1.Controls.Add(this.cb_chucvu);
            this.groupBox1.Controls.Add(this.tb_socmnd);
            this.groupBox1.Controls.Add(this.tb_hktt);
            this.groupBox1.Controls.Add(this.tb_hoten);
            this.groupBox1.Controls.Add(this.tb_dienthoai);
            this.groupBox1.Controls.Add(this.tb_email);
            this.groupBox1.Controls.Add(this.tb_diachi);
            this.groupBox1.Controls.Add(this.tb_manv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(45, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 270);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết nhân viên";
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 632);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt__sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.groupBox1);
            this.Name = "QLNV";
            this.Text = "QLNV";
            this.Load += new System.EventHandler(this.QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt__sua;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.ComboBox cb_chucvu;
        private System.Windows.Forms.TextBox tb_socmnd;
        private System.Windows.Forms.TextBox tb_hktt;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.TextBox tb_dienthoai;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox tb_ns;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}