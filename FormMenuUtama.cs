using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppKasir
{
    public partial class FormMenuUtama : Form
    {
        public static FormMenuUtama menu;
        MenuStrip mnstrip;
        Form_Login FrmLgn;
        void MenuTerkunci()
        {
            MenuLogin.Enabled = true;
            MenuLogout.Enabled = false;
            MenuPass.Enabled = false;
            MenuExit.Enabled = true;
            MenuMaster.Enabled = false;
            MenuTransaksi.Enabled = false;
            MenuAbout.Enabled = false;
            menu = this;
        }
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login FrmLgn = new Form_Login();
            FrmLgn.ShowDialog();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuBarang_Click(object sender, EventArgs e)
        {
            MenuBarang MenuBrg = new MenuBarang();
            MenuBrg.ShowDialog();
        }

        private void MenuLogout_Click(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void MenuPass_Click(object sender, EventArgs e)
        {
            FormPass FrmPass = new FormPass();
            FrmPass.ShowDialog();
        }

        private void MenuKasir_Click(object sender, EventArgs e)
        {
            MenuKasir MnKasir = new MenuKasir();
            MnKasir.ShowDialog();
        }
    }
}
