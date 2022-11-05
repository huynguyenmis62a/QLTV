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
    public partial class QLmuon : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable Com2dt = new DataTable();
        DataTable comdt = new DataTable();
        String sql, constr;
        int i;
        public QLmuon()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comTimkiem1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " select Distinct " + comTimkiem1.Text + " from TableMuonTraSach ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comTimkiem2.DataSource = comdt;
            comTimkiem2.DisplayMember = comTimkiem1.Text;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            sql = " select masophieumuon, madocgia, masach FROM TableMuonTraSach" +
           " where " + comTimkiem1.Text + "=N'" + comTimkiem2.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            sql = "Select TableDocGia.madocgia,TableDocGia.HoTen, TableMuontrasach.masach," +
              " TableSach.TenSach,TableSach.TacGia,TableSach.SoLuong,TableSach.NXB," +
              "TableSach.TheLoai,TableSach.NamXuatBan " + 
              " from (TableDocGia inner join TableMuonTrasach on TableDocGia.madocgia= TableMuonTrasach.madocgia )" +
              " inner join TableSach on TableSach.masach= TableMuonTrasach.masach";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);// làm đầy dữ liệu đổ  vào datatable
            grdData.DataSource = dt;// hiển thị ra ô lưới
            grdData.Refresh();
            NapCT();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtHoTen.Text = grdData.Rows[i].Cells["HoTen"].Value.ToString();
            txtmadocgia.Text = grdData.Rows[i].Cells["madocgia"].Value.ToString();
            //txtNgayMuon.Text = grdData.Rows[i].Cells["NgayMuon"].Value.ToString();
            //txtNgayTra.Text = grdData.Rows[i].Cells["NgayTra"].Value.ToString();
            txtmasach.Text = grdData.Rows[i].Cells["masach"].Value.ToString();
            txtTenSach.Text = grdData.Rows[i].Cells["TenSach"].Value.ToString();
            txtNXB.Text = grdData.Rows[i].Cells["NXB"].Value.ToString();
            txtNamXuatBan.Text = grdData.Rows[i].Cells["NamXuatBan"].Value.ToString();
            txtSoLuong.Text = grdData.Rows[i].Cells["SoLuong"].Value.ToString();
            txtTacGia.Text = grdData.Rows[i].Cells["TacGia"].Value.ToString();
            txtTheLoaisach.Text = grdData.Rows[i].Cells["TheLoai"].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLmuon_Load(object sender, EventArgs e)
        {
            constr = "Data Source=21AK22-COM\\LINH;Initial Catalog=QLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "Select TableDocGia.madocgia,TableDocGia.HoTen, TableMuontrasach.masach," +
                " TableSach.TenSach,TableSach.TacGia,TableSach.SoLuong,TableSach.NXB," +
                "TableSach.TheLoai,TableSach.NamXuatBan " + 
                " from (TableDocGia inner join TableMuonTrasach on TableDocGia.madocgia= TableMuonTrasach.madocgia )" +
                " inner join TableSach on TableSach.masach= TableMuonTrasach.masach";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
            sql = "select TheLoai from TableSach";
            da = new SqlDataAdapter(sql, conn);
            Com2dt.Clear();
            da.Fill(Com2dt);
            txtTheLoaisach.Text = "Com2dt";
            txtTheLoaisach.Text = "TheLoai";
        }
    }
}
