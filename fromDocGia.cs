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
    public partial class fromDocGia : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable TTuoi = new DataTable();
        DataTable TableDocGia = new DataTable();
        string flag = "", sql, constr;
        public fromDocGia()
        {
            InitializeComponent();
            label12.Text = "";

            RemoveXButton(this.Handle);
        }
        int RemoveXButton(IntPtr iHWND)
        {
            int iSysMenu;
            iSysMenu = GetSystemMenu(iHWND, 0);
            return RemoveMenu(iSysMenu, SC_CLOSE, MF_BYCOMMAND);
        }
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern int GetSystemMenu(IntPtr hwnd, int bRevert);
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern int RemoveMenu(int hMenu, int nPosition, int wFlags);
        public const int SC_CLOSE = 61536;
        public const int MF_BYCOMMAND = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtmadocgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã độc giả");
                return;
            }
            if (txtHoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Họ và tên");
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return;
            }
            if (txtCMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số CMND");

            }
            if (txtHoKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Hộ Khẩu Thường trú");
                return;
            }
            if (txtDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đơn vị");
                return;
            }

            if (KiemTraTuoi() == 1)
            {
                string GioiTinh = checkGioiTinh.Checked == true ? "Nu" : "Nam";
                string NgaySinh = XuLiNgay(txtNgaySinh.Value.ToString());
                string NgayLapThe = XuLiNgay(txtNgayLapThe.Value.ToString());
                txtEmail.Text = "Không có";
                txtDienThoai.Text = "000000";



                if (flag == "")
                {

                    string sql1 = "INSERT INTO TableDocGia VALUES ('" + txtmadocgia.Text.Trim() +
                                                                  "',N'" + txtHoten.Text.Trim() +
                                                                  "',N'" + txtDiaChi.Text.Trim() +
                                                                  "','" + txtCMND.Text.Trim() +
                                                                  "',N'" + txtHoKhau.Text.Trim() +
                                                                  "',N'" + txtDonVi.Text.Trim() +
                                                                  "','" + NgaySinh +
                                                                  "','" + txtEmail.Text.Trim() +
                                                                  "','" + txtDienThoai.Text.Trim() +
                                                                  "',N'" + GioiTinh +
                                                                  "','" + txtMaNhanVien.Text.Trim() +
                                                                  "','" + NgayLapThe + "')";
                    da = new SqlDataAdapter(sql1, conn);
                    cmd.Connection = conn;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                    label12.Text = "Đã thêm mới thành công!!";

                }
                else
                {

                    string sql1 = "UPDATE TableDocGia SET HoTen=N'" + txtHoten.Text.Trim() +
                                           "',DiaChi='" + txtDiaChi.Text.Trim() +
                                           "',CMND='" + txtCMND.Text.Trim() +
                                           "',HKTT='" + txtHoKhau.Text.Trim() +
                                           "',DonViCongTac='" + txtDonVi.Text.Trim() +
                                           "',NgaySinh='" + NgaySinh +
                                           "',Email='" + txtEmail.Text.Trim() +
                                           "',DienThoai='" + txtDienThoai.Text.Trim() +
                                           "',GioiTinh='" + GioiTinh +
                                           "',manhanvien='" + txtMaNhanVien.Text.Trim() +
                                           "',Ngaylapthe='" + NgayLapThe +
                                           "' WHERE madocgia='" + flag + "';";
                    da = new SqlDataAdapter(sql1, conn);
                    cmd.Connection = conn;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();


                    flag = "";
                    label12.Text = "Đã cập nhật thành công!!";




                }
                string sql = "SELECT madocgia,HoTen,DiaChi,GioiTinh,manhanvien FROM TableDocGia";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                Load_DS_DocGia_ListView(dt);



            }
        }
    

        private void fromDocGia_Load(object sender, EventArgs e)
        {
            try
            {
                constr = @"Data Source=ADMIN\PKH;Initial Catalog=PTUD;Integrated Security=True";
                conn.ConnectionString = constr;
                conn.Open();


                sql = "SELECT madocgia,HoTen,DiaChi,GioiTinh,manhanvien FROM TableDocGia";
                da = new SqlDataAdapter(sql, conn);
                TableDocGia.Clear();
                da.Fill(TableDocGia);
                Load_DS_DocGia_ListView(TableDocGia);



            }
            catch (Exception err)
            {
                MessageBox.Show(" Có lỗi thi hành" + err.Message);
                //Form1.DaMo[0] = 1;
            }
        }

        private void lsviewDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                int i = lsviewDG.FocusedItem.Index;
                if (i < 0)
                    return;

                flag = lsviewDG.Items[i].Text; //chuyen madocgia vao flag de tien hanh Update neu co thay doi;




                string madocgia = lsviewDG.Items[i].Text;


                string TruyVan = "SELECT * FROM TableDocGia Where madocgia='" + madocgia + "'";
                da = new SqlDataAdapter(TruyVan, conn);
                dt.Clear();
                da.Fill(dt);



                txtmadocgia.Text = dt.Rows[0][0].ToString();
                txtHoten.Text = dt.Rows[0][1].ToString();
                txtDiaChi.Text = dt.Rows[0][2].ToString();
                txtCMND.Text = dt.Rows[0][3].ToString();
                txtHoKhau.Text = dt.Rows[0][4].ToString();
                txtDonVi.Text = dt.Rows[0][5].ToString();

                txtNgaySinh.Value = DateTime.Parse(dt.Rows[0][6].ToString());

                txtEmail.Text = dt.Rows[0][7].ToString();
                txtDienThoai.Text = '0' + dt.Rows[0][8].ToString();

                if (dt.Rows[0][9].ToString().ToLower() == "nu")
                    checkGioiTinh.Checked = true;
                else checkGioiTinh.Checked = false;

                txtMaNhanVien.Text = dt.Rows[0][10].ToString();

                txtNgayLapThe.Value = DateTime.Parse(dt.Rows[0][11].ToString());



            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi thi hành:" + err.Message);


            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            constr = @"Data Source=ADMIN\PKH;Initial Catalog=PTUD;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();


            string SqlDelete;
            SqlDelete = "DELETE FROM TableDocGia WHERE madocgia='" + flag + "'";
            cmd.Connection = conn;//3 cau lenh lien quan den them sua xoa
            cmd.CommandText = SqlDelete;//chuoi sql
            cmd.ExecuteNonQuery();
            Load_DS_DocGia_ListView(TableDocGia);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = txtDienThoai.Text = txtDonVi.Text = txtEmail.Text = txtHoKhau.Text = txtHoten.Text = txtmadocgia.Text = " ";
        }

        private void lsviewDG_DoubleClick(object sender, EventArgs e)
        {
            int i = lsviewDG.FocusedItem.Index;
            string madocgia = lsviewDG.Items[i].Text;


            string TruyVan = "SELECT * FROM TableDocGia Where madocgia='" + madocgia + "'";
            da = new SqlDataAdapter(TruyVan, conn);
            dt.Clear();
            da.Fill(dt);
        }

        private void rcheckDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rcheckDate.Checked == true) datetimeNgayLapThe.Visible = true;
            else datetimeNgayLapThe.Visible = false;
        }

        private void rcheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rcheckAll.Checked == true)
            {
                string TruyVan = "SELECT madocgia,HoTen,DiaChi,GioiTinh,manhanvien FROM TableDocGia";
                da = new SqlDataAdapter(TruyVan, conn);
                TableDocGia.Clear();
                da.Fill(TableDocGia);

                Load_DS_DocGia_ListView(TableDocGia);
            }
        }
        public string XuLiNgay(string a)
        {
            char[] charSeparators = new char[] { ' ' };
            string[] result;
            result = a.Split(charSeparators, StringSplitOptions.None);
            return result[0];
        }
        private int KiemTraTuoi()
        {


            string TruyVan = "Select TuoiMax,TuoiMin from ThamSo";
            da = new SqlDataAdapter(TruyVan, conn);
            TTuoi.Clear();
            da.Fill(TTuoi);

            int tuoi = Int16.Parse(DateTime.Now.Year.ToString()) - Int16.Parse(txtNgaySinh.Value.Year.ToString());
            int TuoiMax = Int16.Parse(TTuoi.Rows[0][0].ToString());
            int TuoiMin = Int16.Parse(TTuoi.Rows[0][1].ToString());
            if (tuoi <= TuoiMax && tuoi >= TuoiMin)
            {

                return 1;

            }
            else
            {
                MessageBox.Show("Người này chưa đủ tuổi làm thẻ!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return 0;
            }


        }

        private void Load_DS_DocGia_ListView(DataTable TableDocGia)
        {
            ListViewItem item;
            lsviewDG.Items.Clear();

            for (int i = 0; i < TableDocGia.Rows.Count; i++)
            {

                item = lsviewDG.Items.Add(TableDocGia.Rows[i][0].ToString());
                for (int j = 1; j < TableDocGia.Columns.Count; j++)
                    item.SubItems.Add(TableDocGia.Rows[i][j].ToString());
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
