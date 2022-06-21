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
    public partial class BánHang : Form
    {
        public BánHang()
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
                string madt = textBox1.Text;
                string tendt = textBox2.Text;
                string hotennv = textBox3.Text;
                string ngayban = textBox4.Text;
                string gia = textBox5.Text;
                string tenkhach = textBox6.Text;
               
                string sql = "insert into  banhang values(@madt,@tendt,@hotennv,@ngayban,@gia,@tenkhach)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@madt", madt));
                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));
                cmd.Parameters.Add(new SqlParameter("@hotennv", hotennv));
                cmd.Parameters.Add(new SqlParameter("@ngayban", ngayban));
                cmd.Parameters.Add(new SqlParameter("@gia", gia));
                cmd.Parameters.Add(new SqlParameter("@tenkhach",tenkhach));
             

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from banhang", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " banhang");

                dataGridView1.DataSource = da1.Tables[" banhang"];

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
                string madt = textBox1.Text;
                string tendt = textBox2.Text;
                string hotennv = textBox3.Text;
                string ngayban = textBox4.Text;
                string gia = textBox5.Text;
                string tenkhach = textBox6.Text;

                string sql = "update banhang Set tendt = @tendt , gia=@gia  where madt= @madt";
               

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@madt", madt));
                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));
                cmd.Parameters.Add(new SqlParameter("@hotennv", hotennv));
                cmd.Parameters.Add(new SqlParameter("@ngayban", ngayban));
                cmd.Parameters.Add(new SqlParameter("@gia", gia));
                cmd.Parameters.Add(new SqlParameter("@tenkhach", tenkhach));


                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from banhang", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " banhang");

                dataGridView1.DataSource = da1.Tables[" banhang"];

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
                string madt = textBox1.Text;
                string tendt = textBox2.Text;
                string hotennv = textBox3.Text;
                string ngayban = textBox4.Text;
                string gia = textBox5.Text;
                string tenkhach = textBox6.Text;

                string sql ="delete banhang where madt=@madt";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@madt", madt));
                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));
                cmd.Parameters.Add(new SqlParameter("@hotennv", hotennv));
                cmd.Parameters.Add(new SqlParameter("@ngayban", ngayban));
                cmd.Parameters.Add(new SqlParameter("@gia", gia));
                cmd.Parameters.Add(new SqlParameter("@tenkhach", tenkhach));


                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from banhang", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " banhang");

                dataGridView1.DataSource = da1.Tables[" banhang"];

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
                string madt = textBox1.Text;
                string tendt = textBox2.Text;
                string hotennv = textBox3.Text;
                string ngayban = textBox4.Text;
                string gia = textBox5.Text;
                string tenkhach = textBox6.Text;

                string sql = "delete banhang where madt=@madt";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@madt", madt));
                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));
                cmd.Parameters.Add(new SqlParameter("@hotennv", hotennv));
                cmd.Parameters.Add(new SqlParameter("@ngayban", ngayban));
                cmd.Parameters.Add(new SqlParameter("@gia", gia));
                cmd.Parameters.Add(new SqlParameter("@tenkhach", tenkhach));


                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from banhang", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " banhang");

                dataGridView1.DataSource = da1.Tables[" banhang"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                String con_str = @"Data Source=DESKTOP-2288VUA\SQLEXPRESS;Initial Catalog=doan_net_TAAAA;Integrated Security=True";
                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();
                string madt = textBox1.Text;
                string tendt = textBox2.Text;
                string hotennv = textBox3.Text;
                string ngayban = textBox4.Text;
                string gia = textBox5.Text;
                string tenkhach = textBox6.Text;

                string sql = "select * from banhang where madt ='" + textBox7.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@madt", textBox7.Text));
                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));
                cmd.Parameters.Add(new SqlParameter("@hotennv", hotennv));
                cmd.Parameters.Add(new SqlParameter("@ngayban", ngayban));
                cmd.Parameters.Add(new SqlParameter("@gia", gia));
                cmd.Parameters.Add(new SqlParameter("@tenkhach", tenkhach));


                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from banhang", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " banhang");

                dataGridView1.DataSource = da1.Tables[" banhang"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            export2Excel(dataGridView1, @"E:\", "xuatfileExcelBan_Hang");
        }
    }
}
