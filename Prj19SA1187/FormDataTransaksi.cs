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
    public partial class FormDataTransaksi : Form
    {
        public static FormDataTransaksi instance;
        public TextBox tb1;
        public FormDataTransaksi()
        {
            InitializeComponent();
            instance = this;
            tb1 = txtUserId;
        }

        SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-HQJL4KAB;Initial Catalog =Db19SA1187; Integrated Security=True");

        private string notrans
        {
            get
            {
                con.Open();
                string nomor = "TR_0001";
                SqlCommand cmd = new SqlCommand("select max(right(idTransaksi,4)) from Tbtransaksi", con);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd[0].ToString() != "")
                    nomor = "TR." + (int.Parse(rd[0].ToString()) + 1).ToString("0000");
                rd.Close();
                return nomor;
            }
        }

        private void isicombo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select idCustomer from Tbcustomer";
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cbIdCustomer.Items.Add(sdr[0]);

            }
            sdr.Close();
            //con.Close();
            //DataSet ds1 = new DataSet();
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //sda.Fill(ds1, "idCustomer");
            //cbIdCustomer.DataSource = ds1.Tables["Tbcustomer"];
            //cbIdCustomer.DisplayMember = "idCustomer";
        }

        private void resetdata()
        {
            con.Close();
            txtIdTransaksi.Text = notrans;
            txtTglTransaksi.Text = "";
            cbIdCustomer.Text = "";
            //txtUserId.Text = "";
            txtUserId.Enabled = false;
            txtTglTransaksi.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Tbtransaksi";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Tbtransaksi");
            dgvDataTransaksi.DataSource = ds;
            dgvDataTransaksi.DataMember = "Tbtransaksi";
            dgvDataTransaksi.ReadOnly = true;
            dgvDataTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormDataTransaksi_Load(object sender, EventArgs e)
        {
            txtIdTransaksi.Text = notrans;
            isicombo();
            txtTglTransaksi.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            showdata();
        }

        private void cbIdCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void btInputTransaksi_Click(object sender, EventArgs e)
        {
            if (txtIdTransaksi.Text == "" | txtTglTransaksi.Text == "" | txtUserId.Text == "" | string.IsNullOrEmpty(cbIdCustomer.Text))
            {
                MessageBox.Show("Data Belum di Isi Semua", "Peringatan");
                goto berhenti;
            }
            string IdCustomer = cbIdCustomer.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Tbtransaksi values('" + txtIdTransaksi.Text + "','" +
                txtTglTransaksi.Text + "','" + IdCustomer + "','" + txtUserId.Text + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data sudah Masuk");
            resetdata();
            showdata();
            txtIdTransaksi.Focus();
            FormDetailTransaksi frdt = new FormDetailTransaksi();
            frdt.Show();
        berhenti:
            ;
        }

        private void btEditTransaksi_Click(object sender, EventArgs e)
        {
            if (txtIdTransaksi.Text == "" | txtTglTransaksi.Text == "" | txtUserId.Text == "" | string.IsNullOrEmpty(cbIdCustomer.Text))
            {
                MessageBox.Show("Data Belum di Isi Semua", "Peringatan");
                goto berhenti;
            } else
            {
                string IdCustomer = cbIdCustomer.SelectedItem.ToString();
                //con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " update Tbtransaksi set tglTransaksi = '" + txtTglTransaksi.Text + "',idCustomer = '" + IdCustomer + "',userId = '" + txtUserId.Text + "'where idTransaksi = '" + txtIdTransaksi.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                showdata();
                resetdata();
            }
        //panggil procedure untuk refresh
        berhenti:
            ;
        }

        private void brDeleteTransaksi_Click(object sender, EventArgs e)
        {
            if (txtIdTransaksi.Text == "")
            {
                MessageBox.Show("Data Belum di Isi Semua", "Peringatan");
                goto berhenti;
            } else
            {
                //con.Open();
                //Membuka Koneksi

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " delete from Tbtransaksi where idTransaksi = '" + txtIdTransaksi.Text + "'";
                //Mengisi perintah sql dengan dekete data ke dalam table custemer
                cmd.ExecuteNonQuery();
                //eksecute(jalankan perintah)
                con.Close();
                //Akhiri koneksi
                showdata();
                resetdata();
            }
        //panggil procedure untuk refresh
        berhenti:
            ;
        }
    }
}
