using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prj19SA1187
{
    public partial class FormMenuUtama : Form
    {
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void btAdmin_Click_1(object sender, EventArgs e)
        {
            FormDataUser dataUser = new FormDataUser();
            dataUser.Show();
            this.Show();
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            FormDataCustomer dtCustomer = new FormDataCustomer();
            dtCustomer.Show();
            this.Show();
        }
                
        private void btMenu_Click(object sender, EventArgs e)
        {
            FormDataMenu dtMenu = new FormDataMenu();
            dtMenu.Show();
            this.Show();
        }

        private void btTransaksi_Click(object sender, EventArgs e)
        {
            FormDataTransaksi dtTransaksi = new FormDataTransaksi();
            dtTransaksi.Show();
            this.Show();
        }

        private void btLaporan_Click(object sender, EventArgs e)
        {
            FormLaporanOmset lprOmset = new FormLaporanOmset();
            lprOmset.Show();
            this.Show();
        }
        private void btKeluar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yakin Anda Mau Keluar",
                      "PERINGATAN!!", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    System.Environment.Exit(1);
                    break;
                case DialogResult.No:
                    break;
            }
        }

    }
}
