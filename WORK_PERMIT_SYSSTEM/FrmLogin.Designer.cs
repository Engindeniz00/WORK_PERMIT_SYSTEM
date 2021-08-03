
namespace WORK_PERMIT_SYSSTEM
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullaniciKombox = new System.Windows.Forms.ComboBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.butonGiris = new System.Windows.Forms.Button();
            this.butonIptal = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.sifremiHatirlacheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // kullaniciKombox
            // 
            this.kullaniciKombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kullaniciKombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciKombox.FormattingEnabled = true;
            this.kullaniciKombox.Location = new System.Drawing.Point(161, 31);
            this.kullaniciKombox.Name = "kullaniciKombox";
            this.kullaniciKombox.Size = new System.Drawing.Size(154, 28);
            this.kullaniciKombox.TabIndex = 2;
            this.kullaniciKombox.SelectedIndexChanged += new System.EventHandler(this.kullaniciKombox_SelectedIndexChanged);
            // 
            // sifreText
            // 
            this.sifreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreText.Location = new System.Drawing.Point(161, 85);
            this.sifreText.MaxLength = 6;
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(154, 26);
            this.sifreText.TabIndex = 3;
            // 
            // butonGiris
            // 
            this.butonGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonGiris.Location = new System.Drawing.Point(30, 199);
            this.butonGiris.Name = "butonGiris";
            this.butonGiris.Size = new System.Drawing.Size(125, 46);
            this.butonGiris.TabIndex = 4;
            this.butonGiris.Text = "Giriş";
            this.butonGiris.UseVisualStyleBackColor = true;
            this.butonGiris.Click += new System.EventHandler(this.butonGiris_Click);
            // 
            // butonIptal
            // 
            this.butonIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonIptal.Location = new System.Drawing.Point(190, 199);
            this.butonIptal.Name = "butonIptal";
            this.butonIptal.Size = new System.Drawing.Size(125, 46);
            this.butonIptal.TabIndex = 5;
            this.butonIptal.Text = "Çıkış";
            this.butonIptal.UseVisualStyleBackColor = true;
            this.butonIptal.Click += new System.EventHandler(this.butonIptal_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(191, 148);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            // 
            // sifremiHatirlacheckBox
            // 
            this.sifremiHatirlacheckBox.AutoSize = true;
            this.sifremiHatirlacheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifremiHatirlacheckBox.Location = new System.Drawing.Point(30, 152);
            this.sifremiHatirlacheckBox.Name = "sifremiHatirlacheckBox";
            this.sifremiHatirlacheckBox.Size = new System.Drawing.Size(127, 24);
            this.sifremiHatirlacheckBox.TabIndex = 7;
            this.sifremiHatirlacheckBox.Text = "Şifremi Hatırla";
            this.sifremiHatirlacheckBox.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.butonGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butonIptal;
            this.ClientSize = new System.Drawing.Size(348, 268);
            this.Controls.Add(this.sifremiHatirlacheckBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.butonIptal);
            this.Controls.Add(this.butonGiris);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.kullaniciKombox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kullaniciKombox;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Button butonGiris;
        private System.Windows.Forms.Button butonIptal;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox sifremiHatirlacheckBox;
    }
}

