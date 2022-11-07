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
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataReader dr, dr1, dr2;
        string sql, sql1, sql2, constr;
        int i;
        private void grdphieumuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void Trasach_Load(object sender, EventArgs e)
        {
            constr = @"Data Source=ADMIN\PKH;Initial Catalog=PTUD;Integrated Security=True";
            conn.ConnectionString = constr;
            sql = "Select * from TableSach";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtmaTL.Items.Add(dr["masach"]);
            }
            conn.Close();
            sql1 = "Select * from TableDocGia";
            cmd = new SqlCommand(sql1, conn);
            conn.Open();
            dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                txtmadg.Items.Add(dr1["madocgia"]);
            }
            conn.Close();

            sql2 = "Select * from TableNhanVien";
            cmd = new SqlCommand(sql2, conn);
            conn.Open();
            dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                txtmaNV.Items.Add(dr2["manhanvien"]);
            }
            conn.Close();

            conn.Open();
            sql = "select * from PHIEUMUON";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            // DataSet DS = new System.Data.DataSet();
            da.Fill(dt);
            grdphieumuon.DataSource = dt;


        }

        private void bntlapphieu_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (MessageBox.Show("Bạn có chắc chắn muốn trả sách?Y/N", "Xác nhận" +
              " yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete from PHIEUMUON where MAPHIEUMUON='" + txtMAPHIEUMUON.Text + "'";
                cmd.Connection = conn;//3 cau lenh lien quan den them sua xoa
                cmd.CommandText = sql;//chuoi sql
                cmd.ExecuteNonQuery();//cach thuc hien lenh
                grdphieumuon.Rows.RemoveAt(grdphieumuon.CurrentRow.Index);//xoa dong hien thoi trong o luoi
                sql = "Update TableSach Set TableSach.SoLuong=TableSach.SoLuong+PHIEUMUON.soluong from TableSach, PHIEUMUON  WHERE PHIEUMUON.masach=TableSach.masach and TableSach.masach='" + txtmaTL.Text.Trim() + "';";
                cmd.Connection = conn;//3 cau lenh lien quan den them sua xoa
                cmd.CommandText = sql;//
                cmd.ExecuteNonQuery();

                NapCT();
            }
            conn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void NapCT()
        {
            i = grdphieumuon.CurrentRow.Index;//Nhan gia tri chi so cua bản ghi hiện thời
            txtMAPHIEUMUON.Text = grdphieumuon.Rows[i].Cells["MAPHIEUMUON"].Value.ToString();
            txtmadg.Text = grdphieumuon.Rows[i].Cells["madocgia"].Value.ToString();
            txtmaNV.Text = grdphieumuon.Rows[i].Cells["manhanvien"].Value.ToString();
            txtmaTL.Text = grdphieumuon.Rows[i].Cells["masach"].Value.ToString();
            txtSL.Text = grdphieumuon.Rows[i].Cells["soluong"].Value.ToString();
            TXTNGAYLAP.Text = grdphieumuon.Rows[i].Cells["ngaylapphieu"].Value.ToString();
            TXTNGAYTRA.Text = grdphieumuon.Rows[i].Cells["ngaytra"].Value.ToString();


            //txtNgaymuon.Text= grdphieumuon.Rows[i].Cells["Ngaymuon"].Value.ToString();
            //txtHantra.Text = grdphieumuon.Rows[i].Cells["Hantra"].Value.ToString();
        }

        private void txtmaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from TableNhanVien Where manhanvien = @manhanvien", conn);
            cmd.Parameters.AddWithValue("@manhanvien", txtmaNV.Text);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string tenNV = dr["HoTen"].ToString();
                txttenNV.Text = tenNV;
            }
            conn.Close();
        }

        public Trasach()
        {
            InitializeComponent();
        }

        private void txtmadg_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Close();
            cmd = new SqlCommand("Select * from TableDocGia Where madocgia = @madocgia", conn);
            cmd.Parameters.AddWithValue("@madocgia", txtmadg.Text);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string TENDG = dr["HoTen"].ToString();
                txttenDG.Text = TENDG;

            }
            conn.Close();
        }

        private void txtmaTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from TableSach Where masach = @masach", conn);
            cmd.Parameters.AddWithValue("@masach", txtmaTL.Text);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string tENTAILIEU = dr["TenSach"].ToString();
                txttenTL.Text = tENTAILIEU;

            }


            conn.Close();
        }
    }
}
