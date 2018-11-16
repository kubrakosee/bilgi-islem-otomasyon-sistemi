namespace BITIRMEPROJESİİ_KUBRA_KOSE_160622090
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_yenıkullanıcı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_yenısifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_gırıs = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vineta BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "MİSAFİR GİRİŞİ";
            this.label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(489, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txt_yenıkullanıcı
            // 
            this.txt_yenıkullanıcı.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txt_yenıkullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yenıkullanıcı.Location = new System.Drawing.Point(633, 457);
            this.txt_yenıkullanıcı.Name = "txt_yenıkullanıcı";
            this.txt_yenıkullanıcı.Size = new System.Drawing.Size(207, 22);
            this.txt_yenıkullanıcı.TabIndex = 13;
            this.txt_yenıkullanıcı.UseWaitCursor = true;
            this.txt_yenıkullanıcı.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_yenıkullanıcı_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(492, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "ŞİFRE:";
            this.label3.UseWaitCursor = true;
            // 
            // txt_yenısifre
            // 
            this.txt_yenısifre.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txt_yenısifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.txt_yenısifre.Location = new System.Drawing.Point(633, 494);
            this.txt_yenısifre.Name = "txt_yenısifre";
            this.txt_yenısifre.PasswordChar = '*';
            this.txt_yenısifre.Size = new System.Drawing.Size(207, 22);
            this.txt_yenısifre.TabIndex = 16;
            this.txt_yenısifre.UseWaitCursor = true;
            this.txt_yenısifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_yenısifre_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(464, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "KULLANICI ADI:";
            this.label2.UseWaitCursor = true;
            // 
            // btn_gırıs
            // 
            this.btn_gırıs.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_gırıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gırıs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_gırıs.ImageKey = "add_user (1).ico";
            this.btn_gırıs.ImageList = this.ımageList1;
            this.btn_gırıs.Location = new System.Drawing.Point(633, 565);
            this.btn_gırıs.Name = "btn_gırıs";
            this.btn_gırıs.Size = new System.Drawing.Size(139, 91);
            this.btn_gırıs.TabIndex = 17;
            this.btn_gırıs.Text = "Giriş";
            this.btn_gırıs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_gırıs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_gırıs.UseVisualStyleBackColor = false;
            this.btn_gırıs.UseWaitCursor = true;
            this.btn_gırıs.Click += new System.EventHandler(this.btn_gırıs_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add_user (1).ico");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1462, 731);
            this.Controls.Add(this.btn_gırıs);
            this.Controls.Add(this.txt_yenıkullanıcı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_yenısifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_yenıkullanıcı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_yenısifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_gırıs;
        private System.Windows.Forms.ImageList ımageList1;
    }
}