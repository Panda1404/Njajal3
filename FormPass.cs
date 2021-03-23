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

namespace AppKasir
{
    public partial class FormPass : Form
    {
        Koneksi Konn = new Koneksi();
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        private DataSet ds;

        public FormPass()
        {
            InitializeComponent();
        }

        private void FormPass_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == textBox3.Text)
            {
                SqlConnection Conn = Konn.GetConn();
                Conn.Open();
                cmd = new SqlCommand("Update TBL_KASIR set Password = '" + textBox3.Text + "' where Kode_Kasir = '" + textBox1.Text + "'", Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Berhasil Diubah");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Silahkan Konfirmasi Ulang Password Baru Anda");
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar (Keys.Enter))
                {
                SqlConnection Conn = Konn.GetConn();
                Conn.Open();
                cmd = new SqlCommand("Select * from TBL_KASIR where Kode_Kasir ='" + textBox1.Text + "'", Conn);
                cmd.ExecuteNonQuery();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    textBox2.Text = rd[1].ToString();
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan");
                }
            }
        }
    }
}
