namespace AccessOwnerForm1
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
            this.btnForm2Ac = new System.Windows.Forms.Button();
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnForm2Ac
            // 
            this.btnForm2Ac.Location = new System.Drawing.Point(39, 99);
            this.btnForm2Ac.Name = "btnForm2Ac";
            this.btnForm2Ac.Size = new System.Drawing.Size(104, 51);
            this.btnForm2Ac.TabIndex = 0;
            this.btnForm2Ac.Text = "Form2 Aç";
            this.btnForm2Ac.UseVisualStyleBackColor = true;
            this.btnForm2Ac.Click += new System.EventHandler(this.btnForm2Ac_Click);
            // 
            // txtVeri
            // 
            this.txtVeri.Location = new System.Drawing.Point(39, 56);
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(373, 26);
            this.txtVeri.TabIndex = 1;
            this.txtVeri.Text = "Lütfen buraya veri girin...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVeri);
            this.Controls.Add(this.btnForm2Ac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForm2Ac;
        public System.Windows.Forms.TextBox txtVeri;
    }
}

