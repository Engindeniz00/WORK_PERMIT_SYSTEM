
namespace WORK_PERMIT_SYSSTEM
{
    partial class FrmDurumDegistir
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
            this.onayKombox = new System.Windows.Forms.ComboBox();
            this.iptNedenText = new System.Windows.Forms.TextBox();
            this.iptaButon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Onay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "İptal Neden";
            // 
            // onayKombox
            // 
            this.onayKombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.onayKombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onayKombox.FormattingEnabled = true;
            this.onayKombox.Location = new System.Drawing.Point(297, 60);
            this.onayKombox.Name = "onayKombox";
            this.onayKombox.Size = new System.Drawing.Size(313, 39);
            this.onayKombox.TabIndex = 2;
            // 
            // iptNedenText
            // 
            this.iptNedenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptNedenText.Location = new System.Drawing.Point(297, 151);
            this.iptNedenText.Multiline = true;
            this.iptNedenText.Name = "iptNedenText";
            this.iptNedenText.Size = new System.Drawing.Size(468, 169);
            this.iptNedenText.TabIndex = 3;
            // 
            // iptaButon
            // 
            this.iptaButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptaButon.Location = new System.Drawing.Point(432, 357);
            this.iptaButon.Name = "iptaButon";
            this.iptaButon.Size = new System.Drawing.Size(204, 66);
            this.iptaButon.TabIndex = 4;
            this.iptaButon.Text = "İPTAL";
            this.iptaButon.UseVisualStyleBackColor = true;
            this.iptaButon.Click += new System.EventHandler(this.iptaButon_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(146, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 66);
            this.button1.TabIndex = 5;
            this.button1.Text = "ONAYLA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmDurumDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iptaButon);
            this.Controls.Add(this.iptNedenText);
            this.Controls.Add(this.onayKombox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDurumDegistir";
            this.Text = "FrmDurumDegistir";
            this.Load += new System.EventHandler(this.FrmDurumDegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox onayKombox;
        private System.Windows.Forms.TextBox iptNedenText;
        private System.Windows.Forms.Button iptaButon;
        private System.Windows.Forms.Button button1;
    }
}