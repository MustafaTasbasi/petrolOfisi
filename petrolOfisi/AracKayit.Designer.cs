namespace petrolOfisi
{
    partial class AracKayit
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
            lblMarka = new Label();
            lblPlaka = new Label();
            lblYakit = new Label();
            cbMarka = new ComboBox();
            cbYakit = new ComboBox();
            txtPlaka = new TextBox();
            dgwAracKayit = new DataGridView();
            btnKaydet = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            lblId = new Label();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwAracKayit).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblMarka.Location = new Point(22, 102);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(82, 31);
            lblMarka.TabIndex = 0;
            lblMarka.Text = "Marka";
            lblMarka.Click += lblMarka_Click;
            // 
            // lblPlaka
            // 
            lblPlaka.AutoSize = true;
            lblPlaka.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPlaka.Location = new Point(22, 139);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(72, 31);
            lblPlaka.TabIndex = 2;
            lblPlaka.Text = "Plaka";
            // 
            // lblYakit
            // 
            lblYakit.AutoSize = true;
            lblYakit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblYakit.Location = new Point(22, 177);
            lblYakit.Name = "lblYakit";
            lblYakit.Size = new Size(67, 31);
            lblYakit.TabIndex = 3;
            lblYakit.Text = "Yakıt";
            // 
            // cbMarka
            // 
            cbMarka.FormattingEnabled = true;
            cbMarka.Items.AddRange(new object[] { "Tofaş", "Toyota", "Renault", "Fiat", "Volkswagen", "Opel", "Hyundai", "Ford", "Peugeot", "Honda" });
            cbMarka.Location = new Point(145, 105);
            cbMarka.Name = "cbMarka";
            cbMarka.Size = new Size(151, 28);
            cbMarka.TabIndex = 4;
            // 
            // cbYakit
            // 
            cbYakit.FormattingEnabled = true;
            cbYakit.Location = new Point(145, 177);
            cbYakit.Name = "cbYakit";
            cbYakit.Size = new Size(151, 28);
            cbYakit.TabIndex = 6;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(145, 144);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(151, 27);
            txtPlaka.TabIndex = 7;
            // 
            // dgwAracKayit
            // 
            dgwAracKayit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAracKayit.Location = new Point(22, 261);
            dgwAracKayit.Name = "dgwAracKayit";
            dgwAracKayit.RowHeadersWidth = 51;
            dgwAracKayit.Size = new Size(776, 188);
            dgwAracKayit.TabIndex = 8;
            dgwAracKayit.CellClick += dgwAracKayit_CellContentClick;
            dgwAracKayit.CellContentClick += dgwAracKayit_CellContentClick;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(145, 218);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(104, 37);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSil.Location = new Point(22, 472);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(102, 38);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click_1;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnGuncelle.Location = new Point(155, 472);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(124, 38);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblId.Location = new Point(346, 110);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 12;
            lblId.Text = "id";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 79);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(310, 8);
            label1.Name = "label1";
            label1.Size = new Size(234, 50);
            label1.TabIndex = 14;
            label1.Text = "ARAÇ KAYIT";
            // 
            // AracKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 541);
            Controls.Add(panel1);
            Controls.Add(lblId);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(dgwAracKayit);
            Controls.Add(txtPlaka);
            Controls.Add(cbYakit);
            Controls.Add(cbMarka);
            Controls.Add(lblYakit);
            Controls.Add(lblPlaka);
            Controls.Add(lblMarka);
            Name = "AracKayit";
            Text = "AracKayit";
            Load += AracKayit_Load;
            ((System.ComponentModel.ISupportInitialize)dgwAracKayit).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarka;
        private Label lblPlaka;
        private Label lblYakit;
        private ComboBox cbMarka;
        private ComboBox cbYakit;
        private TextBox txtPlaka;
        private DataGridView dgwAracKayit;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnGuncelle;
        private Label lblId;
        private Panel panel1;
        private Label label1;
    }
}