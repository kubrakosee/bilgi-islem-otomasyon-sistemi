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
    public partial class bılgısayarekle : Form
    {
        SqlConnection baglanti = new SqlConnection
            (@"Data Source=EBRUPC\SQLEXPRESS;Initial Catalog=kubraa;Integrated Security=True");

        public bılgısayarekle()
        {
            InitializeComponent();
        }
        public void bilgisayarlistele()
        {

            baglanti.Open();
            SqlDataAdapter list = new SqlDataAdapter("select * from bilgisayarekle", baglanti);
            DataTable memory = new DataTable();
            list.Fill(memory);
            dataGridView1.DataSource = memory;
            baglanti.Close();

        }


        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand
                ("insert into bilgisayarekle (kimeait,sifre,hangibolum,tarih)values(@kimeait,@sifre,@hangibolum,@tarih)", baglanti);

            ekle.Parameters.AddWithValue("@kimeait", txtkım.Text);
            ekle.Parameters.AddWithValue("@sifre", txtsıfre.Text);
            ekle.Parameters.AddWithValue("@hangibolum", cbbolum.Text);
            ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(dttarih.Text));

            ekle.ExecuteNonQuery();
            baglanti.Close();

            DialogResult onay; onay = MessageBox.Show
                ("BİLGİSAYAR EKLENİYOR ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                bilgisayarlistele();


        }
        private void bılgısayarekle_Load(object sender, EventArgs e)
        {
            bilgisayarlistele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sl = new SqlCommand
                ("delete from bilgisayarekle where id=@id", baglanti);
            sl.Parameters.AddWithValue("@id", txtıd.Text);
            sl.ExecuteNonQuery();
            baglanti.Close();
            DialogResult onay; onay = MessageBox.Show
                 ("BİLGİSAYAR SİLİNİYOR ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                bilgisayarlistele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtkım.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsıfre.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbbolum.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dttarih.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand gn = new SqlCommand
                ("update bilgisayarekle set kimeait=@kimeait,sifre=@sifre,hangibolum=@hangibolum,tarih=@tarih where id=@id", baglanti);
            gn.Parameters.AddWithValue("@id", txtıd.Text);
            gn.Parameters.AddWithValue("@kimeait", txtkım.Text);
            gn.Parameters.AddWithValue("@sifre", txtsıfre.Text);
            gn.Parameters.AddWithValue("@hangibolum", cbbolum.Text);
            gn.Parameters.AddWithValue("@tarih", Convert.ToDateTime(dttarih.Text));
            gn.ExecuteNonQuery();



            baglanti.Close();
            DialogResult onay; onay = MessageBox.Show
                ("BİLGİSAYAR GÜNCELLENİYOR ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                bilgisayarlistele();


        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void txtıd_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtıd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtkım.Focus();

            }
        }

        private void txtkım_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtıd.Focus();
            }
            else if(e.KeyCode == Keys.Enter)
            {
            txtsıfre.Show();
            }
        }

        private void txtsıfre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtkım.Focus();

            }
        }

        private void cbbolum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                dttarih.Show();

            }
        }
    }
}