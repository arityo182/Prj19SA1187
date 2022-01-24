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
    public partial class FormDetailTransaksi : Form
    {
        public FormDetailTransaksi()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-HQJL4KAB;Initial Catalog =Db19SA1187; Integrated Security=True");
        private void isicomboTransaksi()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select idTransaksi from Tbtransaksi";
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cbIdTransaksi.Items.Add(sdr[0]);

            }
            sdr.Close();
        }
        private void isicomboMenu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select idMenu from Tbmenu";
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cbIdMenu.Items.Add(sdr[0]);

            }
            sdr.Close();
        }

        private void resetdata()
        {
            con.Close();
            cbIdTransaksi.Text = "";
            cbIdMenu.Text = "";
            txtHrgBeli.Text = "";
            txtHrgJual.Text = "";
            txtJumlahSatuan.Text = "";
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TbDetailTransaksi";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TbDetailTransaksi");
            dgvDetailTransaksi.DataSource = ds;
            dgvDetailTransaksi.DataMember = "TbDetailTransaksi";
            dgvDetailTransaksi.ReadOnly = true;
            dgvDetailTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormDetailTransaksi_Load(object sender, EventArgs e)
        {
            isicomboTransaksi();
            isicomboMenu();
            txtHrgBeli.Enabled = false;
            txtHrgJual.Enabled = false;
            showdata();
        }

        private void cbIdMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from Tbmenu where idMenu='" + cbIdMenu.Text + "'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtHrgBeli.Text = rd[2].ToString();
                txtHrgJual.Text = rd[3].ToString();
                rd.Close();
            }
        }

        private void btInput_Click(object sender, EventArgs e)
        {
            int num;
            bool isSatuan = int.TryParse(txtJumlahSatuan.Text.ToString(), out num);
            if (cbIdMenu.Equals("") | cbIdMenu.Equals("") | txtHrgBeli.Text == "" | txtHrgJual.Text == "" | txtJumlahSatuan.Text == "")
            {
                MessageBox.Show("Semua Data Harus Di sis", "Peringatan");
                goto berhenti;
            } else if (!isSatuan)
            {
                MessageBox.Show("Isi Satuan Harus Angka", "Peringatan");
                goto berhenti;
            } else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into TbDetailTransaksi values ('" + cbIdTransaksi.Text + "','" +
                    cbIdMenu.Text + "','" + int.Parse(txtHrgBeli.Text) + "','" + int.Parse(txtHrgJual.Text) +
                    "','" + int.Parse(txtJumlahSatuan.Text) + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                showdata();
                resetdata();
            }
        berhenti:
            ;
        }

        private void brEdit_Click(object sender, EventArgs e)
        {
            if (cbIdMenu.Equals("") | cbIdMenu.Equals("") | txtHrgBeli.Text == "" | txtHrgJual.Text == "" | txtJumlahSatuan.Text == "")
            {
                MessageBox.Show("Semua Data Harus Di sis", "Peringatan");
                goto berhenti;
            } else
            //else if (!isSatuan)
            //{
            //    MessageBox.Show("Isi Satuan Harus Angka", "Peringatan");
            //    goto berhenti;
            //} else
            {
                //string IdCustomer = cbIdCustomer.SelectedItem.ToString();
                //con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " update TbDetailTransaksi set idMenu = '" + cbIdMenu.Text + "',hrgbeli = '" + int.Parse(txtHrgBeli.Text) + "',hrgjual = '" + int.Parse(txtHrgJual.Text) + "',jmljual = '" + int.Parse(txtJumlahSatuan.Text) + "'where idTransaksi = '" + cbIdTransaksi.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                showdata();
                resetdata();
            }
        //panggil procedure untuk refresh
        berhenti:
            ;
        }

        private void brDelete_Click(object sender, EventArgs e)
        {
            if (cbIdTransaksi.Equals(""))
            {
                MessageBox.Show("Data Belum di Isi Semua", "Peringatan");
                goto berhenti;
            }
            else
            {
                //con.Open();
                //Membuka Koneksi

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " delete from TbDetailTransaksi where idTransaksi = '" + cbIdTransaksi.Text + "'";
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
