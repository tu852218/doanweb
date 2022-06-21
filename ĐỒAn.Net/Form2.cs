using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐỒAn.Net
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhânviên n = new Nhânviên();
            n.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hóa_Đơn hd = new Hóa_Đơn();
            hd.ShowDialog();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BáoCao bc = new BáoCao();
            bc.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThốngKê tk = new ThốngKê();
            tk.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KháchHàng kh = new KháchHàng();
            kh.ShowDialog();
        }

        private void điệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ĐiệnThoại dt = new ĐiệnThoại();
            dt.ShowDialog();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BánHang bh = new BánHang();
            bh.ShowDialog();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhà_Cung_Cấp ncc = new Nhà_Cung_Cấp();
            ncc.ShowDialog();
        }

        private void xuatExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xuat_excel xuat_ = new Xuat_excel();
            xuat_.ShowDialog();
        }
    }
}
