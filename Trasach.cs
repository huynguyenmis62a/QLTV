using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTV
{
    public partial class Trasach : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        //DataTable dt1 = new DataTable();
        DataTable Com2dt = new DataTable();
        DataTable comdt = new DataTable();
        String sql, constr;
        int i;
        
        //Boolean addnewflag = false;
        public Trasach()
        {
            InitializeComponent();
            this.grdData1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdData1_DataError);
        }

        private void grdData1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
       
        private void Trasach_Load(object sender, EventArgs e)
        {
            constr = @"Data Source=ADMIN\PKH;Initial Catalog=PTUD;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            //sql = "SELECT masach,TenSach,TacGia,SoLuong,NXB,TheLoai,NamXuatBan FROM TableSach";

            sql = "Select TableDocGia.madocgia,TableDocGia.HoTen, TableMuontrasach.masach," +
                " TableSach.TenSach,TableSach.TacGia,TableSach.SoLuong,TableSach.NXB," +
                "TableSach.TheLoai,TableSach.NamXuatBan " +
                " from (TableDocGia inner join TableMuonTrasach on TableDocGia.madocgia= TableMuonTrasach.madocgia )" +
                " inner join TableSach on TableSach.masach= TableMuonTrasach.masach";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData1.DataSource = dt;
            NapCT();
             sql = "select TheLoai from TableSach";
            da = new SqlDataAdapter(sql, conn);
            Com2dt.Clear();
            da.Fill(Com2dt);
            txtTheloaisach.DataSource = Com2dt;
            txtTheloaisach.DisplayMember = "TheLoai";
            
        }


        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            sql = " select masach,TenSach,TacGia,SoLuong,NXB,TheLoai,NamXuatBan FROM TableSach" +
              " where " + comTenTruong.Text + "=N'" + comGiaTri.Text + "'";
            da = new SqlDataAdapter(sql, conn);//câu lệnh để dataadapter giúp minh truy van du lieu
            dt.Clear();
            da.Fill(dt);// làm đầy dữ liệu đổ  vào datatable
            grdData1.DataSource = dt;// hiển thị ra ô lưới
            grdData1.Refresh();
            NapCT();
        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {

            sql = " select Distinct " + comTenTruong.Text + " from TableSach ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();// trước đây trong comdt đang có dữ liệu gì thì xóa hết đi đổ cái mới vào
            da.Fill(comdt);//dữ liệu được lấy về đã được đổ vào combo box;
            comGiaTri.DataSource = comdt;
            comGiaTri.DisplayMember = comTenTruong.Text;
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            sql = "Select TableDocGia.madocgia,TableDocGia.HoTen, TableMuontrasach.masach," +
                " TableSach.TenSach,TableSach.TacGia,TableSach.SoLuong,TableSach.NXB," +
                "TableSach.TheLoai,TableSach.NamXuatBan " +
                " from (TableDocGia inner join TableMuonTrasach on TableDocGia.madocgia= TableMuonTrasach.madocgia )" +
                " inner join TableSach on TableSach.masach= TableMuonTrasach.masach";
            da = new SqlDataAdapter(sql, conn);//câu lệnh để dataadapter giúp minh truy van du lieu
            dt.Clear();
            da.Fill(dt);// làm đầy dữ liệu đổ  vào datatable
            grdData1.DataSource = dt;// hiển thị ra ô lưới
            grdData1.Refresh();
            NapCT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemm_Click(object sender, EventArgs e)
        {
            sql = "select madocgia, HoTen from TableDocGia where madocgia='" + txtmadocgia.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData1.DataSource = dt;// hiển thị ra ô lưới
            grdData1.Refresh();
            NapCT();
        }

        private void btnDeletem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn trả sách?Y/N", "Xác nhận" +
               " yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete from TableMuonTraSach where masophieumuon='" + txtMaphieumuon.Text + "'";
                cmd.Connection = conn;//3 cau lenh lien quan den them sua xoa
                cmd.CommandText = sql;//chuoi sql
                cmd.ExecuteNonQuery();//cach thuc hien lenh
                grdData1.Rows.RemoveAt(grdData1.CurrentRow.Index);//xoa dong hien thoi trong o luoi
                sql = "Update TableSach Set SoLuong=SoLuong+1 WHERE masach='" + txtmasach.Text.Trim() + "';";
                cmd.Connection = conn;//3 cau lenh lien quan den them sua xoa
                cmd.CommandText = sql;//
                cmd.ExecuteNonQuery();

                NapCT();
            }
        }

        

        

        private void NapCT()
        {
            i = grdData1.CurrentRow.Index;//Nhan gia tri chi so cua bản ghi hiện thời
            txtmadocgia.Text = grdData1.Rows[i].Cells["madocgia"].Value.ToString();
            txtHoTen.Text = grdData1.Rows[i].Cells["HoTen"].Value.ToString();
            txtmasach.Text = grdData1.Rows[i].Cells["masach"].Value.ToString();
            txtTenSach.Text = grdData1.Rows[i].Cells["TenSach"].Value.ToString();
            txtNXB.Text = grdData1.Rows[i].Cells["TacGia"].Value.ToString();
            txtSoLuong.Text = grdData1.Rows[i].Cells["Soluong"].Value.ToString();
            txtTacGia.Text = grdData1.Rows[i].Cells["NXB"].Value.ToString();
            txtTheLoai.Text = grdData1.Rows[i].Cells["TheLoai"].Value.ToString();
            txtNamXuatBan.Text = grdData1.Rows[i].Cells["NamXuatBan"].Value.ToString();

            //txtNgaymuon.Text= grdData1.Rows[i].Cells["Ngaymuon"].Value.ToString();
            //txtHantra.Text = grdData1.Rows[i].Cells["Hantra"].Value.ToString();
        }
}
}
