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
    public partial class FrmQLsach : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        Boolean addnewflag = false;
        public FrmQLsach()
        {
            InitializeComponent();
        }

        private void FrmQLsach_Load(object sender, EventArgs e)
        {
            constr = @"Data Source=ADMIN\PKH;Initial Catalog=PTUD;Integrated Security=True";
            //constr = "Data Source=21AK22-COM\\LINH;Initial Catalog=QLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "SELECT masach, TenSach, TacGia, Soluong, NXB, TheLoai, NamXuatBan from TableSach order by masach";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
            sql = "select masach from TableSach";
            da = new SqlDataAdapter(sql, conn);
        }
        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtmasach.Text = grdData.Rows[i].Cells["masach"].Value.ToString();
            txtTenSach.Text = grdData.Rows[i].Cells["TenSach"].Value.ToString();
            txtNXB.Text = grdData.Rows[i].Cells["NXB"].Value.ToString();
            txtNamXuatBan.Text = grdData.Rows[i].Cells["NamXuatBan"].Value.ToString();
            txtSoLuong.Text = grdData.Rows[i].Cells["SoLuong"].Value.ToString();
            txtTacGia.Text = grdData.Rows[i].Cells["TacGia"].Value.ToString();
            txtTheLoai.Text = grdData.Rows[i].Cells["TheLoai"].Value.ToString();
        }

        private void comTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " select Distinct " + comTimkiem.Text + " from TableSACH ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGiatri.DataSource = comdt;
            comGiatri.DisplayMember = comTimkiem.Text;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            sql = " SELECT masach, TenSach, TacGia, SoLuong, NXB, TheLoai, NamXuatBan from TableSach " +
               " where " + comTimkiem.Text + "=N'" + comGiatri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
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

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdData.RowCount;
            grdData.CurrentCell = grdData[0, i - 2];
            NapCT();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql = "select masach,TenSach,TacGia,SoLuong,NXB,TheLoai,NamXuatBan from TableSach order by masach";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();

            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
            MessageBox.Show("Hãy nhập nội dung ghi mới, kết thúc bấm Cập nhật!");
            txtmasach.Focus();
            addnewflag = true;
            btnUpdate.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy thực hiện mọi sửa đổi trên ô lưới," +
              "kết thúc bấm nút Cập nhật", "Thông báo", MessageBoxButtons.OK);
            btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?Y/N", "Xác nhận" +
              "yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) ;
            {
                sql = "Delete from TableSach where masach='" + txtmasach.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index);
                NapCT();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewflag == false)
            {

                for (i = 0; i < grdData.RowCount - 1; i++)
                {
                    txtmasach.Text = grdData.Rows[i].Cells["masach"].Value.ToString();
                    txtTenSach.Text = grdData.Rows[i].Cells["TenSach"].Value.ToString();
                    txtNXB.Text = grdData.Rows[i].Cells["NXB"].Value.ToString();
                    txtNamXuatBan.Text = grdData.Rows[i].Cells["NamXuatBan"].Value.ToString();
                    txtSoLuong.Text = grdData.Rows[i].Cells["SoLuong"].Value.ToString();
                    txtTacGia.Text = grdData.Rows[i].Cells["TacGia"].Value.ToString();
                    txtTheLoai.Text = grdData.Rows[i].Cells["TheLoai"].Value.ToString();
                    sql = "update TableSach set masach=N'" + txtmasach.Text + "',TenSach=N'" + txtTenSach.Text + "',NXB=N'" + txtNXB.Text + "',NamXuatBan=N'" +
                    txtNamXuatBan.Text + "',SoLuong=N'" + txtSoLuong.Text + "',TacGia=N'" + txtTacGia.Text + "'Where TheLoai=N'" + txtTheLoai.Text + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
            }
            else
            {

                addnewflag = false;
                conn.Close();
                constr = @"Data Source=ADMIN\PKH;Initial Catalog=PTUD;Integrated Security=True";
                //constr = "";
                conn.ConnectionString = constr;
                conn.Open();
                cmd = new SqlCommand("select count(masach) from TableSach where masach = '" + txtmasach.Text + "'", conn);
                cmd.ExecuteScalar();
                int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (count > 0)
                {
                    MessageBox.Show("Mã đã tồn tại,hãy thay đổi! " +
                "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtmasach.Focus();//chuyển con trỏ soạn thảo đến ô txtmanhom

                }
                else
                {
                    sql = "insert into TableSach (masach, TenSach, TacGia, SoLuong, NXB, TheLoai, NamXuatBan)" +
                   " Values ('" + txtmasach.Text + "','" + txtTenSach.Text + "',N'" + txtNXB.Text + "',N'" +
                   txtNamXuatBan.Text + "','" + txtSoLuong.Text + ",'" + txtTacGia.Text + "',N'" + txtTheLoai.Text + "')";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    grdData.Rows[i].Cells["masach"].Value = txtmasach.Text;
                    grdData.Rows[i].Cells["TenSach"].Value = txtTenSach.Text;
                    grdData.Rows[i].Cells["NXB"].Value = txtNXB.Text;
                    grdData.Rows[i].Cells["NamXuatBan"].Value = txtNamXuatBan.Text;
                    grdData.Rows[i].Cells["SoLuong"].Value = txtSoLuong.Text;
                    grdData.Rows[i].Cells["TacGia"].Value = txtTacGia.Text;
                    grdData.Rows[i].Cells["TheLoai"].Value = txtTheLoai.Text;
                    grdData.Refresh();
                }
              
            }
            btnUpdate.Enabled = false;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            sql = "select masach,TenSach,TacGia,SoLuong,NXB,TheLoai,NamXuatBan from TableSach";               
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

    }
}
