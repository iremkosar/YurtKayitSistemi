namespace YurtKayitSistemi
{
    partial class FrmOdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeler));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOgrid = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxtOdenen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnOdemeAl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrKalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayitDataSet2 = new YurtKayitSistemi.YurtKayitDataSet2();
            this.borclarTableAdapter = new YurtKayitSistemi.YurtKayitDataSet2TableAdapters.BorclarTableAdapter();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtOdenenAy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci id :";
            // 
            // TxtOgrid
            // 
            this.TxtOgrid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrid.Location = new System.Drawing.Point(149, 22);
            this.TxtOgrid.Name = "TxtOgrid";
            this.TxtOgrid.Size = new System.Drawing.Size(205, 30);
            this.TxtOgrid.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TxtOdenen
            // 
            this.TxtOdenen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOdenen.Location = new System.Drawing.Point(149, 153);
            this.TxtOdenen.Name = "TxtOdenen";
            this.TxtOdenen.Size = new System.Drawing.Size(205, 30);
            this.TxtOdenen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ödenen :";
            // 
            // TxtKalan
            // 
            this.TxtKalan.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKalan.Location = new System.Drawing.Point(149, 202);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(205, 30);
            this.TxtKalan.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kalan Borç :";
            // 
            // BtnOdemeAl
            // 
            this.BtnOdemeAl.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdemeAl.Location = new System.Drawing.Point(191, 299);
            this.BtnOdemeAl.Name = "BtnOdemeAl";
            this.BtnOdemeAl.Size = new System.Drawing.Size(111, 29);
            this.BtnOdemeAl.TabIndex = 7;
            this.BtnOdemeAl.Text = "Ödeme Al";
            this.BtnOdemeAl.UseVisualStyleBackColor = true;
            this.BtnOdemeAl.Click += new System.EventHandler(this.BtnOdemeAl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrKalanBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borclarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(426, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(697, 282);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
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
            // ogrKalanBorcDataGridViewTextBoxColumn
            // 
            this.ogrKalanBorcDataGridViewTextBoxColumn.DataPropertyName = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.HeaderText = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrKalanBorcDataGridViewTextBoxColumn.Name = "ogrKalanBorcDataGridViewTextBoxColumn";
            this.ogrKalanBorcDataGridViewTextBoxColumn.Width = 125;
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "Borclar";
            this.borclarBindingSource.DataSource = this.yurtKayitDataSet2;
            // 
            // yurtKayitDataSet2
            // 
            this.yurtKayitDataSet2.DataSetName = "YurtKayitDataSet2";
            this.yurtKayitDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(149, 68);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(205, 30);
            this.TxtAd.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(100, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ad :";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(149, 113);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(205, 30);
            this.TxtSoyad.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(74, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Soyad :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtOdenenAy
            // 
            this.TxtOdenenAy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOdenenAy.Location = new System.Drawing.Point(149, 250);
            this.TxtOdenenAy.Name = "TxtOdenenAy";
            this.TxtOdenenAy.Size = new System.Drawing.Size(205, 30);
            this.TxtOdenenAy.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(34, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ödenen Ay :";
            // 
            // FrmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1135, 340);
            this.Controls.Add(this.TxtOdenenAy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnOdemeAl);
            this.Controls.Add(this.TxtKalan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOdenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOgrid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdemeler";
            this.Text = "Ödemeler";
            this.Load += new System.EventHandler(this.FrmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOgrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TxtOdenen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnOdemeAl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayitDataSet2 yurtKayitDataSet2;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private YurtKayitDataSet2TableAdapters.BorclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtOdenenAy;
        private System.Windows.Forms.Label label6;
    }
}