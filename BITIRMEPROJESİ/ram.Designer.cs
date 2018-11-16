namespace BITIRMEPROJESİİ_KUBRA_KOSE_160622090
{
    partial class ram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ram));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.datetarih = new System.Windows.Forms.DateTimePicker();
            this.cbalındı = new System.Windows.Forms.ComboBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.cbramtipi = new System.Windows.Forms.ComboBox();
            this.cbramkapasite = new System.Windows.Forms.ComboBox();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.datetarih);
            this.groupBox1.Controls.Add(this.cbalındı);
            this.groupBox1.Controls.Add(this.txtmarka);
            this.groupBox1.Controls.Add(this.cbramtipi);
            this.groupBox1.Controls.Add(this.cbramkapasite);
            this.groupBox1.Controls.Add(this.txtıd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 586);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguncelle.ImageKey = "ISync_icon.png";
            this.btnguncelle.ImageList = this.ımageList1;
            this.btnguncelle.Location = new System.Drawing.Point(324, 431);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(139, 112);
            this.btnguncelle.TabIndex = 30;
            this.btnguncelle.Text = "RAM GÜNCELLE";
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
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sil.ImageKey = "Dialog-error.svg.png";
            this.btn_sil.ImageList = this.ımageList1;
            this.btn_sil.Location = new System.Drawing.Point(162, 431);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(139, 112);
            this.btn_sil.TabIndex = 29;
            this.btn_sil.Text = "RAM SİL";
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
            this.btn_ekle.Location = new System.Drawing.Point(9, 431);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(139, 112);
            this.btn_ekle.TabIndex = 28;
            this.btn_ekle.Text = "RAM EKLE";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // datetarih
            // 
            this.datetarih.Location = new System.Drawing.Point(171, 352);
            this.datetarih.Name = "datetarih";
            this.datetarih.Size = new System.Drawing.Size(200, 22);
            this.datetarih.TabIndex = 27;
            // 
            // cbalındı
            // 
            this.cbalındı.FormattingEnabled = true;
            this.cbalındı.Items.AddRange(new object[] {
            "Bilgisayarın İçinden Alındı",
            "İnternetten Sipariş Edildi"});
            this.cbalındı.Location = new System.Drawing.Point(171, 297);
            this.cbalındı.Name = "cbalındı";
            this.cbalındı.Size = new System.Drawing.Size(200, 24);
            this.cbalındı.TabIndex = 26;
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(171, 238);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(200, 22);
            this.txtmarka.TabIndex = 25;
            // 
            // cbramtipi
            // 
            this.cbramtipi.FormattingEnabled = true;
            this.cbramtipi.Items.AddRange(new object[] {
            "DDR1",
            "DDR2 ",
            "DDR3",
            "DDR4",
            ""});
            this.cbramtipi.Location = new System.Drawing.Point(171, 170);
            this.cbramtipi.Name = "cbramtipi";
            this.cbramtipi.Size = new System.Drawing.Size(200, 24);
            this.cbramtipi.TabIndex = 24;
            // 
            // cbramkapasite
            // 
            this.cbramkapasite.FormattingEnabled = true;
            this.cbramkapasite.Items.AddRange(new object[] {
            "1 GB",
            "2 GB",
            "4GB",
            "8GB",
            "12GB"});
            this.cbramkapasite.Location = new System.Drawing.Point(171, 104);
            this.cbramkapasite.Name = "cbramkapasite";
            this.cbramkapasite.Size = new System.Drawing.Size(200, 24);
            this.cbramkapasite.TabIndex = 23;
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(162, 41);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(209, 22);
            this.txtıd.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "TARİH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ALINDI -ÇIKARILDI MI?:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "MARKA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "RAM TİPİ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAM KAPASİTESİ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAM ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(543, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 213);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "Home_Button_(1).png");
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anasayfa.ImageKey = "Home_Button_(1).png";
            this.btn_anasayfa.ImageList = this.ımageList2;
            this.btn_anasayfa.Location = new System.Drawing.Point(1367, 86);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(152, 120);
            this.btn_anasayfa.TabIndex = 17;
            this.btn_anasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // ram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1914, 723);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ram";
            this.Text = "RAM";
            this.Load += new System.EventHandler(this.ram_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datetarih;
        private System.Windows.Forms.ComboBox cbalındı;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.ComboBox cbramtipi;
        private System.Windows.Forms.ComboBox cbramkapasite;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button btn_anasayfa;
    }
}