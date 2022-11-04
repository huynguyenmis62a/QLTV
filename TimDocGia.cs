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
    public partial class TimDocGia : Form
    {

        public int flagTimTheoMa = 0;
        public int flagTimTheoTen = 0;

        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable DS_DocGia = new DataTable();
        string constr;
        public TimDocGia()
        {
            InitializeComponent();
            txtHoVATen.Enabled = false;
            txtMaDocGia.Enabled = false;
            dateNgayLapThe.Enabled = false;
            txtNhanVienLap.Enabled = false;
            this.Height = 363;
            label1.Text = "";
            label2.Text = "";
        }
        public string XuLiNgay(string a)
        {
            char[] charSeparators = new char[] { ' ' };
            string[] result;
            result = a.Split(charSeparators, StringSplitOptions.None);
            return result[0];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            listboxTimThay.Items.Clear();
            listView1.Items.Clear();
            label1.Text = "";
            int n = 0;
            if (flagTimTheoMa == 1)
            {
                string madocgia = txtMaDocGia.Text.Trim().ToString();
                for (int i = 0; i < DS_DocGia.Rows.Count; i++)
                {
                    if (string.Equals(madocgia, DS_DocGia.Rows[i][0].ToString().Trim()) == true)
                    {
                        n = 1;
                        for (int k = 0; k < DS_DocGia.Columns.Count; k++)
                        {

                            listboxTimThay.Items.Add(DS_DocGia.Rows[i][k].ToString());
                            label1.Text = "";
                        }

                    }


                }


            }
            if (flagTimTheoTen == 1)
            {
                string tendocgia = txtHoVATen.Text.Trim().ToLower().ToString();
                for (int i = 0; i < DS_DocGia.Rows.Count; i++)
                {
                    if (string.Equals(tendocgia, DS_DocGia.Rows[i][1].ToString().Trim().ToLower()) == true)
                    {
                        n = 1;
                        for (int k = 0; k < DS_DocGia.Columns.Count; k++)
                        {

                            listboxTimThay.Items.Add(DS_DocGia.Rows[i][k].ToString());
                            label1.Text = "";
                        }


                    }
                }

            }
            if (flagNgayLap == 1)
            {
                string ngaylapthe = XuLiNgay(dateNgayLapThe.Value.ToString());
                for (int i = 0; i < DS_DocGia.Rows.Count; i++)
                {
                    //if (DateTime.Equals(DateTime.Parse(ngaylapthe), DateTime.Parse(XuLiNgay(DS_DocGia.Rows[i][11].ToString()))) == true)
                    {
                        ListViewItem item;
                        item = listView1.Items.Add(DS_DocGia.Rows[i][0].ToString());
                        for (int k = 1; k < DS_DocGia.Columns.Count; k++)
                            item.SubItems.Add(DS_DocGia.Rows[i][k].ToString());
                        label1.Text = "";
                    }
                }
            }
            if (flagTimTheoMaNV == 1)
            {
                string manhanvien = txtNhanVienLap.Text.ToString();
                for (int i = 0; i < DS_DocGia.Rows.Count; i++)
                {
                    if (string.Equals(manhanvien, DS_DocGia.Rows[i][10].ToString()) == true)
                    {
                        ListViewItem item;
                        item = listView1.Items.Add(DS_DocGia.Rows[i][0].ToString());
                        for (int k = 1; k < DS_DocGia.Columns.Count; k++)
                            item.SubItems.Add(DS_DocGia.Rows[i][k].ToString());
                        label1.Text = "";
                    }
                }
            }
            if (n == 0) label1.Text = "Không Tìm Thấy Độc Giả Này !!!";

        }
        public int morong = 0;

        private void TimDocGia_Load(object sender, EventArgs e)
        {

            try
            {
                constr = @"Data Source=ADMIN\PKH;Initial Catalog=PTUD;Integrated Security=True";
                conn.ConnectionString = constr;
                conn.Open();
                //Main.DaMo[11] = 1;
                string TruyVan = "Select * From TableDocGia";

                da = new SqlDataAdapter(TruyVan, conn);
                DS_DocGia.Clear();
                da.Fill(DS_DocGia);

            }
            catch (Exception err)
            {
                MessageBox.Show("có lỗi thi hành:" + err.Message);
            }
        }

        private void rcheckMadocgia_CheckedChanged(object sender, EventArgs e)
        {
            if (rcheckMadocgia.Checked == true)
            {
                txtMaDocGia.Enabled = true;
                flagTimTheoMa = 1;


            }
            else
            {
                txtMaDocGia.Enabled = false;
                flagTimTheoMa = 0;
            }
        }

        private void rcheckHoten_CheckedChanged(object sender, EventArgs e)
        {
            if (rcheckHoten.Checked == true)
            {
                txtHoVATen.Enabled = true;
                flagTimTheoTen = 1;
            }
            else
            {
                txtHoVATen.Enabled = false;
                flagTimTheoTen = 0;

            }
        }
        public int flagNgayLap = 0;
        public int flagTimTheoMaNV = 0;

        private void rcheckNgayLapThe_CheckedChanged(object sender, EventArgs e)
        {
            if (rcheckNgayLapThe.Checked == true)
            {
                dateNgayLapThe.Enabled = true;
                flagNgayLap = 1;
                label2.Text = "Nhấn Mở Rộng Để Hiện Thị Kết Quả";

            }
            else
            {
                dateNgayLapThe.Enabled = false;
                flagNgayLap = 0;
                label2.Text = "";


            }
        }

        private void rcheckNhanVien_CheckedChanged(object sender, EventArgs e)
        {

            if (rcheckNhanVien.Checked == true)
            {
                txtNhanVienLap.Enabled = true;
                flagTimTheoMaNV = 1;
                label2.Text = "Nhấn Mở Rộng Để Hiện Thị Kết Quả";

            }
            else
            {
                txtNhanVienLap.Enabled = false;
                flagTimTheoMaNV = 0;
                label2.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (morong == 0)
            {
                this.Height = 484;
                morong = 1;
            }
            else if (morong == 1)
            {
                this.Height = 363;
                morong = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
