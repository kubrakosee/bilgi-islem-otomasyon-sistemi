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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=EBRUPC\SQLEXPRESS;Initial Catalog=kubraa;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_gırıs_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand
                ("insert into gırıs(kullanıcı_adı,sifre)values(@kullanıcı_adı,@sifre)", baglantı);

            ekle.Parameters.AddWithValue("@kullanıcı_adı", txt_yenıkullanıcı.Text);
            ekle.Parameters.AddWithValue("@sifre", txt_yenısifre.Text);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("KAYIT BAŞARILI");
            Form1 gec = new Form1();
            gec.Show();
            this.Hide();
        }

        private void txt_yenıkullanıcı_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_yenısifre.Focus();

            }
        }

        private void txt_yenısifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_yenıkullanıcı.Focus();

            }
        }
    }
}
