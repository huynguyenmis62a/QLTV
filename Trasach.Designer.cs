
namespace QLTV
{
    partial class Trasach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trasach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHIEUMUON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdphieumuon = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMAPHIEUMUON = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.bntlapphieu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTNGAYTRA = new System.Windows.Forms.DateTimePicker();
            this.TXTNGAYLAP = new System.Windows.Forms.DateTimePicker();
            this.txttenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaNV = new System.Windows.Forms.ComboBox();
            this.txttenTL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaTL = new System.Windows.Forms.ComboBox();
            this.txttenDG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmadg = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdphieumuon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(-4, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1272, 71);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(522, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 27);
            this.label8.TabIndex = 19;
            this.label8.Text = "TRẢ SÁCH";
            // 
            // ngaytra
            // 
            this.ngaytra.DataPropertyName = "ngaytra";
            this.ngaytra.HeaderText = "Ngày trả";
            this.ngaytra.Name = "ngaytra";
            // 
            // ngaylapphieu
            // 
            this.ngaylapphieu.DataPropertyName = "ngaylapphieu";
            this.ngaylapphieu.HeaderText = "Ngày mượn";
            this.ngaylapphieu.Name = "ngaylapphieu";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // manhanvien
            // 
            this.manhanvien.DataPropertyName = "manhanvien";
            this.manhanvien.HeaderText = "Mã nhân viên";
            this.manhanvien.Name = "manhanvien";
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.Name = "masach";
            // 
            // madocgia
            // 
            this.madocgia.DataPropertyName = "madocgia";
            this.madocgia.HeaderText = "Mã độc giả";
            this.madocgia.Name = "madocgia";
            // 
            // MAPHIEUMUON
            // 
            this.MAPHIEUMUON.DataPropertyName = "MAPHIEUMUON";
            this.MAPHIEUMUON.HeaderText = "Mã phiếu mượn";
            this.MAPHIEUMUON.Name = "MAPHIEUMUON";
            // 
            // grdphieumuon
            // 
            this.grdphieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdphieumuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHIEUMUON,
            this.madocgia,
            this.masach,
            this.manhanvien,
            this.soluong,
            this.ngaylapphieu,
            this.ngaytra});
            this.grdphieumuon.Location = new System.Drawing.Point(26, 392);
            this.grdphieumuon.Margin = new System.Windows.Forms.Padding(4);
            this.grdphieumuon.Name = "grdphieumuon";
            this.grdphieumuon.Size = new System.Drawing.Size(768, 225);
            this.grdphieumuon.TabIndex = 39;
            this.grdphieumuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdphieumuon_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Mã phiếu mượn";
            // 
            // txtMAPHIEUMUON
            // 
            this.txtMAPHIEUMUON.Location = new System.Drawing.Point(188, 95);
            this.txtMAPHIEUMUON.Margin = new System.Windows.Forms.Padding(4);
            this.txtMAPHIEUMUON.Name = "txtMAPHIEUMUON";
            this.txtMAPHIEUMUON.Size = new System.Drawing.Size(433, 25);
            this.txtMAPHIEUMUON.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Số lượng:";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(188, 278);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(129, 25);
            this.txtSL.TabIndex = 35;
            // 
            // bntlapphieu
            // 
            this.bntlapphieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bntlapphieu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bntlapphieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntlapphieu.Location = new System.Drawing.Point(726, 348);
            this.bntlapphieu.Margin = new System.Windows.Forms.Padding(4);
            this.bntlapphieu.Name = "bntlapphieu";
            this.bntlapphieu.Size = new System.Drawing.Size(92, 36);
            this.bntlapphieu.TabIndex = 34;
            this.bntlapphieu.Text = "Lưu";
            this.bntlapphieu.UseVisualStyleBackColor = false;
            this.bntlapphieu.Click += new System.EventHandler(this.bntlapphieu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 359);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ngày trả ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ngày mượn";
            // 
            // TXTNGAYTRA
            // 
            this.TXTNGAYTRA.CustomFormat = "MM/dd/yyyy";
            this.TXTNGAYTRA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TXTNGAYTRA.Location = new System.Drawing.Point(188, 359);
            this.TXTNGAYTRA.Margin = new System.Windows.Forms.Padding(4);
            this.TXTNGAYTRA.Name = "TXTNGAYTRA";
            this.TXTNGAYTRA.Size = new System.Drawing.Size(188, 25);
            this.TXTNGAYTRA.TabIndex = 31;
            // 
            // TXTNGAYLAP
            // 
            this.TXTNGAYLAP.CustomFormat = "MM/dd/yyyy";
            this.TXTNGAYLAP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TXTNGAYLAP.Location = new System.Drawing.Point(188, 316);
            this.TXTNGAYLAP.Margin = new System.Windows.Forms.Padding(4);
            this.TXTNGAYLAP.Name = "TXTNGAYLAP";
            this.TXTNGAYLAP.Size = new System.Drawing.Size(188, 25);
            this.TXTNGAYLAP.TabIndex = 30;
            // 
            // txttenNV
            // 
            this.txttenNV.Location = new System.Drawing.Point(349, 233);
            this.txttenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txttenNV.Name = "txttenNV";
            this.txttenNV.Size = new System.Drawing.Size(272, 25);
            this.txttenNV.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã nhân viên ";
            // 
            // txtmaNV
            // 
            this.txtmaNV.FormattingEnabled = true;
            this.txtmaNV.Location = new System.Drawing.Point(188, 233);
            this.txtmaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(129, 25);
            this.txtmaNV.TabIndex = 27;
            this.txtmaNV.SelectedIndexChanged += new System.EventHandler(this.txtmaNV_SelectedIndexChanged);
            // 
            // txttenTL
            // 
            this.txttenTL.Location = new System.Drawing.Point(349, 184);
            this.txttenTL.Margin = new System.Windows.Forms.Padding(4);
            this.txttenTL.Name = "txttenTL";
            this.txttenTL.Size = new System.Drawing.Size(272, 25);
            this.txttenTL.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã tài liệu ";
            // 
            // txtmaTL
            // 
            this.txtmaTL.FormattingEnabled = true;
            this.txtmaTL.Location = new System.Drawing.Point(188, 184);
            this.txtmaTL.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaTL.Name = "txtmaTL";
            this.txtmaTL.Size = new System.Drawing.Size(129, 25);
            this.txtmaTL.TabIndex = 24;
            this.txtmaTL.SelectedIndexChanged += new System.EventHandler(this.txtmaTL_SelectedIndexChanged);
            // 
            // txttenDG
            // 
            this.txttenDG.Location = new System.Drawing.Point(349, 138);
            this.txttenDG.Margin = new System.Windows.Forms.Padding(4);
            this.txttenDG.Name = "txttenDG";
            this.txttenDG.Size = new System.Drawing.Size(272, 25);
            this.txttenDG.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã độc giả";
            // 
            // txtmadg
            // 
            this.txtmadg.FormattingEnabled = true;
            this.txtmadg.Location = new System.Drawing.Point(188, 138);
            this.txtmadg.Margin = new System.Windows.Forms.Padding(4);
            this.txtmadg.Name = "txtmadg";
            this.txtmadg.Size = new System.Drawing.Size(129, 25);
            this.txtmadg.TabIndex = 21;
            this.txtmadg.SelectedIndexChanged += new System.EventHandler(this.txtmadg_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(843, 348);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 36);
            this.btnThoat.TabIndex = 66;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Trasach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 749);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdphieumuon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMAPHIEUMUON);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.bntlapphieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTNGAYTRA);
            this.Controls.Add(this.TXTNGAYLAP);
            this.Controls.Add(this.txttenNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmaNV);
            this.Controls.Add(this.txttenTL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaTL);
            this.Controls.Add(this.txttenDG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmadg);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Trasach";
            this.Text = "Trasach";
            this.Load += new System.EventHandler(this.Trasach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdphieumuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn madocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEUMUON;
        private System.Windows.Forms.DataGridView grdphieumuon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMAPHIEUMUON;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Button bntlapphieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TXTNGAYTRA;
        private System.Windows.Forms.DateTimePicker TXTNGAYLAP;
        private System.Windows.Forms.TextBox txttenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtmaNV;
        private System.Windows.Forms.TextBox txttenTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtmaTL;
        private System.Windows.Forms.TextBox txttenDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtmadg;
        private System.Windows.Forms.Button btnThoat;
    }
}