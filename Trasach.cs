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
        String sql, constr, sql1;
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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "select madocgia from TableDocGia where madocgia='" + txtmadocgia.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData1.DataSource = dt;// hiển thị ra ô lưới
            grdData1.Refresh();

            int cnt = grdData1.Rows.Count;
            //Thêm vào griddata
            //Đếm số bản ghi trong ô lưới
            if(cnt == 1) {
                
                //Rỗng__độc giả mới
                sql = "insert into TableDocGia (madocgia,HoTen)" +
                   " Values ('" + txtmadocgia.Text + "','" + txtHoTen.Text + "')";
                //MessageBox.Show("Hãy thêm độc giả mới!");
                //txtmadocgia.Focus();//chuyen con trỏ soạn thảo đến ô mã nhóm
            }
            else
            {
                // Có sẵn
                i = grdData1.CurrentRow.Index;
                grdData1.Rows[i].Cells["masach"].Value = txtmasach.Text;
                grdData1.Rows[i].Cells["TenSach"].Value = txtTenSach.Text;
                grdData1.Rows[i].Cells["TacGia"].Value = txtTacGia.Text;
                grdData1.Rows[i].Cells["Soluong"].Value = txtSoLuong.Text;
                grdData1.Rows[i].Cells["NXB"].Value = txtNXB.Text;
                grdData1.Rows[i].Cells["TheLoai"].Value = txtTheLoai.Text;
                grdData1.Rows[i].Cells["NamXuatBan"].Value = txtNamXuatBan.Text;
                grdData1.Refresh();
            }

            NapCT();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
           /* sql = "insert into TableSach (masach,TenSach,TacGia,SoLuong,NXB,TheLoai,NamXuatBan)" +
                    " Values ('" + txtmasach.Text + "','" + txtTenSach.Text + "',N'" + txtTacGia.Text + "',N'" +
                    txtSoLuong.Text + "','" + txtNXB.Text + "',N'" + txtNamXuatBan.Text + "',N'" +
                    txtTheLoai.Text + "')";
            cmd.Connection = conn;
            cmd.CommandText = sql;*/
           sql1 = " insert into TableMuonTraSach (madocgia, NgayMuon, masach, NgayTra)" +
                "Values('" + txtmadocgia.Text + "',N'" + txtNgaymuon.Value + "',N'"+ txtmasach.Text + "',N'"
                 + txtHantra.Value + "')";
            cmd.Connection = conn;
            cmd.CommandText = sql1;
            cmd.ExecuteNonQuery();

            //Nạp dữ liệu vào ô luwoisi=
           
                 i = grdData1.Rows.Count - 1;
                grdData1.Rows[i].Cells["masach"].Value = txtmasach.Text;
            grdData1.Rows[i].Cells["TenSach"].Value = txtTenSach.Text;
            grdData1.Rows[i].Cells["TacGia"].Value = txtTacGia.Text;
            grdData1.Rows[i].Cells["Soluong"].Value = txtSoLuong.Text;
            grdData1.Rows[i].Cells["NXB"].Value = txtNXB.Text;
            grdData1.Rows[i].Cells["TheLoai"].Value = txtTheLoai.Text;
            grdData1.Rows[i].Cells["NamXuatBan"].Value = txtNamXuatBan.Text;
            grdData1.Rows[i].Cells["madocgia"].Value = txtmadocgia.Text;
            grdData1.Rows[i].Cells["HoTen"].Value = txtHoTen.Text;
            grdData1.Rows[i].Cells["NgayMuon"].Value = txtNgaymuon.Value;
            grdData1.Rows[i].Cells["NgayTra"].Value = txtHantra.Value;
            grdData1.Refresh();
            


            /*sql = "Select TableDocGia.madocgia,TableDocGia.HoTen, TableMuontrasach.masach," +
                " TableSach.TenSach,TableSach.TacGia,TableSach.SoLuong,TableSach.NXB," +
                "TableSach.TheLoai,TableSach.NamXuatBan " +
                " from (TableDocGia inner join TableMuonTrasach on TableDocGia.madocgia= TableMuonTrasach.madocgia )" +
                " inner join TableSach on TableSach.masach= TableMuonTrasach.masach";*/

            sql = "select * from TableMuontrasach, TableSach, TableDocGia where TableMuontrasach.masach = TableSach.masach and TableMuontrasach.madocgia = TableDocGia.madocgia";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData1.DataSource = dt;// hiển thị ra ô lưới
            grdData1.Refresh();
            
          

        }

        private void txtTheloaisach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            sql = "select * from TableSach order by masach";
            da = new SqlDataAdapter(sql, conn);//câu lệnh để dataadapter giúp minh truy van du lieu
            dt.Clear();
            da.Fill(dt);// làm đầy dữ liệu đổ  vào datatable
            grdData1.DataSource = dt;// hiển thị ra ô lưới
            grdData1.Refresh();
            NapCT();
        }

        private void grdData1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void button2_Click(object sender, EventArgs e)// nút hủy
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?Y/N", "Xác nhận" +
                " yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete from TableMuonTraSach where madocgia='" + txtmadocgia.Text + "'";
                cmd.Connection = conn;//3 cau lenh lien quan den them sua xoa
                cmd.CommandText = sql;//chuoi sql
                cmd.ExecuteNonQuery();//cach thuc hien lenh
                grdData1.Rows.RemoveAt(grdData1.CurrentRow.Index);//xoa dong hien thoi trong o luoi

                NapCT();
            }
        }

        private void grdData1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
