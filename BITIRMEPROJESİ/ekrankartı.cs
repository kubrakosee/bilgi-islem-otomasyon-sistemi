﻿using System;
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
    public partial class ekrankartı : Form
    {
        public ekrankartı()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=EBRUPC\SQLEXPRESS;Initial Catalog=kubraa;Integrated Security=True");
        public void ekrankartılistele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from ekrankartı", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand
    ("insert into ekrankartı (chipset,bitd,ekrankartıbellek,alındı,tarih)values(@chipset,@bitd,@ekrankartıbellek,@alındı,@tarih)", baglan);
            ekle.Parameters.AddWithValue("@chipset", txtchıp.Text);
            ekle.Parameters.AddWithValue("@bitd", txtbıt.Text);
            ekle.Parameters.AddWithValue("@ekrankartıbellek",txtbellek.Text);
            ekle.Parameters.AddWithValue("@alındı",cbalındı.Text);
            ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(datetarih.Text));

            ekle.ExecuteNonQuery();
            baglan.Close();
            DialogResult onay; onay = MessageBox.Show
                ("EKRAN KARTI EKLENDİ ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                ekrankartılistele();
        }

        private void btn_sıl_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sl = new SqlCommand("delete from ekrankartı where id=@id", baglan);
            sl.Parameters.AddWithValue("@id", txtıd.Text);
            sl.ExecuteNonQuery();
            baglan.Close();
            DialogResult onay; onay = MessageBox.Show
                ("KLAVYE SİLİNİYOR ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                ekrankartılistele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand guncel = new SqlCommand
            ("update set ekrankartı chipset=@chipset,bitd@bitd,ekrankartıbellek=@ekrankartıbellek,alındı=@alındı,tarih=@tarih where id=@id", baglan);
            guncel.Parameters.AddWithValue("@id", txtıd.Text);
            guncel.Parameters.AddWithValue("@chipset", txtchıp.Text);
            guncel.Parameters.AddWithValue("@bitd", txtbıt.Text);
            guncel.Parameters.AddWithValue("@ekrankartıbellek", txtbellek.Text);
            guncel.Parameters.AddWithValue("@alındı", cbalındı.Text);
            guncel.Parameters.AddWithValue("@tarih", Convert.ToDateTime(datetarih.Text));

            guncel.ExecuteNonQuery();
            baglan.Close();
            DialogResult onay; onay = MessageBox.Show
               ("KASA GÜNCELLENDİ ONAYLIYOR MUSUN?", "Onay Kutusu", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
                ekrankartılistele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtchıp.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbıt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbellek.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbalındı.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            datetarih.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void ekrankartı_Load(object sender, EventArgs e)
        {
            ekrankartılistele();
        }

       
    }
}
