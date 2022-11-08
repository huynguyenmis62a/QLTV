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
    public partial class QLNV : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-UFK0TTCP\SQLEXPRESS;Initial Catalog=qltv;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from TableNhanVien ";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }
        public QLNV()
        {
            InitializeComponent();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tb_manv.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_hoten.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_diachi.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_socmnd.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_hktt.Text = dgv.Rows[i].Cells[4].Value.ToString();
            tb_ns.Text = dgv.Rows[i].Cells[5].Value.ToString();
            tb_email.Text = dgv.Rows[i].Cells[6].Value.ToString();
            cb_chucvu.Text = dgv.Rows[i].Cells[7].Value.ToString();
            tb_dienthoai.Text = dgv.Rows[i].Cells[8].Value.ToString();
            cb_gioitinh.Text = dgv.Rows[i].Cells[9].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into TableNhanVien values ('" + tb_manv.Text + "','" + tb_hoten.Text + "','" + tb_diachi.Text + "','" + tb_socmnd.Text + "','" + tb_hktt.Text + "','" + tb_ns.Text + "','" + tb_email.Text + "','" + cb_chucvu.Text + "','" + tb_dienthoai.Text + "','" + cb_gioitinh.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void bt__sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update TableNhanVien set ('" + tb_manv.Text + "','" + tb_hoten.Text + "','" + tb_diachi.Text + "','" + tb_socmnd.Text + "','" + tb_hktt.Text + "','" + tb_ns.Text + "','" + tb_email.Text + "','" + cb_chucvu.Text + "','" + tb_dienthoai.Text + "','" + cb_gioitinh.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from TableNhanVien where manhanvien= '" + tb_manv.Text + "'";
            command.ExecuteNonQuery();
            loaddata();

        }
    }
}
