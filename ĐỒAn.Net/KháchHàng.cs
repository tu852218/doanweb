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
    public partial class KháchHàng : Form
    {
        public KháchHàng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String con_str = @"Data Source=DESKTOP-2288VUA\SQLEXPRESS;Initial Catalog=doan_net_TAAAA;Integrated Security=True";
                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();
                string makh = textBox1.Text;
                string tenKh = textBox2.Text;
                string sdt = textBox4.Text;
                string diachi = textBox3.Text;
                string sql = "insert into  KhachHang values(@makh,@tenkh,@sdt,@diachi)";
               
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@makh", makh));
                cmd.Parameters.Add(new SqlParameter("@tenkh", tenKh));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang",conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, "KhachHang");

                dataGridView1.DataSource = da1.Tables["Khachhang"];
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String con_str = @"Data Source=DESKTOP-2288VUA\SQLEXPRESS;Initial Catalog=doan_net_TAAAA;Integrated Security=True";
                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();
                string makh = textBox1.Text;
                string tenKh = textBox2.Text;
                string sdt = textBox4.Text;
                string diachi = textBox3.Text;
                string sql = "update KhachHang Set tenkh= @tenkh ,sdt=@sdt, diachi= @diachi  where makh = @makh ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@makh", makh));
                cmd.Parameters.Add(new SqlParameter("@tenkh", tenKh));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, "KhachHang");

                dataGridView1.DataSource = da1.Tables["Khachhang"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String con_str = @"Data Source=DESKTOP-2288VUA\SQLEXPRESS;Initial Catalog=doan_net_TAAAA;Integrated Security=True";
                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();
                string makh = textBox1.Text;
                string tenKh = textBox2.Text;
                string sdt = textBox4.Text;
                string diachi = textBox3.Text;
                string sql = "delete from KhachHang   WHERE makh= @makh ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@makh", makh));
                cmd.Parameters.Add(new SqlParameter("@tenkh", tenKh));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, "KhachHang");

                dataGridView1.DataSource = da1.Tables["Khachhang"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String con_str = @"Data Source=DESKTOP-2288VUA\SQLEXPRESS;Initial Catalog=doan_net_TAAAA;Integrated Security=True";
                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();
                string makh = textBox1.Text;
                string tenKh = textBox2.Text;
                string sdt = textBox4.Text;
                string diachi = textBox3.Text;
                string sql = "select * from KhachHang where tenkh ='" + textBox5.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@makh", makh));
                cmd.Parameters.Add(new SqlParameter("@tenkh", textBox5.Text));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataSet da1 = new DataSet();
                da.Fill(da1, "KhachHang");

                dataGridView1.DataSource = da1.Tables["KhachHang"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KháchHàng_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doan_net_TAAAADataSet2.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.doan_net_TAAAADataSet2.KhachHang);

        }
        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;// do rong moi cot la 25
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
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
        private void button5_Click(object sender, EventArgs e)
        {
            export2Excel(dataGridView1, @"E:\", "xuatfileExcel_KhachHang");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
