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
    public partial class Nhânviên : Form
    {
        public Nhânviên()
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
                string manv = textBox1.Text;
                string hotennv = textBox2.Text;
                string gt = textBox3.Text;
                string chucvu = textBox4.Text;
                string SDT = textBox5.Text;
                string diachi = textBox6.Text;
                string cmnd= textBox7.Text;
                string hsl = textBox8.Text;
                string sql = "insert into  nhanvien values(@manv,@hotennv,@gt,@cmnd,@diachi,@chucvu,@hsl,@sdt)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@manv", manv));
                cmd.Parameters.Add(new SqlParameter("@hotennv", hotennv));
                cmd.Parameters.Add(new SqlParameter("@gt", gt));
                cmd.Parameters.Add(new SqlParameter("@chucvu", chucvu));
                cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
                cmd.Parameters.Add(new SqlParameter("@sdt", SDT));
                cmd.Parameters.Add(new SqlParameter("@hsl", hsl));

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from nhanvien", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, "nhanvien");

                dataGridView1.DataSource = da1.Tables["nhanvien"];

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
                string manv = textBox1.Text;
                string hotennv = textBox2.Text;
                string gt = textBox3.Text;
                string chucvu = textBox4.Text;
                string SDT = textBox5.Text;
                string diachi = textBox6.Text;
                string cmnd = textBox7.Text;
                string hsl = textBox8.Text;
                string sql = "delete  nhanvien where manv=@manv";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@manv", manv));
                cmd.Parameters.Add(new SqlParameter("@hotennv", hotennv));
                cmd.Parameters.Add(new SqlParameter("@gt", gt));
                cmd.Parameters.Add(new SqlParameter("@chucvu", chucvu));
                cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
                cmd.Parameters.Add(new SqlParameter("@sdt", SDT));
                cmd.Parameters.Add(new SqlParameter("@hsl", hsl));

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from nhanvien", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, "nhanvien");

                dataGridView1.DataSource = da1.Tables["nhanvien"];

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
                string manv = textBox1.Text;
                string hotennv = textBox2.Text;
                string gt = textBox3.Text;
                string chucvu = textBox4.Text;
                string SDT = textBox5.Text;
                string diachi = textBox6.Text;
                string cmnd = textBox7.Text;
                string hsl = textBox8.Text;
                string sql = "update nhanvien Set hotennv= @hotennv ,gt=@gt,diachi=@diachi,chucvu=@chucvu where manv = @manv";


                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@manv", manv));
                cmd.Parameters.Add(new SqlParameter("@hotennv", hotennv));
                cmd.Parameters.Add(new SqlParameter("@gt", gt));
                cmd.Parameters.Add(new SqlParameter("@chucvu", chucvu));
                cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
                cmd.Parameters.Add(new SqlParameter("@sdt", SDT));
                cmd.Parameters.Add(new SqlParameter("@hsl", hsl));

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from nhanvien", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, "nhanvien");

                dataGridView1.DataSource = da1.Tables["nhanvien"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String con_str = @"Data Source=DESKTOP-2288VUA\SQLEXPRESS;Initial Catalog=doan_net_TAAAA;Integrated Security=True";
                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();
                string manv = textBox1.Text;
                string hotennv = textBox2.Text;
                string gt = textBox3.Text;
                string chucvu = textBox4.Text;
                string SDT = textBox5.Text;
                string diachi = textBox6.Text;
                string cmnd = textBox7.Text;
                string hsl = textBox8.Text;
                string sql = "select * from nhanvien where manv ='"+ textBox9.Text + "'";


                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@manv", textBox9.Text));
                cmd.Parameters.Add(new SqlParameter("@hotennv", hotennv));
                cmd.Parameters.Add(new SqlParameter("@gt", gt));
                cmd.Parameters.Add(new SqlParameter("@chucvu", chucvu));
                cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
                cmd.Parameters.Add(new SqlParameter("@sdt", SDT));
                cmd.Parameters.Add(new SqlParameter("@hsl", hsl));

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                
                DataSet da1 = new DataSet();
                da.Fill(da1, "nhanvien");

                dataGridView1.DataSource = da1.Tables["nhanvien"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
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
            export2Excel(dataGridView1, @"E:\", "xuatfileExcel_NhanVien");
        }

        private void Nhânviên_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doan_net_TAAAADataSet4.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.doan_net_TAAAADataSet4.nhanvien);

        }
    }

}