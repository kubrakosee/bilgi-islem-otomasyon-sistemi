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
    public partial class anakart : Form
    {
        public anakart()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=EBRUPC\SQLEXPRESS;Initial Catalog=kubraa;Integrated Security=True");
        public void anakartlistele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from anakart", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand
    ("insert into anakart (ramslotu,chıpset,anakartboy,alındı,tarih)values(@ramslotu,@chıpset,@anakartboy,@alındı,@tarih)", baglan);
            ekle.Parameters.AddWithValue("@ramslotu", txtram.Text);
            ekle.Parameters.AddWithValue("@chıpset", txtchıp.Text);
            ekle.Parameters.AddWithValue("@anakartboy", txtanakartboy.Text);
            ekle.Parameters.AddWithValue("@alındı", cbalındı.Text);
            ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(datetarih.Text));

            ekle.ExecuteNonQuery();
            baglan.Close();
            DialogResult onay; onay = MessageBox.Show
                ("ANAKART EKLENDİ ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                anakartlistele();

        }

        private void ekrankartı_Load(object sender, EventArgs e)
        {
            anakartlistele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sl = new SqlCommand("delete from anakart where id=@id", baglan);
            sl.Parameters.AddWithValue("@id", txtıd.Text);
            sl.ExecuteNonQuery();
            baglan.Close();
            DialogResult onay; onay = MessageBox.Show
                ("ANAKART SİLİNİYOR ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                anakartlistele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand guncel = new SqlCommand
            ("update set anakart ramslotu=@ramslotu,chıpset@chıpset,anakartboy=@anakartboy,alındı=@alındı,tarih=@tarih where id=@id", baglan);
            guncel.Parameters.AddWithValue("@id", txtıd.Text);
            guncel.Parameters.AddWithValue("@ramslotu", txtram.Text);
            guncel.Parameters.AddWithValue("@chıpset", txtchıp.Text);
            guncel.Parameters.AddWithValue("@anakartboy", txtanakartboy.Text);
            guncel.Parameters.AddWithValue("@alındı", cbalındı.Text);
            guncel.Parameters.AddWithValue("@tarih", Convert.ToDateTime(datetarih.Text));
            guncel.ExecuteNonQuery();
            baglan.Close();
            DialogResult onay; onay = MessageBox.Show
               ("ANAKART GÜNCELLENDİ ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                anakartlistele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtram.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtchıp.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtanakartboy.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbalındı.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            datetarih.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void anakart_Load(object sender, EventArgs e)
        {
            anakartlistele();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {

            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}

