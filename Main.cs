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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PHIEUMUON f = new PHIEUMUON();
            f.Show(); 
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trasach f= new Trasach();
            f.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap f = new Dangnhap();
            f.Show();

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMK f =new DoiMK();
            f.Show();

        }

        private void danhMụcSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQLsach f = new FrmQLsach();
            f.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLdocgia f = new QLdocgia();
            f.Show();
        }

        private void tìmKiếmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimDocGia f = new TimDocGia();
            f.Show();
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLmuon f = new QLmuon();
            f.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            fromDocGia f = new fromDocGia();
            f.Show();
        }
    }
}
