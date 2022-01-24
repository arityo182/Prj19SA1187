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
    public partial class FormLaporanOmset : Form
    {
        public FormLaporanOmset()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-HQJL4KAB;Initial Catalog =Db19SA1187; Integrated Security=True");

        BindingSource bS = new BindingSource();
        private void FormLaporanOmset_Load(object sender, EventArgs e)
        {
            string sqlquery = "select Tbtransaksi.tglTransaksi, Tbtransaksi.idTransaksi, TbDetailTransaksi.idMenu, Tbmenu.namaMenu, TbDetailTransaksi.jmljual, TbDetailTransaksi.hrgbeli, TbDetailTransaksi.hrgjual, Tbtransaksi.userId, Tbcustomer.namaCustomer from Tbtransaksi inner join TbDetailTransaksi on Tbtransaksi.idTransaksi=TbDetailTransaksi.idTransaksi inner join Tbcustomer on Tbtransaksi.idCustomer=Tbcustomer.idCustomer inner join Tbmenu on TbDetailTransaksi.idMenu=Tbmenu.idMenu";
            //sqlquery += "on Tbtransaksi.idTransaksi=TbDetailTransaksi.idTransaksi";
            // inner join Tbcustomer on Tbtransaksi.idCustomer=Tbcustomer.idCustomer
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvLaporanOmset.DataSource = dt;
            con.Close();
            dgvLaporanOmset.ReadOnly = true;
            dgvLaporanOmset.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Tbtransaksi.tglTransaksi, Tbtransaksi.idTransaksi, TbDetailTransaksi.idMenu, Tbmenu.namaMenu, TbDetailTransaksi.jmljual, TbDetailTransaksi.hrgbeli, TbDetailTransaksi.hrgjual, Tbtransaksi.userId, Tbcustomer.namaCustomer from Tbtransaksi inner join TbDetailTransaksi on Tbtransaksi.idTransaksi=TbDetailTransaksi.idTransaksi inner join Tbcustomer on Tbtransaksi.idCustomer=Tbcustomer.idCustomer inner join Tbmenu on TbDetailTransaksi.idMenu=Tbmenu.idMenu where Tbtransaksi.tglTransaksi like '%" + txtCAri.Text + "%' or Tbtransaksi.userId like '%" + txtCAri.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "Tbtransaksi");
            dgvLaporanOmset.DataSource = ds;
            dgvLaporanOmset.DataMember = "Tbtransaksi";
            dgvLaporanOmset.ReadOnly = true;

            
        }
    }
}
