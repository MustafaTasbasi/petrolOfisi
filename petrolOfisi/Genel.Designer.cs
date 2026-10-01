namespace petrolOfisi
{
    partial class Genel
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
            dgwGenel = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwGenel).BeginInit();
            SuspendLayout();
            // 
            // dgwGenel
            // 
            dgwGenel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGenel.Location = new Point(-4, 12);
            dgwGenel.Name = "dgwGenel";
            dgwGenel.RowHeadersWidth = 51;
            dgwGenel.Size = new Size(792, 440);
            dgwGenel.TabIndex = 0;
            // 
            // Genel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgwGenel);
            Name = "Genel";
            Text = "Genel";
            Load += Genel_Load;
            ((System.ComponentModel.ISupportInitialize)dgwGenel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwGenel;
    }
}