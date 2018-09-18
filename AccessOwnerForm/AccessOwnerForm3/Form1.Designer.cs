namespace AccessOwnerForm3
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
            this.btnVeri1Gonder = new System.Windows.Forms.Button();
            this.btnVeri2Gonder = new System.Windows.Forms.Button();
            this.btnVeri3Gonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVeri1Gonder
            // 
            this.btnVeri1Gonder.Location = new System.Drawing.Point(58, 53);
            this.btnVeri1Gonder.Name = "btnVeri1Gonder";
            this.btnVeri1Gonder.Size = new System.Drawing.Size(118, 39);
            this.btnVeri1Gonder.TabIndex = 0;
            this.btnVeri1Gonder.Text = "Veri1 Gönder";
            this.btnVeri1Gonder.UseVisualStyleBackColor = true;
            this.btnVeri1Gonder.Click += new System.EventHandler(this.btnVeri1Gonder_Click);
            // 
            // btnVeri2Gonder
            // 
            this.btnVeri2Gonder.Location = new System.Drawing.Point(58, 98);
            this.btnVeri2Gonder.Name = "btnVeri2Gonder";
            this.btnVeri2Gonder.Size = new System.Drawing.Size(118, 39);
            this.btnVeri2Gonder.TabIndex = 0;
            this.btnVeri2Gonder.Text = "Veri2 Gönder";
            this.btnVeri2Gonder.UseVisualStyleBackColor = true;
            this.btnVeri2Gonder.Click += new System.EventHandler(this.btnVeri2Gonder_Click);
            // 
            // btnVeri3Gonder
            // 
            this.btnVeri3Gonder.Location = new System.Drawing.Point(58, 143);
            this.btnVeri3Gonder.Name = "btnVeri3Gonder";
            this.btnVeri3Gonder.Size = new System.Drawing.Size(118, 39);
            this.btnVeri3Gonder.TabIndex = 0;
            this.btnVeri3Gonder.Text = "Veri3 Gönder";
            this.btnVeri3Gonder.UseVisualStyleBackColor = true;
            this.btnVeri3Gonder.Click += new System.EventHandler(this.btnVeri3Gonder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVeri3Gonder);
            this.Controls.Add(this.btnVeri2Gonder);
            this.Controls.Add(this.btnVeri1Gonder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVeri1Gonder;
        private System.Windows.Forms.Button btnVeri2Gonder;
        private System.Windows.Forms.Button btnVeri3Gonder;
    }
}

