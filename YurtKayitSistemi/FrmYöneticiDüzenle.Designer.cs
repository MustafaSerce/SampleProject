namespace YurtKayitSistemi
{
    partial class FrmYöneticiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYöneticiDüzenle));
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullanıcıAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYöneticiid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtKayıtDataSet5 = new YurtKayitSistemi.YurtKayıtDataSet5();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new YurtKayitSistemi.YurtKayıtDataSet5TableAdapters.AdminTableAdapter();
            this.yöneticiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yöneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yöneticiSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picYöneticiSil = new System.Windows.Forms.PictureBox();
            this.picYöneticiEkle = new System.Windows.Forms.PictureBox();
            this.picYöneticiGüncelle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYöneticiSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYöneticiEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYöneticiGüncelle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(122, 94);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(152, 29);
            this.txtSifre.TabIndex = 8;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre :";
            // 
            // txtKullanıcıAdi
            // 
            this.txtKullanıcıAdi.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAdi.Location = new System.Drawing.Point(122, 52);
            this.txtKullanıcıAdi.Name = "txtKullanıcıAdi";
            this.txtKullanıcıAdi.Size = new System.Drawing.Size(152, 29);
            this.txtKullanıcıAdi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txtYöneticiid
            // 
            this.txtYöneticiid.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYöneticiid.Location = new System.Drawing.Point(122, 12);
            this.txtYöneticiid.Name = "txtYöneticiid";
            this.txtYöneticiid.Size = new System.Drawing.Size(152, 29);
            this.txtYöneticiid.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yönetici ID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yöneticiidDataGridViewTextBoxColumn,
            this.yöneticiAdDataGridViewTextBoxColumn,
            this.yöneticiSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(426, 233);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurtKayıtDataSet5
            // 
            this.yurtKayıtDataSet5.DataSetName = "YurtKayıtDataSet5";
            this.yurtKayıtDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.yurtKayıtDataSet5;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // yöneticiidDataGridViewTextBoxColumn
            // 
            this.yöneticiidDataGridViewTextBoxColumn.DataPropertyName = "Yöneticiid";
            this.yöneticiidDataGridViewTextBoxColumn.HeaderText = "Yöneticiid";
            this.yöneticiidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yöneticiidDataGridViewTextBoxColumn.Name = "yöneticiidDataGridViewTextBoxColumn";
            this.yöneticiidDataGridViewTextBoxColumn.ReadOnly = true;
            this.yöneticiidDataGridViewTextBoxColumn.Width = 125;
            // 
            // yöneticiAdDataGridViewTextBoxColumn
            // 
            this.yöneticiAdDataGridViewTextBoxColumn.DataPropertyName = "YöneticiAd";
            this.yöneticiAdDataGridViewTextBoxColumn.HeaderText = "YöneticiAd";
            this.yöneticiAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yöneticiAdDataGridViewTextBoxColumn.Name = "yöneticiAdDataGridViewTextBoxColumn";
            this.yöneticiAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // yöneticiSifreDataGridViewTextBoxColumn
            // 
            this.yöneticiSifreDataGridViewTextBoxColumn.DataPropertyName = "YöneticiSifre";
            this.yöneticiSifreDataGridViewTextBoxColumn.HeaderText = "YöneticiSifre";
            this.yöneticiSifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yöneticiSifreDataGridViewTextBoxColumn.Name = "yöneticiSifreDataGridViewTextBoxColumn";
            this.yöneticiSifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // picYöneticiSil
            // 
            this.picYöneticiSil.Image = ((System.Drawing.Image)(resources.GetObject("picYöneticiSil.Image")));
            this.picYöneticiSil.Location = new System.Drawing.Point(313, 69);
            this.picYöneticiSil.Name = "picYöneticiSil";
            this.picYöneticiSil.Size = new System.Drawing.Size(81, 59);
            this.picYöneticiSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYöneticiSil.TabIndex = 14;
            this.picYöneticiSil.TabStop = false;
            this.picYöneticiSil.Click += new System.EventHandler(this.picYöneticiSil_Click);
            // 
            // picYöneticiEkle
            // 
            this.picYöneticiEkle.Image = ((System.Drawing.Image)(resources.GetObject("picYöneticiEkle.Image")));
            this.picYöneticiEkle.Location = new System.Drawing.Point(280, 12);
            this.picYöneticiEkle.Name = "picYöneticiEkle";
            this.picYöneticiEkle.Size = new System.Drawing.Size(75, 51);
            this.picYöneticiEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYöneticiEkle.TabIndex = 13;
            this.picYöneticiEkle.TabStop = false;
            this.picYöneticiEkle.Click += new System.EventHandler(this.picYöneticiEkle_Click);
            // 
            // picYöneticiGüncelle
            // 
            this.picYöneticiGüncelle.Image = ((System.Drawing.Image)(resources.GetObject("picYöneticiGüncelle.Image")));
            this.picYöneticiGüncelle.Location = new System.Drawing.Point(361, 12);
            this.picYöneticiGüncelle.Name = "picYöneticiGüncelle";
            this.picYöneticiGüncelle.Size = new System.Drawing.Size(75, 51);
            this.picYöneticiGüncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYöneticiGüncelle.TabIndex = 12;
            this.picYöneticiGüncelle.TabStop = false;
            this.picYöneticiGüncelle.Click += new System.EventHandler(this.picYöneticiGüncelle_Click);
            // 
            // FrmYöneticiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(439, 388);
            this.Controls.Add(this.picYöneticiSil);
            this.Controls.Add(this.picYöneticiEkle);
            this.Controls.Add(this.picYöneticiGüncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtYöneticiid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullanıcıAdi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYöneticiDüzenle";
            this.Text = "Yönetici Düzenleme";
            this.Load += new System.EventHandler(this.FrmYöneticiDüzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYöneticiSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYöneticiEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYöneticiGüncelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullanıcıAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYöneticiid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayıtDataSet5 yurtKayıtDataSet5;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private YurtKayıtDataSet5TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yöneticiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yöneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yöneticiSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox picYöneticiSil;
        private System.Windows.Forms.PictureBox picYöneticiEkle;
        private System.Windows.Forms.PictureBox picYöneticiGüncelle;
    }
}