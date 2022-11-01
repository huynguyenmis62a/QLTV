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
    public partial class Luutrusach : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable Com2dt = new DataTable();
        DataTable comdt = new DataTable();
        String sql, constr;
        int i;
        Boolean addnewflag = false;
        public Luutrusach()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void Mnsach_Load(object sender, EventArgs e)
        {
            constr = @"Data Source=ADMIN\PKH;Initial Catalog=PTUD;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "SELECT masach,TenSach,TacGia,SoLuong,NXB,TheLoai,NamXuatBan FROM TableSach";
            
            da = new SqlDataAdapter(sql, conn);//câu lệnh để dataadapter giúp minh truy van du lieu
            da.Fill(dt);// làm đầy dữ liệu đổ  vào datatable
            grdData.DataSource = dt;// hiển thị ra ô lưới
            NapCT();
            sql = "select TheLoai from TableSach";
            da = new SqlDataAdapter(sql, conn);
            Com2dt.Clear();
            da.Fill(Com2dt);
            txtTheLoai.DataSource = Com2dt;
            txtTheLoai.DisplayMember = "TheLoai";
            
        }

        private void grpTTsach_Enter(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdData.RowCount;// i= đếm số d
            grdData.CurrentCell = grdData[0, i - 2];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;//i là dòng hiện thời
            if (i <= grdData.RowCount - 2)
            {
                grdData.CurrentCell = grdData[0, i + 1];
            }
            else
            {
                grdData.CurrentCell = grdData[0, 0];
            }

            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i > 0)
            {
                grdData.CurrentCell = grdData[0, i - 1];
            }
            else
            {
                grdData.CurrentCell = grdData[0, grdData.RowCount - 2];
            }
            NapCT();
        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " select Distinct " + comTenTruong.Text + " FROM TableSach ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();// trước đây trong comdt đang có dữ liệu gì thì xóa hết đi đổ cái mới vào
            da.Fill(comdt);//dữ liệu được lấy về đã được đổ vào combo box;
            comGiaTri.DataSource = comdt;
            comGiaTri.DisplayMember = comTenTruong.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?Y/N", "Xác nhận" +
               " yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete from TableSach where ='" + txtmasach.Text + "'";
                cmd.Connection = conn;//3 cau lenh lien quan den them sua xoa
                cmd.CommandText = sql;//chuoi sql
                cmd.ExecuteNonQuery();//cach thuc hien lenh
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index);//xoa dong hien thoi trong o luoi

                NapCT();
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            sql = "select * from TableSach order by masach";
            da = new SqlDataAdapter(sql, conn);//câu lệnh để dataadapter giúp minh truy van du lieu
            dt.Clear();
            da.Fill(dt);// làm đầy dữ liệu đổ  vào datatable
            grdData.DataSource = dt;// hiển thị ra ô lưới
            grdData.Refresh();
            NapCT();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            sql = " select masach,TenSach,TacGia,SoLuong,NXB,TheLoai,NamXuatBan FROM TableSach" +
               " where " + comTenTruong.Text + "=N'" + comGiaTri.Text + "'";
            da = new SqlDataAdapter(sql, conn);//câu lệnh để dataadapter giúp minh truy van du lieu
            dt.Clear();
            da.Fill(dt);// làm đầy dữ liệu đổ  vào datatable
            grdData.DataSource = dt;// hiển thị ra ô lưới
            grdData.Refresh();
            NapCT();
        }

        private void cmdEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewflag == false)
            {//chỗ này là cập nhật sửa chữa
                for (i = 0; i < grdData.RowCount - 1; i++)
                {
                    txtmasach.Text = grdData.Rows[i].Cells["masach"].Value.ToString();
                    txtTenSach.Text = grdData.Rows[i].Cells["TenSach"].Value.ToString();
                    txtTacGia.Text = grdData.Rows[i].Cells["TacGia"].Value.ToString();
                    txtSoLuong.Text = grdData.Rows[i].Cells["Soluong"].Value.ToString();
                    txtNXB.Text = grdData.Rows[i].Cells["NXB"].Value.ToString();
                    txtTheLoai.Text = grdData.Rows[i].Cells["TheLoai"].Value.ToString();
                    txtNamXuatBan.Text = grdData.Rows[i].Cells["NamXuatBan"].Value.ToString();
                    sql = "update TableSach set TenSach=N'" + txtTenSach.Text + "'," + " TacGia=N'" +
                        txtTacGia.Text + "',SoLuong=N'" + txtSoLuong.Text + "',NXB=N'" + txtNXB.Text + "',NamXuatBan=N'" + txtNamXuatBan.Text + "',TheLoai=N'" + txtTheLoai.Text + "' where masach='" + txtmasach.Text + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
            }

            else
            {
                //chỗ này là cập nhật thêm mới
                addnewflag = false;
                sql = "insert into TableSach (masach,TenSach,TacGia,SoLuong,NXB,TheLoai,NamXuatBan)" +
                    " Values ('" + txtmasach.Text + "','" + txtTenSach.Text + "',N'" + txtTacGia.Text + "',N'" +
                    txtSoLuong.Text + "','" + txtNXB.Text + "',N'" + txtNamXuatBan.Text + "',N'"+
                    txtTheLoai.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                // nạp bản ghi vừa thêm từ chi tiết vào ô lưới
                grdData.Rows[i].Cells["masach"].Value = txtmasach.Text;
                grdData.Rows[i].Cells["TenSach"].Value = txtTenSach.Text;
                grdData.Rows[i].Cells["TacGia"].Value = txtTacGia.Text;
                grdData.Rows[i].Cells["Soluong"].Value = txtSoLuong.Text;
                grdData.Rows[i].Cells["NXB"].Value = txtNXB.Text;
                grdData.Rows[i].Cells["TheLoai"].Value = txtTheLoai.Text;
                grdData.Rows[i].Cells["NamXuatBan"].Value = txtNamXuatBan.Text;
                grdData.Refresh();
            }
            btnUpdate.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;//Nhan gia tri chi so cua bản ghi hiện thời
            txtmasach.Text = grdData.Rows[i].Cells["masach"].Value.ToString();
            txtTenSach.Text = grdData.Rows[i].Cells["TenSach"].Value.ToString();
            txtTacGia.Text = grdData.Rows[i].Cells["TacGia"].Value.ToString();
            txtSoLuong.Text = grdData.Rows[i].Cells["Soluong"].Value.ToString();
            txtNXB.Text = grdData.Rows[i].Cells["NXB"].Value.ToString();
            txtTheLoai.Text = grdData.Rows[i].Cells["TheLoai"].Value.ToString();
            txtNamXuatBan.Text = grdData.Rows[i].Cells["NamXuatBan"].Value.ToString();
           
        }
    }
}
