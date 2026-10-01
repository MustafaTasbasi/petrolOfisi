namespace petrolOfisi
{
    partial class PompaciKayit
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblTel = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTel = new TextBox();
            btnKaydet = new Button();
            dgwPompaciKayit = new DataGridView();
            btnSil = new Button();
            btnGuncelle = new Button();
            lblId = new Label();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwPompaciKayit).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblAd.Location = new Point(40, 166);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(54, 38);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblSoyad.Location = new Point(40, 216);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(97, 38);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblTel.Location = new Point(40, 263);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(113, 38);
            lblTel.TabIndex = 2;
            lblTel.Text = "Telefon";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(200, 170);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(200, 227);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 4;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(200, 274);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(125, 27);
            txtTel.TabIndex = 5;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(200, 321);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(115, 45);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dgwPompaciKayit
            // 
            dgwPompaciKayit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPompaciKayit.Location = new Point(29, 384);
            dgwPompaciKayit.Name = "dgwPompaciKayit";
            dgwPompaciKayit.RowHeadersWidth = 51;
            dgwPompaciKayit.Size = new Size(569, 198);
            dgwPompaciKayit.TabIndex = 7;
            dgwPompaciKayit.CellClick += dgwPompaciKayit_CellContentClick;
            dgwPompaciKayit.CellContentClick += dgwPompaciKayit_CellContentClick;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSil.Location = new Point(29, 588);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(108, 48);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click_1;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnGuncelle.Location = new Point(174, 588);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(131, 48);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblId.Location = new Point(349, 177);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 10;
            lblId.Text = "id";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 133);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(282, 40);
            label1.Name = "label1";
            label1.Size = new Size(333, 59);
            label1.TabIndex = 12;
            label1.Text = "POMPACI KAYIT";
            // 
            // PompaciKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 666);
            Controls.Add(panel1);
            Controls.Add(lblId);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(dgwPompaciKayit);
            Controls.Add(btnKaydet);
            Controls.Add(txtTel);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblTel);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "PompaciKayit";
            Text = "Form2";
            Load += PompaciKayit_Load;
            ((System.ComponentModel.ISupportInitialize)dgwPompaciKayit).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblTel;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTel;
        private Button btnKaydet;
        private DataGridView dgwPompaciKayit;
        private Button btnSil;
        private Button btnGuncelle;
        private Label lblId;
        private Panel panel1;
        private Label label1;
    }
}