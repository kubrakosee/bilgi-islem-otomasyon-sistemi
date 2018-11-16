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
    public partial class kasa : Form
    {
        public kasa()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=EBRUPC\SQLEXPRESS;Initial Catalog=kubraa;Integrated Security=True");
        public void kasalistele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from kasa", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
        private void kasa_Load(object sender, EventArgs e)
        {
            kasalistele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand
    ("insert into kasa (nerdengeldi,kasaıc,tarih)values(@nerdengeldi,@kasaıc,@tarih)", baglan);
            ekle.Parameters.AddWithValue("@nerdengeldi", cbalındı.Text);
            ekle.Parameters.AddWithValue("@kasaıc", cbkasaıc.Text);
            ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(datetarih.Text));
            
            ekle.ExecuteNonQuery();
            baglan.Close();
            DialogResult onay; onay = MessageBox.Show
                ("KASA EKLENDİ ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                kasalistele();
        }

        private void btn_sıl_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sl = new SqlCommand("delete from sabit where id=@id", baglan);
            sl.Parameters.AddWithValue("@id", txtıd.Text);
            sl.ExecuteNonQuery();
            baglan.Close();
            DialogResult onay; onay = MessageBox.Show
                ("KASA SİLİNİYOR ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
               kasalistele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand guncel = new SqlCommand
            ("update set kasa nerdengeldi=@nerdengeldi,kasaıc@kasaıc,tarih=@tarih where id=@id", baglan);
            guncel.Parameters.AddWithValue("@id", txtıd.Text);
            guncel.Parameters.AddWithValue("@nerdengeldi", cbalındı.Text);
            guncel.Parameters.AddWithValue("@kasaıc", cbkasaıc.Text);
            guncel.Parameters.AddWithValue("@tarih", Convert.ToDateTime(datetarih.Text));
            
            guncel.ExecuteNonQuery();
            baglan.Close();
            DialogResult onay; onay = MessageBox.Show
               ("KASA GÜNCELLENDİ ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                kasalistele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbalındı.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbkasaıc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            datetarih.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

    }
}
