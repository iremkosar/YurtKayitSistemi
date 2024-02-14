namespace YurtKayitSistemi
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderİstatistikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirİstatistikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erişimKolaylığıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayitDataSet1 = new YurtKayitSistemi.YurtKayitDataSet1();
            this.ogrenciTableAdapter = new YurtKayitSistemi.YurtKayitDataSet1TableAdapters.OgrenciTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrencilerToolStripMenuItem,
            this.bölümlerToolStripMenuItem,
            this.ödemelerToolStripMenuItem,
            this.giderlerToolStripMenuItem,
            this.istatistiklerToolStripMenuItem,
            this.yöneticiToolStripMenuItem,
            this.erişimKolaylığıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1189, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğrenciListesiToolStripMenuItem,
            this.öğrenciDüzenleToolStripMenuItem});
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            this.öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            this.öğrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.öğrenciListesiToolStripMenuItem.Text = "Öğrenci Listesi";
            this.öğrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListesiToolStripMenuItem_Click);
            // 
            // öğrenciDüzenleToolStripMenuItem
            // 
            this.öğrenciDüzenleToolStripMenuItem.Name = "öğrenciDüzenleToolStripMenuItem";
            this.öğrenciDüzenleToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.öğrenciDüzenleToolStripMenuItem.Text = "Öğrenci Sil";
            this.öğrenciDüzenleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciDüzenleToolStripMenuItem_Click);
            // 
            // bölümlerToolStripMenuItem
            // 
            this.bölümlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümEkleToolStripMenuItem,
            this.bölümDüzenleToolStripMenuItem});
            this.bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            this.bölümlerToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.bölümlerToolStripMenuItem.Text = "Bölümler";
            // 
            // bölümEkleToolStripMenuItem
            // 
            this.bölümEkleToolStripMenuItem.Name = "bölümEkleToolStripMenuItem";
            this.bölümEkleToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.bölümEkleToolStripMenuItem.Text = "Bölüm Ekle";
            this.bölümEkleToolStripMenuItem.Click += new System.EventHandler(this.bölümEkleToolStripMenuItem_Click);
            // 
            // bölümDüzenleToolStripMenuItem
            // 
            this.bölümDüzenleToolStripMenuItem.Name = "bölümDüzenleToolStripMenuItem";
            this.bölümDüzenleToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.bölümDüzenleToolStripMenuItem.Text = "Bölüm Düzenle";
            this.bölümDüzenleToolStripMenuItem.Click += new System.EventHandler(this.bölümDüzenleToolStripMenuItem_Click);
            // 
            // ödemelerToolStripMenuItem
            // 
            this.ödemelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borçlarToolStripMenuItem});
            this.ödemelerToolStripMenuItem.Name = "ödemelerToolStripMenuItem";
            this.ödemelerToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.ödemelerToolStripMenuItem.Text = "Ödemeler";
            // 
            // borçlarToolStripMenuItem
            // 
            this.borçlarToolStripMenuItem.Name = "borçlarToolStripMenuItem";
            this.borçlarToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.borçlarToolStripMenuItem.Text = "Ödeme Al";
            this.borçlarToolStripMenuItem.Click += new System.EventHandler(this.borçlarToolStripMenuItem_Click);
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem,
            this.giderİstatistikleriToolStripMenuItem});
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.gToolStripMenuItem.Text = "Gider Ekle";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // giderİstatistikleriToolStripMenuItem
            // 
            this.giderİstatistikleriToolStripMenuItem.Name = "giderİstatistikleriToolStripMenuItem";
            this.giderİstatistikleriToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.giderİstatistikleriToolStripMenuItem.Text = "Gider Listesi";
            this.giderİstatistikleriToolStripMenuItem.Click += new System.EventHandler(this.giderİstatistikleriToolStripMenuItem_Click);
            // 
            // istatistiklerToolStripMenuItem
            // 
            this.istatistiklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirİstatistikleriToolStripMenuItem});
            this.istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            this.istatistiklerToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.istatistiklerToolStripMenuItem.Text = "İstatistikler";
            // 
            // gelirİstatistikleriToolStripMenuItem
            // 
            this.gelirİstatistikleriToolStripMenuItem.Name = "gelirİstatistikleriToolStripMenuItem";
            this.gelirİstatistikleriToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.gelirİstatistikleriToolStripMenuItem.Text = "Gelir İstatistikleri";
            this.gelirİstatistikleriToolStripMenuItem.Click += new System.EventHandler(this.gelirİstatistikleriToolStripMenuItem_Click);
            // 
            // yöneticiToolStripMenuItem
            // 
            this.yöneticiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreİşlemleriToolStripMenuItem,
            this.personelDüzenleToolStripMenuItem,
            this.notEkleToolStripMenuItem});
            this.yöneticiToolStripMenuItem.Name = "yöneticiToolStripMenuItem";
            this.yöneticiToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.yöneticiToolStripMenuItem.Text = "Yönetici";
            // 
            // şifreİşlemleriToolStripMenuItem
            // 
            this.şifreİşlemleriToolStripMenuItem.Name = "şifreİşlemleriToolStripMenuItem";
            this.şifreİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.şifreİşlemleriToolStripMenuItem.Text = "Şifre İşlemleri";
            this.şifreİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.şifreİşlemleriToolStripMenuItem_Click);
            // 
            // personelDüzenleToolStripMenuItem
            // 
            this.personelDüzenleToolStripMenuItem.Name = "personelDüzenleToolStripMenuItem";
            this.personelDüzenleToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.personelDüzenleToolStripMenuItem.Text = "Personel Düzenle";
            this.personelDüzenleToolStripMenuItem.Click += new System.EventHandler(this.personelDüzenleToolStripMenuItem_Click);
            // 
            // notEkleToolStripMenuItem
            // 
            this.notEkleToolStripMenuItem.Name = "notEkleToolStripMenuItem";
            this.notEkleToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.notEkleToolStripMenuItem.Text = "Not Ekle";
            this.notEkleToolStripMenuItem.Click += new System.EventHandler(this.notEkleToolStripMenuItem_Click);
            // 
            // erişimKolaylığıToolStripMenuItem
            // 
            this.erişimKolaylığıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinasıToolStripMenuItem,
            this.paintToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.erişimKolaylığıToolStripMenuItem.Name = "erişimKolaylığıToolStripMenuItem";
            this.erişimKolaylığıToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.erişimKolaylığıToolStripMenuItem.Text = "Erişim Kolaylığı";
            // 
            // hesapMakinasıToolStripMenuItem
            // 
            this.hesapMakinasıToolStripMenuItem.Name = "hesapMakinasıToolStripMenuItem";
            this.hesapMakinasıToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.hesapMakinasıToolStripMenuItem.Text = "Hesap Makinası";
            this.hesapMakinasıToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinasıToolStripMenuItem_Click);
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.paintToolStripMenuItem.Text = "Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.paintToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrOdaNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 390);
            this.dataGridView1.TabIndex = 1;
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogridDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrOdaNoDataGridViewTextBoxColumn
            // 
            this.ogrOdaNoDataGridViewTextBoxColumn.DataPropertyName = "OgrOdaNo";
            this.ogrOdaNoDataGridViewTextBoxColumn.HeaderText = "OgrOdaNo";
            this.ogrOdaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrOdaNoDataGridViewTextBoxColumn.Name = "ogrOdaNoDataGridViewTextBoxColumn";
            this.ogrOdaNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtKayitDataSet1;
            // 
            // yurtKayitDataSet1
            // 
            this.yurtKayitDataSet1.DataSetName = "YurtKayitDataSet1";
            this.yurtKayitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(689, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(752, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1189, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderİstatistikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirİstatistikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erişimKolaylığıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayitDataSet1 yurtKayitDataSet1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtKayitDataSet1TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem notEkleToolStripMenuItem;
    }
}