﻿using System;
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
    public partial class frmPrvPhieumuon : Form
    {
        public frmPrvPhieumuon(rptPhieumuon rpt)
        {
            InitializeComponent();
            crystalReportViewer2.ReportSource = rpt;
        }

        private void frmPrvPhieumuon_Load(object sender, EventArgs e)
        {

        }
    }
}
