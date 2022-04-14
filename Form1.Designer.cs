
namespace carkifelek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.btnCarkiCevir = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblToplamPuan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCarkiCevir
            // 
            this.btnCarkiCevir.Location = new System.Drawing.Point(101, 368);
            this.btnCarkiCevir.Name = "btnCarkiCevir";
            this.btnCarkiCevir.Size = new System.Drawing.Size(94, 29);
            this.btnCarkiCevir.TabIndex = 0;
            this.btnCarkiCevir.Text = "Carki Cevir";
            this.btnCarkiCevir.UseVisualStyleBackColor = true;
            this.btnCarkiCevir.Click += new System.EventHandler(this.btnCarkiCevir_Click);
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(92, 43);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(316, 278);
            this.pbResim.TabIndex = 1;
            this.pbResim.TabStop = false;
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(266, 359);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(18, 20);
            this.lblPuan.TabIndex = 2;
            this.lblPuan.Text = "...";
            // 
            // lblToplamPuan
            // 
            this.lblToplamPuan.AutoSize = true;
            this.lblToplamPuan.Location = new System.Drawing.Point(266, 391);
            this.lblToplamPuan.Name = "lblToplamPuan";
            this.lblToplamPuan.Size = new System.Drawing.Size(122, 20);
            this.lblToplamPuan.TabIndex = 3;
            this.lblToplamPuan.Text = "Toplam puanınız:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 461);
            this.Controls.Add(this.lblToplamPuan);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btnCarkiCevir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Button btnCarkiCevir;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblToplamPuan;
    }
}

