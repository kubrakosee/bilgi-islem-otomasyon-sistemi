namespace BITIRMEPROJESİİ_KUBRA_KOSE_160622090
{
    partial class klavye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(klavye));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.txttur = new System.Windows.Forms.TextBox();
            this.cbalındı = new System.Windows.Forms.ComboBox();
            this.datetarih = new System.Windows.Forms.DateTimePicker();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sıl = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btn_anasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add-circle-green-128.png");
            this.ımageList1.Images.SetKeyName(1, "Dialog-error.svg.png");
            this.ımageList1.Images.SetKeyName(2, "ISync_icon.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(523, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 215);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "KLAVYE ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "KLAVYE TÜRÜ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "NERDEN GELDİ-ALINDI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "TARİH:";
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(176, 35);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(200, 22);
            this.txtıd.TabIndex = 24;
            // 
            // txttur
            // 
            this.txttur.Location = new System.Drawing.Point(176, 95);
            this.txttur.Name = "txttur";
            this.txttur.Size = new System.Drawing.Size(200, 22);
            this.txttur.TabIndex = 25;
            // 
            // cbalındı
            // 
            this.cbalındı.FormattingEnabled = true;
            this.cbalındı.Items.AddRange(new object[] {
            "İNTERNETTEN SİPARİŞ EDİLDİ",
            "İŞYERİNDEN GELDİ"});
            this.cbalındı.Location = new System.Drawing.Point(176, 145);
            this.cbalındı.Name = "cbalındı";
            this.cbalındı.Size = new System.Drawing.Size(200, 24);
            this.cbalındı.TabIndex = 26;
            // 
            // datetarih
            // 
            this.datetarih.Location = new System.Drawing.Point(176, 195);
            this.datetarih.Name = "datetarih";
            this.datetarih.Size = new System.Drawing.Size(200, 22);
            this.datetarih.TabIndex = 27;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ekle.ImageKey = "add-circle-green-128.png";
            this.btn_ekle.ImageList = this.ımageList1;
            this.btn_ekle.Location = new System.Drawing.Point(9, 297);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(134, 103);
            this.btn_ekle.TabIndex = 30;
            this.btn_ekle.Text = "KLAVYE EKLE";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sıl
            // 
            this.btn_sıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sıl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sıl.ImageKey = "Dialog-error.svg.png";
            this.btn_sıl.ImageList = this.ımageList1;
            this.btn_sıl.Location = new System.Drawing.Point(178, 297);
            this.btn_sıl.Name = "btn_sıl";
            this.btn_sıl.Size = new System.Drawing.Size(134, 103);
            this.btn_sıl.TabIndex = 31;
            this.btn_sıl.Text = "KLAVYE SİL";
            this.btn_sıl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sıl.UseVisualStyleBackColor = true;
            this.btn_sıl.Click += new System.EventHandler(this.btn_sıl_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guncelle.ImageKey = "ISync_icon.png";
            this.btn_guncelle.ImageList = this.ımageList1;
            this.btn_guncelle.Location = new System.Drawing.Point(344, 297);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(134, 103);
            this.btn_guncelle.TabIndex = 32;
            this.btn_guncelle.Text = "KLAVYE GÜNCELLE";
            this.btn_guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_sıl);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.datetarih);
            this.groupBox1.Controls.Add(this.cbalındı);
            this.groupBox1.Controls.Add(this.txttur);
            this.groupBox1.Controls.Add(this.txtıd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.btn_anasayfa.Location = new System.Drawing.Point(1362, 102);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(152, 120);
            this.btn_anasayfa.TabIndex = 19;
            this.btn_anasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // klavye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1795, 859);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "klavye";
            this.Text = "KLAVYE";
            this.Load += new System.EventHandler(this.klavye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.TextBox txttur;
        private System.Windows.Forms.ComboBox cbalındı;
        private System.Windows.Forms.DateTimePicker datetarih;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sıl;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button btn_anasayfa;
    }
}