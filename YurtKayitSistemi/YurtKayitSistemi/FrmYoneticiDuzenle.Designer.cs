namespace YurtKayitSistemi
{
    partial class FrmYoneticiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYoneticiDuzenle));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yoneticiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayitDataSet7 = new YurtKayitSistemi.YurtKayitDataSet7();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtYoneticiid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminTableAdapter = new YurtKayitSistemi.YurtKayitDataSet7TableAdapters.AdminTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yoneticiidDataGridViewTextBoxColumn,
            this.yoneticiAdDataGridViewTextBoxColumn,
            this.yoneticiSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(561, 150);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yoneticiidDataGridViewTextBoxColumn
            // 
            this.yoneticiidDataGridViewTextBoxColumn.DataPropertyName = "Yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.HeaderText = "Yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiidDataGridViewTextBoxColumn.Name = "yoneticiidDataGridViewTextBoxColumn";
            this.yoneticiidDataGridViewTextBoxColumn.ReadOnly = true;
            this.yoneticiidDataGridViewTextBoxColumn.Width = 125;
            // 
            // yoneticiAdDataGridViewTextBoxColumn
            // 
            this.yoneticiAdDataGridViewTextBoxColumn.DataPropertyName = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.HeaderText = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiAdDataGridViewTextBoxColumn.Name = "yoneticiAdDataGridViewTextBoxColumn";
            this.yoneticiAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // yoneticiSifreDataGridViewTextBoxColumn
            // 
            this.yoneticiSifreDataGridViewTextBoxColumn.DataPropertyName = "YoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.HeaderText = "YoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiSifreDataGridViewTextBoxColumn.Name = "yoneticiSifreDataGridViewTextBoxColumn";
            this.yoneticiSifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.yurtKayitDataSet7;
            // 
            // yurtKayitDataSet7
            // 
            this.yurtKayitDataSet7.DataSetName = "YurtKayitDataSet7";
            this.yurtKayitDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(512, 189);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(163, 37);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(343, 189);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(163, 37);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(174, 189);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(163, 37);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.OldLace;
            this.txtSifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(307, 135);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(270, 30);
            this.txtSifre.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(239, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifre :";
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.BackColor = System.Drawing.Color.OldLace;
            this.TxtKullaniciAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAd.Location = new System.Drawing.Point(307, 85);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Size = new System.Drawing.Size(270, 30);
            this.TxtKullaniciAd.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(178, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kullanıcı Ad :";
            // 
            // TxtYoneticiid
            // 
            this.TxtYoneticiid.BackColor = System.Drawing.Color.OldLace;
            this.TxtYoneticiid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYoneticiid.Location = new System.Drawing.Point(307, 40);
            this.TxtYoneticiid.Name = "TxtYoneticiid";
            this.TxtYoneticiid.Size = new System.Drawing.Size(270, 30);
            this.TxtYoneticiid.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(178, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Yönetici id :";
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // FrmYoneticiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtYoneticiid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYoneticiDuzenle";
            this.Text = "Yönetici İşlemleri";
            this.Load += new System.EventHandler(this.FrmYoneticiDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKullaniciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtYoneticiid;
        private System.Windows.Forms.Label label1;
        private YurtKayitDataSet7 yurtKayitDataSet7;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private YurtKayitDataSet7TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSifreDataGridViewTextBoxColumn;
    }
}