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
    public partial class FormLogin : Form
    {
        public static FormLogin instance;
        public FormLogin()
        {
            InitializeComponent();
            instance = this;
        }
        SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-HQJL4KAB;Initial Catalog =Db19SA1187; Integrated Security=True");

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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Set to no text.
            txtPassword.Text = "";
            // The password character is an asterisk.
            txtPassword.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtPassword.MaxLength = 14;
            this.AcceptButton = btLogin;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" | txtPassword.Text == "")
            {
                MessageBox.Show("Pastikan Username dan Password sudah di isi", "Peringatan");
                goto berhenti;
            }
            //FormDataTransaksi.instance.tb1.Text = txtUser.Text;
            string textcipher = null;
            textcipher = CaesarCipher(txtPassword.Text, 17);

            con.Close();
            SqlCommand cmd = new SqlCommand("select * from Tbadmin where userId='" + txtUser.Text +
                "' and password='" + textcipher + "'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                FormMenuUtama frm_menu = new FormMenuUtama();
                frm_menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User id atau password tidak vald", "Peringatan");
                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
                rd.Close();
            }
        berhenti:
            ;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToLower());
        }
    }
}
