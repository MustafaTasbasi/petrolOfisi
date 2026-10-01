namespace petrolOfisi
{
    partial class YakitKayit
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
            lblYakitTuru = new Label();
            lblFiyat = new Label();
            btnKaydet = new Button();
            dgwYakit = new DataGridView();
            btnGuncelle = new Button();
            btnSil = new Button();
            lblId = new Label();
            cbFiyat = new ComboBox();
            txtYakitTuru = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgwYakit).BeginInit();
            SuspendLayout();
            // 
            // lblYakitTuru
            // 
            lblYakitTuru.AutoSize = true;
            lblYakitTuru.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYakitTuru.ForeColor = Color.Red;
            lblYakitTuru.Location = new Point(35, 20);
            lblYakitTuru.Name = "lblYakitTuru";
            lblYakitTuru.Size = new Size(148, 38);
            lblYakitTuru.TabIndex = 1;
            lblYakitTuru.Text = "Yakıt Türü";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFiyat.ForeColor = Color.Red;
            lblFiyat.Location = new Point(48, 75);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(81, 38);
            lblFiyat.TabIndex = 2;
            lblFiyat.Text = "Fiyat";
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.ForeColor = Color.Red;
            btnKaydet.Location = new Point(209, 141);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(151, 49);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dgwYakit
            // 
            dgwYakit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwYakit.Location = new Point(12, 211);
            dgwYakit.Name = "dgwYakit";
            dgwYakit.RowHeadersWidth = 51;
            dgwYakit.Size = new Size(652, 216);
            dgwYakit.TabIndex = 5;
            dgwYakit.CellClick += dgwYakit_CellContentClick;
            dgwYakit.CellContentClick += dgwYakit_CellContentClick;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.ForeColor = Color.Red;
            btnGuncelle.Location = new Point(183, 433);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(151, 49);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.Red;
            btnSil.Location = new Point(12, 433);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(151, 49);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Red;
            lblId.Location = new Point(369, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(26, 20);
            lblId.TabIndex = 8;
            lblId.Text = " id";
            // 
            // cbFiyat
            // 
            cbFiyat.FormattingEnabled = true;
            cbFiyat.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50" });
            cbFiyat.Location = new Point(209, 86);
            cbFiyat.Name = "cbFiyat";
            cbFiyat.Size = new Size(151, 28);
            cbFiyat.TabIndex = 10;
            // 
            // txtYakitTuru
            // 
            txtYakitTuru.Location = new Point(209, 27);
            txtYakitTuru.Name = "txtYakitTuru";
            txtYakitTuru.Size = new Size(151, 27);
            txtYakitTuru.TabIndex = 11;
            // 
            // YakitKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 524);
            Controls.Add(txtYakitTuru);
            Controls.Add(cbFiyat);
            Controls.Add(lblId);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(dgwYakit);
            Controls.Add(btnKaydet);
            Controls.Add(lblFiyat);
            Controls.Add(lblYakitTuru);
            Name = "YakitKayit";
            Text = "Yakit";
            Load += Yakit_Load;
            ((System.ComponentModel.ISupportInitialize)dgwYakit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblYakitTuru;
        private Label lblFiyat;
        private Button btnKaydet;
        private DataGridView dgwYakit;
        private Button btnGuncelle;
        private Button btnSil;
        private Label lblId;
        private ComboBox cbFiyat;
        private TextBox txtYakitTuru;
    }
}