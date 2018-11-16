using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BITIRMEPROJESİİ_KUBRA_KOSE_160622090
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=EBRUPC\SQLEXPRESS;Initial Catalog=kubraa;Integrated Security=True");
        

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_kullanıcı.Text = Properties.Settings.Default.k_adi;
            txt_sifre.Text = Properties.Settings.Default.sıfre;

            txt_sifre.Text = "";
            txt_kullanıcı.Text = "";


        }

        private void ch_benıhatırla_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_benıhatırla.Checked)
            {
                Properties.Settings.Default.k_adi = txt_kullanıcı.Text;
                Properties.Settings.Default.sıfre = txt_sifre.Text;
                Properties.Settings.Default.Save();
                /*Kullanıcı ve Şifre Kayıt etmesi için*/
            }

            else
            {
                Properties.Settings.Default.k_adi = null;
                Properties.Settings.Default.sıfre = null;
                Properties.Settings.Default.Save();
            }
        }

        private void btn_gırıs_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * from gırıs where kullanıcı_adı=@kullanıcı_adı AND sifre=@sifre", baglantı);

            komut.Parameters.AddWithValue("@kullanıcı_adı", txt_kullanıcı.Text);
            komut.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            komut.ExecuteNonQuery();

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form3 frm = new Form3();
                frm.Show();
                this.Hide();
            }

            else
            {


                MessageBox.Show("şifre yanlış");
                txt_kullanıcı.Text = "";
                txt_sifre.Text = "";

            }
            baglantı.Close();
        }

        private void txt_kullanıcı_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_sifre.Focus();

            }
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_kullanıcı.Focus();

            }
        }

        private void btn_yenı_Click(object sender, EventArgs e)
        {
            Form2 yenıkayıtformu = new Form2();
            yenıkayıtformu.Show();
            this.Hide();
        }

        private void cb_sıfregoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_sıfregoster.Checked)
            {
                txt_sifre.PasswordChar = '\0';
            }
            else
            {
                txt_sifre.PasswordChar = '*';

            }
        }
    }
}
