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
    public partial class QLdocgia : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        Boolean addnewflag = false;
        public QLdocgia()
        {
            InitializeComponent();
        }

        private void QLdocgia_Load(object sender, EventArgs e)
        {
            //constr = @"Data Source=ADMIN\PKH;Initial Catalog=PTUD;Integrated Security=True";
           // constr = "Data Source=21AK22-COM\\LINH;Initial Catalog=QLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "SELECT madocgia, HoTen, NgaySinh, DonViCongTac, GioiTinh, Email, DienThoai, NgayLapThe from TableDocGia order by madocgia";
          //  sql = "SELECT madocgia, HoTen, DonViCongTac, NgayLapThe from TableDocGia order by madocgia";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
            sql = "select masach from TableSach";
            da = new SqlDataAdapter(sql, conn);
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

      /*  private void comTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " select Distinct " + comTimkiem.Text + " from TableDocGia ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGiatri.DataSource = comdt;
            comGiatri.DisplayMember = comTimkiem.Text;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            sql = " SELECT madocgia,HoTen,DonViCongTac,NgayLapThe from TableDocGia " +
             " where " + comTimkiem.Text + "=N'" + comGiatri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            sql = "select madocgia,HoTen,DonViCongTac,NgayLapThe from TableDocGia";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }*/

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
            sql = "select madocgia,HoTen,DonViCongTac,NgayLapThe,NgaySinh,GioiTinh,Email,DienThoai from TableDocGia order by madocgia";
           // sql = "select madocgia,HoTen,DonViCongTac,NgayLapThe from TableDocGia order by madocgia";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();

            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
            MessageBox.Show("Hãy nhập nội dung ghi mới, kết thúc bấm Cập nhật!");
            txtmadocgia.Focus();
            addnewflag = true;
            btnUpdate.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy thực hiện mọi sửa đổi trên ô lưới," +
           "kết thúc bấm nút Cập nhật", "Thông báo", MessageBoxButtons.OK);
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewflag == false)
            {

                for (i = 0; i < grdData.RowCount - 1; i++)
                {
                    txtmadocgia.Text = grdData.Rows[i].Cells["madocgia"].Value.ToString();
                    txtHoTen.Text = grdData.Rows[i].Cells["HoTen"].Value.ToString();
                    txtDonViCongTac.Text = grdData.Rows[i].Cells["DonViCongTac"].Value.ToString();
                    txtNgayLapThe.Text = grdData.Rows[i].Cells["NgayLapThe"].Value.ToString();
                    txtGioiTinh.Text = grdData.Rows[i].Cells["GioiTinh"].Value.ToString();
                    txtNgaySinh.Text = grdData.Rows[i].Cells["NgaySinh"].Value.ToString();
                    txtEmail.Text = grdData.Rows[i].Cells["Email"].Value.ToString();
                    txtDienThoai.Text = grdData.Rows[i].Cells["DienThoai"].Value.ToString();
                    sql = "update TableDocGia set madocgia=N'" + txtmadocgia.Text + "',HoTen=N'" + txtHoTen.Text + "',DonViCongTac=N'" +
                        txtDonViCongTac.Text + "',GioiTinh=N'" + txtGioiTinh.Text + "',NgaySinh=N'" + txtNgaySinh + "',Email=N'" +
                        txtEmail.Text + "',DienThoai='N" + txtDienThoai.Text + "'Where NgayLapThe='" + txtNgayLapThe.Text + "'";
                  //  sql = "update TableDocGia set madocgia=N'" + txtmadocgia.Text + "',HoTen=N'" + txtHoTen.Text + "',DonViCongTac=N'" + txtDonViCongTac.Text + "'Where NgayLapThe='" + txtNgayLapThe.Text + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
            }
            else
            {

                addnewflag = false;
                sql = "insert into TableDocGia (madocgia, HoTen, DonViCongTac, NgayLapThe)" +
                    " Values ('" + txtmadocgia.Text + "','" + txtHoTen.Text + "',N'" + txtDonViCongTac.Text + "',N'" + txtNgayLapThe.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows[i].Cells["madocgia"].Value = txtmadocgia.Text;
                grdData.Rows[i].Cells["HoTen"].Value = txtHoTen.Text;
                grdData.Rows[i].Cells["DonViCongTac"].Value = txtDonViCongTac.Text;
                grdData.Rows[i].Cells["NgayLapThe"].Value = txtNgayLapThe.Text;
                grdData.Rows[i].Cells["GioiTinh"].Value = txtGioiTinh.Text;
                grdData.Rows[i].Cells["NgaySinh"].Value = txtNgaySinh.Text;
                grdData.Rows[i].Cells["Email"].Value = txtEmail.Text;
                grdData.Rows[i].Cells["DienThoai"].Value = txtDienThoai.Text;
                grdData.Refresh();

            }
            btnUpdate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?Y/N", "Xác nhận" +
             "yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete from TableDocGia where madocgia='" + txtmadocgia.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index);
                NapCT();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptQLDG rpt = new rptQLDG();
            DataTable rptData = new DataTable();
           sql = "Select* from TableSach ";
            da = new SqlDataAdapter(sql, conn); 
            da.Fill(rptData);
            rpt.SetDataSource(rptData);
            //rpt.DataDefinition.FormulaFields["mabaocao"].Text = "'" + comTimkiem.Text + "'";
            FrmPrv_QLDG f = new FrmPrv_QLDG(rpt);
            f.Show();

        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtmadocgia.Text = grdData.Rows[i].Cells["madocgia"].Value.ToString();
            txtHoTen.Text = grdData.Rows[i].Cells["HoTen"].Value.ToString();
            txtDonViCongTac.Text = grdData.Rows[i].Cells["DonViCongTac"].Value.ToString();
            txtNgayLapThe.Text = grdData.Rows[i].Cells["NgayLapThe"].Value.ToString();
            txtNgaySinh.Text = grdData.Rows[i].Cells["NgaySinh"].Value.ToString();
            txtGioiTinh.Text = grdData.Rows[i].Cells["GioiTinh"].Value.ToString();
            txtEmail.Text = grdData.Rows[i].Cells["Email"].Value.ToString();
            txtDienThoai.Text = grdData.Rows[i].Cells["DienThoai"].Value.ToString();
        }
    }
}
