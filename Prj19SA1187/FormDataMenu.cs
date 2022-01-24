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
    public partial class FormDataMenu : Form
    {
        public FormDataMenu()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-HQJL4KAB;Initial Catalog =Db19SA1187; Integrated Security=True");

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            //Membuat SQLCOMMAND dengan alias (nama pengganti) dari SQLCOMMAND
            cmd.Connection = con;
            //include koneksi ke data perintah
            cmd.CommandType = CommandType.Text;
            //Menentukan jenis perintah berupa text(perintah SQl biasa)
            cmd.CommandText = "select * from Tbmenu";
            //perintah sql
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Membuat data adaoter untuk mengeksekusi perintah SQLCOMMAND(scom)
            da.Fill(ds, "Tbmenu");
            //Isi dari select from ms barang tadi kita yampung ke dalam dataset
            dgvDataMenu.DataSource = ds;
            //set datasource untuk menampilkan data yang berasal dari isi
            dgvDataMenu.DataMember = "Tbmenu";
            //set datagriud untuk menampilkan member dari dataset dsi yang telah kitapilih pada data source sebelumnya
            dgvDataMenu.ReadOnly = true;
            //set datagrid bersifat read only
            dgvDataMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void resetdata()
        {
            txtIdMenu.Text = "";
            txtNmMenu.Text = "";
            txtHrgBeli.Text = "";
            txtHrgJual.Text = "";
            txtStnMenu.Text = "";
            txtStokMenu.Text = "";
        }
        private void FormDataMenu_Load(object sender, EventArgs e)
        {
            resetdata();
            showdata();
        }

        private void btInputMenu_Click(object sender, EventArgs e)
        {
            if(txtHrgBeli.Text == "" | txtHrgJual.Text == "" | txtIdMenu.Text == "" | txtNmMenu.Text == "" | txtStnMenu.Text == "" | txtStokMenu.Text == "")
            {
                MessageBox.Show("Semua Harus di isi", "Peringatan");
                goto berhenti;
            } else
            {
                con.Open();
                //Membuka Koneksi

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "ADDMENU";
                cmd.CommandType = CommandType.StoredProcedure;

                //buat sql parameter dengan nama variabel yang sama pada sql
                //Storedd procedure yang telah kita buat
                SqlParameter idMenu = new SqlParameter("@idMenu", SqlDbType.VarChar);
                SqlParameter namaMenu = new SqlParameter("@namaMenu", SqlDbType.VarChar);
                SqlParameter hargaBeli = new SqlParameter("@hrgBeli", SqlDbType.Int);
                SqlParameter hargaJual = new SqlParameter("@hrgJual", SqlDbType.Int);
                SqlParameter satuan = new SqlParameter("@satuan", SqlDbType.Int);
                SqlParameter stok = new SqlParameter("@stok", SqlDbType.Int);

                //Isi variabel sql parameter tadi dengan nilai
                idMenu.Value = txtIdMenu.Text;
                namaMenu.Value = txtNmMenu.Text;
                hargaBeli.Value = txtHrgBeli.Text;
                hargaJual.Value = txtHrgJual.Text;
                satuan.Value = txtStnMenu.Text;
                stok.Value = txtStokMenu.Text;

                //Kemudian add parameter yang telah kita buat tadi kedalam command yantgada
                cmd.Parameters.Add(idMenu);
                cmd.Parameters.Add(namaMenu);
                cmd.Parameters.Add(hargaBeli);
                cmd.Parameters.Add(hargaJual);
                cmd.Parameters.Add(satuan);
                cmd.Parameters.Add(stok);

                //Jalankan storedprocedure
                cmd.ExecuteNonQuery();

                con.Close();
                //Akhiri koneksi
                showdata();
                resetdata();

            }
        berhenti:
            ;
        }

        private void btEditMenu_Click(object sender, EventArgs e)
        {
            if (txtHrgBeli.Text == "" | txtHrgJual.Text == "" | txtIdMenu.Text == "" | txtNmMenu.Text == "" | txtStnMenu.Text == "" | txtStokMenu.Text == "")
            {
                MessageBox.Show("Semua Harus di isi", "Peringatan");
                goto berhenti;
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Tbmenu set namaMenu = '" + txtNmMenu.Text + "',hargaBeli = '" + int.Parse(txtHrgBeli.Text) + "',hargaJual = '" + int.Parse(txtHrgJual.Text) + "',satuan = '" + int.Parse(txtStnMenu.Text) + "',stok = '" + int.Parse(txtStokMenu.Text) + "'where idMenu = '" + int.Parse(txtIdMenu.Text) + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                showdata();
                resetdata();
                //int num;
                //bool numHrgBeli = int.TryParse(txtHrgBeli.Text.ToString(), out num);
                //bool numHrgJual = int.TryParse(txtHrgJual.Text.ToString(), out num);
                //bool numIdMenu = int.TryParse(txtIdMenu.Text.ToString(), out num);
                //bool numSatuan = int.TryParse(txtStnMenu.Text.ToString(), out num);
                //bool numStok = int.TryParse(txtStokMenu.Text.ToString(), out num);

                //if(!numHrgBeli | !numHrgJual | !numIdMenu | !numSatuan | !numStok)
                //{
                //    MessageBox.Show("Isi harga harus angka", "Peringatan");
                //    goto berhenti;
                //} else
                //{
                //    con.Open();
                //    SqlCommand cmd = new SqlCommand();
                //    cmd.Connection = con;
                //    cmd.CommandType = CommandType.Text;
                //    cmd.CommandText = "update Tbmenu set namaMenu = '" + txtNmMenu.Text + "',hargaBeli = '" + int.Parse(txtHrgBeli.Text) + "',hargaJual = '" + int.Parse(txtHrgJual.Text) + "',satuan = '" + int.Parse(txtStnMenu.Text) + "',stok = '" + int.Parse(txtStokMenu.Text) + "'where idMenu = '" + int.Parse(txtIdMenu.Text) + "'";
                //    cmd.ExecuteNonQuery();
                //    con.Close();
                //    showdata();
                //    resetdata();
            //}
            }
        berhenti:
            ;
        }

        private void btDeleteMenu_Click(object sender, EventArgs e)
        {
            if(txtIdMenu.Text == "")
            {
                MessageBox.Show("IdMenu Harus di isi", "Peringatan");
                goto berhenti;
            } else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELMENU";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter idMenu = new SqlParameter("@idMenu", SqlDbType.VarChar);

                idMenu.Value = txtIdMenu.Text;
                cmd.Parameters.Add(idMenu);
                cmd.ExecuteNonQuery();
                con.Close();
                showdata();
                resetdata();
            }
        berhenti:
            ;
        }

        private void btSearchMenu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Tbmenu where idMenu like '%" + txtSearchMenu.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "Tbmenu");
            dgvDataMenu.DataSource = ds;
            dgvDataMenu.DataMember = "Tbmenu";
            dgvDataMenu.ReadOnly = true;
        }
    }
}
