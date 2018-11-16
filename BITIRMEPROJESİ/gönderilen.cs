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
using wordeaktar = Microsoft.Office.Interop.Word;





namespace BITIRMEPROJESİİ_KUBRA_KOSE_160622090
{
    public partial class gönderilen : Form
    {
        public gönderilen()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=EBRUPC\SQLEXPRESS;Initial Catalog=kubraa;Integrated Security=True");
        public void gönderilenlistele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from gonderılen", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

        }

        private void gönderilen_Load(object sender, EventArgs e)
        {
            gönderilenlistele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand
   ("insert into gonderılen (hangıbolum,adısoyad,gonderilennedir,markası,gonderıldı,siparis,elimizde) values(@hangıbolum,@adısoyad,@gonderilennedir,@markası,@gonderıldı,@siparis,@elimizde)", baglan);
            ekle.Parameters.AddWithValue("@hangıbolum", cbhangıbolum.Text);
            ekle.Parameters.AddWithValue("@adısoyad", txtgonderilenad.Text);
            ekle.Parameters.AddWithValue("@gonderilennedir", cbnedir.Text);
            ekle.Parameters.AddWithValue("@markası", txtmarka.Text);
            ekle.Parameters.AddWithValue("@gonderıldı", Convert.ToDateTime(datetarih.Text));
            ekle.Parameters.AddWithValue("@siparis", cbsıparıs.Text);
            ekle.Parameters.AddWithValue("@elimizde", cbelimizde.Text);

            ekle.ExecuteNonQuery();
            baglan.Close();
            DialogResult onay; onay = MessageBox.Show
                ("GÖNDERİLEN EKLENDİ ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                gönderilenlistele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand
("update set gonderılen hangıbolum=@hangıbolum,adısoyad=@adısoyad,gonderilennedir=@gonderilennedir,markası=@markası,gonderıldı=@gonderıldı,siparis=@siparis,elimizde=@elimizde where id=@id", baglan);

            guncelle.Parameters.AddWithValue("@id", txtıd.Text);
            guncelle.Parameters.AddWithValue("@hangıbolum", cbhangıbolum.Text);
            guncelle.Parameters.AddWithValue("@adısoyad", txtgonderilenad.Text);
            guncelle.Parameters.AddWithValue("@gonderilennedir", cbnedir.Text);
            guncelle.Parameters.AddWithValue("@markası", txtmarka.Text);
            guncelle.Parameters.AddWithValue("@gonderıldı", Convert.ToDateTime(datetarih.Text));
            guncelle.Parameters.AddWithValue("@siparis", cbsıparıs.Text);
            guncelle.Parameters.AddWithValue("@elimizde", cbelimizde.Text);

            guncelle.ExecuteNonQuery();
            baglan.Close();
            DialogResult onay; onay = MessageBox.Show
                ("GÖNDERİLEN GÜNCELLENDİ ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                gönderilenlistele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbhangıbolum.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtgonderilenad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbnedir.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtmarka.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            datetarih.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbsıparıs.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbelimizde.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }



        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void worddeaktar_Click(object sender, EventArgs e)
        {
            //BURDA FORMUN İÇİNDEKİ TEXTBOX, COMBOBOX İÇİNE YAZILANLARI WORDDE AKTARIYOR
            wordeaktar.Application wordapp = new wordeaktar.Application();
            wordapp.Visible = true;
            wordeaktar.Document worddoc;
            object wordobj = System.Reflection.Missing.Value;
            worddoc = wordapp.Documents.Add(ref wordobj);
            wordapp.Selection.TypeText(txtıd.Text);
            wordapp.Selection.TypeText(cbhangıbolum.Text);
            wordapp.Selection.TypeText(txtgonderilenad.Text);
            wordapp.Selection.TypeText(cbnedir.Text);
            wordapp.Selection.TypeText(txtmarka.Text);
            wordapp.Selection.TypeText(datetarih.Text);
            wordapp.Selection.TypeText(cbsıparıs.Text);
            wordapp.Selection.TypeText(cbelimizde.Text);
            wordapp = null;
        }

       

        }
    }


