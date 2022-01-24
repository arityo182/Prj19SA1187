using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prj19SA1187
{
    public partial class FormDataCustomer : Form
    {
        public FormDataCustomer()
        {
            InitializeComponent();
        }

        private void FormDataCustomer_Load(object sender, EventArgs e)
        {
            resetdata();
            showdata();
        }
        SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-HQJL4KAB;Initial Catalog =Db19SA1187; Integrated Security=True");
        private void resetdata()
        {
            txtIdCustomer.Text = "";
            txtNmCustomer.Text = "";
            txtAlmtCustomer.Text = "";
            txtKtCustomer.Text = "";
            txtNmrHpCustomer.Text = "";

        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Tbcustomer";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Tbcustomer");
            dgvCustomer.DataSource = ds;
            dgvCustomer.DataMember = "Tbcustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //private void btSearchCustomer_Click(object sender, EventArgs e)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select * from Tbcustomer where namaCustomer like '%" + txtSearchCustomer.Text + "%'";
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(ds, "Tbcustomer");
        //    dgvCustomer.DataSource = ds;
        //    dgvCustomer.DataMember = "Tbcustomer";
        //    dgvCustomer.ReadOnly = true;
        //}

        private void btInputCustomer_Click(object sender, EventArgs e)
        {
            if (txtIdCustomer.Text == "" | txtNmCustomer.Text == "" | txtAlmtCustomer.Text == "" | txtKtCustomer.Text == "" | txtNmrHpCustomer.Text == "")
            //gunakajn or untuk argument membandingkan
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            int num;
            //buat variabel num
            bool isNum = int.TryParse(txtNmrHpCustomer.Text.ToString(), out num);
            //Membuat variabel is num dan kemudian isi dari variabel isnum itu sendiri
            //Mengubah tyupe data dan menyimpan hsilnya pada variabel num

            if (!isNum)
            //Mengecek nilai isnum false
            // karena number melainkan alfabet
            {
                MessageBox.Show("Isi Nomor Harus Angka", "Peringatan");
                goto berhenti;
                // bila false maka tampilkan pesan harga mesti number
            }

            con.Open();
            //Membuka Koneksi

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Tbcustomer values ('" + txtIdCustomer.Text + "','" + txtNmCustomer.Text + "','" + txtAlmtCustomer.Text + "','" + txtKtCustomer.Text + "','" + int.Parse(txtNmrHpCustomer.Text) + "')";
            //Mengisi perintah sql dengan insert data ke dalam table custemer
            cmd.ExecuteNonQuery();
            //eksecute(jalankan perintah)
            con.Close();
            //Akhiri koneksi
            showdata();
            resetdata();
        //panggil procedure untuk refresh

        berhenti:
            ;
        }

        private void btEditCustomer_Click(object sender, EventArgs e)
        {
            if (txtIdCustomer.Text == "" | txtNmCustomer.Text == "" | txtAlmtCustomer.Text == "" | txtKtCustomer.Text == "" | txtNmrHpCustomer.Text == "")
            //gunakajn or untuk argument membandingkan
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            int num;
            //buat variabel num
            bool isNum = int.TryParse(txtNmrHpCustomer.Text.ToString(), out num);
            //Membuat variabel is num dan kemudian isi dari variabel isnum itu sendiri
            //Mengubah tyupe data dan menyimpan hsilnya pada variabel num

            if (!isNum)
            //Mengecek nilai isnum false
            // karena number melainkan alfabet
            {
                MessageBox.Show("Isi Nomor Harus Angka", "Peringatan");
                goto berhenti;
                // bila false maka tampilkan pesan harga mesti number
            }

            con.Open();
            //Membuka Koneksi

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Tbcustomer set namaCustomer='" + txtNmCustomer.Text + "',almntCustomer='" + txtAlmtCustomer.Text + "',kota='" + txtKtCustomer.Text + "',nmrHp='" + int.Parse(txtNmrHpCustomer.Text) + "'where idCustomer='" + txtIdCustomer.Text + "'";
            //Mengisi perintah sql dengan insert data ke dalam table custemer
            cmd.ExecuteNonQuery();
            //eksecute(jalankan perintah)
            con.Close();
            //Akhiri koneksi
            showdata();
            resetdata();
        //panggil procedure untuk refresh

        berhenti:
            ;
        }

        private void brDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (txtIdCustomer.Text == "")
            {
                MessageBox.Show("Isi Input id customer yang akan di hapus");
                goto berhenti;
            }
            con.Open();
            //Membuka Koneksi

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from Tbcustomer where idCustomer = '" + txtIdCustomer.Text + "'";
            //Mengisi perintah sql dengan dekete data ke dalam table custemer
            cmd.ExecuteNonQuery();
            //eksecute(jalankan perintah)
            con.Close();
            //Akhiri koneksi
            showdata();
            resetdata();
        //panggil procedure untuk refresh
        berhenti:
            ;
        }
    }
}
