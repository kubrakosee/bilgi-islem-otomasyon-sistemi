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
    public partial class ram : Form
    {
        public ram()
        {
            InitializeComponent();
            
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=EBRUPC\SQLEXPRESS;Initial Catalog=kubraa;Integrated Security=True");
        public void ramlistele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from ram", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
        private void ram_Load(object sender, EventArgs e)
        {
            ramlistele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand
    ("insert into ram (ramkapasıte,ramtipi,marka,alındı,tarih)values(@ramkapasıte,@ramtipi,@marka,@alındı,@tarih)", baglan);
            ekle.Parameters.AddWithValue("@ramkapasıte", cbramkapasite.Text);
            ekle.Parameters.AddWithValue("@ramtipi", cbramtipi.Text);
            ekle.Parameters.AddWithValue("@marka", txtmarka.Text);
            ekle.Parameters.AddWithValue("@alındı", cbalındı.Text);
            ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(datetarih.Text));

            ekle.ExecuteNonQuery();
            baglan.Close();
            DialogResult onay; onay = MessageBox.Show
                ("ANAKART EKLENDİ ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                ramlistele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sl = new SqlCommand("delete from ram where id=@id", baglan);
            sl.Parameters.AddWithValue("@id", txtıd.Text);
            sl.ExecuteNonQuery();
            baglan.Close();
            DialogResult onay; onay = MessageBox.Show
               ("YAZICI SİLİNİYOR  ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                ramlistele();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand guncelle = new SqlCommand
                ("update set ram ramkapasıte=@ramkapasıte,ramtipi=@ramtipi,marka=@marka,alındı=@alındı,tarih=@tarih where id=@id", baglan);
            guncelle.Parameters.AddWithValue("@id", txtıd.Text);
            guncelle.Parameters.AddWithValue("@nerdengeldi", cbramkapasite.Text);
            guncelle.Parameters.AddWithValue("@ramtipi", cbramtipi.Text);
            guncelle.Parameters.AddWithValue("@marka", txtmarka.Text);
            guncelle.Parameters.AddWithValue("@alındı", cbalındı.Text);
            guncelle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(datetarih.Text));
            DialogResult onay; onay = MessageBox.Show
                ("YAZICI GÜNCELLENİYOR  ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                ramlistele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbramkapasite.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbramtipi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtmarka.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbalındı.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            datetarih.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
