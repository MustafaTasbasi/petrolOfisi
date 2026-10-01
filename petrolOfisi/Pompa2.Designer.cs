namespace petrolOfisi
{
    partial class Pompa2
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
            lblPompaci = new Label();
            lblArac = new Label();
            lblLitre = new Label();
            cbPompaci = new ComboBox();
            cbArac = new ComboBox();
            txtLitre = new TextBox();
            btnKaydet = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPompaci
            // 
            lblPompaci.AutoSize = true;
            lblPompaci.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPompaci.Location = new Point(186, 177);
            lblPompaci.Name = "lblPompaci";
            lblPompaci.Size = new Size(129, 38);
            lblPompaci.TabIndex = 0;
            lblPompaci.Text = "Pompacı";
            // 
            // lblArac
            // 
            lblArac.AutoSize = true;
            lblArac.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblArac.Location = new Point(186, 228);
            lblArac.Name = "lblArac";
            lblArac.Size = new Size(76, 38);
            lblArac.TabIndex = 1;
            lblArac.Text = "Araç";
            // 
            // lblLitre
            // 
            lblLitre.AutoSize = true;
            lblLitre.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLitre.Location = new Point(186, 287);
            lblLitre.Name = "lblLitre";
            lblLitre.Size = new Size(76, 38);
            lblLitre.TabIndex = 2;
            lblLitre.Text = "Litre";
            // 
            // cbPompaci
            // 
            cbPompaci.FormattingEnabled = true;
            cbPompaci.Location = new Point(356, 187);
            cbPompaci.Name = "cbPompaci";
            cbPompaci.Size = new Size(151, 28);
            cbPompaci.TabIndex = 3;
            // 
            // cbArac
            // 
            cbArac.FormattingEnabled = true;
            cbArac.Location = new Point(356, 239);
            cbArac.Name = "cbArac";
            cbArac.Size = new Size(151, 28);
            cbArac.TabIndex = 4;
            // 
            // txtLitre
            // 
            txtLitre.Location = new Point(356, 298);
            txtLitre.Name = "txtLitre";
            txtLitre.Size = new Size(151, 27);
            txtLitre.TabIndex = 5;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(289, 355);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(135, 48);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 114);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(228, 31);
            label2.Name = "label2";
            label2.Size = new Size(292, 51);
            label2.TabIndex = 8;
            label2.Text = "YAKIT ALIM 2";
            // 
            // Pompa2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 520);
            Controls.Add(panel1);
            Controls.Add(btnKaydet);
            Controls.Add(txtLitre);
            Controls.Add(cbArac);
            Controls.Add(cbPompaci);
            Controls.Add(lblLitre);
            Controls.Add(lblArac);
            Controls.Add(lblPompaci);
            Name = "Pompa2";
            Text = "Pompa2";
            Load += Pompa2_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPompaci;
        private Label lblArac;
        private Label lblLitre;
        private ComboBox cbPompaci;
        private ComboBox cbArac;
        private TextBox txtLitre;
        private Button btnKaydet;
        private Panel panel1;
        private Label label2;
    }
}