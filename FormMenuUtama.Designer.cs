
namespace AppKasir
{
    partial class FormMenuUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAkun = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPass = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKasir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTrans = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuApp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAkun,
            this.MenuMaster,
            this.MenuTransaksi,
            this.MenuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAkun
            // 
            this.MenuAkun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLogin,
            this.MenuLogout,
            this.MenuExit,
            this.MenuPass});
            this.MenuAkun.Name = "MenuAkun";
            this.MenuAkun.Size = new System.Drawing.Size(64, 20);
            this.MenuAkun.Text = "Account";
            // 
            // MenuLogin
            // 
            this.MenuLogin.Name = "MenuLogin";
            this.MenuLogin.Size = new System.Drawing.Size(168, 22);
            this.MenuLogin.Text = "Log In";
            this.MenuLogin.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // MenuLogout
            // 
            this.MenuLogout.Name = "MenuLogout";
            this.MenuLogout.Size = new System.Drawing.Size(168, 22);
            this.MenuLogout.Text = "Log Out";
            this.MenuLogout.Click += new System.EventHandler(this.MenuLogout_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(168, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // MenuPass
            // 
            this.MenuPass.Name = "MenuPass";
            this.MenuPass.Size = new System.Drawing.Size(168, 22);
            this.MenuPass.Text = "Change Password";
            this.MenuPass.Click += new System.EventHandler(this.MenuPass_Click);
            // 
            // MenuMaster
            // 
            this.MenuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarang,
            this.MenuKasir});
            this.MenuMaster.Name = "MenuMaster";
            this.MenuMaster.Size = new System.Drawing.Size(58, 20);
            this.MenuMaster.Text = " Master";
            // 
            // MenuBarang
            // 
            this.MenuBarang.Name = "MenuBarang";
            this.MenuBarang.Size = new System.Drawing.Size(180, 22);
            this.MenuBarang.Text = "Master Barang";
            this.MenuBarang.Click += new System.EventHandler(this.MenuBarang_Click);
            // 
            // MenuKasir
            // 
            this.MenuKasir.Name = "MenuKasir";
            this.MenuKasir.Size = new System.Drawing.Size(180, 22);
            this.MenuKasir.Text = "Master Kasir";
            this.MenuKasir.Click += new System.EventHandler(this.MenuKasir_Click);
            // 
            // MenuTransaksi
            // 
            this.MenuTransaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTrans,
            this.MenuReport});
            this.MenuTransaksi.Name = "MenuTransaksi";
            this.MenuTransaksi.Size = new System.Drawing.Size(66, 20);
            this.MenuTransaksi.Text = "Transaksi";
            // 
            // MenuTrans
            // 
            this.MenuTrans.Name = "MenuTrans";
            this.MenuTrans.Size = new System.Drawing.Size(167, 22);
            this.MenuTrans.Text = "Mesin Transaksi";
            // 
            // MenuReport
            // 
            this.MenuReport.Name = "MenuReport";
            this.MenuReport.Size = new System.Drawing.Size(167, 22);
            this.MenuReport.Text = "Laporan Transaksi";
            // 
            // MenuAbout
            // 
            this.MenuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuApp});
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(50, 20);
            this.MenuAbout.Text = "Utility";
            // 
            // MenuApp
            // 
            this.MenuApp.Name = "MenuApp";
            this.MenuApp.Size = new System.Drawing.Size(127, 22);
            this.MenuApp.Text = "MenuApp";
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuUtama";
            this.Text = "FormMenuUtama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenuUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuBarang;
        private System.Windows.Forms.ToolStripMenuItem MenuKasir;
        private System.Windows.Forms.ToolStripMenuItem MenuTrans;
        private System.Windows.Forms.ToolStripMenuItem MenuReport;
        private System.Windows.Forms.ToolStripMenuItem MenuApp;
        public System.Windows.Forms.ToolStripMenuItem MenuAkun;
        public System.Windows.Forms.ToolStripMenuItem MenuLogin;
        public System.Windows.Forms.ToolStripMenuItem MenuLogout;
        public System.Windows.Forms.ToolStripMenuItem MenuExit;
        public System.Windows.Forms.ToolStripMenuItem MenuPass;
        public System.Windows.Forms.ToolStripMenuItem MenuMaster;
        public System.Windows.Forms.ToolStripMenuItem MenuTransaksi;
        public System.Windows.Forms.ToolStripMenuItem MenuAbout;
    }
}