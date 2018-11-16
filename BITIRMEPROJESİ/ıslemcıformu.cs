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
    public partial class ıslemcıformu : Form
    {
        public ıslemcıformu()
        {
            InitializeComponent();
        }
        public void islemcılistele()
        {
            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from ıslemcı", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglantı.Close();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=EBRUPC\SQLEXPRESS;Initial Catalog=kubraa;Integrated Security=True");

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand
            ("insert into ıslemcı(hangıbılgısayardancıktı,hangıtarıh,nezamanınternetalındı,ıslemcımarkası)values(@hangıbılgısayardancıktı,@hangıtarıh,@nezamanınternetalındı,@ıslemcımarkası)", baglantı);
            ekle.Parameters.AddWithValue("@hangıbılgısayardancıktı", txthangıbılgısayar.Text);
            ekle.Parameters.AddWithValue("@hangıtarıh", Convert.ToDateTime(dateTimehangıtarih.Text));
            ekle.Parameters.AddWithValue("@nezamanınternetalındı", Convert.ToDateTime(dateTimealındı.Text));
            ekle.Parameters.AddWithValue("@ıslemcımarkası",txtmarkası.Text);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            DialogResult onay; onay = MessageBox.Show
                ("İŞLEMCİ EKLENDİ ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            islemcılistele();
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txthangıbılgısayar.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimehangıtarih.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimealındı.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtmarkası.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btn_sıl_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand sl = new SqlCommand("delete from ıslemcı where id=@id",baglantı);
            sl.Parameters.AddWithValue("@id",txtıd.Text);
            sl.ExecuteNonQuery();
            baglantı.Close();
            
            DialogResult onay; onay = MessageBox.Show
                ("İŞLEMCİ SİLİNİYOR  ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                islemcılistele();
           
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand gn = new SqlCommand
("update set ıslemcı hangıbılgısayardancıktı=@hangıbılgısayardancıktı,hangıtarıh=@hangıtarıh,nezamanınternetalındı=@nezamanınternetalındı,ıslemcımarkası=@ıslemcımarkası where id=@id ",baglantı);
            gn.Parameters.AddWithValue("@id",txtıd.Text);
            gn.Parameters.AddWithValue("@hangıbılgısayardancıktı",txthangıbılgısayar.Text);
            gn.Parameters.AddWithValue("@hangıtarıh",Convert.ToDateTime(dateTimehangıtarih.Text));
            gn.Parameters.AddWithValue("@nezamanınternetalındı",Convert.ToDateTime(dateTimealındı.Text));
            gn.Parameters.AddWithValue("@ıslemcımarkası",txtmarkası.Text);
            gn.ExecuteNonQuery();
            
            baglantı.Close();
            DialogResult onay; onay = MessageBox.Show
               ("İŞLEMCİ GÜNCELLENİYOR ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            islemcılistele();

        }

        private void ıslemcıformu_Load(object sender, EventArgs e)
        {
            islemcılistele();
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