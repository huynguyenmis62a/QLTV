
namespace QLTV
{
    partial class PHIEUMUON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PHIEUMUON));
            this.txtmadg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenDG = new System.Windows.Forms.TextBox();
            this.txttenTL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaTL = new System.Windows.Forms.ComboBox();
            this.txttenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaNV = new System.Windows.Forms.ComboBox();
            this.TXTNGAYLAP = new System.Windows.Forms.DateTimePicker();
            this.TXTNGAYTRA = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bntlapphieu = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMAPHIEUMUON = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grdphieumuon = new System.Windows.Forms.DataGridView();
            this.MAPHIEUMUON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdphieumuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmadg
            // 
            this.txtmadg.FormattingEnabled = true;
            this.txtmadg.Location = new System.Drawing.Point(144, 119);
            this.txtmadg.Name = "txtmadg";
            this.txtmadg.Size = new System.Drawing.Size(98, 25);
            this.txtmadg.TabIndex = 0;
            this.txtmadg.SelectedIndexChanged += new System.EventHandler(this.txtmadg_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã độc giả";
            // 
            // txttenDG
            // 
            this.txttenDG.Location = new System.Drawing.Point(265, 119);
            this.txttenDG.Name = "txttenDG";
            this.txttenDG.Size = new System.Drawing.Size(205, 25);
            this.txttenDG.TabIndex = 2;
            this.txttenDG.TextChanged += new System.EventHandler(this.txttenDG_TextChanged);
            // 
            // txttenTL
            // 
            this.txttenTL.Location = new System.Drawing.Point(265, 171);
            this.txttenTL.Name = "txttenTL";
            this.txttenTL.Size = new System.Drawing.Size(205, 25);
            this.txttenTL.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã tài liệu ";
            // 
            // txtmaTL
            // 
            this.txtmaTL.FormattingEnabled = true;
            this.txtmaTL.Location = new System.Drawing.Point(144, 171);
            this.txtmaTL.Name = "txtmaTL";
            this.txtmaTL.Size = new System.Drawing.Size(98, 25);
            this.txtmaTL.TabIndex = 3;
            this.txtmaTL.SelectedIndexChanged += new System.EventHandler(this.txtmaTL_SelectedIndexChanged);
            // 
            // txttenNV
            // 
            this.txttenNV.Location = new System.Drawing.Point(265, 219);
            this.txttenNV.Name = "txttenNV";
            this.txttenNV.Size = new System.Drawing.Size(205, 25);
            this.txttenNV.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã nhân viên ";
            // 
            // txtmaNV
            // 
            this.txtmaNV.FormattingEnabled = true;
            this.txtmaNV.Location = new System.Drawing.Point(144, 219);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(98, 25);
            this.txtmaNV.TabIndex = 6;
            this.txtmaNV.SelectedIndexChanged += new System.EventHandler(this.txtmaNV_SelectedIndexChanged);
            // 
            // TXTNGAYLAP
            // 
            this.TXTNGAYLAP.CustomFormat = "MM/dd/yyyy";
            this.TXTNGAYLAP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TXTNGAYLAP.Location = new System.Drawing.Point(144, 309);
            this.TXTNGAYLAP.Name = "TXTNGAYLAP";
            this.TXTNGAYLAP.Size = new System.Drawing.Size(142, 25);
            this.TXTNGAYLAP.TabIndex = 9;
            // 
            // TXTNGAYTRA
            // 
            this.TXTNGAYTRA.CustomFormat = "MM/dd/yyyy";
            this.TXTNGAYTRA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TXTNGAYTRA.Location = new System.Drawing.Point(144, 351);
            this.TXTNGAYTRA.Name = "TXTNGAYTRA";
            this.TXTNGAYTRA.Size = new System.Drawing.Size(142, 25);
            this.TXTNGAYTRA.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày trả ";
            // 
            // bntlapphieu
            // 
            this.bntlapphieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bntlapphieu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bntlapphieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntlapphieu.Location = new System.Drawing.Point(534, 380);
            this.bntlapphieu.Name = "bntlapphieu";
            this.bntlapphieu.Size = new System.Drawing.Size(92, 36);
            this.bntlapphieu.TabIndex = 13;
            this.bntlapphieu.Text = "Lưu";
            this.bntlapphieu.UseVisualStyleBackColor = false;
            this.bntlapphieu.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(144, 265);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(98, 25);
            this.txtSL.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số lượng:";
            // 
            // txtMAPHIEUMUON
            // 
            this.txtMAPHIEUMUON.Location = new System.Drawing.Point(144, 74);
            this.txtMAPHIEUMUON.Name = "txtMAPHIEUMUON";
            this.txtMAPHIEUMUON.Size = new System.Drawing.Size(326, 25);
            this.txtMAPHIEUMUON.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mã phiếu mượn";
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
            this.grdphieumuon.Location = new System.Drawing.Point(22, 425);
            this.grdphieumuon.Name = "grdphieumuon";
            this.grdphieumuon.Size = new System.Drawing.Size(745, 239);
            this.grdphieumuon.TabIndex = 18;
            this.grdphieumuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdphieumuon_CellClick);
            this.grdphieumuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MAPHIEUMUON
            // 
            this.MAPHIEUMUON.DataPropertyName = "MAPHIEUMUON";
            this.MAPHIEUMUON.HeaderText = "Mã phiếu mượn";
            this.MAPHIEUMUON.Name = "MAPHIEUMUON";
            // 
            // madocgia
            // 
            this.madocgia.DataPropertyName = "madocgia";
            this.madocgia.HeaderText = "Mã độc giả";
            this.madocgia.Name = "madocgia";
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.Name = "masach";
            // 
            // manhanvien
            // 
            this.manhanvien.DataPropertyName = "manhanvien";
            this.manhanvien.HeaderText = "Mã nhân viên";
            this.manhanvien.Name = "manhanvien";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // ngaylapphieu
            // 
            this.ngaylapphieu.DataPropertyName = "ngaylapphieu";
            this.ngaylapphieu.HeaderText = "Ngày mượn";
            this.ngaylapphieu.Name = "ngaylapphieu";
            // 
            // ngaytra
            // 
            this.ngaytra.DataPropertyName = "ngaytra";
            this.ngaytra.HeaderText = "Ngày trả";
            this.ngaytra.Name = "ngaytra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(390, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 27);
            this.label8.TabIndex = 19;
            this.label8.Text = "MƯỢN SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 54);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(737, 380);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 36);
            this.btnThoat.TabIndex = 67;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Location = new System.Drawing.Point(632, 380);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(92, 36);
            this.btnIn.TabIndex = 68;
            this.btnIn.Text = "In phiếu mượn";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // PHIEUMUON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 749);
            this.Controls.Add(this.btnIn);
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
            this.Name = "PHIEUMUON";
            this.Text = "PHIEUMUON";
            this.Load += new System.EventHandler(this.PHIEUMUON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdphieumuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtmadg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenDG;
        private System.Windows.Forms.TextBox txttenTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtmaTL;
        private System.Windows.Forms.TextBox txttenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtmaNV;
        private System.Windows.Forms.DateTimePicker TXTNGAYLAP;
        private System.Windows.Forms.DateTimePicker TXTNGAYTRA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntlapphieu;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMAPHIEUMUON;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdphieumuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEUMUON;
        private System.Windows.Forms.DataGridViewTextBoxColumn madocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
    }
}