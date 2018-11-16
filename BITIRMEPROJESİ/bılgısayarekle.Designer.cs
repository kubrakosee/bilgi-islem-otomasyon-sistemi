namespace BITIRMEPROJESİİ_KUBRA_KOSE_160622090
{
    partial class bılgısayarekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bılgısayarekle));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.cbbolum = new System.Windows.Forms.ComboBox();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.txtsıfre = new System.Windows.Forms.TextBox();
            this.txtkım = new System.Windows.Forms.TextBox();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bilgisayarekleTableAdapter1 = new BITIRMEPROJESİİ_KUBRA_KOSE_160622090.kubraaDataSetTableAdapters.bilgisayarekleTableAdapter();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.cbbolum);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.txtsıfre);
            this.groupBox1.Controls.Add(this.txtkım);
            this.groupBox1.Controls.Add(this.txtıd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 531);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguncelle.ImageKey = "ISync_icon.png";
            this.btnguncelle.ImageList = this.ımageList1;
            this.btnguncelle.Location = new System.Drawing.Point(314, 361);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(134, 103);
            this.btnguncelle.TabIndex = 13;
            this.btnguncelle.Text = "BİLGİSAYAR GÜNCELLE";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add-circle-green-128.png");
            this.ımageList1.Images.SetKeyName(1, "Dialog-error.svg.png");
            this.ımageList1.Images.SetKeyName(2, "ISync_icon.png");
            this.ımageList1.Images.SetKeyName(3, "red-home-icon.png");
            this.ımageList1.Images.SetKeyName(4, "Home_Button_(1).png");
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sil.ImageKey = "Dialog-error.svg.png";
            this.btn_sil.ImageList = this.ımageList1;
            this.btn_sil.Location = new System.Drawing.Point(176, 361);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(134, 103);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "BİLGİSAYAR SİL";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ekle.ImageKey = "add-circle-green-128.png";
            this.btn_ekle.ImageList = this.ımageList1;
            this.btn_ekle.Location = new System.Drawing.Point(33, 361);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(134, 103);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "BİLGİSAYAR EKLE";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // cbbolum
            // 
            this.cbbolum.FormattingEnabled = true;
            this.cbbolum.Items.AddRange(new object[] {
            "KEÇE HATTI",
            "MUHASEBE",
            "ALIM SATIM",
            "SATIN ALMA",
            "BOYAHANE",
            "İDARİ "});
            this.cbbolum.Location = new System.Drawing.Point(194, 197);
            this.cbbolum.Name = "cbbolum";
            this.cbbolum.Size = new System.Drawing.Size(163, 24);
            this.cbbolum.TabIndex = 10;
            this.cbbolum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbolum_KeyDown);
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(176, 259);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(200, 22);
            this.dttarih.TabIndex = 9;
            // 
            // txtsıfre
            // 
            this.txtsıfre.Location = new System.Drawing.Point(194, 145);
            this.txtsıfre.Name = "txtsıfre";
            this.txtsıfre.Size = new System.Drawing.Size(163, 22);
            this.txtsıfre.TabIndex = 7;
            this.txtsıfre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsıfre_KeyDown);
            // 
            // txtkım
            // 
            this.txtkım.Location = new System.Drawing.Point(194, 88);
            this.txtkım.Name = "txtkım";
            this.txtkım.Size = new System.Drawing.Size(163, 22);
            this.txtkım.TabIndex = 6;
            this.txtkım.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkım_KeyDown);
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(194, 32);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(163, 22);
            this.txtıd.TabIndex = 5;
            this.txtıd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtıd_KeyDown);
            this.txtıd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtıd_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "TARİH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "BİLGİSAYAR ŞİFRESİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "HANGİ BÖLÜMDEN GELDİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "KİME AİT BİLGİSAYAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "BİLGİSAYAR ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 339);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bilgisayarekleTableAdapter1
            // 
            this.bilgisayarekleTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anasayfa.ImageKey = "Home_Button_(1).png";
            this.btn_anasayfa.ImageList = this.ımageList2;
            this.btn_anasayfa.Location = new System.Drawing.Point(1272, 143);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(152, 120);
            this.btn_anasayfa.TabIndex = 15;
            this.btn_anasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "Home_Button_(1).png");
            // 
            // bılgısayarekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1718, 693);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bılgısayarekle";
            this.Text = "BİLGİSAYAR";
            this.Load += new System.EventHandler(this.bılgısayarekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ComboBox cbbolum;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.TextBox txtsıfre;
        private System.Windows.Forms.TextBox txtkım;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList1;
        private kubraaDataSetTableAdapters.bilgisayarekleTableAdapter bilgisayarekleTableAdapter1;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.ImageList ımageList2;
    }
}