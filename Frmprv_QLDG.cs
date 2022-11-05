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
    public partial class Frmprv_QLDG : Form
    {
        public Frmprv_QLDG(RptQLDG rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void Frmprv_QLDG_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
