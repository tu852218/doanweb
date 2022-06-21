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


namespace ĐỒAn.Net
{
    public partial class Hóa_Đơn : Form
    {
        public Hóa_Đơn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

         
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                String con_str = @"Data Source=DESKTOP-2288VUA\SQLEXPRESS;Initial Catalog=doan_net_TAAAA;Integrated Security=True";
                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();
                string mahd = textBox1.Text;
                string ngayban = textBox3.Text;
                string manv = textBox4.Text;
                string soluong = textBox5.Text;
                string makh = textBox6.Text;
                string tendt = textBox7.Text;
                string diachi = textBox8.Text;
                string sdt = textBox9.Text;
                string gia = textBox10.Text;
                string sql = "insert into hoadon values (@mahd,@ngayban,@manv,@soluong,@makh,@tendt,@diachi,@sdt,@gia) ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
                cmd.Parameters.Add(new SqlParameter("@ngayban", ngayban));
                cmd.Parameters.Add(new SqlParameter("@manv", manv));
                cmd.Parameters.Add(new SqlParameter("@soluong", soluong));
                cmd.Parameters.Add(new SqlParameter("@makh", makh));

                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@gia", gia));




                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from hoadon", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " hoadon");

                dataGridView1.DataSource = da1.Tables[" hoadon"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                String con_str = @"Data Source=DESKTOP-2288VUA\SQLEXPRESS;Initial Catalog=doan_net_TAAAA;Integrated Security=True";
                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();
                string mahd = textBox1.Text;
                string ngayban = textBox3.Text;
                string manv = textBox4.Text;
                string soluong = textBox5.Text;
                string makh = textBox6.Text;
                string tendt = textBox7.Text;
                string diachi = textBox8.Text;
                string sdt = textBox9.Text;
                string gia = textBox10.Text;
                string sql = "DELETE  hoadon where mahd=@mahd ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
                cmd.Parameters.Add(new SqlParameter("@ngayban", ngayban));
                cmd.Parameters.Add(new SqlParameter("@manv", manv));
                cmd.Parameters.Add(new SqlParameter("@soluong", soluong));
                cmd.Parameters.Add(new SqlParameter("@makh", makh));

                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@gia", gia));




                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from hoadon", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " hoadon");

                dataGridView1.DataSource = da1.Tables[" hoadon"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                String con_str = @"Data Source=DESKTOP-2288VUA\SQLEXPRESS;Initial Catalog=doan_net_TAAAA;Integrated Security=True";
                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();
                string mahd = textBox1.Text;
                string ngayban = textBox3.Text;
                string manv = textBox4.Text;
                string soluong = textBox5.Text;
                string makh = textBox6.Text;
                string tendt = textBox7.Text;
                string diachi = textBox8.Text;
                string sdt = textBox9.Text;
                string gia = textBox10.Text;
                string sql = "update   hoadon set  mahd=@mahd ,gia=@gia, soluong=@soluong, tendt=@tendt  where manv=@manv ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
                cmd.Parameters.Add(new SqlParameter("@ngayban", ngayban));
                cmd.Parameters.Add(new SqlParameter("@manv", manv));
                cmd.Parameters.Add(new SqlParameter("@soluong", soluong));
                cmd.Parameters.Add(new SqlParameter("@makh", makh));

                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@gia", gia));




                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select * from hoadon", conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " hoadon");

                dataGridView1.DataSource = da1.Tables[" hoadon"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            try
            {
                String con_str = @"Data Source=DESKTOP-2288VUA\SQLEXPRESS;Initial Catalog=doan_net_TAAAA;Integrated Security=True";
                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();
                string mahd = textBox1.Text;
                string ngayban = textBox3.Text;
                string manv = textBox4.Text;
                string soluong = textBox5.Text;
                string makh = textBox6.Text;
                string tendt = textBox7.Text;
                string diachi = textBox8.Text;
                string sdt = textBox9.Text;
                string gia = textBox10.Text;
                string sql = "SELECT* FROM   hoadon where mahd ='" + textBox2.Text + "'" ;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@mahd", textBox2.Text));
                cmd.Parameters.Add(new SqlParameter("@ngayban", ngayban));
                cmd.Parameters.Add(new SqlParameter("@manv", manv));
                cmd.Parameters.Add(new SqlParameter("@soluong", soluong));
                cmd.Parameters.Add(new SqlParameter("@makh", makh));

                cmd.Parameters.Add(new SqlParameter("@tendt", tendt));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@gia", gia));




                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet da1 = new DataSet();
                da.Fill(da1, " hoadon");

                dataGridView1.DataSource = da1.Tables[" hoadon"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
