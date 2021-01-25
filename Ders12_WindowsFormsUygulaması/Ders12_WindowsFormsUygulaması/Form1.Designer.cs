
namespace Ders12_WindowsFormsUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnVeriyiBul = new System.Windows.Forms.Button();
            this.lbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güncellemek İstediğiniz Verinin ID\'sini Giriniz";
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtID.Location = new System.Drawing.Point(16, 57);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(381, 29);
            this.TxtID.TabIndex = 1;
            // 
            // BtnVeriyiBul
            // 
            this.BtnVeriyiBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVeriyiBul.Location = new System.Drawing.Point(16, 92);
            this.BtnVeriyiBul.Name = "BtnVeriyiBul";
            this.BtnVeriyiBul.Size = new System.Drawing.Size(381, 34);
            this.BtnVeriyiBul.TabIndex = 2;
            this.BtnVeriyiBul.Text = "Veriyi Bul";
            this.BtnVeriyiBul.UseVisualStyleBackColor = true;
            this.BtnVeriyiBul.Click += new System.EventHandler(this.BtnVeriyiBul_Click);
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(457, 31);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(419, 381);
            this.lbx.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 423);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.BtnVeriyiBul);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button BtnVeriyiBul;
        private System.Windows.Forms.ListBox lbx;
    }
}

