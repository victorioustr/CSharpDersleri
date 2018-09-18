namespace AccessOwnerForm2
{
    partial class Form2
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
            this.lblGelenVeri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGelenVeri
            // 
            this.lblGelenVeri.AutoSize = true;
            this.lblGelenVeri.Location = new System.Drawing.Point(74, 54);
            this.lblGelenVeri.Name = "lblGelenVeri";
            this.lblGelenVeri.Size = new System.Drawing.Size(51, 20);
            this.lblGelenVeri.TabIndex = 0;
            this.lblGelenVeri.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGelenVeri);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGelenVeri;
    }
}