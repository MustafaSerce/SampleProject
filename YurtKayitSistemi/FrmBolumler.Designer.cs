namespace YurtKayitSistemi
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.picBolumGüncelle = new System.Windows.Forms.PictureBox();
            this.picBolumEkle = new System.Windows.Forms.PictureBox();
            this.picBolumSil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBolumid = new System.Windows.Forms.TextBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayıtDataSet = new YurtKayitSistemi.YurtKayıtDataSet();
            this.bolumlerTableAdapter = new YurtKayitSistemi.YurtKayıtDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBolumGüncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // picBolumGüncelle
            // 
            this.picBolumGüncelle.Image = ((System.Drawing.Image)(resources.GetObject("picBolumGüncelle.Image")));
            this.picBolumGüncelle.Location = new System.Drawing.Point(630, 97);
            this.picBolumGüncelle.Name = "picBolumGüncelle";
            this.picBolumGüncelle.Size = new System.Drawing.Size(100, 70);
            this.picBolumGüncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBolumGüncelle.TabIndex = 0;
            this.picBolumGüncelle.TabStop = false;
            this.toolTip1.SetToolTip(this.picBolumGüncelle, "Bölümü Güncelle");
            this.picBolumGüncelle.Click += new System.EventHandler(this.picBolumGüncelle_Click);
            // 
            // picBolumEkle
            // 
            this.picBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("picBolumEkle.Image")));
            this.picBolumEkle.Location = new System.Drawing.Point(677, 21);
            this.picBolumEkle.Name = "picBolumEkle";
            this.picBolumEkle.Size = new System.Drawing.Size(100, 70);
            this.picBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBolumEkle.TabIndex = 1;
            this.picBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.picBolumEkle, "Bölüm Ekle");
            this.picBolumEkle.Click += new System.EventHandler(this.picBolumEkle_Click);
            // 
            // picBolumSil
            // 
            this.picBolumSil.Image = ((System.Drawing.Image)(resources.GetObject("picBolumSil.Image")));
            this.picBolumSil.Location = new System.Drawing.Point(571, 21);
            this.picBolumSil.Name = "picBolumSil";
            this.picBolumSil.Size = new System.Drawing.Size(100, 70);
            this.picBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBolumSil.TabIndex = 2;
            this.picBolumSil.TabStop = false;
            this.toolTip1.SetToolTip(this.picBolumSil, "Bölüm Sil");
            this.picBolumSil.Click += new System.EventHandler(this.picBolumSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bölüm Adı :";
            // 
            // txtBolumid
            // 
            this.txtBolumid.Enabled = false;
            this.txtBolumid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBolumid.Location = new System.Drawing.Point(190, 38);
            this.txtBolumid.Name = "txtBolumid";
            this.txtBolumid.Size = new System.Drawing.Size(240, 30);
            this.txtBolumid.TabIndex = 5;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBolumAd.Location = new System.Drawing.Point(190, 85);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(240, 30);
            this.txtBolumAd.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIDDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 330);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            this.bolumIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            this.bolumAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtKayıtDataSet;
            // 
            // yurtKayıtDataSet
            // 
            this.yurtKayıtDataSet.DataSetName = "YurtKayıtDataSet";
            this.yurtKayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.txtBolumid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBolumSil);
            this.Controls.Add(this.picBolumEkle);
            this.Controls.Add(this.picBolumGüncelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bolumler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBolumGüncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBolumGüncelle;
        private System.Windows.Forms.PictureBox picBolumEkle;
        private System.Windows.Forms.PictureBox picBolumSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBolumid;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayıtDataSet yurtKayıtDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtKayıtDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}