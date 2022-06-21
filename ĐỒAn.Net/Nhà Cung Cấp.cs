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
    public partial class Nhà_Cung_Cấp : Form
    {
        public Nhà_Cung_Cấp()
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
                string gianhap = textBox2.Text;
                string tendt = textBox1.Text;
                string ncc = textBox3.Text;
                string giaban = textBox4.Text;
                string madt = textBox6.Text;

                string sql = "insert into ncc values(@tendt,@gianhap,@ncc,@giaban,@madt)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@madt", madt));
                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));
                cmd.Parameters.Add(new SqlParameter("@gianhap", gianhap));
                cmd.Parameters.Add(new SqlParameter("@giaban", giaban));

                cmd.Parameters.Add(new SqlParameter("@ncc", ncc));


                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from ncc ", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " ncc ");

                dataGridView1.DataSource = da1.Tables[" ncc "];

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
                string gianhap = textBox2.Text;
                string tendt = textBox1.Text;
                string ncc = textBox3.Text;
                string giaban = textBox4.Text;
                string madt = textBox6.Text;

                string sql = "delete ncc where tendt=@tendt";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@madt", madt));
                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));
                cmd.Parameters.Add(new SqlParameter("@gianhap", gianhap));
                cmd.Parameters.Add(new SqlParameter("@giaban", giaban));

                cmd.Parameters.Add(new SqlParameter("@ncc", ncc));


                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from ncc ", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " ncc ");

                dataGridView1.DataSource = da1.Tables[" ncc "];

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
                string gianhap = textBox2.Text;
                string tendt = textBox1.Text;
                string ncc = textBox3.Text;
                string giaban = textBox4.Text;
                string madt = textBox6.Text;

                string sql = "UPDATE ncc set madt =@madt, gianhap=@gianhap, giaban=@giaban, ncc=@ncc where tendt=@tendt";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@madt", madt));
                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));
                cmd.Parameters.Add(new SqlParameter("@gianhap", gianhap));
                cmd.Parameters.Add(new SqlParameter("@giaban", giaban));

                cmd.Parameters.Add(new SqlParameter("@ncc", ncc));


                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from ncc ", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " ncc ");

                dataGridView1.DataSource = da1.Tables[" ncc "];

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
                string gianhap = textBox2.Text;
                string tendt = textBox1.Text;
                string ncc = textBox3.Text;
                string giaban = textBox4.Text;
                string madt = textBox6.Text;

                string sql = "select * from ncc where madt= '" + textBox5.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@madt", textBox5.Text));
                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));
                cmd.Parameters.Add(new SqlParameter("@gianhap", gianhap));
                cmd.Parameters.Add(new SqlParameter("@giaban", giaban));

                cmd.Parameters.Add(new SqlParameter("@ncc", ncc));


                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " ncc ");

                dataGridView1.DataSource = da1.Tables[" ncc "];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Nhà_Cung_Cấp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doan_net_TAAAADataSet5.ncc' table. You can move, or remove it, as needed.
            this.nccTableAdapter.Fill(this.doan_net_TAAAADataSet5.ncc);

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
            export2Excel(dataGridView1, @"E:\", "xuatfileExcel_ncc");
        }
    }
}
