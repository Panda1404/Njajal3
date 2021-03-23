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
    public partial class MenuBarang : Form
    {
        Koneksi Konn = new Koneksi();
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        private DataSet ds;


        void List()
        {
            comboBox1.Items.Add("PCS");
            comboBox1.Items.Add("RENCENG");
            comboBox1.Items.Add("BOX");
            comboBox1.Items.Add("PACK");
        }
        void MunculData()
        {
            SqlConnection Conn = Konn.GetConn();
            Conn.Open();
            cmd = new SqlCommand("select * from TBL_BARANG", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_BARANG");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TBL_BARANG";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();



        }
        public MenuBarang()
        {
            InitializeComponent();
        }

        private void MenuBarang_Load(object sender, EventArgs e)
        {
            MunculData();
            List();
            textBox1.Text = "BRG";
            textBox3.Clear();
            textBox4.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || comboBox1.Text == "")
            {

                MessageBox.Show("Silahkan Cek Ulang Data Anda");

            }
            else
            {
                SqlConnection Conn = Konn.GetConn();
                Conn.Open();
                cmd = new SqlCommand("insert into TBL_BARANG values ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "', '" + comboBox1.Text + "')", Conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Ditambahkan");
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.Text = "";
                textBox1.Clear();
                MunculData();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || comboBox1.Text == "")
            {

                MessageBox.Show("Silahkan Cek Ulang Data Anda");

            }
            else
            {


                SqlConnection Conn = Konn.GetConn();
                Conn.Open();
                cmd = new SqlCommand("Update TBL_BARANG set NamaBarang = '" + textBox2.Text + "', JumlahBarang='" + textBox3.Text + "', HargaBarang='" + textBox4.Text + "', Satuan='" + comboBox1.Text + "' where KodeBarang = '" + textBox1.Text + "'", Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diubah");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.Text = "";
                MunculData();


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection Conn = Konn.GetConn();
            Conn.Open();
            cmd = new SqlCommand("Delete TBL_BARANG where KodeBarang = '" + textBox1.Text + "'", Conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Dihapus");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
            MunculData();



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection Conn = Konn.GetConn();
                SqlDataReader reader = null;
                {
                    Conn.Open();
                    cmd = new SqlCommand("Select * from TBL_BARANG where KodeBarang = '" + textBox1.Text + "'", Conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox2.Text = reader[1].ToString();
                        textBox3.Text = reader[2].ToString();
                        textBox4.Text = reader[3].ToString();
                        comboBox1.Text = reader[4].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Silahkan Cek Ulang Kode Barang Anda");
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}