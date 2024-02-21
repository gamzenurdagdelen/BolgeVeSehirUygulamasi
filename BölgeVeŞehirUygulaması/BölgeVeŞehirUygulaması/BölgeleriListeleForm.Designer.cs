namespace BölgeVeŞehirUygulaması
{
    partial class BölgeleriListeleForm
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
            this.txtBölgeAdı = new System.Windows.Forms.TextBox();
            this.btnBölgeEkle = new System.Windows.Forms.Button();
            this.btnBölgeSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtBölgeAdı
            // 
            this.txtBölgeAdı.Location = new System.Drawing.Point(16, 268);
            this.txtBölgeAdı.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBölgeAdı.Name = "txtBölgeAdı";
            this.txtBölgeAdı.Size = new System.Drawing.Size(132, 22);
            this.txtBölgeAdı.TabIndex = 1;
            // 
            // btnBölgeEkle
            // 
            this.btnBölgeEkle.Location = new System.Drawing.Point(157, 268);
            this.btnBölgeEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBölgeEkle.Name = "btnBölgeEkle";
            this.btnBölgeEkle.Size = new System.Drawing.Size(100, 28);
            this.btnBölgeEkle.TabIndex = 2;
            this.btnBölgeEkle.Text = "Bölge Ekle";
            this.btnBölgeEkle.UseVisualStyleBackColor = true;
            this.btnBölgeEkle.Click += new System.EventHandler(this.btnBölgeEkle_Click);
            // 
            // btnBölgeSil
            // 
            this.btnBölgeSil.Location = new System.Drawing.Point(265, 268);
            this.btnBölgeSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBölgeSil.Name = "btnBölgeSil";
            this.btnBölgeSil.Size = new System.Drawing.Size(100, 28);
            this.btnBölgeSil.TabIndex = 3;
            this.btnBölgeSil.Text = "Bölge Sil";
            this.btnBölgeSil.UseVisualStyleBackColor = true;
            this.btnBölgeSil.Click += new System.EventHandler(this.btnBölgeSil_Click);
            // 
            // BölgeleriListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 321);
            this.Controls.Add(this.btnBölgeSil);
            this.Controls.Add(this.btnBölgeEkle);
            this.Controls.Add(this.txtBölgeAdı);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BölgeleriListeleForm";
            this.Text = "Bölgeleri Listele";
            this.Load += new System.EventHandler(this.BölgeleriListeleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBölgeAdı;
        private System.Windows.Forms.Button btnBölgeEkle;
        private System.Windows.Forms.Button btnBölgeSil;
    }
}
