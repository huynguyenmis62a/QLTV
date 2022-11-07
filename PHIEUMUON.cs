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
    public partial class PHIEUMUON : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataReader dr, dr1,dr2;
        string sql, sql1,sql2, constr;
        

        private void txttenDG_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            // if (Kiemtramasach() == 1 && KiemTraDaMuonSachChua() == 1)
            // {
            try { 
                sql = "insert into PHIEUMUON (MAPHIEUMUON,madocgia,manhanvien,masach,ngaylapphieu,ngaytra,soluong)" +
                " values ('" + txtMAPHIEUMUON.Text + "','" + txtmadg.Text + "','" + txtmaNV.Text + "','"+txtmaTL.Text+"','" + TXTNGAYLAP.Text + "','" + TXTNGAYTRA.Text + "','" + txtSL.Text + "')";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            sql = "Update TableSach Set TableSach.SoLuong=TableSach.SoLuong-PHIEUMUON.soluong from TableSach, PHIEUMUON  WHERE PHIEUMUON.masach=TableSach.masach and TableSach.masach='" + txtmaTL.Text.Trim() + "';";
            cmd.Connection = conn;//3 cau lenh lien quan den them sua xoa
            cmd.CommandText = sql;//
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tạo phiếu mượn thành công!", " Thông báo ");
                //Nạp dữ liệu vào ô luới

            
            i = grdphieumuon.Rows.Count - 1;
            grdphieumuon.Rows[i].Cells["MAPHIEUMUON"].Value = txtMAPHIEUMUON.Text;
            grdphieumuon.Rows[i].Cells["madocgia"].Value = txtmadg.Text;
            grdphieumuon.Rows[i].Cells["manhanvien"].Value = txtmaNV.Text;
            grdphieumuon.Rows[i].Cells["soluong"].Value = txtSL.Text;
            
             grdphieumuon.Rows[i].Cells["masach"].Value= txtmaTL.Text;
             grdphieumuon.Rows[i].Cells["ngaylapphieu"].Value = TXTNGAYLAP.Text;
           grdphieumuon.Rows[i].Cells["ngaytra"].Value  =    TXTNGAYTRA.Text;

            grdphieumuon.Refresh();
            conn.Close();
            }catch(Exception err)
            {
                MessageBox.Show(" Có lỗi thi hành :" + err.Message);
            }

            // }
            // else
            //{

            //     return;
            //  }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void grdphieumuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            rptPhieumuon rpt = new rptPhieumuon();
            DataTable rptData = new DataTable();//Bảng mới để truyền chiếu dữ liệu vào đấy, lấy từ sql vào đây
            //tạo câu Sql
            sql = " Select m.masach,s.TenSach, m.soluong,m.madocgia,m.ngaylapphieu,m.ngaytra,m.manhanvien from PHIEUMUON m, TableSach s where m.masach=s.masach";
               // "where " +

                //"MAPHIEUMUON='" + txtMAPHIEUMUON.Text + "'";//bảng mẫu thiết kế như nào thì gọi ra đúng như vậy
            // comGtri chính là chứa cái mã nhóm
            da = new SqlDataAdapter(sql, conn);
            rptData.Clear();
            da.Fill(rptData);// Lấy dữ liệu và đổ vào rptData

            //Gán
            rpt.SetDataSource(rptData);
            //chuyền dữ liệu từ ngooài vào
           // rpt.DataDefinition.FormulaFields["MAPHIEUMUON"].Text//.Text= "'" + txtMAPHIEUMUON.Text + "'";
            //rpt.DataDefinition.FormulaFields["HoTen"].Text = "'" + txttenDG.Text + "'";
            //rpt.DataDefinition.FormulaFields["madocgia"].Text = "'" + txtmadg.Text + "'";
            //rpt.DataDefinition.FormulaFields["manhanvien"].Text = "'" + txtmaNV.Text + "'";
            //rpt.DataDefinition.FormulaFields["ngaylapphieu"].Text = "'" + TXTNGAYLAP.Text + "'";
            //rpt.DataDefinition.FormulaFields["ngaytra"].Text = "'" + TXTNGAYTRA.Text + "'";
            // giúp mình chuyền tên nhóm nằm ở comgtri vào formula field tennhom
            frmPrvPhieumuon f = new frmPrvPhieumuon(rpt);
            f.Show();
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

        int i;

        

        public PHIEUMUON()
        {
            InitializeComponent();
        }

        private void PHIEUMUON_Load(object sender, EventArgs e)
        {
            try
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

            }catch(Exception err)
            {
                MessageBox.Show(" Có lỗi thi hành :" + err.Message);
            }
        }

        //thử nghiệm từ đây
        /*
         int Kiemtramasach()
        {
            sql = "SELECT masach,SoLuong From TableSach where masach='" + txtmaTL.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);     

            if (dt.Rows[0][1].ToString() == "1")
            {
                MessageBox.Show("Xin lỗi ! Sách chỉ còn 1 cuốn nên không thể cho mượn");

                return 0;
            }


            return 1;

        }
        int KiemTraDaMuonSachChua()
         {
             sql = "SELECT m.masophieumuon,m.madocgia,d.HoTen as HoTenDocGia  ,s.masach,s.TenSach,m.manhanvien ," +
                 "s.NXB  ,m.NgayMuon,m.NgayTra FROM TableMuonTraSach m,TableNhanVien n,TableSach s,TableDocGia d where m.madocgia = d.madocgia and m.manhanvien = n.manhanvien and m.masach = s.masach ";
             da = new SqlDataAdapter(sql, conn);
             dt.Clear();
             da.Fill(dt);

             string a = txtmadg.Text.ToString();
             string TruyVan = "Select ChoPhepMuon from ThamSo";
             da = new SqlDataAdapter(TruyVan, conn);
             dt.Clear();
             da.Fill(dt);


             String x = (dt.Rows[0][2].ToString());
             int chomuon = Int32.Parse(x);
             int dem = 0;
             for (int i = 0; i < dt.Rows.Count; i++)
             {
                 if ((dt.Rows[i][1].ToString()).Equals(a))
                 {
                     dem++;
                 }
             }
             if (dem == chomuon)
             {
                 MessageBox.Show("Độc Giả này đã mượn quá quy định của thư viện");
                 return 0;
             }
             else return 1;


         }*/







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


    }
}
