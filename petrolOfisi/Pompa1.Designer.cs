namespace petrolOfisi
{
    partial class Pompa1
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
            cbPompaci = new ComboBox();
            cbArac = new ComboBox();
            label1 = new Label();
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
            lblPompaci.Location = new Point(218, 166);
            lblPompaci.Name = "lblPompaci";
            lblPompaci.Size = new Size(129, 38);
            lblPompaci.TabIndex = 0;
            lblPompaci.Text = "Pompacı";
            // 
            // lblArac
            // 
            lblArac.AutoSize = true;
            lblArac.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblArac.Location = new Point(218, 225);
            lblArac.Name = "lblArac";
            lblArac.Size = new Size(76, 38);
            lblArac.TabIndex = 1;
            lblArac.Text = "Araç";
            // 
            // cbPompaci
            // 
            cbPompaci.FormattingEnabled = true;
            cbPompaci.Location = new Point(378, 176);
            cbPompaci.Name = "cbPompaci";
            cbPompaci.Size = new Size(151, 28);
            cbPompaci.TabIndex = 2;
            // 
            // cbArac
            // 
            cbArac.FormattingEnabled = true;
            cbArac.Location = new Point(378, 225);
            cbArac.Name = "cbArac";
            cbArac.Size = new Size(151, 28);
            cbArac.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(218, 284);
            label1.Name = "label1";
            label1.Size = new Size(76, 38);
            label1.TabIndex = 4;
            label1.Text = "Litre";
            // 
            // txtLitre
            // 
            txtLitre.Location = new Point(378, 295);
            txtLitre.Name = "txtLitre";
            txtLitre.Size = new Size(151, 27);
            txtLitre.TabIndex = 5;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(262, 355);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(174, 46);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-5, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 114);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(267, 29);
            label2.Name = "label2";
            label2.Size = new Size(292, 51);
            label2.TabIndex = 8;
            label2.Text = "YAKIT ALIM 1";
            // 
            // Pompa1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 520);
            Controls.Add(panel1);
            Controls.Add(btnKaydet);
            Controls.Add(txtLitre);
            Controls.Add(label1);
            Controls.Add(cbArac);
            Controls.Add(cbPompaci);
            Controls.Add(lblArac);
            Controls.Add(lblPompaci);
            Name = "Pompa1";
            Text = "Pompa1";
            Load += Pompa1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPompaci;
        private Label lblArac;
        private ComboBox cbPompaci;
        private ComboBox cbArac;
        private Label label1;
        private TextBox txtLitre;
        private Button btnKaydet;
        private Panel panel1;
        private Label label2;
    }
}