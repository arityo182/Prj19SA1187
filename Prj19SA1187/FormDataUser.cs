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
    public partial class FormDataUser : Form
    {
        public FormDataUser()
        {
            InitializeComponent();

        }
        private void FormDataUser_Load(object sender, EventArgs e)
        {
            cbOtoritasUser.Items.Add("Supervisor");
            cbOtoritasUser.Items.Add("User");
            resetdata();
            showdata();
        }
        SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-HQJL4KAB;Initial Catalog =Db19SA1187; Integrated Security=True");
        DataTable dt = new DataTable();
        BindingSource bS = new BindingSource();
        private void resetdata()
        {
            txtUserid.Text = "";
            txtPassword.Text = "";
            txtNamaUser.Text = "";
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Tbadmin";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Tbadmin");
            dgvDataUser.DataSource = ds;
            dgvDataUser.DataMember = "Tbadmin";
            dgvDataUser.ReadOnly = true;
            dgvDataUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private string CaesarCipher(string value, int shift)
        {
            string[] joinCipher = new string[200];
            string joinText = "";
            string[] wordArray = value.Split(' ');

            try
            {
                for (int x = 0; x < wordArray.Length; x++)
                {
                    //Konversi String character dalam array
                    char[] buffer = wordArray[x].ToCharArray();

                    for (int i = 0; i < buffer.Length; i++)
                    {
                        //Pengambilan karakter berdasarkan index array
                        //Kemudian di konversikan ke bentuk karakter
                        char letter = buffer[i];
                        letter = (char)(letter - shift);

                        //Substract26 on overflow
                        //add 26 on underflow
                        if (letter > 'z')
                        {
                            letter = (char)(letter - 26);
                        }
                        else if (letter < 'a')
                        {
                            letter = (char)(letter + 26);
                        }
                        //Store
                        buffer[i] = letter;
                    }

                    string HasilKonversi = new string(buffer);
                    joinCipher[x] = HasilKonversi;
                }
                joinText = string.Join(" ", joinCipher);
                return joinText;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

       
        private void btInput_Click(object sender, EventArgs e)
        {
            if (txtNamaUser.Text == "" | txtPassword.Text == "" | txtUserid.Text == "" | string.IsNullOrEmpty(cbOtoritasUser.Text))
            {
                MessageBox.Show("Semua Data harus di isi", "Peringatan");
                goto berhenti;
            }
            String cbOtoritas = cbOtoritasUser.SelectedItem.ToString();
            String textchiper = null;
            textchiper = CaesarCipher(txtPassword.Text, 17);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Tbadmin values ('" + txtUserid.Text + "','" + textchiper +  "','"+ txtNamaUser.Text + "','" + cbOtoritas +"')";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtNamaUser.Text == "" | txtPassword.Text == "" | txtUserid.Text == "" | string.IsNullOrEmpty(cbOtoritasUser.Text))
            {
                MessageBox.Show("Semua data harus di isi", "Peringatan");
                goto berhenti;
            }
            String cbOtoritas = cbOtoritasUser.SelectedItem.ToString();
            String textcipher = null;
            textcipher = CaesarCipher(txtPassword.Text, 17);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Tbadmin set password='" + textcipher + "',namaUser='"+ txtNamaUser.Text+ "',Otoritas='" + cbOtoritas+ "'where userId='" + txtUserid.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            if (txtUserid.Text == "")
            {
                MessageBox.Show("ISi user id yang akan di hapus");
                goto berhenti;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Tbadmin where userId = '" + txtUserid.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }
    }
}
