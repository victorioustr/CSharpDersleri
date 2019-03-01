namespace SettingsAndSerialize
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
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.rbSettings = new System.Windows.Forms.RadioButton();
            this.rbSerialize = new System.Windows.Forms.RadioButton();
            this.btnCagir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Location = new System.Drawing.Point(60, 64);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih1.TabIndex = 0;
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Location = new System.Drawing.Point(60, 90);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih2.TabIndex = 0;
            // 
            // txtKalan
            // 
            this.txtKalan.Location = new System.Drawing.Point(60, 116);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(200, 20);
            this.txtKalan.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(185, 171);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rbSettings
            // 
            this.rbSettings.AutoSize = true;
            this.rbSettings.Checked = true;
            this.rbSettings.Location = new System.Drawing.Point(61, 145);
            this.rbSettings.Name = "rbSettings";
            this.rbSettings.Size = new System.Drawing.Size(63, 17);
            this.rbSettings.TabIndex = 3;
            this.rbSettings.TabStop = true;
            this.rbSettings.Text = "Settings";
            this.rbSettings.UseVisualStyleBackColor = true;
            // 
            // rbSerialize
            // 
            this.rbSerialize.AutoSize = true;
            this.rbSerialize.Location = new System.Drawing.Point(60, 174);
            this.rbSerialize.Name = "rbSerialize";
            this.rbSerialize.Size = new System.Drawing.Size(64, 17);
            this.rbSerialize.TabIndex = 4;
            this.rbSerialize.Text = "Serialize";
            this.rbSerialize.UseVisualStyleBackColor = true;
            // 
            // btnCagir
            // 
            this.btnCagir.Location = new System.Drawing.Point(185, 142);
            this.btnCagir.Name = "btnCagir";
            this.btnCagir.Size = new System.Drawing.Size(75, 23);
            this.btnCagir.TabIndex = 2;
            this.btnCagir.Text = "Çağır";
            this.btnCagir.UseVisualStyleBackColor = true;
            this.btnCagir.Click += new System.EventHandler(this.btnCagir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 293);
            this.Controls.Add(this.rbSerialize);
            this.Controls.Add(this.rbSettings);
            this.Controls.Add(this.btnCagir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKalan);
            this.Controls.Add(this.dtpTarih2);
            this.Controls.Add(this.dtpTarih1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RadioButton rbSettings;
        private System.Windows.Forms.RadioButton rbSerialize;
        private System.Windows.Forms.Button btnCagir;
    }
}

