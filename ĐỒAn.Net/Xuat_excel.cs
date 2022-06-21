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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace ĐỒAn.Net
{
    public partial class Xuat_excel : Form
    {
        public Xuat_excel()
        {
            InitializeComponent();
        }

        private void Xuat_excel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doan_net_TAAAADataSet3.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.doan_net_TAAAADataSet3.KhachHang);
            // TODO: This line of code loads data into the 'doan_net_TAAAADataSet1.hoadon' table. You can move, or remove it, as needed.
            this.hoadonTableAdapter.Fill(this.doan_net_TAAAADataSet1.hoadon);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;// do rong moi cot la 25
             for(int i=1;i<g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for(int j=0;j<g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;

        }

        private void xuatFileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            export2Excel(HoaDondataGridView1 , @"E:\", "xuatfileExcel_Hoadon");
        }
    }
}
