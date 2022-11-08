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
    public partial class THphieumuon : Form
    {

        SqlDataAdapter da = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection();
        DataTable dt = new DataTable();
        string sql, constr;
        public THphieumuon()
        {
            InitializeComponent();
        }

        private void THphieumuon_Load(object sender, EventArgs e)
        {
            constr = @"Data Source=ADMIN\PKH;Initial Catalog=PTUD;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " select PHIEUMUON.MAPHIEUMUON, PHIEUMUON.madocgia, TableDocGia.Hoten from PHIEUMUON, TableDocGia where PHIEUMUON.madocgia=TableDocGia.madocgia ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
        }
    }
}
