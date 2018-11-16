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
    public partial class sabit : Form
    {
        public sabit()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=EBRUPC\SQLEXPRESS;Initial Catalog=kubraa;Integrated Security=True");
        public void sabitlistele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from sabit", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
        private void sabit_Load(object sender, EventArgs e)
        {
            sabitlistele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand
    ("insert into sabit (marka,kapasite,arabirim,tariih,nerdenalindi)values(@marka,@kapasite,@arabirim,@tariih,@nerdenalindi)", baglan);
            ekle.Parameters.AddWithValue("@marka", txtmarka.Text);
            ekle.Parameters.AddWithValue("@kapasite", cbkapasite.Text);
            ekle.Parameters.AddWithValue("@arabirim", txtarabirim.Text);
            ekle.Parameters.AddWithValue("@tariih", Convert.ToDateTime(dateTimetarih.Text));
            ekle.Parameters.AddWithValue("@nerdenalindi", cbALİNDİ.Text);
            ekle.ExecuteNonQuery();
                baglan.Close();
                DialogResult onay; onay = MessageBox.Show
                    ("SABİT DİSK EKLENDİ ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
            sabitlistele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sl = new SqlCommand("delete from sabit where id=@id",baglan);
            sl.Parameters.AddWithValue("@id",txtıd.Text);
            sl.ExecuteNonQuery();
                baglan.Close();
                DialogResult onay; onay = MessageBox.Show
                    ("SABİT DİSK SİLİNİYOR ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
            sabitlistele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand guncel = new SqlCommand
            ("update set sabit marka=@marka,kapasite@kapasite,arabirim=@arabirim,tariih=@tariih,nerdenalindi=@nerdenalindi where id=@id",baglan);
            guncel.Parameters.AddWithValue("@id", txtıd.Text);
            guncel.Parameters.AddWithValue("@marka", txtmarka.Text);
            guncel.Parameters.AddWithValue("@kapasite", cbkapasite.Text);
            guncel.Parameters.AddWithValue("@arabirim", txtarabirim.Text);
            guncel.Parameters.AddWithValue("@tariih", Convert.ToDateTime(dateTimetarih.Text));
            guncel.Parameters.AddWithValue("@nerdenalindi", cbALİNDİ.Text);
            guncel.ExecuteNonQuery();
                baglan.Close();
                DialogResult onay; onay = MessageBox.Show
                   ("SABİT DİSK GÜNCELLENDİ ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
            sabitlistele();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtmarka.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbkapasite.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtarabirim.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimetarih.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbALİNDİ.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();

        }

        private void btn_anasayfa_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

             
        
    }
}
