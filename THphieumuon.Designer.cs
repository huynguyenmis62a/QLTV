
namespace QLTV
{
    partial class THphieumuon
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
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MAPHIEUMUON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHIEUMUON,
            this.madocgia,
            this.HoTen});
            this.grdData.Location = new System.Drawing.Point(39, 40);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(293, 334);
            this.grdData.TabIndex = 2;
            // 
            // MAPHIEUMUON
            // 
            this.MAPHIEUMUON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAPHIEUMUON.DataPropertyName = "MAPHIEUMUON";
            this.MAPHIEUMUON.HeaderText = "Mã phiếu mượn";
            this.MAPHIEUMUON.Name = "MAPHIEUMUON";
            this.MAPHIEUMUON.Width = 96;
            // 
            // madocgia
            // 
            this.madocgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.madocgia.DataPropertyName = "madocgia";
            this.madocgia.HeaderText = "Mã độc giả";
            this.madocgia.Name = "madocgia";
            this.madocgia.Width = 79;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 73;
            // 
            // THphieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdData);
            this.Name = "THphieumuon";
            this.Text = "THphieumuon";
            this.Load += new System.EventHandler(this.THphieumuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEUMUON;
        private System.Windows.Forms.DataGridViewTextBoxColumn madocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
    }
}