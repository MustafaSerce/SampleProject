namespace YurtKayitSistemi
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.picPersonelSil = new System.Windows.Forms.PictureBox();
            this.picPersonelEkle = new System.Windows.Forms.PictureBox();
            this.picPersoneliGüncelle = new System.Windows.Forms.PictureBox();
            this.txtPersonelid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonelGörev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtKayıtDataSet6 = new YurtKayitSistemi.YurtKayıtDataSet6();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new YurtKayitSistemi.YurtKayıtDataSet6TableAdapters.PersonelTableAdapter();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonelSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonelEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersoneliGüncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // picPersonelSil
            // 
            this.picPersonelSil.Image = ((System.Drawing.Image)(resources.GetObject("picPersonelSil.Image")));
            this.picPersonelSil.Location = new System.Drawing.Point(357, 78);
            this.picPersonelSil.Name = "picPersonelSil";
            this.picPersonelSil.Size = new System.Drawing.Size(81, 59);
            this.picPersonelSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonelSil.TabIndex = 23;
            this.picPersonelSil.TabStop = false;
            this.picPersonelSil.Click += new System.EventHandler(this.picPersonelSil_Click);
            // 
            // picPersonelEkle
            // 
            this.picPersonelEkle.Image = ((System.Drawing.Image)(resources.GetObject("picPersonelEkle.Image")));
            this.picPersonelEkle.Location = new System.Drawing.Point(324, 21);
            this.picPersonelEkle.Name = "picPersonelEkle";
            this.picPersonelEkle.Size = new System.Drawing.Size(75, 51);
            this.picPersonelEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonelEkle.TabIndex = 22;
            this.picPersonelEkle.TabStop = false;
            this.picPersonelEkle.Click += new System.EventHandler(this.picPersonelEkle_Click);
            // 
            // picPersoneliGüncelle
            // 
            this.picPersoneliGüncelle.Image = ((System.Drawing.Image)(resources.GetObject("picPersoneliGüncelle.Image")));
            this.picPersoneliGüncelle.Location = new System.Drawing.Point(405, 21);
            this.picPersoneliGüncelle.Name = "picPersoneliGüncelle";
            this.picPersoneliGüncelle.Size = new System.Drawing.Size(75, 51);
            this.picPersoneliGüncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersoneliGüncelle.TabIndex = 21;
            this.picPersoneliGüncelle.TabStop = false;
            this.picPersoneliGüncelle.Click += new System.EventHandler(this.picPersoneliGüncelle_Click);
            // 
            // txtPersonelid
            // 
            this.txtPersonelid.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelid.Location = new System.Drawing.Point(148, 28);
            this.txtPersonelid.Name = "txtPersonelid";
            this.txtPersonelid.Size = new System.Drawing.Size(152, 29);
            this.txtPersonelid.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Personel ID :";
            // 
            // txtPersonelGörev
            // 
            this.txtPersonelGörev.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelGörev.Location = new System.Drawing.Point(148, 103);
            this.txtPersonelGörev.Name = "txtPersonelGörev";
            this.txtPersonelGörev.Size = new System.Drawing.Size(152, 29);
            this.txtPersonelGörev.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Personel Görev :";
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAdi.Location = new System.Drawing.Point(148, 68);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(152, 29);
            this.txtPersonelAdi.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Personel Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(490, 233);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // yurtKayıtDataSet6
            // 
            this.yurtKayıtDataSet6.DataSetName = "YurtKayıtDataSet6";
            this.yurtKayıtDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtKayıtDataSet6;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personelid";
            this.personelidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelidDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            this.personelAdSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            this.personelDepartmanDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(494, 396);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picPersonelSil);
            this.Controls.Add(this.picPersonelEkle);
            this.Controls.Add(this.picPersoneliGüncelle);
            this.Controls.Add(this.txtPersonelid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPersonelGörev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonelAdi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPersonelSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonelEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersoneliGüncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPersonelSil;
        private System.Windows.Forms.PictureBox picPersonelEkle;
        private System.Windows.Forms.PictureBox picPersoneliGüncelle;
        private System.Windows.Forms.TextBox txtPersonelid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonelGörev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayıtDataSet6 yurtKayıtDataSet6;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtKayıtDataSet6TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
    }
}