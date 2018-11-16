using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITIRMEPROJESİİ_KUBRA_KOSE_160622090
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_bılgısayarekle_Click(object sender, EventArgs e)
        {
           
            bılgısayarekle frmgırıs = new bılgısayarekle();
            frmgırıs.Show();
            this.Hide();

        }

        private void btn_ıslemcıekle_Click(object sender, EventArgs e)
        {
            ıslemcıformu formıslem = new ıslemcıformu();
            formıslem.Show();
            this.Hide();
        }

        private void btn_yazıcıekle_Click(object sender, EventArgs e)
        {
            YAZICI frmyazıcı = new YAZICI();
         
            frmyazıcı.Show();
            this.Hide();
        }

        private void btn_sabıtdiskekle_Click(object sender, EventArgs e)
        {
            sabit frmsabit = new sabit();
            frmsabit.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_anakartekle_Click(object sender, EventArgs e)
        {
            anakart frmanakart = new anakart();
            frmanakart.Show();
            this.Hide();
        }

        private void btn_ramekle_Click(object sender, EventArgs e)
        {
            ram frmram = new ram();
            frmram.Show();
            this.Hide();

        }

        private void btn_kasaekle_Click(object sender, EventArgs e)
        {
            kasa frmkasa = new kasa();
            frmkasa.Show();
            this.Hide();
        }

        private void btn_klavyeekle_Click(object sender, EventArgs e)
        {
            klavye frmklavye = new klavye();
            frmklavye.Show();
            this.Hide();
        }

        private void btn_gonderılen_Click(object sender, EventArgs e)
        {
            gönderilen frmgonderilen = new gönderilen();
            frmgonderilen.Show();
            this.Hide();
        }

        private void btn_ekrankartı_Click(object sender, EventArgs e)
        {
            ekrankartı frmekrankartı = new ekrankartı();
            frmekrankartı.Show();
            this.Hide();
        }

       

        private void btn_alınan_Click(object sender, EventArgs e)
        {
            alınan frmalınan = new alınan();
            frmalınan.Show();
            this.Hide();
        }
    }
}
