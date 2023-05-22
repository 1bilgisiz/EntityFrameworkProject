namespace EntityProjeUygulama
{
    partial class FrmAnaForm
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
            this.BtnKategori = new System.Windows.Forms.Button();
            this.BtnUrun = new System.Windows.Forms.Button();
            this.Btnİstatiktik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKategori
            // 
            this.BtnKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKategori.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnKategori.Location = new System.Drawing.Point(89, 50);
            this.BtnKategori.Name = "BtnKategori";
            this.BtnKategori.Size = new System.Drawing.Size(228, 205);
            this.BtnKategori.TabIndex = 0;
            this.BtnKategori.Text = "Kategori İşlemleri";
            this.BtnKategori.UseVisualStyleBackColor = false;
            this.BtnKategori.Click += new System.EventHandler(this.BtnKategori_Click);
            // 
            // BtnUrun
            // 
            this.BtnUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnUrun.Location = new System.Drawing.Point(394, 50);
            this.BtnUrun.Name = "BtnUrun";
            this.BtnUrun.Size = new System.Drawing.Size(228, 205);
            this.BtnUrun.TabIndex = 0;
            this.BtnUrun.Text = "Ürün İşlemleri";
            this.BtnUrun.UseVisualStyleBackColor = false;
            this.BtnUrun.Click += new System.EventHandler(this.BtnUrun_Click);
            // 
            // Btnİstatiktik
            // 
            this.Btnİstatiktik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btnİstatiktik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnİstatiktik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btnİstatiktik.Location = new System.Drawing.Point(698, 50);
            this.Btnİstatiktik.Name = "Btnİstatiktik";
            this.Btnİstatiktik.Size = new System.Drawing.Size(228, 205);
            this.Btnİstatiktik.TabIndex = 0;
            this.Btnİstatiktik.Text = "İstatistikler";
            this.Btnİstatiktik.UseVisualStyleBackColor = false;
            this.Btnİstatiktik.Click += new System.EventHandler(this.Btnİstatiktik_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1032, 319);
            this.Controls.Add(this.Btnİstatiktik);
            this.Controls.Add(this.BtnUrun);
            this.Controls.Add(this.BtnKategori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKategori;
        private System.Windows.Forms.Button BtnUrun;
        private System.Windows.Forms.Button Btnİstatiktik;
    }
}