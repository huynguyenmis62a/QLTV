using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmPrv_THSach : Form
    {
        public frmPrv_THSach(rptTonghopSACH rpt)
        {
            InitializeComponent();
            crystalReportViewer3.ReportSource = rpt;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
