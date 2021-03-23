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
    public partial class MenuKasir : Form
    {
        Koneksi Konn = new Koneksi();
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        private DataSet ds;

        void MunculData()
        {
            SqlConnection Conn = Konn.GetConn();
            Conn.Open();
            cmd = new SqlCommand("select * from TBL_KASIR", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_KASIR");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TBL_KASIR";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }
        public MenuKasir()
        {
            InitializeComponent();
        }

        private void MenuKasir_Load(object sender, EventArgs e)
        {
            MunculData();
            textBox1.Text = "KSR";
            textBox3.Clear();
            textBox4.Text = "@gmail.com";
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "")
            {

                MessageBox.Show("Silahkan Cek Ulang Data Anda");

            }
            else
            {
                SqlConnection Conn = Konn.GetConn();
                Conn.Open();
                cmd = new SqlCommand("insert into TBL_KASIR values ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", Conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Ditambahkan");
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                textBox1.Clear();
                MunculData();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "")
            {

                MessageBox.Show("Silahkan Cek Ulang Data Anda");

            }
            else
            {


                SqlConnection Conn = Konn.GetConn();
                Conn.Open();
                cmd = new SqlCommand("Update TBL_KASIR set Password = '" + textBox2.Text + "', Nama='" + textBox3.Text + "', Email='" + textBox4.Text + "' where Kode_Kasir = '" + textBox1.Text + "'", Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diubah");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                MunculData();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = Konn.GetConn();
            Conn.Open();
            cmd = new SqlCommand("Delete TBL_KASIR where Kode_Kasir = '" + textBox1.Text + "'", Conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Dihapus");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MunculData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuKasir_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection Conn = Konn.GetConn();
                SqlDataReader reader = null;
                {
                    Conn.Open();
                    cmd = new SqlCommand("Select * from TBL_KASIR where Kode_Kasir = '" + textBox1.Text + "'", Conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox2.Text = reader[1].ToString();
                        textBox3.Text = reader[2].ToString();
                        textBox4.Text = reader[3].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Silahkan Cek Ulang Kode Kasir Anda");
                    }
                }
            }
        }
    }
}