
namespace MCD_MessageBoxUygulama
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefonNo = new System.Windows.Forms.TextBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.bildirimCubugu = new System.Windows.Forms.NotifyIcon(this.components);
            this.lstMusteriler = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstMusteriler);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(654, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Kayıt Listesi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYeniKayit);
            this.groupBox2.Controls.Add(this.txttelefonNo);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.txtsoyisim);
            this.groupBox2.Controls.Add(this.txtisim);
            this.groupBox2.Controls.Add(this.lblTelefonNo);
            this.groupBox2.Controls.Add(this.lblemail);
            this.groupBox2.Controls.Add(this.lblSoyisim);
            this.groupBox2.Controls.Add(this.lblIsim);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(53, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 431);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Müşteri Ekleme Formu";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsim.Location = new System.Drawing.Point(26, 64);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(58, 25);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "İsim:";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyisim.Location = new System.Drawing.Point(26, 105);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(95, 25);
            this.lblSoyisim.TabIndex = 0;
            this.lblSoyisim.Text = "Soyisim:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblemail.Location = new System.Drawing.Point(26, 143);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(135, 25);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email Adres:";
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefonNo.Location = new System.Drawing.Point(27, 188);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(189, 25);
            this.lblTelefonNo.TabIndex = 0;
            this.lblTelefonNo.Text = "Telefon Numarası:";
            // 
            // txtisim
            // 
            this.txtisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtisim.Location = new System.Drawing.Point(220, 66);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(197, 30);
            this.txtisim.TabIndex = 1;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyisim.Location = new System.Drawing.Point(220, 102);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(197, 30);
            this.txtsoyisim.TabIndex = 1;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtemail.Location = new System.Drawing.Point(220, 143);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(197, 30);
            this.txtemail.TabIndex = 1;
            // 
            // txttelefonNo
            // 
            this.txttelefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttelefonNo.Location = new System.Drawing.Point(220, 183);
            this.txttelefonNo.Name = "txttelefonNo";
            this.txttelefonNo.Size = new System.Drawing.Size(197, 30);
            this.txttelefonNo.TabIndex = 1;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayit.Location = new System.Drawing.Point(220, 228);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(197, 46);
            this.btnYeniKayit.TabIndex = 2;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // bildirimCubugu
            // 
            this.bildirimCubugu.Text = "notifyIcon1";
            this.bildirimCubugu.Visible = true;
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.FormattingEnabled = true;
            this.lstMusteriler.ItemHeight = 25;
            this.lstMusteriler.Location = new System.Drawing.Point(27, 64);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(447, 354);
            this.lstMusteriler.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 686);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.TextBox txttelefonNo;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.ListBox lstMusteriler;
        private System.Windows.Forms.NotifyIcon bildirimCubugu;
    }
}

