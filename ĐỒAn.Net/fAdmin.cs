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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doan_net_TAAAADataSet7.danhmuc' table. You can move, or remove it, as needed.
            //this.danhmucTableAdapter.Fill(this.doan_net_TAAAADataSet7.danhmuc);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String con_str = @"Data Source=DESKTOP-2288VUA\SQLEXPRESS;Initial Catalog=doan_net_TAAAA;Integrated Security=True";
                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();
                string madt = textBox2.Text;
                string tendt = textBox1.Text;

                string sql = "insert into  danhmuc values(@madt,@tendt)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@madt", madt));
                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));


                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from danhmuc ", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " danhmuc ");

                dataGridView1.DataSource = da1.Tables[" danhmuc "];

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
                string madt = textBox2.Text;
                string tendt = textBox1.Text;

                string sql = "DELETE  danhmuc WHERE madt=@madt";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@madt", madt));
                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));


                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from danhmuc ", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " danhmuc ");

                dataGridView1.DataSource = da1.Tables[" danhmuc "];

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
                string madt = textBox2.Text;
                string tendt = textBox1.Text;

                string sql = "update  danhmuc set madt=@madt where tendt=@tendt";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@madt", madt));
                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));


                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from danhmuc ", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " danhmuc ");

                dataGridView1.DataSource = da1.Tables[" danhmuc "];

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
                string madt = textBox2.Text;
                string tendt = textBox1.Text;

                string sql = "select * from  danhmuc  where madt= '" + textBox3.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@madt", textBox3.Text));
                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));


                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " danhmuc ");

                dataGridView1.DataSource = da1.Tables[" danhmuc "];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            
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
            export2Excel(dataGridView1, @"E:\", "xuatfileExcel_DanhMuc");
        }

       
    }
}
   

