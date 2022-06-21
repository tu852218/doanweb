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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try { 
            String con_str = @"Data Source=DESKTOP-2288VUA\SQLEXPRESS;Initial Catalog=DoAn.Net;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con_str);
            
                conn.Open();
                string ten = textBox1.Text;
                string mk = textBox2.Text;
                string sql = "select *from Nguoidung where ten=@ten and matkhau=@mk";
                 SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@mk", mk));


                int n = cmd.ExecuteNonQuery();
                if (n == 0)
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Form FORM11 = new Form2();
                    FORM11.Show();

                   


                }
                
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
