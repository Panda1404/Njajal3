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
    public partial class Form_Login : Form
    {
        Koneksi Konn = new Koneksi();
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        private DataSet ds;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "KSR001";
            textBox2.Text = "12345";
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = Konn.GetConn();
            SqlDataReader reader = null;
            {
                Conn.Open();
                cmd = new SqlCommand("select * from TBL_KASIR where Kode_Kasir='" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", Conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    FormMenuUtama.menu.MenuAbout.Enabled = true;
                    FormMenuUtama.menu.MenuTransaksi.Enabled = true;
                    FormMenuUtama.menu.MenuLogout.Enabled = true;
                    FormMenuUtama.menu.MenuPass.Enabled = true;
                    FormMenuUtama.menu.MenuMaster.Enabled = true;
                    FormMenuUtama.menu.MenuLogin.Enabled = false;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Zannen");
                }
            }
        }
    }
}
