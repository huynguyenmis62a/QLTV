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
using System.Configuration;

namespace QLTV
{
    public partial class Dangnhap : Form
        
    {
        public static string UserName = "";
        
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        string constr;
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            constr = @"Data Source=ADMIN\PKH;Initial Catalog=QLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@UserName", txtuser.Text);
            cmd.Parameters.AddWithValue("@Password", txtpass.Text);
            
            object kq = cmd.ExecuteScalar();
            UserName = txtuser.Text;
            cmd.Connection = conn;
            int code = Convert.ToInt32(kq);
         
            if (code == 0)
            {
                MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main f = new Main();
                f.Show();
            }
            else if (code == 1)
            {
                MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main f = new Main();
                f.Show();
            }

            else
            
             if (code == 2)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpass.Text = "";
                txtuser.Text = "";
                txtuser.Focus();
                     
                 MessageBox.Show(" Bạn đã đăng nhập sai quá 3 lần! Chương trình kết thúc");
                 Application.Exit();
                    
            }
            
            else 
            {
                
                MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpass.Text = "";
                txtuser.Text = "";
                txtuser.Focus();


            }
         conn.Close();
            }
          
        
        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtpass_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtpass.PasswordChar = (char)0;
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}

