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
    public partial class YAZICI : Form
    {
        public YAZICI()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=EBRUPC\SQLEXPRESS;Initial Catalog=kubraa;Integrated Security=True");
        public void yazıcılistele()
        {

            baglantı.Open();
            SqlDataAdapter list = new SqlDataAdapter("select * from yazıcıekle", baglantı);
            DataTable memory = new DataTable();
            list.Fill(memory);
            dataGridView1.DataSource = memory;
            baglantı.Close();

        }

        private void YAZICI_Load(object sender, EventArgs e)
        {
            yazıcılistele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand
            ("insert into yazıcıekle(nerdengeldi,hangitarihte,markası,ozelliği)values(@nerdengeldi,@hangitarihte,@markası,@ozelliği)", baglantı);
            ekle.Parameters.AddWithValue("@nerdengeldi", txtnerden.Text);
            ekle.Parameters.AddWithValue("@hangitarihte", Convert.ToDateTime(dateTimetarih.Text));
            ekle.Parameters.AddWithValue("@markası", txtmarka.Text);
            ekle.Parameters.AddWithValue("@ozelliği", cbEKLE.Text);
            ekle.ExecuteNonQuery();
             DialogResult onay; onay = MessageBox.Show
                ("YAZICI EKLENDİ ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
             if (onay == DialogResult.Yes)
            baglantı.Close();
           
            
            yazıcılistele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand sl = new SqlCommand("delete from yazıcıekle where id=@id",baglantı);
            sl.Parameters.AddWithValue("@id",txtıd.Text);
            sl.ExecuteNonQuery();
            baglantı.Close();
            DialogResult onay; onay = MessageBox.Show
               ("YAZICI SİLİNİYOR  ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            yazıcılistele();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand guncelle = new SqlCommand
                ("update set yazıcıekle nerdengeldi=@nerdengeldi,hangitarihte=@hangitarihte,markası=@markası,ozelliği=@ozelliği where id=@id", baglantı);
            guncelle.Parameters.AddWithValue("@id", txtıd.Text);
            guncelle.Parameters.AddWithValue("@nerdengeldi", txtnerden.Text);
            guncelle.Parameters.AddWithValue("@hangitarihte", Convert.ToDateTime(dateTimetarih.Text));
            guncelle.Parameters.AddWithValue("@markası", txtmarka.Text);
            guncelle.Parameters.AddWithValue("@ozelliği", cbEKLE.Text);
            guncelle.ExecuteNonQuery();
            DialogResult onay; onay = MessageBox.Show
                ("YAZICI GÜNCELLENİYOR  ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            yazıcılistele();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnerden.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimetarih.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtmarka.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbEKLE.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
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
