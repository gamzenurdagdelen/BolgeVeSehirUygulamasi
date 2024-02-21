namespace BölgeVeŞehirUygulaması
{
    partial class ŞehirleriListeleForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtŞehirAdı = new System.Windows.Forms.TextBox();
            this.cmbBölgeler = new System.Windows.Forms.ComboBox();
            this.btnŞehirEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ŞehirSilBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtŞehirAdı
            // 
            this.txtŞehirAdı.Location = new System.Drawing.Point(16, 268);
            this.txtŞehirAdı.Margin = new System.Windows.Forms.Padding(4);
            this.txtŞehirAdı.Name = "txtŞehirAdı";
            this.txtŞehirAdı.Size = new System.Drawing.Size(132, 22);
            this.txtŞehirAdı.TabIndex = 1;
            // 
            // cmbBölgeler
            // 
            this.cmbBölgeler.FormattingEnabled = true;
            this.cmbBölgeler.Location = new System.Drawing.Point(157, 268);
            this.cmbBölgeler.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBölgeler.Name = "cmbBölgeler";
            this.cmbBölgeler.Size = new System.Drawing.Size(160, 24);
            this.cmbBölgeler.TabIndex = 2;
            // 
            // btnŞehirEkle
            // 
            this.btnŞehirEkle.Location = new System.Drawing.Point(327, 268);
            this.btnŞehirEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnŞehirEkle.Name = "btnŞehirEkle";
            this.btnŞehirEkle.Size = new System.Drawing.Size(100, 28);
            this.btnŞehirEkle.TabIndex = 3;
            this.btnŞehirEkle.Text = "Şehir Ekle";
            this.btnŞehirEkle.UseVisualStyleBackColor = true;
            this.btnŞehirEkle.Click += new System.EventHandler(this.btnŞehirEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Şehir Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ŞehirSilBtn
            // 
            this.ŞehirSilBtn.Location = new System.Drawing.Point(380, 304);
            this.ŞehirSilBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ŞehirSilBtn.Name = "ŞehirSilBtn";
            this.ŞehirSilBtn.Size = new System.Drawing.Size(100, 28);
            this.ŞehirSilBtn.TabIndex = 5;
            this.ŞehirSilBtn.Text = "Şehir Sil";
            this.ŞehirSilBtn.UseVisualStyleBackColor = true;
            this.ŞehirSilBtn.Click += new System.EventHandler(this.ŞehirSilBtn_Click);
            // 
            // ŞehirleriListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 382);
            this.Controls.Add(this.ŞehirSilBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnŞehirEkle);
            this.Controls.Add(this.cmbBölgeler);
            this.Controls.Add(this.txtŞehirAdı);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ŞehirleriListeleForm";
            this.Text = "Şehirleri Listele";
            this.Load += new System.EventHandler(this.ŞehirleriListeleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtŞehirAdı;
        private System.Windows.Forms.ComboBox cmbBölgeler;
        private System.Windows.Forms.Button btnŞehirEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ŞehirSilBtn;
    }
}
